using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_and_Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                var data = line.Split(' ');
                Int64 firstNumber = Int64.Parse(data[0]);
                Int64 seceondNumber = Int64.Parse(data[1]);
                if (firstNumber > seceondNumber)
                {
                    Int64 temp;
                    temp = firstNumber;
                    firstNumber = seceondNumber;
                    seceondNumber = temp;
                }
                    
                if (firstNumber == 1)
                    if (firstNumber == seceondNumber)
                        mylist.Add("Even");
                    else
                        mylist.Add("Odd");          
                else
                    mylist.Add("Even");
                    
            }
            foreach (var value in mylist)
                Console.WriteLine(value);
            Console.Read();
        }
    }
}
