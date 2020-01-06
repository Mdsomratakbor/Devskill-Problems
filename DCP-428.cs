using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Contiguous_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i=0; i<testCase; i++)
            {
                int arrayElement = int.Parse(Console.ReadLine());
                int[] array = new int[arrayElement];
                var element = Console.ReadLine().Split(' ');
                for (int j =0; j<arrayElement; j++)
                {
                    array[j] = int.Parse(element[j]);
                }

                int index = 0;
         
                int answer = 0;
                while(index<arrayElement)
                {
                    answer++;
                    int value = array[index];
                    while (index<arrayElement && value == array[index]){
                        index++;
                    }
                }
                mylist.Add(answer);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
