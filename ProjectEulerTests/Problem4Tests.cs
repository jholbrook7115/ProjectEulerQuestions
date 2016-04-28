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
    public class Problem4Tests
    {
        [TestMethod()]
        public void isPalindromeTest()
        {
            Problem4 p = new Problem4();
            bool expected = true;
            bool actual = p.isPalindrome(9009);
            Assert.AreEqual(expected, actual);

            Problem4 p1 = new Problem4();
            expected = false;
            actual = p.isPalindrome(1100);
            Assert.AreEqual(expected, actual);


        }

        [TestMethod()]
        public void largest3DigitPalindromeTest()
        {
            Problem4 p = new Problem4();
            int expected = 906609;
            int actual = p.largest3DigitPalindromeBrute();
            Assert.AreEqual(expected, actual);
        }
    }
}