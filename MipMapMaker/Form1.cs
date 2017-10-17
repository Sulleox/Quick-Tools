using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using CSharpImageLibrary;
using System.IO;
using System.Drawing.Imaging;

namespace MipMapMaker
{
	public partial class MipMakerform : Form
	{

		private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };

		public MipMakerform()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
			{
				pathBox.Text = folderBrowserDialog1.SelectedPath;
				GetFilesInFolder();
			}
		}

		//Nomenclature des fichiers : NomDuFichier_Mip0

		private void GetFilesInFolder()
		{
			string[] fileNames = Directory.GetFiles( pathBox.Text );

			List<List<string>> output = new List<List<string>>();
			int currentSubList = 0;
			output.Add( new List<string>() );
			output[0].Add( fileNames[0] );

			for ( int i = 1 ; i < fileNames.Length ; i++ )
			{
				string original = output[currentSubList][0].Substring( 0, output[currentSubList][0].LastIndexOf( '_' ) );
				string input = fileNames[i].Substring( 0, fileNames[i].LastIndexOf( '_' ) );

				if ( original == input )
				{
					output[currentSubList].Add( fileNames[i] );
				}
				else
				{
					currentSubList++;
					output.Add( new List<string>() );
					output[currentSubList].Add( fileNames[i] );
				}
			}

			for ( int i = 0 ; i < output.Count ; i++ )
			{
				string outputPath = output[currentSubList][0].Substring( 0, output[currentSubList][0].LastIndexOf( '_' ) ) + ".dds";
				SaveDDS( output[i], outputPath );
			}
		}

		private void SaveDDS( List<string> paths, string outputPath )
		{
			ImageEngineImage outputImage = new ImageEngineImage( paths[0] );

			for ( int i = 1 ; i < paths.Count ; i++ )
			{
				ImageEngineImage mipImage = new ImageEngineImage( paths[i] );
				ImageFormats.ImageEngineFormatDetails mipFormat = new ImageFormats.ImageEngineFormatDetails( ImageEngineFormat.BMP );

				var mipData = mipImage.Save( mipFormat, MipHandling.KeepTopOnly );

				using ( var ff = File.Create( @"C:\Users\lvalet\Desktop\Tools Test\MipMap Generator\" + i + ".bmp" ) )
				{
					ff.Write( mipData, 0, mipData.Length );
				}

				MipMap mip = new MipMap( mipData, mipImage.Width, mipImage.Height, mipFormat );
				outputImage.MipMaps.Add( mip );
			}

			ImageFormats.ImageEngineFormatDetails outputFormat = new ImageFormats.ImageEngineFormatDetails( ImageEngineFormat.DDS_DXT3 );
			byte[] data = outputImage.Save( outputFormat, MipHandling.Default, mipToSave: paths.Count );

			using ( var file = File.Create( outputPath ) )
			{
				file.Write( data, 0, data.Length );
			}
		}
	}
}
