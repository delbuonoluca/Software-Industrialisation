using EdgeDetectionApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetectionTest_
{
    [TestClass]
    public class EdgeDetectionFilterTest
    {
        [TestMethod]
        public void DetectEdges_ShouldNotThrowException()
        {
            ImageEdgesDetection edgeDetection = new ImageEdgesDetection();
            Bitmap bitmap = new Bitmap(100, 100);

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                edgeDetection.DetectEdges("Laplacian3x3", "Sobel3x3Horizontal", null);
            });

            /*Assert.ThrowsException<ArgumentNullException>(() =>
            {
                edgeDetection.DetectEdges("Laplacian3x3", "Sobel3x3Horizontal", bitmap);
            });*/
        }

        [TestMethod]
        public void DetectEdges_ShouldReturnBitmap()
        {
            ImageEdgesDetection edgeDetection = new ImageEdgesDetection();
            Bitmap bitmap = new Bitmap(100, 100);
            Bitmap result = edgeDetection.DetectEdges("Laplacian3x3", "Sobel3x3Horizontal", bitmap);
            Assert.IsNotNull(result);
        }

    }
}
