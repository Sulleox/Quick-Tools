using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CSharpImageLibrary;
using System.IO;

namespace MipMapMaker
{
	public partial class MipMakerForm : Form
	{
		private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };

		public MipMakerForm()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
			{
				pathBox.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void confirmButton_Click( object sender, EventArgs e )
		{
			ProcessFolder();
		}

		private void ProcessFolder()
		{
			string[] fileNames = Directory.GetFiles( pathBox.Text ).Where( f => allowedExts.Contains( Path.GetExtension( f ) ) ).ToArray();

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
				string outputPath = output[i][0].Substring( 0, output[i][0].LastIndexOf( '_' ) ) + ".dds";
				SaveDDS( output[i], outputPath );
			}
		}

		private void SaveDDS( List<string> paths, string outputPath )
		{
			ImageEngineImage outputImage = new ImageEngineImage( paths[0] );

			for ( int i = 1 ; i < paths.Count ; i++ )
			{
				ImageEngineImage mipImage = new ImageEngineImage( paths[i] );
				MipMap mip = new MipMap( mipImage.MipMaps[0].Pixels, mipImage.Width, mipImage.Height, mipImage.FormatDetails );
				outputImage.MipMaps.Add( mip );
			}
			ImageFormats.ImageEngineFormatDetails outputFormat = new ImageFormats.ImageEngineFormatDetails( ImageEngineFormat.DDS_DXT1 );
			byte[] data = outputImage.Save( outputFormat, MipHandling.KeepExisting );

			using ( var file = File.Create( outputPath ) )
			{
				file.Write( data, 0, data.Length );
			}
		}
	}
}
