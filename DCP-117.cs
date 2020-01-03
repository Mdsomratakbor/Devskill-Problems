using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Easy_But_Not_Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            
            List<long> mylist = new List<long>();
            for (int i=0; i<UserInput; i++)
            {

                long Number = long.Parse(Console.ReadLine());
                long sum = (Number * (Number + 1)) / 2;


                mylist.Add(sum);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
