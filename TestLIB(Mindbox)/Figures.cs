namespace TestLIB_Mindbox_
{
    public class Figure 
    {
        public double Area { get; set; }

        public static double MatchArea(double radius) 
        { 
            return Math.PI * radius * radius; 
        }

        public static double MatchArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    public class Circle:Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
            Area = Math.PI * Radius * Radius;
        }
    }
    public class Triangle:Figure 
    {
        public double A { get; set; } 
        public double B { get; set; } 
        public double C { get; set; }
        public bool Rectangular { get; set; }

        public Triangle(double a, double b, double c) 
        {
            A = a;
            B = b;
            C = c;

            AreaTriangle();

            IsRectangular();
        }

        private void AreaTriangle() 
        {
            // Площадь треугольника по формуле Герона
            double p = (A + B + C) / 2;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private void IsRectangular() 
        {
            // Определения прямоугольного треугольника
            double[] side = { A, B, C };
            //double maxSide = side.Max();
            double ressultMinSide = 0;

            //double[] newside = Array.Empty<double>();
            foreach (double i in side)
            {
                if (i != side.Max())
                {
                    ressultMinSide += i * i;
                }
            }

            if (Math.Pow(side.Max(), 2) == ressultMinSide)
            {
                Rectangular = true;
            }
            else
            {
                Rectangular = false;
            }
        }
    }

}
