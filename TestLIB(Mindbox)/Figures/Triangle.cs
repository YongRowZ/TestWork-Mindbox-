using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLIB_Mindbox_.Interfaces;

namespace TestLIB_Mindbox_.Figures
{
    public class Triangle : IFigure<double>
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Area { get; set; }
        public bool Rectangular { get; set; }

        public Triangle(double sideA, double sideB, double sideC) 
        {
            (SideA, SideB, SideC) = (sideA, sideB, sideC);

            if (IsValid()) 
            {
                Area = MathArea();
                Rectangular = isRectangular();
            }

            else 
            {
                SideA = SideB = SideC = default;
            }
        }

        public bool IsValid()
        {
            return (SideA + SideB > SideC &&
                    SideA + SideC > SideB &&
                    SideB + SideC > SideA);
        }

        public double MathArea()
        {
            double area = default;
            double p = ((SideA + SideB + SideC) / 2);

            return SideA <= 0 || SideB <= 0 || SideC <= 0 ?
                area : Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool isRectangular() 
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                   Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
                   Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }
    }
}
