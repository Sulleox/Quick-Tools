using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageResizer
{

    public partial class ImageResizer : Form
    {
        private string[] filesList;
        public List<string> imagesList = new List<string>();
        
        private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };

        public ImageResizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ImageFolderBrowser.ShowDialog()==DialogResult.OK)
            {
                pathBox.Text = ImageFolderBrowser.SelectedPath;
                GetFilesInFolder();
            }
        }

        private void GetFilesInFolder()
        {
           filesList = Directory.GetFiles(pathBox.Text);
            for (int i = 0; i < filesList.Length; i++)
            {
                for (int y = 0; y < allowedExts.Length; y++)
                {
                    if(Path.GetExtension(filesList[i]) == allowedExts[y])
                    {
                        imagesList.Add(filesList[i]);
                    }
                }
            }
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            ResizeImages();
        }

        private void ResizeImages()
        {
            Directory.CreateDirectory(pathBox.Text + "\\ResizedImages");
            for (int i = 0; i < imagesList.Count; i++)
            {
                var srcImage = Image.FromFile(filesList[i]);
                using (var newImage = new Bitmap((int)widthInput.Value, (int) heigthInput.Value))
                using (var graphics = Graphics.FromImage(newImage))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(srcImage, new Rectangle(0, 0, (int)widthInput.Value, (int)heigthInput.Value));
                    srcImage.Dispose();
                    if (overwriteToggle.Checked)
                    {
                        System.IO.File.Delete(filesList[i]);
                        newImage.Save(pathBox.Text + @"\" + Path.GetFileName(filesList[i]));
                    }
                    else
                    {
                        newImage.Save(pathBox.Text + @"\ResizedImages\" + Path.GetFileName(filesList[i]));
                    }
                }
            }
        }
    }
}