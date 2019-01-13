using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZPI2018_Z_GAMMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPI2018_Z_GAMMA.Tests
{
    [TestClass()]
    public class FunkcjeTests
    {
        [TestMethod()]
        public void MedianaTest()
        {
            float expected = 0;
            float actual = 0;
            Funkcje f =  new Funkcje();
     
             Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");

            Assert.Fail();
        }
    }
}