using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_school_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            int Case = 0;
            List<string> mylist = new List<string>();
            for (int i=0; i<UserInput; i++)
            {

                int Number = Int32.Parse(Console.ReadLine());
                Number = Number*(Number + 1);
                Number /= 2;
                double Number1 = Math.Pow(Number,2);
                Case++;
                mylist.Add("Case "+Case+": "+Number1);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
