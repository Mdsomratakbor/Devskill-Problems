using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kufa_Land
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            
            for (int i=0; i<userInput; i++)
            {
                long number = long.Parse(Console.ReadLine());
                if (number % 3 == 0)
                    mylist.Add(1);
                else if (number % 3 == 1)
                    mylist.Add(2);
                else
                    mylist.Add(4);

            }
            foreach (var value in mylist)
                Console.WriteLine(value);
            Console.Read();
        }
    }
}
