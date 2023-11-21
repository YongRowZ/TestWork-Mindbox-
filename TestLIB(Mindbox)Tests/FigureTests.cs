using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLIB_Mindbox_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace TestLIB_Mindbox_.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void FigureTest_100_100returned()
        {
            Figure figure = new();

            figure.Area = 100;

            Assert.AreEqual(100, figure.Area);
        }

        [TestMethod()]
        public void MatchAreaTest_Circle_10_314returned()
        {
            Figure circle = new();
            Assert.AreEqual
                (314, (int)circle.MatchArea(10), "Значение не равно ожидаемому!");
        }

        [TestMethod()]
        public void MatchAreaTest_Triangle_15and13and17_93returned()
        {
            Figure triangle = new();
            Assert.AreEqual
                (93, (int)triangle.MatchArea(15,13,17), "Значение не равно ожидаемому!");
        }
    }
}