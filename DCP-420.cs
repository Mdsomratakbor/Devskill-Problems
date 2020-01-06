using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Cost
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
           
            for (int i=0; i<testCase; i++)
            {
                int numberElement = int.Parse(Console.ReadLine());
                var myArray = new int[numberElement];
                var data = Console.ReadLine().Split(' ');
                for (int j=0; j<numberElement; j++)
                {
                    myArray[j] = int.Parse(data[j]);
                }

                int minimum = 0;              
                Array.Sort(myArray);
                minimum = myArray[0];
                

                int sum = 0;
                for (int k = 1; k<myArray.Length; k++)
                {

                    sum +=  myArray[k] - minimum;                          
                          
                }
                mylist.Add(sum);
            }
            foreach (var value in mylist)
                Console.WriteLine(value);
            Console.Read(); 
        }
    }
}
