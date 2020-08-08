using System;
using System.Collections.Generic;

namespace SolutionToProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            Console.WriteLine($"For: {For(input)}");
            Console.WriteLine($"While: {While(input)}");
            Console.WriteLine($"Recursive: {Recursive(input)}");
        }

        static int For(in List<int> input)
        {
            var result = 0;
            for (var i = 0; i < input.Count; i++)
            {
                result += input[i];
            }
            return result;
        }
        
        static int While(in List<int> input)
        {
            var result = 0;
            if (input.Count == 0) return result;

            var index = 0;
            while (index < input.Count)
            {
                result += input[index];
                ++index;
            }

            return result;
        }

        static int Recursive(in List<int> input)
        {
            return R(input, 0);
        }

        static int R(in List<int> input, in int index)
        {
            return index >= input.Count ? 0 : input[index] + R(input, index + 1);
        }
    }
}