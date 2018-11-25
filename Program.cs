using System;

namespace Csharp_Euler002
{
    class Program
    {
        static void Main(string[] args)
        {   /*  Euler Challenge #2
                In a Fibanacci sequence, find the sum of all even terms 4 million of less.   
                https://projecteuler.net/problem=2  */

            int sumTotal = 2; int fib1 = 1; int fib2 = 2;
            int currFib = fib1 + fib2;
            while(currFib <= 4000000)
            {
                sumTotal += IsEven(currFib);
                // Advance the fibanacci sequence.
                fib1 = fib2;
                fib2 = currFib;
                currFib = fib1 + fib2;
            }
            Console.WriteLine("Euler Challenge #2\n\nIn a Fibanacci sequence, the sum of all even terms 4 million of less = {0}.", sumTotal);
            Console.ReadLine();
        }

        static int IsEven(int num1)
        {   // Returns the number if it is even, return zero if an odd number.
            if (num1 % 2 == 0){
                return (num1);
            }
            return (0);
        }
    }
}
