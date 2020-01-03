using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brothers_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberInput = long.Parse(Console.ReadLine());
            long sum = 0;
            List<long> mylist = new List<long>();
            for (int i = 3; i < numberInput; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            mylist.Add(sum);

            foreach (var value in mylist)
                Console.WriteLine(value);
            Console.Read();
        }
    }
}
