using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<char> mylist = new List<char>();
            for (int i=1; i<=testCase; i++)
            {
                string palingdropString = Console.ReadLine();
                int value = -1;
                for (int j=0; j<palingdropString.Length; j++)
                {
                    if (value < palingdropString[j])
                        value = palingdropString[j];
                }
                char c = Convert.ToChar(value);
                mylist.Add(c);

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
