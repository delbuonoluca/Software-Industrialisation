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

        [TestMethod]
        public void RainbowFilter_WithEmptyBitmap_ReturnsEmptyBitmap()
        {
            var bitmap = new Bitmap(0, 0);
            var result = ImageFilters.RainbowFilter(bitmap);
            Assert.AreEqual(0, result.Width);
            Assert.AreEqual(0, result.Height);
        }

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
    }
}
