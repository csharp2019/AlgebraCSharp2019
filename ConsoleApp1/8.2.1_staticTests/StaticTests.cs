using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8._2._1_static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1_static.Tests
{
    [TestClass()]
    public class StaticTests
    {
        [TestMethod()]
        public void ZbrojTest()
        {
            Assert.AreEqual(6, Static.Zbroj(3.4, 2.6));
            //Assert.Fail();
        }

        [TestMethod()]
        public void KubTest()
        {
            Assert.AreEqual(8, Static.Kub(2));
        }

        [TestMethod()]
        public void UdaljenostTest()
        {
            Assert.AreEqual(2, Static.Udaljenost(0,0,0,2));
            Assert.AreEqual((199.740063125653).ToString("F6"), (Static.Udaljenost(0.0005, 0.26, 0.1593, 200)).ToString("F6"));
            Assert.AreNotEqual(3, Static.Udaljenost(0, 0, 0, 2));

        }

        [TestMethod()]
        public void FahrenheitTest()
        {
            Assert.AreEqual(60.8, Static.Fahrenheit(16));
            Assert.AreEqual(32, Static.Fahrenheit(0));
            Assert.AreEqual(23, Static.Fahrenheit(-5));
            Assert.AreEqual(-508, Static.Fahrenheit(-300));
            Assert.AreEqual(-5368, Static.Fahrenheit(-3000));
            Assert.IsTrue(Static.Fahrenheit(-150) >= -273);
            


        }
    }
}