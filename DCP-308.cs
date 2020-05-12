using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP-308
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
                string dialog = (line[0] + " " + line[1] + " " + line[2]);
                int year = Convert.ToInt32(line[3]);
                if (dialog.Contains("Shuvo nobo borsho"))
                {
                    year += 650;
                    mylist.Add("Shuva naya barsha " + year);
                }
                else
                {
                    year -= 650;
                    mylist.Add("Shuvo nobo borsho " + year);
                }
            }
            foreach(var data in mylist)
            {
                Console.WriteLine(data);
            }         
            Console.Read();
        }
    }
}
