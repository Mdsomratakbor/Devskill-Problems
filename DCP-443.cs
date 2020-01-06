using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boltu_vs_Balti
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=1; i<=testInput; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                if (numberInput == 1 || numberInput == 3)
                {
                    mylist.Add("Case "+i+ "-> YES;");
                }
                else
                {
                    mylist.Add("Case " + i + "-> NO;");
                }
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
