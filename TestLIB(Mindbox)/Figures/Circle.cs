using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLIB_Mindbox_.Interfaces;

namespace TestLIB_Mindbox_.Figures
{
    public class Circle : IFigure<double>
    {
        public double Area { get; set; }
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = 
                radius < 0 ? Radius : radius;

            Area = 
                !IsValid() ? Area : MathArea();
        }

        public bool IsValid()
        {
            return Radius > 0;
        }

        public double MathArea()
        {
            double area = default;
            return Radius <= 0 ?
                area : Math.PI * Radius * Radius;
        }
    }
}
