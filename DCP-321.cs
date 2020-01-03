using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Case_of_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<StringBuilder> mylist = new List<StringBuilder>();
            
            for (int i=0; i<userInput; i++ )
            {
                StringBuilder sb = new StringBuilder();
                string stringDataInput = Console.ReadLine();
               
                foreach (char value in stringDataInput)
                {
                    if (char.IsUpper(value))
                    {
                        sb.Append(char.ToLower(value));


                    }
                    else
                    {
                        sb.Append(char.ToUpper(value));


                    }
                }
                    
                    mylist.Add(sb);
                

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
