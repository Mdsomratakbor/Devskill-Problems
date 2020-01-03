using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            var product = new int[10005];
            int Case = 0;
            for (int i=0; i<testInput; i++)
            {
                Case++;
                long creditPrice = long.Parse(Console.ReadLine());
                int totalItem = Int32.Parse(Console.ReadLine());
                var data = Console.ReadLine().Split(' ');               
                for (int j=0; j<totalItem; j++)
                {                    
                     product[j] = Int32.Parse(data[j]);                                                
                }
               
                int a = 0;

                int temp = 0;
                for (int k =0; k < totalItem-2; k++)
                {
                    
                    for (int L = k + 1; L < totalItem + 1; L++)
                    {
                        temp = product[k] + product[L];
                        for (int M = L + 1; M<totalItem; M++)
                        {
                            temp += product[M];
                            if (temp == creditPrice)
                            {
                                a = 1;
                                k = k + 1;
                                L = L + 1;
                                M = M + 1;
                                mylist.Add("Case "+ Case +": "+ k +" "+ L +" "+ M );
                                break;
                            }
                            temp -= product[M];
                        }
                        if (a == 1) break;                      
                    }
                    if (a == 1) break;
                }
                if (a != 1) mylist.Add("Case "+ Case + ": You are out of your luck!");
              
                              
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }

            Console.Read();
        }
    }
}
