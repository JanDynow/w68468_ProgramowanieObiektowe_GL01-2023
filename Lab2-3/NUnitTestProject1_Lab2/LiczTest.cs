using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1_Lab2;
using NUnit.Framework;

namespace NUnitTestProject1_Lab2
{
    class LiczTest
    {
        private Licz licz;
        [SetUp]
        public void Setup()
        {
            licz = new Licz();
        }

        [Test]
        public void Dodaj_Test()
        {
            Assert.NotNull(licz);
        }
        [Test]
        [TestCase(2, 5, 7)]
        [TestCase(5, 6, 11)]
        public void Dodaj_Test(int i, int x, int expect)
        {
            licz.Dodaj(i);
            licz.Dodaj(x);
            Assert.AreEqual(expect, licz.Value);
        }
    }
}
