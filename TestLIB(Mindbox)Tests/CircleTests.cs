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
            double r = 10;

            Circle cir = new Circle(r);
            
            Assert.AreEqual
                (314, (int)cir.Area, "Значение не равно ожидаемому!");

        }
    }
}