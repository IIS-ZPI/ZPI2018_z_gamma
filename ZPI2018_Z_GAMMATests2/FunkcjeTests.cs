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
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 3;
            actual = f.Mediana("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
            //Assert.Fail();

        }

        public void MedianaTestRos()
        {
            float expected = 0;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 4;
            w.Add(itm);
            expected = 3;
            actual = f.Mediana("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
            //Assert.Fail();

        }

        public void MedianaTestMal()
        {
            float expected = 0;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 4;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 1;
            w.Add(itm);
            expected = 2;
            actual = f.Mediana("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
            //Assert.Fail();

        }
    }
}