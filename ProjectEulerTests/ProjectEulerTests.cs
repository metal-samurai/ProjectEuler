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

        [TestMethod()]
        public void SmallestMultipleTest()
        {
            Assert.AreEqual(60, ProjectEuler.SmallestMultiple(5));
            Assert.AreEqual(420, ProjectEuler.SmallestMultiple(7));
            Assert.AreEqual(2520, ProjectEuler.SmallestMultiple(10));
            Assert.AreEqual(360360, ProjectEuler.SmallestMultiple(13));
            Assert.AreEqual(232792560, ProjectEuler.SmallestMultiple(20));
        }

        [TestMethod()]
        public void SumSquareDifferenceTest()
        {
            Assert.AreEqual(2640, ProjectEuler.SumSquareDifference(10));
            Assert.AreEqual(41230, ProjectEuler.SumSquareDifference(20));
            Assert.AreEqual(25164150, ProjectEuler.SumSquareDifference(100));
        }

        [TestMethod()]
        public void NthPrimeTest()
        {
            Assert.AreEqual(13, ProjectEuler.NthPrime(6));
            Assert.AreEqual(29, ProjectEuler.NthPrime(10));
            Assert.AreEqual(7919, ProjectEuler.NthPrime(1000));
            Assert.AreEqual(104743, ProjectEuler.NthPrime(10001));
        }

        [TestMethod()]
        public void LargestProductInASeriesTest()
        {
            Assert.AreEqual(5832, ProjectEuler.LargestProductInASeries(4));
            Assert.AreEqual(23514624000, ProjectEuler.LargestProductInASeries(13));
        }

        [TestMethod()]
        public void SpecialPythagoreanTripletTest()
        {
            Assert.AreEqual(480, ProjectEuler.SpecialPythagoreanTriplet(24));
            Assert.AreEqual(49920, ProjectEuler.SpecialPythagoreanTriplet(120));
            Assert.AreEqual(31875000, ProjectEuler.SpecialPythagoreanTriplet(1000));
        }

        [TestMethod()]
        public void PrimeSummationTest()
        {
            Assert.AreEqual(41, ProjectEuler.PrimeSummation(17));
            Assert.AreEqual(277050, ProjectEuler.PrimeSummation(2001));
            Assert.AreEqual(873608362, ProjectEuler.PrimeSummation(140759));
            Assert.AreEqual(142913828922, ProjectEuler.PrimeSummation(2000000));
        }

        [TestMethod()]
        public void LargestGridProductTest()
        {
            int[,] grid1 =
                {
  {8, 2, 22, 97, 38, 15, 0, 40, 0, 75, 4, 5, 7, 78, 52, 12, 50, 77, 91, 8},
  {49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 4, 56, 62, 0},
  {81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 3, 49, 13, 36, 65},
  {52, 70, 95, 23, 4, 60, 11, 42, 69, 24, 68, 56, 1, 32, 56, 71, 37, 2, 36, 91},
  {22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80},
  {24, 47, 32, 60, 99, 3, 45, 2, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50},
  {32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70},
  {67, 26, 20, 68, 2, 62, 12, 20, 95, 63, 94, 39, 63, 8, 40, 91, 66, 49, 94, 21},
  {24, 55, 58, 5, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72},
  {21, 36, 23, 9, 75, 0, 76, 44, 20, 45, 35, 14, 0, 61, 33, 97, 34, 31, 33, 95},
  {78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 3, 80, 4, 62, 16, 14, 9, 53, 56, 92},
  {16, 39, 5, 42, 96, 35, 31, 47, 55, 58, 88, 24, 0, 17, 54, 24, 36, 29, 85, 57},
  {86, 56, 0, 48, 35, 71, 89, 7, 5, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58},
  {19, 80, 81, 68, 5, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 4, 89, 55, 40},
  {4, 52, 8, 83, 97, 35, 99, 16, 7, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66},
  {88, 36, 68, 87, 57, 62, 20, 72, 3, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69},
  {4, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8, 46, 29, 32, 40, 62, 76, 36},
  {20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 4, 36, 16},
  {20, 73, 35, 29, 78, 31, 90, 1, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 5, 54},
  {1, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 1, 89, 19, 67, 48}
            };

            int[,] grid2 = 
                {
  { 40, 17, 81, 18, 57 },
  { 74, 4, 36, 16, 29 },
  { 36, 42, 69, 73, 45 },
  { 51, 54, 69, 16, 92 },
  { 7, 97, 57, 32, 16 }
            };

            Assert.AreEqual(70600674, ProjectEuler.LargestGridProduct(grid1));
            Assert.AreEqual(14169081, ProjectEuler.LargestGridProduct(grid2));
        }

        [TestMethod()]
        public void DivisibleTriangleNumberTest()
        {
            Assert.AreEqual(28, ProjectEuler.DivisibleTriangleNumber(5));
            Assert.AreEqual(630, ProjectEuler.DivisibleTriangleNumber(23));
            Assert.AreEqual(1385280, ProjectEuler.DivisibleTriangleNumber(167));
            Assert.AreEqual(17907120, ProjectEuler.DivisibleTriangleNumber(374));
            Assert.AreEqual(76576500, ProjectEuler.DivisibleTriangleNumber(500));
        }
    }
}