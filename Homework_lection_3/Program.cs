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
            return values.Aggregate((acumulator,next_value) => acumulator * next_value);          
        }

        public static int Fibonacci_sequence_with_LINQ(int input)
        {

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
            int test_value=5;

            WriteLine(factorial_function_with_LINQ(test_value));
            WriteLine(Fibonacci_sequence_with_LINQ(test_value));

            ReadKey();
        }
    }
}
