using EdgeDetectionApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace EdgeDetectionTest_
{
    [TestClass]
    public class ImageFiltersTest
    {
        //ChatGPT generated Unit tests
        [TestMethod]
        public void RainbowFilter_WithNullBitmap_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => ImageFilters.RainbowFilter(null));
        }

        // NEEDS CORRECTION
        /*[TestMethod]
        public void RainbowFilter_WithEmptyBitmap_ReturnsEmptyBitmap()
        {
            if (!IsCreatingEmptyBitmapSupported())
            {
                Assert.Inconclusive("Creating an empty bitmap is not supported by this graphics library.");
                return;
            }

            var bitmap = new Bitmap(0, 0);
            var result = ImageFilters.RainbowFilter(bitmap);
            Assert.AreEqual(bitmap.Width, result.Width);
            Assert.AreEqual(bitmap.Height, result.Height);
        }

        private bool IsCreatingEmptyBitmapSupported()
        {
            try
            {
                var emptyBitmap = new Bitmap(0, 0);
                emptyBitmap.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }*/


        [TestMethod]
        public void RainbowFilter_WithBitmap_ReturnsBitmapWithSameDimensions()
        {
            var bitmap = new Bitmap(100, 100);
            var result = ImageFilters.RainbowFilter(bitmap);
            Assert.AreEqual(bitmap.Width, result.Width);
            Assert.AreEqual(bitmap.Height, result.Height);
        }

        [TestMethod]
        public void RainbowFilter_WithBitmap_ChangesPixelsColor()
        {
            var bitmap = new Bitmap(100, 100);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }

            var result = ImageFilters.RainbowFilter(bitmap);
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    Assert.AreNotEqual(Color.White, result.GetPixel(i, j));
                }
            }
        }

        // NEEDS CORRECTION
        [TestMethod]
        public void SwapFilter_WithBitmap_SwapsColors()
        {
            var bitmap = new Bitmap(100, 100);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(255, 100, 50, 25));
                }
            }

            var result = ImageFilters.SwapFilter(bitmap);

            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    var originalColor = bitmap.GetPixel(i, j);
                    var swappedColor = result.GetPixel(i, j);
                    Assert.AreEqual(originalColor.A, swappedColor.A);
                    Assert.AreEqual(originalColor.R, swappedColor.B);
                    Assert.AreEqual(originalColor.G, swappedColor.G);
                    Assert.AreEqual(originalColor.B, swappedColor.R);
                }
            }
        }        
    }
}
