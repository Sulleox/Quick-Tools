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

        private List<string> GetFilesInFolder()
        {
            string[] fileNames = Directory.GetFiles(pathBox.Text);
            List<string> mipmap = new List<string>();

            for (int i = 0; i < fileNames.Length; i++)
            {
                //NomDuFichier_Mip0
                if (i != 0)
                {
                    if(fileNames[i].Remove(fileNames.Length - 5) != fileNames[i - 1].Remove(fileNames.Length - 5))
                    {
                        mipmap.Add(fileNames[i]);
                    }
                    else
                    {

                        mipmap.Clear();
                        mipmap.Add(fileNames[i]);
                    }
                }
                else
                {
                    mipmap.Add(fileNames[i]);
                }
            }

        }
    }
}
