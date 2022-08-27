using System.Diagnostics;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ProjectEulerTests")]
namespace ProjectEuler
{
    public static class ProjectEuler
    {
        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below the provided parameter value number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int MultiplesOf3And5(int number)
        {
            var sum = 0;

            for (var i = 3; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            
            return sum;
        }

        /// <summary>
        /// By considering the terms in the Fibonacci sequence whose values do not exceed number, find the sum of the even-valued terms.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FiboEvenSum(int number)
        {
            List<int> sequence = new(new int[] { 1, 2 });
            var sum = 0;
            var i = 0;
            while (sequence[i] <= number)
            {
                if (sequence[i] % 2 == 0)
                {
                    sum += sequence[i];
                }

                if (i == sequence.Count - 1)
                {
                    sequence.Add(sequence[i] + sequence[i - 1]);
                    sequence.RemoveAt(0);
                }
                else
                {
                    i++;
                }
            }

            return sum;
        }

        internal static bool IsPrime(long number)
        {
            if (number < 2) return false;

            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        /// <summary>
        /// What is the largest prime factor of the given number?
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long LargestPrimeFactor(long number)
        {
            long largestFactor = 0;

            for (var i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    while (number % i == 0)
                    {
                        largestFactor = i;
                        number /= i;
                    }
                }
            }

            return largestFactor;
        }

        /// <summary>
        /// Find the largest palindrome made from the product of two n-digit numbers.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static long? LargestPalindromeProduct(int digits)
        {
            var maxOperand = long.Parse(new string('9', digits));
            var minOperand = long.Parse("1" + new string('0', digits - 1));
            long? largestPalindrome = null;

            for (var i = maxOperand; i >= minOperand; i--)
            {
                for (var j = maxOperand; j >= minOperand; j--)
                {
                    var product = i * j;
                    
                    if (product.ToString() == new string(product.ToString().Reverse().ToArray()))
                    {
                        if (largestPalindrome == null || product >= largestPalindrome) largestPalindrome = product;
                        break;
                    }
                }
            }

            return largestPalindrome;
        }

        /// <summary>
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to number?
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static long SmallestMultiple(int number)
        {
            if (number < 1) throw new ArgumentException("Number must be > 0");
            if (number <= 2) return number;

            long smallestMultiple = 0;
            
            for (var i = number; smallestMultiple == 0; i += number)
            {
                for (var j = 2; j <= number; j++)
                {
                    if (i % j != 0) break;
                    if (j == number) smallestMultiple = i;
                }
            }

            return smallestMultiple;
        }

        /// <summary>
        /// Find the difference between the sum of the squares of the first n natural numbers and the square of the sum.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long SumSquareDifference(int n)
        {
            var sumSquares = 0;
            var squareSum = 0;

            for (var i = 1; i <= n; i++)
            {
                sumSquares += i * i;
                squareSum += i;
            }

            squareSum *= squareSum;

            return squareSum - sumSquares;
        }

        /// <summary>
        /// What is the nth prime number?
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long NthPrime(int n)
        {
            if (n == 1) return 2;
            if (n == 2) return 3;

            var lastPrime = 3;

            for (var i = 3; i <= n; i++)
            {
                do
                {
                    lastPrime += 2;
                } while (!IsPrime(lastPrime));
            }

            return lastPrime;
        }

        /// <summary>
        /// Find the n adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long LargestProductInASeries(int n)
        {
            int[] thousandDigits = { 7, 3, 1, 6, 7, 1, 7, 6, 5, 3, 1, 3, 3, 0, 6, 2, 4, 9, 1, 9, 2, 2, 5, 1, 1, 9, 6, 7, 4, 4, 2, 6, 5, 7, 4, 7, 4, 2, 3, 5, 5, 3, 4, 9, 1, 9, 4, 9, 3, 4, 9, 6, 9, 8, 3, 5, 2, 0, 3, 1, 2, 7, 7, 4, 5, 0, 6, 3, 2, 6, 2, 3, 9, 5, 7, 8, 3, 1, 8, 0, 1, 6, 9, 8, 4, 8, 0, 1, 8, 6, 9, 4, 7, 8, 8, 5, 1, 8, 4, 3, 8, 5, 8, 6, 1, 5, 6, 0, 7, 8, 9, 1, 1, 2, 9, 4, 9, 4, 9, 5, 4, 5, 9, 5, 0, 1, 7, 3, 7, 9, 5, 8, 3, 3, 1, 9, 5, 2, 8, 5, 3, 2, 0, 8, 8, 0, 5, 5, 1, 1, 1, 2, 5, 4, 0, 6, 9, 8, 7, 4, 7, 1, 5, 8, 5, 2, 3, 8, 6, 3, 0, 5, 0, 7, 1, 5, 6, 9, 3, 2, 9, 0, 9, 6, 3, 2, 9, 5, 2, 2, 7, 4, 4, 3, 0, 4, 3, 5, 5, 7, 6, 6, 8, 9, 6, 6, 4, 8, 9, 5, 0, 4, 4, 5, 2, 4, 4, 5, 2, 3, 1, 6, 1, 7, 3, 1, 8, 5, 6, 4, 0, 3, 0, 9, 8, 7, 1, 1, 1, 2, 1, 7, 2, 2, 3, 8, 3, 1, 1, 3, 6, 2, 2, 2, 9, 8, 9, 3, 4, 2, 3, 3, 8, 0, 3, 0, 8, 1, 3, 5, 3, 3, 6, 2, 7, 6, 6, 1, 4, 2, 8, 2, 8, 0, 6, 4, 4, 4, 4, 8, 6, 6, 4, 5, 2, 3, 8, 7, 4, 9, 3, 0, 3, 5, 8, 9, 0, 7, 2, 9, 6, 2, 9, 0, 4, 9, 1, 5, 6, 0, 4, 4, 0, 7, 7, 2, 3, 9, 0, 7, 1, 3, 8, 1, 0, 5, 1, 5, 8, 5, 9, 3, 0, 7, 9, 6, 0, 8, 6, 6, 7, 0, 1, 7, 2, 4, 2, 7, 1, 2, 1, 8, 8, 3, 9, 9, 8, 7, 9, 7, 9, 0, 8, 7, 9, 2, 2, 7, 4, 9, 2, 1, 9, 0, 1, 6, 9, 9, 7, 2, 0, 8, 8, 8, 0, 9, 3, 7, 7, 6, 6, 5, 7, 2, 7, 3, 3, 3, 0, 0, 1, 0, 5, 3, 3, 6, 7, 8, 8, 1, 2, 2, 0, 2, 3, 5, 4, 2, 1, 8, 0, 9, 7, 5, 1, 2, 5, 4, 5, 4, 0, 5, 9, 4, 7, 5, 2, 2, 4, 3, 5, 2, 5, 8, 4, 9, 0, 7, 7, 1, 1, 6, 7, 0, 5, 5, 6, 0, 1, 3, 6, 0, 4, 8, 3, 9, 5, 8, 6, 4, 4, 6, 7, 0, 6, 3, 2, 4, 4, 1, 5, 7, 2, 2, 1, 5, 5, 3, 9, 7, 5, 3, 6, 9, 7, 8, 1, 7, 9, 7, 7, 8, 4, 6, 1, 7, 4, 0, 6, 4, 9, 5, 5, 1, 4, 9, 2, 9, 0, 8, 6, 2, 5, 6, 9, 3, 2, 1, 9, 7, 8, 4, 6, 8, 6, 2, 2, 4, 8, 2, 8, 3, 9, 7, 2, 2, 4, 1, 3, 7, 5, 6, 5, 7, 0, 5, 6, 0, 5, 7, 4, 9, 0, 2, 6, 1, 4, 0, 7, 9, 7, 2, 9, 6, 8, 6, 5, 2, 4, 1, 4, 5, 3, 5, 1, 0, 0, 4, 7, 4, 8, 2, 1, 6, 6, 3, 7, 0, 4, 8, 4, 4, 0, 3, 1, 9, 9, 8, 9, 0, 0, 0, 8, 8, 9, 5, 2, 4, 3, 4, 5, 0, 6, 5, 8, 5, 4, 1, 2, 2, 7, 5, 8, 8, 6, 6, 6, 8, 8, 1, 1, 6, 4, 2, 7, 1, 7, 1, 4, 7, 9, 9, 2, 4, 4, 4, 2, 9, 2, 8, 2, 3, 0, 8, 6, 3, 4, 6, 5, 6, 7, 4, 8, 1, 3, 9, 1, 9, 1, 2, 3, 1, 6, 2, 8, 2, 4, 5, 8, 6, 1, 7, 8, 6, 6, 4, 5, 8, 3, 5, 9, 1, 2, 4, 5, 6, 6, 5, 2, 9, 4, 7, 6, 5, 4, 5, 6, 8, 2, 8, 4, 8, 9, 1, 2, 8, 8, 3, 1, 4, 2, 6, 0, 7, 6, 9, 0, 0, 4, 2, 2, 4, 2, 1, 9, 0, 2, 2, 6, 7, 1, 0, 5, 5, 6, 2, 6, 3, 2, 1, 1, 1, 1, 1, 0, 9, 3, 7, 0, 5, 4, 4, 2, 1, 7, 5, 0, 6, 9, 4, 1, 6, 5, 8, 9, 6, 0, 4, 0, 8, 0, 7, 1, 9, 8, 4, 0, 3, 8, 5, 0, 9, 6, 2, 4, 5, 5, 4, 4, 4, 3, 6, 2, 9, 8, 1, 2, 3, 0, 9, 8, 7, 8, 7, 9, 9, 2, 7, 2, 4, 4, 2, 8, 4, 9, 0, 9, 1, 8, 8, 8, 4, 5, 8, 0, 1, 5, 6, 1, 6, 6, 0, 9, 7, 9, 1, 9, 1, 3, 3, 8, 7, 5, 4, 9, 9, 2, 0, 0, 5, 2, 4, 0, 6, 3, 6, 8, 9, 9, 1, 2, 5, 6, 0, 7, 1, 7, 6, 0, 6, 0, 5, 8, 8, 6, 1, 1, 6, 4, 6, 7, 1, 0, 9, 4, 0, 5, 0, 7, 7, 5, 4, 1, 0, 0, 2, 2, 5, 6, 9, 8, 3, 1, 5, 5, 2, 0, 0, 0, 5, 5, 9, 3, 5, 7, 2, 9, 7, 2, 5, 7, 1, 6, 3, 6, 2, 6, 9, 5, 6, 1, 8, 8, 2, 6, 7, 0, 4, 2, 8, 2, 5, 2, 4, 8, 3, 6, 0, 0, 8, 2, 3, 2, 5, 7, 5, 3, 0, 4, 2, 0, 7, 5, 2, 9, 6, 3, 4, 5, 0 };

            long largestProduct = 1;

            for (var i = 0; i <= thousandDigits.Length - n; i++)
            {
                long product = 1;

                for (var j = i; j < i + n; j++)
                {
                    product *= thousandDigits[j];
                    if (product == 0) break;
                }
                
                if (product > largestProduct) largestProduct = product;
            }
            return largestProduct;
        }

        /// <summary>
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc such that a + b + c = n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long? SpecialPythagoreanTriplet(int n)
        {
            for (var i = 1; i <= n - 2; i++)
            {
                for (var j = i + 1; i + j <= n - 1; j++)
                {
                    var k = n - i - j;

                    if (i + j + k == n && i * i + j * j == k * k)
                    {
                        return i * j * k;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Find the sum of all the primes below n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long PrimeSummation(int n)
        {
            if (n <= 2) return 0;
            if (n == 3) return 2;

            long sum = 2;

            for (var i = 3; i < n; i += 2)
            {
                if (IsPrime(i)) sum += i;
            }

            return sum;
        }

        /// <summary>
        /// What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in a given arr grid?
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        /// <remarks>arr is assumed to be a square grid.</remarks>
        public static long LargestGridProduct(int[,] arr)
        {
            var numValues = 4;
            long largestProduct = 0;

            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    long product = 0;

                    //check down
                    if (i <= arr.GetLength(0) - numValues)
                    {
                        product = 1;

                        for (var k = i; k < i + numValues; k++)
                        {
                            product *= arr[k, j];
                        }

                        if (product > largestProduct) largestProduct = product;
                    }
                    
                    //check right
                    if (j <= arr.GetLength(1) - numValues)
                    {
                        product = 1;
                        
                        for (var k = j; k < j + numValues; k++)
                        {
                            product *= arr[i, k];
                        }

                        if (product > largestProduct) largestProduct = product;
                    }

                    //check diagonal left
                    if (i <= arr.GetLength(0) - numValues && j >= numValues - 1)
                    {
                        product = 1;
                        
                        for (var k = j; k >= j - numValues + 1; k--)
                        {
                            product *= arr[i + (j - k), k];
                        }

                        if (product > largestProduct) largestProduct = product;
                    }

                    //check diagonal right
                    if (i <= arr.GetLength(0) - numValues && j <= arr.GetLength(1) - numValues)
                    {
                        product = 1;
                        
                        for (var k = j; k < j + numValues; k++)
                        {
                            product *= arr[i + (k - j), k];
                        }

                        if (product > largestProduct) largestProduct = product;
                    }
                        
                }
                

            }

            return largestProduct;
        }

        /// <summary>
        /// What is the value of the first triangle number to have over n divisors?
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long DivisibleTriangleNumber(int n)
        {
            if (n == 0) return 1;

            var triangleNumber = 1;
            var divisorCount = 0;

            for (var i = 2; divisorCount <= n; i++)
            {
                triangleNumber += i;
                divisorCount = 0;
                
                for (var j = 1; j < Math.Sqrt(triangleNumber); j++)
                {
                    if (triangleNumber % j == 0) divisorCount += 2;
                }

                if (triangleNumber % Math.Sqrt(triangleNumber) == 0) divisorCount++;
            }

            return triangleNumber;
        }
    }
}