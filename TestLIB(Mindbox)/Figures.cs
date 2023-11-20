namespace TestLIB_Mindbox_
{
    public class Figure 
    {
        public double Area { get; set; }
    }
    public class Circle:Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            this.Radius = radius;
            this.Area = Math.PI * Radius * Radius;
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
            this.A = a;
            this.B = b;
            this.C = c;

            AreaTriangle();

            IsRectangular();
        }

        private void AreaTriangle() 
        {
            // Площадь треугольника по формуле Герона
            double p = (A + B + C) / 2;
            this.Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
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
                this.Rectangular = true;
            }
            else
            {
                this.Rectangular = false;
            }
        }
    }

}
