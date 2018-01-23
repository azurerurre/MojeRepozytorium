using Microsoft.VisualStudio.TestTools.UnitTesting;
using GryciukTestowanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GryciukTestowanie.Tests
{
    [TestClass()]
    public class OperacjeMatematyczneTests
    {
        [TestMethod()]
        public void DodajTest()
        {
            OperacjeMatematyczne cel = new OperacjeMatematyczne();
            int liczbaA = 3;
            int liczbaB = 5;
            int spodziewanyWynik = 8;
            int aktualnyWynik;
            aktualnyWynik = cel.Dodaj(liczbaA, liczbaB);
            Assert.AreEqual(spodziewanyWynik, aktualnyWynik);
        }

        [TestMethod()]
        public void OdejmijTest()
        {
            OperacjeMatematyczne cel = new OperacjeMatematyczne();
            int liczbaA = 7;
            int liczbaB = 1;
            int spodziewanyWynik = 3;
            int aktualnyWynik;
            aktualnyWynik = cel.Odejmij(liczbaA, liczbaB);
            Assert.AreEqual(spodziewanyWynik, aktualnyWynik);
        }

        [TestMethod()]
        public void MnozTest()
        {
            OperacjeMatematyczne cel = new OperacjeMatematyczne();
            int liczbaA = 4;
            int liczbaB = 5;
            int spodziewanyWynik = 20;
            int aktualnyWynik;
            aktualnyWynik = cel.Mnoz(liczbaA, liczbaB);
            Assert.AreEqual(spodziewanyWynik, aktualnyWynik);
        }

        [TestMethod()]
        public void DzielTest()
        {
            OperacjeMatematyczne cel = new OperacjeMatematyczne();
            int liczbaA = 4;
            int liczbaB = 2;
            int spodziewanyWynik = 2;
            int aktualnyWynik;
            aktualnyWynik = cel.Dziel(liczbaA, liczbaB);
            Assert.AreEqual(spodziewanyWynik, aktualnyWynik);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DzielPrzezZeroTest()
        {
            OperacjeMatematyczne cel = new OperacjeMatematyczne();
            int liczbaA = 4;
            int liczbaB = 0;
            int aktualnyWynik;
            aktualnyWynik = cel.Dziel(liczbaA, liczbaB);
        }
    }
}