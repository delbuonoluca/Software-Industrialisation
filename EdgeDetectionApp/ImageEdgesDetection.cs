using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetectionApp
{
    public class ImageEdgesDetection
    {
        // Edge detection method 
        public Bitmap DetectEdges(string xFilter, string yFilter, Bitmap bitmapImg)
        {
            if (bitmapImg == null)
            {
                throw new ArgumentNullException(nameof(bitmapImg), "Input bitmap cannot be null.");
            }

            double[,] xFilterMatrix = GetFilterMatrix(xFilter);
            double[,] yFilterMatrix = GetFilterMatrix(yFilter);

            Bitmap newbitmap = bitmapImg;
            BitmapData newbitmapData = new BitmapData();
            newbitmapData = newbitmap.LockBits(new Rectangle(0, 0, newbitmap.Width, newbitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

            byte[] pixelbuff = new byte[newbitmapData.Stride * newbitmapData.Height];
            byte[] resultbuff = new byte[newbitmapData.Stride * newbitmapData.Height];

            Marshal.Copy(newbitmapData.Scan0, pixelbuff, 0, pixelbuff.Length);
            newbitmap.UnlockBits(newbitmapData);


            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            double blueX = 0.0;
            double greenX = 0.0;
            double redX = 0.0;

            double blueY = 0.0;
            double greenY = 0.0;
            double redY = 0.0;

            double blueTotal = 0.0;
            double greenTotal = 0.0;
            double redTotal = 0.0;

            int filterOffset = 1;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                newbitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    newbitmap.Width - filterOffset; offsetX++)
                {
                    blueX = greenX = redX = 0;
                    blueY = greenY = redY = 0;

                    blueTotal = greenTotal = redTotal = 0.0;

                    byteOffset = offsetY *
                                 newbitmapData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * newbitmapData.Stride);

                            blueX += (double)(pixelbuff[calcOffset]) *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            greenX += (double)(pixelbuff[calcOffset + 1]) *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            redX += (double)(pixelbuff[calcOffset + 2]) *
                                      xFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            blueY += (double)(pixelbuff[calcOffset]) *
                                      yFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            greenY += (double)(pixelbuff[calcOffset + 1]) *
                                      yFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];

                            redY += (double)(pixelbuff[calcOffset + 2]) *
                                      yFilterMatrix[filterY + filterOffset,
                                              filterX + filterOffset];
                        }
                    }

                    blueTotal = 0;
                    greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                    redTotal = 0;

                    if (blueTotal > 255)
                    { blueTotal = 255; }
                    else if (blueTotal < 0)
                    { blueTotal = 0; }

                    if (greenTotal > 255)
                    { greenTotal = 255; }
                    else if (greenTotal < 0)
                    { greenTotal = 0; }

                    if (redTotal > 255)
                    { redTotal = 255; }
                    else if (redTotal < 0)
                    { redTotal = 0; }

                    resultbuff[byteOffset] = (byte)(blueTotal);
                    resultbuff[byteOffset + 1] = (byte)(greenTotal);
                    resultbuff[byteOffset + 2] = (byte)(redTotal);
                    resultbuff[byteOffset + 3] = 255;
                }
            }

            Bitmap resultbitmap = new Bitmap(newbitmap.Width, newbitmap.Height);

            BitmapData resultData = resultbitmap.LockBits(new Rectangle(0, 0,
                                     resultbitmap.Width, resultbitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                  PixelFormat.Format32bppArgb);

            Marshal.Copy(resultbuff, 0, resultData.Scan0, resultbuff.Length);
            resultbitmap.UnlockBits(resultData);

            return resultbitmap;
        }

        private double[,] GetFilterMatrix(string filterName)
        {
            switch (filterName)
            {
                case "Laplacian3x3":
                    return EdgeDetectionFilterMatrix.Laplacian3x3;
                case "Laplacian5x5":
                    return EdgeDetectionFilterMatrix.Laplacian5x5;
                case "LaplacianOfGaussian":
                    return EdgeDetectionFilterMatrix.LaplacianOfGaussian;
                case "Gaussian3x3":
                    return EdgeDetectionFilterMatrix.Gaussian3x3;
                case "Gaussian5x5Type1":
                    return EdgeDetectionFilterMatrix.Gaussian5x5Type1;
                case "Gaussian5x5Type2":
                    return EdgeDetectionFilterMatrix.Gaussian5x5Type2;
                case "Sobel3x3Horizontal":
                    return EdgeDetectionFilterMatrix.Sobel3x3Horizontal;
                case "Sobel3x3Vertical":
                    return EdgeDetectionFilterMatrix.Sobel3x3Vertical;
                case "Prewitt3x3Horizontal":
                    return EdgeDetectionFilterMatrix.Prewitt3x3Horizontal;
                case "Prewitt3x3Vertical":
                    return EdgeDetectionFilterMatrix.Prewitt3x3Vertical;
                case "Kirsch3x3Horizontal":
                    return EdgeDetectionFilterMatrix.Kirsch3x3Horizontal;
                case "Kirsch3x3Vertical":
                    return EdgeDetectionFilterMatrix.Kirsch3x3Vertical;
                default:
                    return EdgeDetectionFilterMatrix.Laplacian3x3;
            }
        }

    }
}
