using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdd2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdd2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SumofOddTest_5()
        {
            Assert.AreEqual(9,SumOfOddsClass.SumofOdd(5));
        }
        [TestMethod()]
        public void SumofOddTest_6()
        {
            Assert.AreEqual(9, SumOfOddsClass.SumofOdd(6));
        }
    }
}