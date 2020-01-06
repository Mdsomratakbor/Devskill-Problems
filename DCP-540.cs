using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<testCase; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber % 3 != 0)
                    mylist.Add("First");
                else
                    mylist.Add("Second");
                
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
