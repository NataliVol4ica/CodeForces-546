using System;
using System.Linq;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(str => !String.IsNullOrEmpty(str)).ToList();
            long n = Convert.ToInt64(input[0]);
            long k = Convert.ToInt64(input[1]);
            long ans = n * 2; //throw + open; for every stone
            ans += Math.Min(k - 1, n - k); //step to one of the sides of line
            ans += n - 1 > 0 ? n - 1 : 0; //step to the opposite side; except last
            ans += 1; //throw extra stone from hatch after first throw
            Console.WriteLine(ans);
        }
    }
}
