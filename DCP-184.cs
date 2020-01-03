using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            int[] myarray = new int[45];
            myarray[0] = 0;
            myarray[1] = 1;
            myarray[2] = 3;
            for (int j = 3; j < 45; j++)
            {
                myarray[j] = myarray[j - 1] + myarray[j - 2];
            }
            for (int i=0; i<UserInput; i++)
            {
             
                int Number = Int32.Parse(Console.ReadLine());
                mylist.Add(myarray[Number]);
               
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }

        
    }
}
