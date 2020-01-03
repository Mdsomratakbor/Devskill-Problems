using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squar_Sum_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong userInput = ulong.Parse(Console.ReadLine());
            List<ulong> mylist = new List<ulong>();
            for (ulong i=0; i<userInput; i++)
            {
                ulong numberInput = ulong.Parse(Console.ReadLine());
                ulong a = 0, b = 0, c = 0, d = 0;
                for (ulong k=1; k<=numberInput; k++)
                {
                     a = k * k;
                     b += a;
                }
                for (ulong l=1; l<=numberInput; l++)
                {
                    c += l;
                    d = c;
                }
                d *= d;
                mylist.Add(d-b);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
