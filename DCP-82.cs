using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            string Output = "";
            for (int i=0; i<UserInput; i++)
            {
                int Input = Int32.Parse(Console.ReadLine());
                int ChickenLover = 120;
                if (ChickenLover<=Input)
                {
                    Output = "Good Boy Sifat";
                }
                else
                {
                    Output = "Naughty Boy Sifat";
                }
                mylist.Add(Output);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
