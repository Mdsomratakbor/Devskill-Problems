using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1;
            var array = new long[66];
            for (int i=1; i<=60; i++)
            {
                a = a * 2;
                long t = a;
                while (t>9)
                {
                    t = t / 10;
                }
                array[i] = t;
            }
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<testCase; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 1)
                    mylist.Add("-" + array[number]);
                else
                    mylist.Add("+"+array[number]);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
