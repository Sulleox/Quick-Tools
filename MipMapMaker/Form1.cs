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
				ImageFormats.ImageEngineFormatDetails mipFormat = new ImageFormats.ImageEngineFormatDetails( ImageEngineFormat.BMP );

				int ByteCount = mipImage.BitCount / 8;
				byte[] rawData = mipImage.Save( mipFormat, MipHandling.KeepTopOnly );
				byte[] finalData = new byte[mipImage.Height * mipImage.Width * ByteCount];
				int offset = rawData.Length - finalData.Length;

				for ( int pixY = 0 ; pixY < mipImage.Height ; pixY++ )
					for ( int pixX = 0 ; pixX < mipImage.Width ; pixX++ )
						for ( int channel = 0 ; channel < ByteCount ; channel++ )
						{
							int outputIndex = ( ( mipImage.Height - pixY - 1 ) * mipImage.Width * ByteCount ) + ( pixX * ByteCount ) + channel;
							int inputIndex = ( pixY * mipImage.Width * ByteCount ) + ( pixX * ByteCount ) + channel + offset;

							finalData[outputIndex] = rawData[inputIndex];
						}

				MipMap mip = new MipMap( finalData, mipImage.Width, mipImage.Height, mipFormat );
				outputImage.MipMaps.Add( mip );
			}

			ImageFormats.ImageEngineFormatDetails outputFormat = new ImageFormats.ImageEngineFormatDetails( ImageEngineFormat.DDS_DXT1 );
			byte[] data = outputImage.Save( outputFormat, MipHandling.Default, mipToSave: paths.Count );

			using ( var file = File.Create( outputPath ) )
			{
				file.Write( data, 0, data.Length );
			}
		}
	}
}
