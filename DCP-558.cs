using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_kth_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            while (userInput>0)
            {
                Int64 kthGroup = Int64.Parse(Console.ReadLine());
                kthGroup *= 2;
                int oddNumber = 0, evenNumber = 0;
                for(int i=0; i<kthGroup; i++)
                {
                    if (i % 2 != 0)
                        oddNumber += i;
                    else
                        evenNumber += i;
                }
                int defference = oddNumber - evenNumber;
                mylist.Add(defference);
                userInput--;
            }
            foreach (var data in mylist)
            {
                Console.WriteLine(data);
            }
            Console.Read(); 
        }
    }
}
