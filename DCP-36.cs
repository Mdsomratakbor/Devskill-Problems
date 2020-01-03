using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnil_and_Shibli
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            int Case = 0;
            for (int i=0; i<userInput; i++)
            {
                Case++;
                var data1 = Console.ReadLine().Split(' ');
                var data2 = Console.ReadLine().Split(' ');
                int a1, a2, a3, b1, b2, b3;
                a1 = Int32.Parse(data1[0]);
                a2 = Int32.Parse(data1[1]);
                a3 = Int32.Parse(data1[2]);
                b1 = Int32.Parse(data2[0]);
                b2 = Int32.Parse(data2[1]);
                b3 = Int32.Parse(data2[2]);
                if (a1 > b1 && a1 > b2 && a1 > b3 && a2 > b1 && a2 > b2 && a2 > b3 && a3 > b1 && a3 > b2 && a3 > b3)
                    mylist.Add("Case "+Case+": Swapnil wins");
                else if (b1 > a1 && b1 > a2 && b1 > a3 && b2 > a1 && b2 > a2 && b2 > a3 && b3 > a1 && b3 > a2 && b3 > a3)
                    mylist.Add("Case "+ Case +": Shibli wins");
                else
                    mylist.Add("Case "+Case +": Both can win");

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
