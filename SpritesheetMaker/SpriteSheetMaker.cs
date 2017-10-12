using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace SpritesheetMaker
{
	public partial class SpritesheetMaker : Form
	{
		public SpritesheetMaker()
		{
			InitializeComponent();
		}

        private string[] filesList;
        public List<string> imagesList = new List<string>();

        private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };


        private void browseButton_Click(object sender, EventArgs e)
        {
          
        }

        private void GetFilesInFolder()
        {
            filesList = Directory.GetFiles(pathBox.Text);
            for (int i = 0; i < filesList.Length; i++)
            {
                for (int y = 0; y < allowedExts.Length; y++)
                {
                    if (Path.GetExtension(filesList[i]) == allowedExts[y])
                    {
                        imagesList.Add(filesList[i]);
                    }
                }
            }
        }
    }
}
