using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionToProblem3
{
    class Program
    {
        private static Dictionary<long, long> cache = new Dictionary<long, long>();
        static void Main(string[] args)
        {
            var n = 100;
            var builder = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                builder.AppendLine($"{f(i)}");
            }
            Console.WriteLine(builder.ToString());
        }

        static long f(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (!cache.ContainsKey(n))
            {
                cache[n] = f(n - 1) + f(n - 2);
            }
            return cache[n];
        }
    }
}