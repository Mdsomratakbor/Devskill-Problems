using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_and_Fool
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for(int i=0; i<userInput; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int A, B, total = 0;
                A = Int32.Parse(data[0]);
                B = Int32.Parse(data[1]);
                total = Int32.Parse(data[2]);
                int x = 0, pc = 0, AB = 0;

                AB = A / B;
                A %= B;
                StringBuilder z = new StringBuilder();
                while (pc<total)
                {
                    
                    A *= 10;
                    x = A / B;
                    // string y = x.ToString();
                    z.Append(x);
                    A %= B;
                    pc++;
                }
                mylist.Add(AB+"."+z);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
