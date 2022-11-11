using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    /// <summary>
    /// Класс фиуры треугольник.
    /// </summary>
    public class Triangle : IFigure
    {
        // Длины сторон треугольника.
        private double a;
        private double b;
        private double c;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="a"> Длина перво стороны. </param>
        /// <param name="b"> Длина второй стороны. </param>
        /// <param name="c"> Длина третье стороны. </param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Нахождение площади треугольнка по трём сторонам.
        /// </summary>
        /// <returns> Площадь треугольника. </returns>
        public double GetSquare()
        {
            if (IsRightAngled())
            {
                return a * b * 0.5;
            }

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns> true - если треугольник прямоугольный, false - в противном случае. </returns>
        public bool IsRightAngled()
        {
            if (a > c)
            {
                (a, c) = (c, a);
            }
            if (b > c)
            {
                (b, c) = (c, b);
            }

            return a * a + b * b == c * c;
        }
    }
}
