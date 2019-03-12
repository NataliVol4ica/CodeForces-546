using System;
using System.Linq;
using System.Collections.Generic;

namespace E
{
    class Program
    {
        static void Sum(List<long> a, List<long> k, int i, int x)
        {
            a[i] += x;
            for (int j = i + 1; j < a.Count; j++)
                a[j] = Math.Max(a[j], a[j - 1] + k[j - 1]);
        }
        static void Print(List<long> a, int l, int r)
        {
            double sum = 0;
            for (int i = l - 1; i < r; i++)
                sum += a[i];
            var split = sum.ToString().Split('.').ToList();
            string str = split[0];
            Console.WriteLine(str);
        }
        static void ParseCommand(List<string> cmd, List<long>a, List<long>k)
        {
            int i = Convert.ToInt32(cmd[1]);
            int x = Convert.ToInt32(cmd[2]);
            if (cmd[0] == "+")
                Sum(a, k, i -1 , x);
            else
                Print(a, i, x);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var a = Console.ReadLine()
                .Split(' ')
                .Where(str => !String.IsNullOrEmpty(str))
                .Select(str => Convert.ToInt64(str))
                .ToList();
            var k = Console.ReadLine()
                .Split(' ')
                .Where(str => !String.IsNullOrEmpty(str))
                .Select(str => Convert.ToInt64(str))
                .ToList();
            int q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                var command = Console.ReadLine()
                .Split(' ')
                .Where(str => !String.IsNullOrEmpty(str))
                .ToList();
                ParseCommand(command, a, k);
            }
        }
    }
}
