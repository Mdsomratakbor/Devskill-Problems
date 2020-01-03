using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomrrow_Is_Eid
{
    class Program
    {
        static void Main(string[] args)
        {
            int EidDay1 = 30;
            int EidDay2 = 29;
            int UserInput = Int32.Parse(Console.ReadLine());
            if (EidDay1 == UserInput || EidDay2 == UserInput)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
