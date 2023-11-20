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
    public class FigureTests
    {
        [TestMethod()]
        public void FigureTest_100_100returned()
        {
            Figure figure = new Figure();

            figure.Area = 100;

            Assert.AreEqual(100, figure.Area);
        }
    }
}