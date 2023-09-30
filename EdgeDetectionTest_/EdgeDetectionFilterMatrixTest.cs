using EdgeDetectionApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetectionTest_
{
    [TestClass]
    public class EdgeDetectionFilterMatrixTest
    {
        [TestMethod]
        public void Laplacian3x3_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Laplacian3x3);
        }

        [TestMethod]
        public void Gaussian3x3_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
                { 1, 2, 1 },
                { 2, 4, 2 },
                { 1, 2, 1 }
            };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Gaussian3x3);
        }

        [TestMethod]
        public void Laplacian5x5_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        { -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1 },
        { -1, -1, 24, -1, -1 },
        { -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Laplacian5x5);
        }

        [TestMethod]
        public void LaplacianOfGaussian_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        {  0,   0, -1,  0,  0 },
        {  0,  -1, -2, -1,  0 },
        { -1,  -2, 16, -2, -1 },
        {  0,  -1, -2, -1,  0 },
        {  0,   0, -1,  0,  0 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.LaplacianOfGaussian);
        }

        [TestMethod]
        public void Gaussian5x5Type1_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        { 2,  4,  5,  4,  2 },
        { 4,  9, 12,  9,  4 },
        { 5, 12, 15, 12,  5 },
        { 4,  9, 12,  9,  4 },
        { 2,  4,  5,  4,  2 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Gaussian5x5Type1);
        }

        [TestMethod]
        public void Gaussian5x5Type2_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        {  1,   4,  6,  4,  1 },
        {  4,  16, 24, 16,  4 },
        {  6,  24, 36, 24,  6 },
        {  4,  16, 24, 16,  4 },
        {  1,   4,  6,  4,  1 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Gaussian5x5Type2);
        }

        [TestMethod]
        public void Sobel3x3Horizontal_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        { -1,  0,  1 },
        { -2,  0,  2 },
        { -1,  0,  1 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Sobel3x3Horizontal);
        }

        [TestMethod]
        public void Sobel3x3Vertical_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        {  1,  2,  1 },
        {  0,  0,  0 },
        { -1, -2, -1 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Sobel3x3Vertical);
        }

        [TestMethod]
        public void Prewitt3x3Horizontal_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        { -1,  0,  1 },
        { -1,  0,  1 },
        { -1,  0,  1 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Prewitt3x3Horizontal);
        }

        [TestMethod]
        public void Prewitt3x3Vertical_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        {  1,  1,  1 },
        {  0,  0,  0 },
        { -1, -1, -1 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Prewitt3x3Vertical);
        }

        [TestMethod]
        public void Kirsch3x3Horizontal_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        {  5,  5,  5 },
        { -3,  0, -3 },
        { -3, -3, -3 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Kirsch3x3Horizontal);
        }

        [TestMethod]
        public void Kirsch3x3Vertical_ShouldReturnCorrectMatrix()
        {
            double[,] expected = {
        {  5, -3, -3 },
        {  5,  0, -3 },
        {  5, -3, -3 }
    };

            CollectionAssert.AreEqual(expected, EdgeDetectionFilterMatrix.Kirsch3x3Vertical);
        }
    }
}
