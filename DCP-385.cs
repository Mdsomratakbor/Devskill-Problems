using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long userInput = long.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (long i=0; i<userInput; i++)
            {
                decimal numberInput = decimal.Parse(Console.ReadLine());

                while (numberInput>4 && numberInput%5==0)
                {
                    numberInput /= 5;
                }                
                if (numberInput == 1)
                    mylist.Add("YES");                            
                else
                    mylist.Add("NO");
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
