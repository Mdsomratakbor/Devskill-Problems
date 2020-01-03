using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_the_Recursion
{
    class Program
    {
        public static int recur(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                if (b > c)
                {
                    return recur(a - (a - b), b, c);
                }
                else
                {
                    return recur(a - (a - c), b, c);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    return recur(a, b - (b - a), c);
                }
                else
                {
                    return recur(a, b - (b - c), c);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    return recur(a, b, c - (c - a));
                }
                else
                {
                    return recur(a, b, c - (c - b));
                }
            }
            return a + b + c;
        }
        
        static void Main(string[] args)
        {
            int a=0, b=0, c=0;
            List<int> mylist = new List<int>();
            
            while (true) 
            {
                var data = Console.ReadLine();
                if (string.IsNullOrEmpty(data)) { break; }      
                    var line = data.Split(' ');
                data = null;
               
                    a = int.Parse(line[0]);
                    b = int.Parse(line[1]);
                    c = int.Parse(line[2]);
                    line = null;
                
                
                mylist.Add(recur(a, b, c));                               
            }

            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }

            Console.Read();
        }
    }
}
