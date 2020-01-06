using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Perfect_Square_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<long> mylist = new List<long>();
            for (int i=1; i<=testCase; i++)
            {
                double x = double.Parse(Console.ReadLine());
                x = Math.Sqrt(x);
                long y = (long)x;
                y++;
                mylist.Add((long)(y * y));
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
