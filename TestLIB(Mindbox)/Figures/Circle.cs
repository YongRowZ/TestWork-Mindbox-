using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLIB_Mindbox_.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }
        
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            SetArea(MatchArea(radius));
        }
    }
}
