namespace TestLIB_Mindbox_
{
    public class Figure 
    {
        public double Area { get; private set; }

        public static double MatchArea(double radius) 
        {
            if (radius <= 0) 
                return default;

            else
                return Math.PI * radius * radius;
        }

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

        public Circle(double radius) 
        {
            if (radius <= 0) 
                Radius = default;

            else 
            {
                Radius = radius;
                SetArea(Math.PI * Radius * Radius);
            }
        }
    }

    public class Triangle:Figure 
    {
        public double A { get; private set; } 
        public double B { get; private set; } 
        public double C { get; private set; }
        public bool Rectangular { get; private set; }

        public Triangle(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0) 
            {
                A = B = C = default;
                Rectangular = default;
            }

            else 
            {
                (A, B, C) = (a, b, c);

                AreaTriangle();
                IsRectangular();
            }
        }

        private void AreaTriangle() 
        {
            // Площадь треугольника по формуле Герона
            double p = (A + B + C) / 2;
            SetArea(Math.Sqrt(p * (p - A) * (p - B) * (p - C)));
        }

        private void IsRectangular() 
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
