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
    public class ProjectEulerTests
    {
        [TestMethod()]
        public void MultiplesOf3And5Test()
        {
            Assert.AreEqual(543, ProjectEuler.MultiplesOf3And5(49));
            Assert.AreEqual(233168, ProjectEuler.MultiplesOf3And5(1000));
            Assert.AreEqual(16687353, ProjectEuler.MultiplesOf3And5(8456));
            Assert.AreEqual(89301183, ProjectEuler.MultiplesOf3And5(19564));
        }

        [TestMethod()]
        public void FiboEvenSumTest()
        {
            Assert.AreEqual(10, ProjectEuler.FiboEvenSum(8));
            Assert.AreEqual(10, ProjectEuler.FiboEvenSum(10));
            Assert.AreEqual(44, ProjectEuler.FiboEvenSum(34));
            Assert.AreEqual(44, ProjectEuler.FiboEvenSum(60));
            Assert.AreEqual(798, ProjectEuler.FiboEvenSum(1000));
            Assert.AreEqual(60696, ProjectEuler.FiboEvenSum(100000));
            Assert.AreEqual(4613732, ProjectEuler.FiboEvenSum(4000000));
        }

        [TestMethod()]
        public void IsPrimeTestTrue()
        {
            Assert.IsTrue(ProjectEuler.IsPrime(2));
            Assert.IsTrue(ProjectEuler.IsPrime(3));
            Assert.IsTrue(ProjectEuler.IsPrime(5));
            Assert.IsTrue(ProjectEuler.IsPrime(7));
            Assert.IsTrue(ProjectEuler.IsPrime(11));
            Assert.IsTrue(ProjectEuler.IsPrime(13));
            Assert.IsTrue(ProjectEuler.IsPrime(29));
        }

        [TestMethod()]
        public void IsPrimeTestFalse()
        {
            Assert.IsFalse(ProjectEuler.IsPrime(-1));
            Assert.IsFalse(ProjectEuler.IsPrime(0));
            Assert.IsFalse(ProjectEuler.IsPrime(1));
            Assert.IsFalse(ProjectEuler.IsPrime(4));
        }

        [TestMethod()]
        public void LargestPrimeFactorTest()
        {
            Assert.AreEqual(2, ProjectEuler.LargestPrimeFactor(2));
            Assert.AreEqual(3, ProjectEuler.LargestPrimeFactor(3));
            Assert.AreEqual(5, ProjectEuler.LargestPrimeFactor(5));
            Assert.AreEqual(7, ProjectEuler.LargestPrimeFactor(7));
            Assert.AreEqual(2, ProjectEuler.LargestPrimeFactor(8));
            Assert.AreEqual(29, ProjectEuler.LargestPrimeFactor(13195));
            Assert.AreEqual(6857, ProjectEuler.LargestPrimeFactor(600851475143));
        }

        [TestMethod()]
        public void LargestPalindromeProduct()
        {
            Assert.AreEqual(9009, ProjectEuler.LargestPalindromeProduct(2));
            Assert.AreEqual(906609, ProjectEuler.LargestPalindromeProduct(3));
        }
    }
}