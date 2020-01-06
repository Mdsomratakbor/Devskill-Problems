using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_New_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            char[] year = new char[110];
            for (int i=0; i<userInput; i++)           
            {
               
                int y = 2018;
                 year = Console.ReadLine().ToArray();
                for(int j=year.Length - 1; ; j-- )
                {
                    if (year[j] == 'r')
                    {
                        break;
                    }
                    else if(year[j]=='+')
                    {
                        y++;
                       
                    }
                    
                }
                mylist.Add("Happy New Year-" + y);


            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
