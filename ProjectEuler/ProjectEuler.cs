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
            if (number == 2) return true;

            for (var i = 2; i < number; i++)
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
    }
}