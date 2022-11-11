using System;

namespace GeometryLibrary
{    
    /// <summary>
    /// Класс игуры круг.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        private double r;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="r"> Радиус. </param>
        public Circle(double r)
        {
            this.r = r;
        }

        /// <summary>
        /// Метод нахождения площади круга.
        /// </summary>
        /// <returns> Площадь круга. </returns>
        public double GetSquare() => Math.PI * r * r;
    }
}
