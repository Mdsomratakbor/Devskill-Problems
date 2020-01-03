using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veley_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<userInput;i++)
            {
                string userString = Console.ReadLine();
                string outputString = "";
                if (userString.ToLower().Contains('r') == true)
                {
                    outputString=  "Not vely easy";

                }
                else
                {
                    outputString = "Vely easy";
                }
                mylist.Add(outputString);
            }
            foreach (var data in mylist)
            {
                Console.WriteLine(data);
            }
            Console.Read();
        }
    }
}
