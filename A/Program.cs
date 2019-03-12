using System;
using System.Collections.Generic;
using System.Linq;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var glavi = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .Where(str => !String.IsNullOrEmpty(str))
                    .Select(str => Convert.ToInt32(str))
                    .ToList() ;
                glavi.Add(input[1]);
            }
            int page = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            while (glavi[j] < page)
                j++;
            Console.WriteLine(glavi.Count - j);
        }
    }
}
