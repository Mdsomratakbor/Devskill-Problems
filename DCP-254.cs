using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            int Case = 0;
            double max =0;
            int min = 0;
            for (int i=0; i<userInput; i++)
            {
                Case++;
                var data = Console.ReadLine().Split(' ');
                int B = Int32.Parse(data[0]);
                int S = Int32.Parse(data[1]);
                int G = Int32.Parse(data[2]);
                int R = Int32.Parse(data[3]);
                int Sum = (B * 1) + (S * 3) + (G * 10) - (R * 5);
            
                max = Math.Max(max, Sum);
                if ((Sum < 0) && (min == 0 || Sum > min))
                    min = Sum;



                if (Sum<0)
                {
                    mylist.Add("Player "+Case+": "+0);
                }
                else
                {
                    mylist.Add("Player " + Case + ": " + Sum);
                }


            }
            if (max>0) {
                mylist.Add("High Score = " + max);
            }
            else
            {
                mylist.Add("High Score = " + min);
            }

            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();

        }
    }
}
