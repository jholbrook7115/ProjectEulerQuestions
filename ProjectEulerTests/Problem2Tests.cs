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
    public class Problem2Tests
    {
        Problem2 p = new Problem2();
        [TestMethod()]
        public void sumOfEvenFibonacciTest()
        {
            //int expected = 4613732;
            Problem2 p = new Problem2();
            int expected = 10;
            int actual = p.sumOfEvenFibonacci(10);
            Assert.AreEqual(expected, actual);

            Problem2 p1 = new Problem2();
            expected = 44;
            actual = p1.sumOfEvenFibonacci(50);
            Assert.AreEqual(expected, actual);

            Problem2 p2 = new Problem2();
            expected = 4613732;
            actual = p2.sumOfEvenFibonacci(4000000);
            Assert.AreEqual(expected, actual);
        }
    }
}