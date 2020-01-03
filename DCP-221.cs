using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_and_Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInpt = Int32.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            int Case = 0;
                for (int i=0; i<UserInpt; i++)
            {
                var data = Console.ReadLine();
                List<string> mylist= data.Split(' ').ToList();

                int s = mylist.Count;
                int max = 0, min = 100000;
                for (int j = 0; j < s; j++)
                {
                    int tt = Convert.ToInt32(mylist[j]);
                    if (max < tt)
                        max = tt;
                    if (min > tt)
                        min = tt;
                }
                
                
                Case++;
                
                list.Add("Case "+Case+ ": Among "+ s+" numbers "+max+" is maximum and "+min+" is minimum");

            }
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
