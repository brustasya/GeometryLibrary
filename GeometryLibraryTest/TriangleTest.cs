using System;
using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibraryTest
{
    /// <summary>
    /// Тестирование класса треугольника.
    /// </summary>
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Тестирование метода нахождения площади треугольника.
        /// </summary>
        [TestMethod]
        public void TestGetSquare()
        {
            double a = 6;
            double b = 8;
            double c = 4;

            IFigure triangle = new Triangle(a, b, c);

            double expected = Math.Sqrt(9 * 3 * 5);
            double result = triangle.GetSquare();

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Тестирование метода проверки является ли треугольник прямоугольным.
        /// </summary>
        [TestMethod]
        public void TestIsRightAngled()
        {
            double a = 5;
            double b = 3;
            double c = 4;

            Triangle triangle = new Triangle(a, b, c);

            bool expected = true;
            bool result = triangle.IsRightAngled();

            Assert.AreEqual(expected, result);
        }
    }
}

