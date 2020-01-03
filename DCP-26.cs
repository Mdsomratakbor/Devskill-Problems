using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int k=0; k<input; k++) {
                string Userinput = Console.ReadLine();
                string OutputWord = "";
                for (int i = Userinput.Length - 1; i >= 0; --i)
                {
                    OutputWord += Userinput[i];
                }
                mylist.Add(OutputWord);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }

    }
}
