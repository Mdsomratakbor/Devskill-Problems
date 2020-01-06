using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_N
{
    class Program
    {
        static void Main(string[] args)
        {       
            while (true)
            {
                StringBuilder AddNumber1 = new StringBuilder();
                StringBuilder AddNumber2 = new StringBuilder();
                var data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                {
                    break;
                }
               for (int i = 1; i < data.Length; i++)
                 {
                    Console.Write(9); 
                 }
                Console.Write(8);
                for (int i = 1; i < data.Length; i++)
                {
                    Console.Write(0);
                }
                Console.WriteLine(1);
            }
            Console.Read();


        }
    }
}
