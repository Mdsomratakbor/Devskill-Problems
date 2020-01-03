using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JU_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<decimal> mylist = new List<decimal>();
            for (int i=0; i<userInput; i++)
            {
                var data = Console.ReadLine();
                var line = data.Split(' ');
                decimal firstNumber = Convert.ToDecimal(line[0]);
                decimal seceondNumber = Convert.ToDecimal(line[1]);
                decimal number = (firstNumber + seceondNumber);
                number = number / 2;
                decimal total = Convert.ToDecimal(Math.Floor(number)); 
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
