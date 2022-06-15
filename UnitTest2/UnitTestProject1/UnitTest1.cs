using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp5;

namespace UnitTestProject1
{
    [TestClass]
  
    public class UnitTest1
    {

        [TestMethod]
        public void TestBilgi(string kelime)
        {
            Program p = new Program();
            
            string ters = p.BilgiGetir(kelime);
            
            Assert.AreEqual(ters,kelime);
        }
    }
}
