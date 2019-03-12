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
        static List<long> GetDiagonal(List<List<long>> matrix, int n, int i, int j)
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
        static void CompareSortedDiagonals(List<long> left, List<long> right)
        {
            for (int i = 0; i < left.Count; i++)
                if (left[i] != right[i])
                {
                    Console.WriteLine("NO");
                    System.Environment.Exit(0);
                }
        }
        static void CompareDiagonals(List<List<long>> matrix1, List<List<long>> matrix2, int n, int m)
        {
            //the beginning of diagonal moves horizontally
            int pos = 0;
            while (pos < m)
            {
                int j = pos;
                int i = 0;
                var diag1 = GetDiagonal(matrix1, n, i, j);
                var diag2 = GetDiagonal(matrix2, n, i, j);
                CompareSortedDiagonals(diag1, diag2);
                pos++;
            }
            //the beginning of diagonal moves Vertically
            pos = 1;
            while (pos < n)
            {
                int i = pos;
                int j = m - 1;
                var diag1 = GetDiagonal(matrix1, n, i, j);
                var diag2 = GetDiagonal(matrix2, n, i, j);
                CompareSortedDiagonals(diag1, diag2);
                pos++;
            }
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Where(str => !String.IsNullOrEmpty(str))
                .ToList();
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            var matrix1 = ReadMatrix(n);
            var matrix2 = ReadMatrix(n);            
            CompareDiagonals(matrix1, matrix2, n, m);       
            Console.WriteLine("YES");
        }
    }
}
