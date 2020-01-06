using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMORA_Confusion
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0;i<testCase; i++)
            {
                string inputCase = Console.ReadLine();
                if (inputCase[0] == 'Q')
                    mylist.Add("I am going to ask you this one time, where is Gamora?");
                else if (inputCase[0] == 'S')
                    mylist.Add("I will do you one better, who is Gamora?");
                else if (inputCase[0] == 'D')
                    mylist.Add("I will do you one better, why is Gamora?");
                else
                    mylist.Add("What is Gamora?");
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
