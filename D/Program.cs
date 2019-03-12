using System;
using System.Linq;
using System.Collections.Generic;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(str => !String.IsNullOrEmpty(str)).ToList();
        }
    }
}
