using System;
using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibraryTest
{
    /// <summary>
    /// Тестирование класса круга.
    /// </summary>
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Тестирование метода нахождения площади.
        /// </summary>
        [TestMethod]
        public void TestGetSquare()
        {
            double r = 3;
            IFigure circle = new Circle(r);

            double expected = Math.PI * r * r;
            double result = circle.GetSquare();

            Assert.AreEqual(expected, result);
        }
    }
}
