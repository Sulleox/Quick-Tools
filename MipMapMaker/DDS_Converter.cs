using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpImageLibrary;

namespace MipMapMaker
{
	internal static class DDS_Converter
	{
		public static void SaveDDS( List<string> paths, string outputPath )
		{
			ImageEngineImage outputImage = new ImageEngineImage( outputPath );

			for ( int i = 0 ; i < paths.Count ; i++ )
			{
				ImageEngineImage mipImage = new ImageEngineImage( paths[i] );
				MipMap mip = new MipMap( mipImage.OriginalData, mipImage.Width, mipImage.Height, mipImage.FormatDetails );
				outputImage.MipMaps[i] = mip;
			}

			ImageFormats.ImageEngineFormatDetails outputFormat = new ImageFormats.ImageEngineFormatDetails( ImageEngineFormat.DDS_DXT3 );

			outputImage.Save( outputPath, outputFormat, MipHandling.KeepExisting, mipToSave: paths.Count );
		}
	}
}
