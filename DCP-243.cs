using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Power_Of_9
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
                if (number%2==0)
                {
                    mylist.Add(1);
                }
                else
                {
                    mylist.Add(9);
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
