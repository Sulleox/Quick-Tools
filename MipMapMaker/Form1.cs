﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpImageLibrary;
using System.IO;

namespace MipMapMaker
{
    public partial class Form1 : Form
    {

        private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = folderBrowserDialog1.SelectedPath;
                GetFilesInFolder();
            }
        }

        //Nomenclature des fichiers : NomDuFichier_Mip0

        private void GetFilesInFolder()
        {
            string[] fileNames = Directory.GetFiles(pathBox.Text);
            List<string> mipmap = new List<string>();

            for (int i = 0; i < fileNames.Length; i++)
            {
                if (i != 0)
                {
                    if (fileNames[i].Remove(fileNames.Length - 5) == fileNames[i - 1].Remove(fileNames.Length - 5))
                    {
                        mipmap.Add(fileNames[i]);
                    }
                    else
                    {
                        SaveDDS(mipmap, fileNames[i - 1].Remove(fileNames.Length - 5));
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
        private void SaveDDS(List<string> paths, string outputPath)
        {
            ImageEngineImage outputImage = new ImageEngineImage(outputPath);

            for (int i = 0; i < paths.Count; i++)
            {
                ImageEngineImage mipImage = new ImageEngineImage(paths[i]);
                MipMap mip = new MipMap(mipImage.OriginalData, mipImage.Width, mipImage.Height, mipImage.FormatDetails);
                outputImage.MipMaps[i] = mip;
            }

            ImageFormats.ImageEngineFormatDetails outputFormat = new ImageFormats.ImageEngineFormatDetails(ImageEngineFormat.DDS_DXT3);

            outputImage.Save(outputPath, outputFormat, MipHandling.KeepExisting, mipToSave: paths.Count);
        }
    }
}