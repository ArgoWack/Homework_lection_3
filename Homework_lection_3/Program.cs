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
            IEnumerable<int> values = Enumerable.Range(1, input);
            if (input == 0)
                return 1;
            else
                return values.Aggregate((acumulator,next_value) => acumulator * next_value);          
        }

        public static int Fibonacci_sequence_with_LINQ(int input)
        {
            if (input == 0)
                return 0;
            return Enumerable.Range(0, input).Skip(1).Aggregate(new { previous = 0, current = 1 }, (previous, _) => new { previous = previous.current, current = previous.previous + previous.current }).current;

            /*
             * It's my failed attempt. Probably didn't work because Method "Where" saw "Index" just as a value and not actual index.
             * 
            IEnumerable<int> values = Enumerable.Range(1, input).Select(x => 1);

            if (input == 0 || input == 1)
            {
                return input;
            }

            values =values.Where(index => index > 1).Select((index,x) => values.ElementAt(index-2)+ values.ElementAt(index-1));
            return values.Last();
            */
        }
        static void Main(string[] args)
        {
            /* I don't know whether I should handle exceptions here since they can't appear as long as int is given to methods below.
               I would implement them if user would be to write input from console tho.*/

            int test_value = 1;

            WriteLine("Factorial: " + factorial_function_with_LINQ(test_value));
            WriteLine("Fibonacci: " + Fibonacci_sequence_with_LINQ(test_value));

            ReadKey();

        }
    }
}
