using System.Runtime.InteropServices;

namespace TestLIB_Mindbox_
{
    public class Figure 
    {
        public double Area { get; private set; }

        /// <param name="radius">Радиус круга</param>
        public static double MatchArea(double radius) 
        {
            if (radius <= 0) 
                return default;

            else
                return Math.PI * radius * radius;
        }

        /// <param name="a">Одна из сторон треугольника</param>
        /// <param name="b">Одна из сторон треугольника</param>
        /// <param name="c">Одна из сторон треугольника</param>
        public static double MatchArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) 
                return default;

            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        /// <param name="area">Площадь фигуры</param>
        public void SetArea(double area) 
        {
            if (area > 0)
                Area = area;

            else
                Area = default;
        }
    }

    public class Circle:Figure
    {
        public double Radius { get; private set; }

        /// <param name="radius">Радиус круга</param>
        public Circle(double radius) 
        {
            SetArea(MatchArea(radius));
        }
    }

    public class Triangle:Figure 
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
            SetArea(MatchArea(a,b,c));

            if (Area == default) 
            {
                A = B = C = default;
                Rectangular = default;
            }
            else 
            {
                (A, B, C) = (a, b, c);
                isRectangular();
            }
        }

        private void isRectangular() 
        {
            // Определения прямоугольного треугольника
            double[] side = { A, B, C };
            double ressultMinSide = 0;

            foreach (double i in side)
            {
                if (i != side.Max())
                    ressultMinSide += i * i;
            }

            if (Math.Pow(side.Max(), 2) == ressultMinSide)
                Rectangular = true;

            else
                Rectangular = false;
        }
    }
}
