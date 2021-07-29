using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSample.Shape;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSample.Shape.Tests
{
    [TestClass()]
    public class TangelTests
    {
        [TestMethod()]
        public void SizeTest()
        {
            var t = new Tangel();
            Assert.AreEqual(100, t.Size());
        }
    }
}