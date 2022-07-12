using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace Homework_lection_3
{
    class Program
    {
        public static int factorial_function_with_LINQ(int input)
        {
            //To DO:
            // turn it into LINQ method

            // input - number of factorial 

            List<int> factorials = new List<int>();

            factorials.Add(1);
            factorials.Add(1);
            if (input == 0 || input == 1)
            {
                return 1;
            }
            else
            {
                for (int i=2;i<input;i++)
                {
                    factorials.Add(factorials[i - 1] * i);
                }
                return input * factorial_function_with_LINQ(input - 1);
            }
        }

        public static int Fibonacci_sequence_with_LINQ(int input)
        {
            //To DO:
            // turn it into LINQ method

            // input - number of fibonaci 

            List<int> Fibonacci = new List<int>();
            Fibonacci.Add(0);
            Fibonacci.Add(1);

            if (input == 0 || input == 1)
            {
                return input;
            }
            else
            {
                for (int i = 2; i <= input; i++)
                {
                    Fibonacci.Add(Fibonacci[i - 1]+ Fibonacci[i - 2]);
                }

                return Fibonacci.Last();
            }   
        }
        static void Main(string[] args)
        {
            WriteLine(factorial_function_with_LINQ(5));
            WriteLine(Fibonacci_sequence_with_LINQ(5));

            ReadKey();
        }
    }
}
