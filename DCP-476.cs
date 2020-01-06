using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_Verdict
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            int i = 0;
            List<string> mylist = new List<string>();
            while(i<userInput)
            {
                string input = Console.ReadLine();
                if (input.Contains("ac"))
                    mylist.Add("Accepted");
                else if (input.Contains("wa"))
                    mylist.Add("Wrong Answer");
                else if (input.Contains("rte"))
                    mylist.Add("Run Time Error");
                else
                    mylist.Add("Time Limit Exceeded");

                i++;
            }
            foreach (var vlaue in mylist)
                Console.WriteLine(vlaue);
            Console.Read();
                
        }
    }
}
