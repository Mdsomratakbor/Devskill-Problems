using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wink_kick
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i = 0; i < userInput; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int A = Convert.ToInt32(data[0]);
                int B = Convert.ToInt32(data[1]);
                if (B == 0 || A % B != 0)
                    mylist.Add(":kick:");
                else
                  mylist.Add(":wink:");

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
