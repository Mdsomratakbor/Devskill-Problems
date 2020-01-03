using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boshir_Mishtanno
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=1; i<=testCase; i++)
            {
                var data = Console.ReadLine().Split(' ');
                int R = int.Parse(data[0]);
                int C = int.Parse(data[1]);
                long ans = 0;
                while (R*C>0)
                {
                    ans = ans + (R * C);
                    R--;
                    C--;
                }
                ans *= 15;
                mylist.Add("Case " + i + ": " + ans);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
