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
    public class CircleTests
    {
        [TestMethod()]
        public void AreaCircleTest_10_314returned()
        {
            double radius = 10;

            Figures.Circle circle = new(radius);
            
            Assert.AreEqual
                (314, (int)circle.Area, "Значение не равно ожидаемому!");

        }

        [TestMethod()]
        public void AreaCircleTest_ExceptionValue_0returned() 
        {
            double radius = -10;

            Figures.Circle circle = new(radius);

            Assert.AreEqual
                (0, circle.Area, "Значение не равно ожидаемому!");
        }
    }
}