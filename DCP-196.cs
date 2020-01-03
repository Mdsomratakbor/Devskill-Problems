using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            List<decimal> list = new List<decimal>();
            for (int i=0; i<number; i++)
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');//data input two value in space
                decimal V = decimal.Parse(data[0]); //first integer
                decimal T = decimal.Parse(data[1]);//seceond integer
                decimal S =-(V / T);//nagative output print
                S = Math.Round(S, 2);//two decimal number output
                list.Add(S);
                
            }
            foreach (var result in list)
            {
                Console.WriteLine(result);
            }

            Console.Read();

        }
    }
}
