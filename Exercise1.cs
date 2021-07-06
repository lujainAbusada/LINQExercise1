using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercises
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            List<int> squares = new List<int> { 1, 4, 9, 16 };

            var function = TestForSquares(numbers, squares);
            Console.WriteLine(function);
        }
        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            return numbers.Select(number => (int)Math.Pow(number,2)).SequenceEqual(squares);

        }
    }
}


   