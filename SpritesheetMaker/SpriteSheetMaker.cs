using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpritesheetMaker
{
    public partial class SpritesheetMaker : Form
    {
        private readonly string[] allowedExts = { ".png", ".jpg", ".tga" };

        public SpritesheetMaker()
        {
            InitializeComponent();
        }

        private void BrowsingButton_Click(object sender, EventArgs e)
        {
            if (SpritesFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                spritepathBox.Text = SpritesFolderBrowser.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (outpoutFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outpoutPathBox.Text = outpoutFolderDialog.SelectedPath;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (spritepathBox.Text != string.Empty && outpoutPathBox.Text != string.Empty)
            {
                GetFilesInFolder();
                //PackSpriteSheet(sprites, spriteSize, GetSpritesheetSize(sprites, spriteSize));
            }
        }

        private void GetFilesInFolder()
        {
            string[] filesList = Directory.GetFiles(spritepathBox.Text);

            List<List<string>> output = new List<List<string>>();
            int currentSubList = 0;
            output.Add(new List<string>());
            output[0].Add(filesList[0]);

            List<Image> sprites = new List<Image>();

            for (int i = 1; i < filesList.Length; i++)
            {
                for (int j = 0; j < allowedExts.Length; j++)
                {
                    if (Path.GetExtension(filesList[i]) == allowedExts[j])
                    {
                        string original = output[currentSubList][0].Substring(0, output[currentSubList][0].LastIndexOf('_'));
                        string input = filesList[i].Substring(0, filesList[i].LastIndexOf('_'));

                        if (original == input)
                        {
                            output[currentSubList].Add(filesList[i]);
                        }
                        else
                        {
                            currentSubList++;
                            output.Add(new List<string>());
                            output[currentSubList].Add(filesList[i]);
                        }
                    }
                }
            }

            for (int k = 0; k < output.Count; k++)
            {
                sprites.Clear();

                for (int l = 0; l < output[k].Count; l++)
                {
                    sprites.Add(Image.FromFile(output[k][l]));
                }

                Image[] spriteTable = sprites.ToArray();
                Size spriteSize = GetSpriteSize(spriteTable);
                int spriteSheetSize = GetSpritesheetSize(spriteTable, spriteSize);
                string fileName = Path.GetFileNameWithoutExtension(output[k][0]);

                PackSpriteSheet(spriteTable, spriteSize, spriteSheetSize, fileName);
            }
        }


        private Size GetSpriteSize(Image[] graphics)
        {
            int width = 0;
            int height = 0;

            for (int i = 0; i < graphics.Length; i++)
            {
                if (graphics[i].Width > width) width = graphics[i].Width;
                if (graphics[i].Height > height) height = graphics[i].Height;
            }

            return new Size(width, height);
        }

        private int GetSpritesheetSize(Image[] graphics, Size spriteSize)
        {
            int count = graphics.Length;
            int highDim = spriteSize.Width > spriteSize.Height ? spriteSize.Width : spriteSize.Height;
            int colCount = (int)Math.Ceiling(graphics.Length / 4.0f);

            return NearestPow2(colCount * highDim);
        }

        private int NearestPow2(int x)
        {
            return (int)Math.Pow(2, Math.Ceiling(Math.Log(x) / Math.Log(2)));
        }

        private void PackSpriteSheet(Image[] graphics, Size spriteSize, int SpriteSheetSize, string fileName)
        {
            if (overwriteBox.Checked && File.Exists(outpoutPathBox.Text + @"\" + nameBox.Text + "." + extensionBox.Text))
            {
                System.IO.File.Delete(outpoutPathBox.Text + @"\" + nameBox.Text + "." + extensionBox.Text);
            }
            Bitmap newBitmap = new Bitmap(SpriteSheetSize, SpriteSheetSize);
            Graphics spriteSheet = Graphics.FromImage(newBitmap);
            int currentSprite = 0;
            for (int i = 0; i <= SpriteSheetSize - spriteSize.Height && currentSprite < graphics.Length; i += spriteSize.Height)
            {
                for (int j = 0; j <= SpriteSheetSize - spriteSize.Width && currentSprite < graphics.Length; j += spriteSize.Width)
                {
                    spriteSheet.DrawImage(graphics[currentSprite], j, i, spriteSize.Width, spriteSize.Height);
                    graphics[currentSprite].Dispose();
                    currentSprite++;
                }
            }

            switch (extensionBox.SelectedIndex)
            {
                case 0:
                    {
                        if(oneFolderCheck.Checked)
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + nameBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                    break;
                case 1:
                    {
                        if (oneFolderCheck.Checked)
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + fileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                        else
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + nameBox.Text + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        }
                    }
                    break;
                case 2:
                    {
                        if (oneFolderCheck.Checked)
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + fileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + nameBox.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                    break;
                default:
                    {
                        if (oneFolderCheck.Checked)
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else
                        {
                            newBitmap.Save(outpoutPathBox.Text + @"\" + nameBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                    break;
            }
            spriteSheet.Dispose();
            newBitmap.Dispose();
        }
    }
}
