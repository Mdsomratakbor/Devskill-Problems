using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miraclaw_and_funny_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<long> mylist = new List<long>();
            for (int i=0; i<userInput; i++)
            {
                long a = 0, b = 0;
                int numberInput = Int32.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');
                var Numbers = new long[100005];
                for (int l = data.Length; l >= 0; l--)
                {
                    Numbers[l] = Int64.Parse(data[l]);
                }
                for (int j=0; j<numberInput; j++)
                {                 
                    for (long k=0; k< Numbers.Length; k++)
                    {
                        a += Numbers[k];
                        long t =Numbers[k];
                        t -= j;
                        if (t >= 0)
                        {
                            b += t;
                        }
                        j++;
                    }                  
                }
                mylist.Add(a-b);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();     
        }
    }
}
