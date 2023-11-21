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

            Triangle tr = new(a,b,c);

            Assert.AreEqual
                (93, (int)tr.Area, "Значение не равно ожидаемому!");

            Assert.AreEqual
                (false, tr.Rectangular, "Значение не равно ожидаемому!");

        }
    }
}