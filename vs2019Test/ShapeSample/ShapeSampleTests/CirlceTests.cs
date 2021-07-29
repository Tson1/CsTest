using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSample;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSample.Tests
{
    [TestClass()]
    public class CirlceTests
    {
        [TestMethod()]
        public void ExecutTest()
        {
            //Assert.Fail();
            var cle = new Cirlce();
            Assert.AreEqual(1, cle.Execut());
        }

        [TestMethod()]
        public void Execut2Test()
        {
            var cle = new Cirlce();
            Assert.AreEqual(false, cle.Execut2());
        }
    }
}