using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_of_a_Box
{
    class Program
    {    
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            List<decimal> mylist = new List<decimal>();
            for (int i=0; i<UserInput; i++)
            {
                var data = Console.ReadLine();
                var line = data.Split(' ');
                float x = float.Parse(line[0]);
                float y = float.Parse(line[1]);
                float z = float.Parse(line[2]);
                double Total = (double)(x * x + y * y + z *z);
                decimal Total1 = (decimal)Math.Sqrt(Total);
                Total1 = decimal.Round(Total1, 2);
                mylist.Add(Total1);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
