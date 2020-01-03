using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_and_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            string Output = " ";
            for (int i=0; i<UserInput; i++)
            {
                var data = Console.ReadLine();
                var line = data.Split(' ');
                double Radius = double.Parse(line[0]);
                double Side = double.Parse(line[1]);
                Radius = Radius * 1.414213562373095;
                double Radius2 = Math.Round(Radius, 2);
                if (Radius2 == Side)
                {
                    Output = "Yes";
                }
                else
                {
                    Output = "No";
                }
                mylist.Add(Output);
            }
            
            foreach(var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
