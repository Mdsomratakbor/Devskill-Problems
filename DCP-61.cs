using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid_Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = Int32.Parse(Console.ReadLine());
            List<long> mylist = new List<long>();
            for (int i=0; i<testInput; i++)
            {
                var data = Console.ReadLine().Split(' ');
                long height = long.Parse(data[0]);
                long width = long.Parse(data[1]);
                long total = 1;
                height += width;
                if (width > height / 2)
                    width = height-width;
                int j = 0;
                while (j<width)
                {
                    total *= (height - j);
                    total /= j + 1;
                    j++;
                }
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
