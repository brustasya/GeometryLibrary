using System;
using GeometryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibraryTest
{
    /// <summary>
    /// ������������ ������ �����.
    /// </summary>
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// ������������ ������ ���������� �������.
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
