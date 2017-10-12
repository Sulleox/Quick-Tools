using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SpritesheetMaker
{
	public partial class SpritesheetMaker : Form
	{
		public SpritesheetMaker()
		{
			InitializeComponent();
		}






		private Size GetSpriteSize( Image[] graphics )
		{
			int width = 0;
			int height = 0;

			for ( int i = 0 ; i < graphics.Length ; i++ )
			{
				if ( graphics[i].Width > width ) width = graphics[i].Width;
				if ( graphics[i].Height > height ) height = graphics[i].Height;
			}

			return new Size( width, height );
		}

		private int GetSpritesheetSize( Image[] graphics, Size spriteSize )
		{
			int count = graphics.Length;
			int highDim = spriteSize.Width > spriteSize.Height ? spriteSize.Width : spriteSize.Height;
			int colCount = (int)Math.Ceiling( (float)highDim / 4.0f );
			int size = NearestPow2( 25 );


			Console.WriteLine( size );

			return 0;
		}

		private int NearestPow2( int x )
		{
			return (int)Math.Round( Math.Pow( Math.Ceiling( Math.Log( x, 2 ) ), 2 ) );
		}
	}
}
