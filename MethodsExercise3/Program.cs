using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isCheck)
        {
            var sum = a + b;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var a = 36;
            var b = 57;

            var answer = Add(a, b);

            var x = 65.1m;
            var y = 71.4m;

            var decimalAnswer = Add(x, y);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");

            Console.WriteLine(thirdAnswer);

        }
    }
}
