﻿using System;
using System.Linq;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(str => !String.IsNullOrEmpty(str));
        }
    }
}
