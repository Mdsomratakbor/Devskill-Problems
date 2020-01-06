using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exactly_Two_Times
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
                var array = new int[arrayElement];
                var data = Console.ReadLine().Split(' ');
                for (int j=0; j<arrayElement; j++)
                {
                    array[j] = int.Parse(data[j]);
                }
                int answer = 0;
                for (int k=0; k<array.Length; k++) {
                    for (int l=k+1; l<array.Length; l++)
                    {
                        if (array[k] == array[l])
                            answer = array[k];
                    }                    
                }
                mylist.Add(answer);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
