using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToplama()
        {
            Program p = new Program();
            double sonuc = p.Topla(10, 10);
            Assert.AreEqual(sonuc, 20);
        }
        [TestMethod]
        public void TestCikarma()
        {
            Program p = new Program();
            double sonuc = p.Cikar(10, 5);
            Assert.AreEqual(sonuc, 7);
        }
        [TestMethod]
        public void TestBolme()
        {
            Program p = new Program();
            double sonuc = p.Bolme(10, 5);
            Assert.AreEqual(sonuc, 2);
        }
        [TestMethod]
        public void TestCarpma()
        {
            Program p = new Program();
            double sonuc = p.Carpma(3, 5);
            Assert.AreEqual(sonuc, 20);
        }
        public void TestMethod1()
        {

        }
    }
}
