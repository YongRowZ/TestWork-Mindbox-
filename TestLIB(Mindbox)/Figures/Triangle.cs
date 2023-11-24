using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLIB_Mindbox_.Figures
{
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public bool Rectangular { get; private set; }

        /// <param name="a">Одна из сторон треугольника</param>
        /// <param name="b">Одна из сторон треугольника</param>
        /// <param name="c">Одна из сторон треугольника</param>
        public Triangle(double a, double b, double c)
        {
            SetArea(MatchArea(a, b, c));

            if (Area != default)
            {
                (A, B, C) = (a, b, c);
                Rectangular = isRectangular();
            }
        }

        private bool isRectangular()
        {
            // Определения прямоугольного треугольника
            return Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2) ||
                   Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2) ||
                   Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2);
        }
    }
}
