using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galib_and_Hasan_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = Int32.Parse(Console.ReadLine());
            int i = 1;
            
            List<string> mylist = new List<string>();
            while (i <= testInput)
            {
                
                var data = Console.ReadLine().Split(' ');
                long AO = long.Parse(data[0]);
                long BC = long.Parse(data[1]);
                long AB = AO*2;
                long AC = (AB*AB) - (BC*BC);
                mylist.Add("Case "+i+": "+AC);
                
                
                i++;
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
