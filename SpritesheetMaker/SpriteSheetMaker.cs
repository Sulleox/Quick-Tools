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
                Image[] sprites = GetFilesInFolder();
                Size spriteSize = GetSpriteSize(sprites);
                PackSpriteSheet(sprites, spriteSize, GetSpritesheetSize(sprites, spriteSize));
            }
        }

        private Image[] GetFilesInFolder()
        {
            string[] filesList = Directory.GetFiles(spritepathBox.Text);
            List<Image> sprites = new List<Image>();

            for (int i = 0; i < filesList.Length; i++)
            {
                for (int y = 0; y < allowedExts.Length; y++)
                {
                    if (Path.GetExtension(filesList[i]) == allowedExts[y])
                    {
                        sprites.Add(Image.FromFile(filesList[i]));
                    }
                }
            }

            return sprites.ToArray();
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

        private void PackSpriteSheet(Image[] graphics, Size spriteSize, int SpriteSheetSize)
        {
            Bitmap newBitmap = new Bitmap(SpriteSheetSize, SpriteSheetSize);
            Graphics spriteSheet = Graphics.FromImage(newBitmap);
            int currentSprite = 0;
            for(int i = 0; i < SpriteSheetSize - spriteSize.Height; i += spriteSize.Height)
            {
                for(int j = 0; j < SpriteSheetSize - spriteSize.Width; j += spriteSize.Width)
                {
                    if (currentSprite >= graphics.Length)
                    {
                        Pen pen = new Pen(Color.DarkRed, 1);
                        spriteSheet.DrawRectangle(pen, j, i, spriteSize.Width, spriteSize.Height);
                    }
                    else
                    {
                        spriteSheet.DrawImage(graphics[currentSprite], j,i, graphics[currentSprite].Width, graphics[currentSprite].Height);
                        graphics[currentSprite].Dispose();
                        currentSprite++;
                    }
                }
            }
            switch (extensionBox.SelectedIndex)
            {
                case 0:
                    if (File.Exists(spritepathBox.Text + @"\" + nameBox.Text + ".png"))
                    {
                        File.Delete(spritepathBox.Text + @"\" + nameBox.Text + ".png");
                    }
                    else
                    {
                        newBitmap.Save(spritepathBox.Text + @"\" + nameBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    break;
                case 1:
                    if (File.Exists(spritepathBox.Text + @"\" + nameBox.Text + ".bmp"))
                    {
                        File.Delete(spritepathBox.Text + @"\" + nameBox.Text + ".bmp");
                    }
                    else
                    {
                        newBitmap.Save(spritepathBox.Text + @"\" + nameBox.Text + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    break;
                default:
                    if (File.Exists(spritepathBox.Text + @"\" + nameBox.Text + ".png"))
                    {
                        File.Delete(spritepathBox.Text + @"\" + nameBox.Text + ".png");
                    }
                    else
                    {
                        newBitmap.Save(spritepathBox.Text + @"\" + nameBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    break;
            }
            spriteSheet.Dispose();
            newBitmap.Dispose();
        }
    }
}
