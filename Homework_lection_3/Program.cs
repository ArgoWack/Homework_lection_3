using System;
using System.Linq;

namespace Homework_lection_3
{
    class Program
    {
        public static int factorial_function_with_LINQ(int input)
        {
            //To DO:
            // turn it into LINQ method

            // input - number of factorial 

            if (input == 0 || input == 1)
            {
                return 1;
            }
            else
            {
                return input * factorial_function_with_LINQ(input - 1);
            }
        }

        public static int Fibonacci_sequence_with_LINQ(int input)
        {
            //To DO:
            // turn it into LINQ method

            // input - number of fibonaci 

            if (input == 0 || input == 1)
            {
                return input;
            }
            else
            {
                return Fibonacci_sequence_with_LINQ(input - 1) + Fibonacci_sequence_with_LINQ(input - 2);
            }          
        }
        static void Main(string[] args)
        {
            Console.WriteLine(factorial_function_with_LINQ(5));
            Console.WriteLine(Fibonacci_sequence_with_LINQ(5));

            Console.ReadKey();
        }
    }
}
