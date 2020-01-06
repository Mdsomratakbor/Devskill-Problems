using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_and_Rule
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            StringBuilder zeroDigit = new StringBuilder();
             for (int i=1; i<=testInput; i++)
            {
                int digitNumber = int.Parse(Console.ReadLine());
                if (digitNumber == 1)
                {
                    mylist.Add(3.ToString());
                }
                else
                {
                    for (int j = 2; j <= (digitNumber - 1); j++)
                    {
                        zeroDigit.Append(0);
                    }
                    mylist.Add(1+""+zeroDigit+2);
                }
                zeroDigit = new StringBuilder();
                
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }

            Console.Read();
        }
    }
}
