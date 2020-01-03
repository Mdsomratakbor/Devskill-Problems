using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_Can_I_First_Solve
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i=0; i<userInput; i++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                int A = Int32.Parse(data[0]);
                int B = Int32.Parse(data[1]);
                int AB = Int32.Parse(data[2]);
                int BA = AB + B;
                 BA -= A;
                mylist.Add(BA);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
