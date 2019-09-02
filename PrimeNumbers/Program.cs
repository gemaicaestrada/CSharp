using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countAsPrime = 1;
            // Prime validation
            for (int number = 3; number <= 10000000; number++)
            {
                bool isPrime = true;
                for (int factor = 2; factor <= Math.Sqrt(number); factor++)
                {
                    if (number % factor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // Count how many prime numbers
                if (isPrime)
                {
                    countAsPrime += 1;
                }
            }
            Console.WriteLine($"total number of prime number in 10 million: {countAsPrime}");
        }
    }
}

