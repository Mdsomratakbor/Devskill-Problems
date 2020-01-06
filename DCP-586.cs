using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackoverflow_Medals
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i=0; i<testCase; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int broBronzeMedalCount = int.Parse(data[0]);
                int silverMedalCount = int.Parse(data[1]);
                int goldMedalCount = int.Parse(data[2]);
                int total = (broBronzeMedalCount * 10) + (silverMedalCount * 50) + (goldMedalCount * 100);
                mylist.Add(total);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
