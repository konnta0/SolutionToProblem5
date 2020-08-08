using System;
using System.Collections.Generic;

namespace SolutionToProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input1 = new List<object>
            {
                "a", "b", "c"
            };
            var input2 = new List<object>
            {
                1, 2, 3
            };

            f(input1, input2).ForEach(n =>
            {
                Console.Write($"{n} ");
            });
        }

        static List<object> f(in List<object> input1, in List<object> input2)
        {
            var result = new List<object>();
            
            for (var i = 0; i < input1.Count; i++)
            { 
                result.Add(input1[i]);
                if (i < input2.Count)
                {
                    result.Add(input2[i]);
                }
            }

            for (var diff = input2.Count - (input2.Count - input1.Count); diff < input2.Count; diff++)
            {
                result.Add(input2[diff]);
            }
            
            return result;
        }
    }
}