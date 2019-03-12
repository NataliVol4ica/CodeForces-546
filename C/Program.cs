using System;
using System.Linq;
using System.Collections.Generic;

namespace C
{
    class Program
    {
        static List<List<long>> ReadMatrix(int n)
        {
            var matrix = new List<List<long>>();
            for (int i = 0; i < n; i++)
                matrix.Add(
                    Console.ReadLine()
                    .Split(' ')
                    .Where(str => !String.IsNullOrEmpty(str))
                    .Select(str => Convert.ToInt64(str))
                    .ToList());
            return matrix;
        }
        static List<long> GetDiagonal(List<List<long>> matrix, int n, int m, int i, int j)
        {
            var diagonal = new List<long>();
            while (j >= 0 && i < n)
            {
                diagonal.Add(matrix[i][j]);
                i++;
                j--;
            }
            return diagonal.OrderBy(x => x).ToList();
        }
        static void CompareLists(List<long> l1, List<long> l2)
        {
            for (int i = 0; i < l1.Count; i++)
                if (l1[i] != l2[i])
                {
                    Console.WriteLine("NO");
                    System.Environment.Exit(0);
                }
        }
        static void CompareDiagonals(List<List<long>> matrix1, List<List<long>> matrix2, int n, int m)
        {
            int pos = 0;
            while (pos < m)
            {
                int j = pos;
                int i = 0;
                var diag1 = GetDiagonal(matrix1, n, m, i, j);
                var diag2 = GetDiagonal(matrix2, n, m, i, j);
                CompareLists(diag1, diag2);
                pos++;
            }
            pos = 1;
            while (pos < n)
            {
                var diagonal = new List<long>();
                int i = pos;
                int j = m - 1;
                var diag1 = GetDiagonal(matrix1, n, m, i, j);
                var diag2 = GetDiagonal(matrix2, n, m, i, j);
                CompareLists(diag1, diag2);
                pos++;
            }
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(str => !String.IsNullOrEmpty(str)).ToList();
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            var matrix1 = ReadMatrix(n);
            var matrix2 = ReadMatrix(n);
            /*int n = 5;
            int m = 4;
            var matrix1 = new List<List<long>>
            {
                new List<long> { 6, 3, 2, 11 },
                new List<long> { 5, 9, 4, 2 },
                new List<long> { 3, 3, 3, 3},
                new List<long> { 4, 8, 2, 2},
                new List<long> { 7, 8, 6, 4}
            };
            var matrix2 = new List<List<long>>
            {
                new List<long> { 6, 3, 2, 11 },
                new List<long> { 5, 9, 3, 8 },
                new List<long> { 3, 4, 3, 2},
                new List<long> { 4, 2, 3, 2},
                new List<long> { 7, 8, 6, 4}
            };      */      
            CompareDiagonals(matrix1, matrix2, n, m);       
            Console.WriteLine("YES");
        }
    }
}
