using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabu_and_the_Series
{
    class Program
    {
        public static long[] myarray = new long[1000001];
        public static void GabuSeries()
        {
            myarray[1] = 0;
            myarray[2] = 2;
            long p = 6;
            long j = 3 ;
            while (j < 1000001)
            {
                myarray[j] = myarray[j - 1] + p;
                p += 4;
                j++;
            }
        }

        static void Main(string[] args)
        {
            long userInput = Int32.Parse(Console.ReadLine());
            List<long> mylist = new List<long>();
            for (long i=0; i<userInput; i++)
            {
                GabuSeries();
                long Number = Int32.Parse(Console.ReadLine());
                mylist.Add(myarray[Number]);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
  

    }
}
