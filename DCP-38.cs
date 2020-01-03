using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysterious_Pond
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i = 0; i < userInput; i++)
            {
                int number = Int32.Parse(Console.ReadLine());
                int b = -1,c = 10000001;
                string lateName = "";
                string firstName = " ";
                int time = 0;
                string name = "";
                for (int j = 0; j < number; j++)
                {
                        var data = Console.ReadLine();
                        var line = data.Split(' ');
                         name = line[0].ToString();
                         time = Convert.ToInt32(line[1]);
                    if (time > b)
                    {
                        lateName = name;
                        b = time;
                    }
                    if (time < c)
                    {
                        firstName = name;
                        c = time;
                    }
                }          
                mylist.Add(lateName + " " + firstName);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
