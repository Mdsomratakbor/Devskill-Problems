using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=1; i<=testCase; i++)
            {
                var data = Console.ReadLine().Split(' ');
                Int64 firstNumber = Int64.Parse(data[0]);
                Int64 seceondNumber = Int64.Parse(data[1]);
                if (firstNumber==1)
                {
                    if ((seceondNumber - firstNumber) % 2 == 0)
                        mylist.Add("Case "+i+": Even");
                    else
                        mylist.Add("Case " + i + ": Odd");
                }
                else
                {
                    if ((seceondNumber - firstNumber + 1) % 2 == 0)
                        mylist.Add("Case " + i + ": Even");
                    else
                        mylist.Add("Case " + i + ": Odd");
                }
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
