using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CSharpImageLibrary;

namespace MipMapMaker
{
	public partial class MipMapMaker : Form
	{

		private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };

		public MipMapMaker()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			if ( folderBrowserDialog.ShowDialog() == DialogResult.OK )
			{
				pathBox.Text = folderBrowserDialog.SelectedPath;
				GetFilesInFolder();
			}
		}

        private void GetFilesInFolder()
        {
            
        }
    }
}
