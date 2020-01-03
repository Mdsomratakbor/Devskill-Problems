using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<int> myconinList = new List<int>();
            for (int i=0; i<userInput; i++)
            {
                int numberCoin = Int32.Parse(Console.ReadLine());
                double number = Math.Ceiling(((Math.Sqrt(1.0 + (8 * numberCoin)))-1.0)/2.0);
                int total = Convert.ToInt32(number);
                myconinList.Add(total);
            }
            foreach (var value in myconinList)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
