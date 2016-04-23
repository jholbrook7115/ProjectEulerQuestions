using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public Problem1 prog = new Problem1();
        [TestMethod()]
        public void sumOfMultiplesTest()
        {
            int expected = 23;
            int actual = prog.sumOfMultiples(new int[] { 3, 5 }, 10);
            Assert.AreEqual(expected, actual);

            expected = 233168;
            actual = prog.sumOfMultiples(new int[] { 3, 5 }, 1000);
            Assert.AreEqual(expected, actual);
        }
    }
}