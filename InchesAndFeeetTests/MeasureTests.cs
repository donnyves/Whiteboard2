using Microsoft.VisualStudio.TestTools.UnitTesting;
using Conversions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions.Tests
{
    [TestClass()]
    public class MeasureTests
    {
        //This is an example of how to write a test, below is a way to test FeetToInches.
        [TestMethod()]
        public void InchesToFeetTestNeg2()
        {
            Assert.AreEqual(-24, Measure.FeetToInches(12));
        }

        [TestMethod()]
        public void FeetToInchesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FeetToInchesTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InchesToFeetTest1()
        {
            Assert.Fail();
        }
    }
}