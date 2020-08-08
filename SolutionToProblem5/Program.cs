using System;
using System.Collections.Generic;

namespace SolutionToProblem5
{
    class Program
    { 
        static List<int> v = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

        static void Main(string[] args)
        {
            var sum = 100;
            var ret = f(sum, v[0], 1);
            foreach (var r in ret)
            {
                Console.WriteLine(r);
            }
        }

        static List<string> f(int sum, int num, int idx)
        {
            var d = Math.Abs(num % 10);
            if (idx >= v.Count)
            {
                var r = new List<string>();

                if (sum == num)
                {
                    r.Add(d.ToString());
                }
                return r;
            }

            Func<int, string, List<string>, List<string>> func = (n, op, source) =>
            {
                var ret = new List<string>();
                foreach (var s in source)
                {
                    ret.Add($"{n}{op}{s}");
                }
                return ret;
            };

            var b1 = f(sum - num, v[idx], idx + 1);
            var b2 = f(sum - num, -v[idx], idx + 1);
            var b3 = f(sum, num >= 0 ? 10 * num + v[idx] : 10 * num - v[idx], idx + 1);
            
            var ret = new List<string>();
            ret.AddRange(func(d, "+", b1));
            ret.AddRange(func(d, "-", b2));
            ret.AddRange(func(d, string.Empty, b3));
            return ret;
        }
    }
}