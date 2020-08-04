using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1. Create a loop that prints all values 1-255

            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine($"current int: {i}");
            }

            // 2. Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                Console.WriteLine($"Divisable by 3: {i}");
                }
                if (i % 5 == 0)
                {
                Console.WriteLine($"Divisable by 5: {i}");
                }
            }

            // 3. Modify the previous loop to print "Fizz" for multiples of 3, 
            //    "Buzz" for multiples of 5, 
            //    and "FizzBuzz" for numbers that are multiples of both 3 and 5

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}: FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}: Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}: Buzz");
                }
            }

            // Optional - Rewrite for loops as while loops
            // 1.
            int k = 1;
            while (k < 256)
            {
                Console.WriteLine($"Current int: {k}");
                k++;
            }

            // 2.
            int value = 1;
            while (value < 101)
            {
                if (value % 3 == 0)
                {
                    Console.WriteLine($"Divisable by 3: {value}");
                }
                if (value % 5 == 0)
                {
                    Console.WriteLine($"Divisable by 5: {value}");
                }
                value++;

            }

            // 3. 
            int buzzfuzz = 1;
            while (buzzfuzz < 101)
            {
                if (buzzfuzz % 3 == 0 && buzzfuzz % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (buzzfuzz % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (buzzfuzz % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                buzzfuzz++;
            }
        }
    }
}
