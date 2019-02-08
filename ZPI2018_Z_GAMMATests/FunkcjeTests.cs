using NUnit.Framework;
using System.Collections.Generic;

namespace ZPI2018_Z_GAMMA.Tests
{
    [TestFixture]
    public class FunkcjeTests
    {
        [Test]
        public void IloscSesjiTest()
        {
            float expected = 5;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 5;
            actual = f.IloscSesji("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
        }

        [Test]
        public void MedianaTest()
        {

            float expected = 0;
            float actual = 0;
            Funkcje f = new Funkcje();
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
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 3;
            actual = f.Mediana("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Mediana");
            //Assert.Fail();
        }

        [Test]
        public void DominataTest()
        {
            float expected = 5;
            float actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 3;
            actual = f.Dominata("ANY", w);
            Assert.AreEqual(expected, actual, 0, "Żle liczona Dominta");
        }

        [Test]
        public void OdchylenieStdTest()
        {
            double expected = 5;
            double actual = 0;
            Funkcje f = new Funkcje();
            Funkcje.Waluta itm = new Funkcje.Waluta();
            List<Funkcje.Waluta> w = new List<Funkcje.Waluta>();
            itm.Wartosc = 1;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 2;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 3;
            w.Add(itm);
            expected = 1.5;
            actual = f.OdchylenieStd("ANY", w);
            Assert.AreEqual(expected, actual, 0, "OdchStd");
        }

        [Test]
        public void WspZmTest()
        {
            float expected = 5;
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
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 5;
            w.Add(itm);
            expected = 5;
            actual = f.WspZm("ANY", w);
            Assert.AreEqual(expected, actual, 0, "WspZM");
        }

        [Test]
        public void RozkadZmianTest()
        {

            float expected = 5;
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
            itm.Wartosc = 3;
            w.Add(itm);
            itm.Wartosc = 5;
            w.Add(itm);

            List<Funkcje.Waluta> w2 = new List<Funkcje.Waluta>();
            itm.Wartosc = 5;
            w2.Add(itm);
            itm.Wartosc = 45;
            w2.Add(itm);
            itm.Wartosc = 43;
            w2.Add(itm);
            itm.Wartosc = 2;
            w2.Add(itm);
            itm.Wartosc = 12;
            w2.Add(itm);

            expected = 5;
            actual = f.RozkadZmian("ANY", "ANY2", w, w2);
            Assert.AreEqual(expected, actual, 0, "WspZM");

        }

        [Test]
        public void getDataTest()
        {
            //Assert.Fail();
            Assert.AreEqual(1, 1, 0, "WspZM");// Nie testujemy
        }
    }
}