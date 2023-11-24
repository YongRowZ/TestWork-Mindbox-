using System.Runtime.InteropServices;

namespace TestLIB_Mindbox_
{
    public class Figure 
    {
        public double Area { get; private set; }

        /// <param name="radius">Радиус круга</param>
        public static double MatchArea(double radius) 
        {
            double area = default;
            return radius <= 0 ? 
                area : Math.PI * radius * radius;
        }

        /// <param name="a">Одна из сторон треугольника</param>
        /// <param name="b">Одна из сторон треугольника</param>
        /// <param name="c">Одна из сторон треугольника</param>
        public static double MatchArea(double a, double b, double c)
        {
            double area = default;
            return a <= 0 || b <= 0 || c <= 0 ?
                area : Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
        }

        /// <param name="area">Площадь фигуры</param>
        public void SetArea(double area) 
        {
            Area = area < 0 || area == default ? 
                Area : area;
        }
    }

}
