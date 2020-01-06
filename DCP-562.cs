using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argentina_and_Brazil
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<userInput; i++)
            {
                var data = Console.ReadLine();
                var line = data.Split(' ');
                int argentianGoal = Int32.Parse(line[0]);
                int brazilGoal = Int32.Parse(line[1]);
                string argentina = "Argentina";
                string brazil = "Brazil";
                if (argentianGoal>brazilGoal)
                {
                    mylist.Add(argentina+" "+argentianGoal+" - " + brazilGoal+" "+brazil);
                }
                else
                {
                    mylist.Add(brazil + " " + brazilGoal+" - "+argentianGoal+" "+argentina);
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
