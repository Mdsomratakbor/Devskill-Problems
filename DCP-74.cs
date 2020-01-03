using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKey
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            int Case = 0;
            for (int i=1; i<=userInput; i++)
            {
                long k, l, m;
                Case++;
                long NumberInput = Int64.Parse(Console.ReadLine());
                NumberInput *= 3;
                if (NumberInput % 2!=0)
                {
                     k = NumberInput - 2;
                     l = NumberInput - 1;
                     m = NumberInput;
                    mylist.Add("Case #"+Case+": "+k+" "+l+" "+m);
                }
                else
                {
                    k = NumberInput;
                    l = NumberInput - 1;
                    m = NumberInput - 2;
                    mylist.Add("Case #"+Case+": "+k+" "+l+" "+m);

                }


            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
