using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            string Output = " ";
            for (int i=0; i<UserInput; i++)
            {
                int InputNUmber = Int32.Parse(Console.ReadLine());
                int flag = 0;
                int DivideNumber = InputNUmber / 2;
                if (InputNUmber == 1 || InputNUmber == 0)
                {
                    Output = "No";
                }
                else {
                    for (int k = 2; k <= DivideNumber; k++)
                    {
                        flag = 0;
                        if (InputNUmber % k == 0)
                        {
                            Output = "No";
                            flag = 1;
                            break;
                        }

                    }
                    if (flag == 0)
                    {
                        Output = "Yes";
                    }
                    
                }
                mylist.Add(Output);
            }
            
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
