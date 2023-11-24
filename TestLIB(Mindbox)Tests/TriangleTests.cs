using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLIB_Mindbox_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLIB_Mindbox_.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void AreaTriangleTest_15and13and17_93returned()
        {
            double a = 15;
            double b = 13;
            double c = 17;

            Figures.Triangle triangle = new(a,b,c);

            Assert.AreEqual
                (93, (int)triangle.Area, "Значение не равно ожидаемому!");

            Assert.AreEqual
                (false, triangle.Rectangular, "Значение не равно ожидаемому!");

        }

        [TestMethod()]
        public void AreaTriangleTest_15andExceptionValueand17_0returned() 
        {
            double a = 15;
            double b = -13;
            double c = 17;

            Figures.Triangle triangle = new(a, b, c);

            Assert.AreEqual
                (0, triangle.Area, "Значение не равно ожидаемому!");

            Assert.AreEqual
                (false, triangle.Rectangular, "Значение не равно ожидаемому!");
        }
    }
}