using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squar_and_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<userInput; i++)
            {
                int number = Int32.Parse(Console.ReadLine());
                int sq = 0, cu = 0;
                for (int j=1; j*j<number; j++)
                {
                    if (j * j == number)
                        sq = j;
                    if (j * j * j == number)
                        cu = j;
                    if (sq > 0 && cu > 0)
                        break;
                }
                if (sq > 0 && cu > 0)
                    mylist.Add("Both");
                else if (sq > 0)
                    mylist.Add("Perfect Square");
                else if (cu > 0)
                    mylist.Add("Perfect Cube");
                else
                    mylist.Add("None");

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
