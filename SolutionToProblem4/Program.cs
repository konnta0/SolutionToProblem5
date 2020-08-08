using System;
using System.Collections.Generic;

namespace SolutionToProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>
            {
                50, 2, 1, 9
            };       
            Console.WriteLine(f(input));
        }

        static string f(in List<int> input)
        {
            var l = new List<int>(input);
            var result = "";
            l.Sort((x, y) =>
            {
                var X = x.ToString();
                var Y = y.ToString();
                
                return (X + Y).CompareTo(Y + X) * -1;
            });
            foreach (var r in l)
            {
                result += r;
            }
            return result;
        }
    }
}