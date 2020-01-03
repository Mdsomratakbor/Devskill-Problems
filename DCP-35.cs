using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbercheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();          
            for (int i=1; i<=UserInput; i++)
            {               
                int number = int.Parse(Console.ReadLine());
                double root = Math.Sqrt(number);
                 root = Math.Round(root);
                int Total = (int)(root * root);
                if (number == Total)
                    mylist.Add("Case " + i + ": YES");
                else
                    mylist.Add("Case " + i + ": NO");                                               
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
