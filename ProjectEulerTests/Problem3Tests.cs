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
    public class Problem3Tests
    {
        [TestMethod()]
        public void largestPrimeFactorBruteTest()
        {
            Problem3 p = new Problem3();
            int expected = 7;
            int actual = p.largestPrimeFactorBrute(14);
            Assert.AreEqual(expected, actual);

            Problem3 p1 = new Problem3();
            expected = 5;
            actual = p1.largestPrimeFactorBrute(100);
            Assert.AreEqual(expected, actual);

            //The following test will take an (figurative)eternity to run.  
            //I would not recommend it but try it if you want to i guess.
           
            //Problem3 p2 = new Problem3();
            //expected = 6857;
            //actual = p.largestPrimeFactorBrute(600851475143);
            //Assert.AreEqual(expected, actual);


        }

        [TestMethod()]
        public void largestPrimeFactorSmartTest()
        {
            Problem3 p2 = new Problem3();
            long expected = 6857;
            long actual = p2.largestPrimeFactorSmart(600851475143);
            Assert.AreEqual(expected, actual);
        }
    }
}