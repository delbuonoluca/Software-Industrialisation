using System.Collections.Generic;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PictureBox.Image.Testes
{
    public static class ImageFilters
    {
        //Rainbow Filter
        public static Bitmap RainbowFilter(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
            int raz = bmp.Height / 4;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color originalColor = bmp.GetPixel(i, x);

                    if (i < raz)
                    {
                        temp.SetPixel(i, x, Color.FromArgb(originalColor.R / 5, originalColor.G, originalColor.B));
                    }
                    else if (i < raz * 2)
                    {
                        temp.SetPixel(i, x, Color.FromArgb(originalColor.R, originalColor.G / 5, originalColor.B));
                    }
                    else if (i < raz * 3)
                    {
                        temp.SetPixel(i, x, Color.FromArgb(originalColor.R, originalColor.G, originalColor.B / 5));
                    }
                    else if (i < raz * 4)
                    {
                        temp.SetPixel(i, x, Color.FromArgb(originalColor.R / 5, originalColor.G, originalColor.B / 5));
                    }
                    else
                    {
                        temp.SetPixel(i, x, Color.FromArgb(originalColor.R / 5, originalColor.G / 5, originalColor.B / 5));
                    }
                }
            }

            return temp;
        }

        //Color filter to swap pixel colors
        public static Bitmap FilterSwap(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color originalColor = bmp.GetPixel(i, x);
                    Color swappedColor = Color.FromArgb(originalColor.A, originalColor.G, originalColor.B, originalColor.R);
                    temp.SetPixel(i, x, swappedColor);
                }
            }

            return temp;
        }

        public static Bitmap RevertFilterSwap(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color originalColor = bmp.GetPixel(i, x);
                    Color revertedColor = Color.FromArgb(originalColor.A, originalColor.B, originalColor.G, originalColor.R);
                    temp.SetPixel(i, x, revertedColor);
                }
            }

            return temp;
        }





    }


}
