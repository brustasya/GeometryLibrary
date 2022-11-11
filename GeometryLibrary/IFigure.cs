using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    /// <summary>
    /// Интерейс для все геометричских фигур.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод нахождения площади фигуры.
        /// </summary>
        /// <returns> Площадь фигуры. </returns>
        double GetSquare();
    }
}
