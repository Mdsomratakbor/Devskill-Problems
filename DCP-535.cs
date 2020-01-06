using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tweety_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<testCase; i++)
            {
                string asciiValue = Console.ReadLine();
                byte[] asciiBytes = Encoding.ASCII.GetBytes(asciiValue);
                int totalAscii = 0;
                for (int j=0; j< asciiBytes.Length; j++)
                {
                    totalAscii += asciiBytes[j];
                }
                if (totalAscii % 20 == 0)
                    mylist.Add("Yes");
                else
                    mylist.Add("No");

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
