using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            int Case = 0;
            for (int i=0; i<userInput; i++)
            {
                Case++;
                var data = Console.ReadLine();
                var line = data.Split(' ');
                int x1 = Int32.Parse(line[0]);
                int y1 = Int32.Parse(line[1]);
                int x2 = Int32.Parse(line[2]);
                int y2 = Int32.Parse(line[3]);
                int xy = Math.Abs(x1-x2)+Math.Abs(y1-y2);
                mylist.Add("Case "+Case+": "+xy);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
