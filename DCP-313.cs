using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gain_Dev_Shop_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i=0; i<testCase; i++)
            {
                string problemType = Console.ReadLine();
                if (problemType == "Easy Problem")
                    mylist.Add(20);
                else if (problemType == "Medium Problem")
                    mylist.Add(40);
                else
                    mylist.Add(68);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
