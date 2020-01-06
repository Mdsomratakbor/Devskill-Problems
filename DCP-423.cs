using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Magical_Number
{
    class Program
    {
        //public static int PrimeNumber(int number)
        //{
        //    int sum = 0;
        //    for (int i = 2; i <= number; i++)
        //    {
        //        bool isPrime = true;

        //        for (int j = 2; j < i; j++)
        //        {
        //            if (i % j == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //        }
        //        if (isPrime)
        //        {
        //            sum++;
        //        }

        //    }
        //    return sum;
        //}
            static void Main(string[] args)
            {
            int mx = 100005;
            var arr = new int[mx];
            var cum = new int[mx];
            for (int i = 1; i < mx; i++)
            {
                int num = i;
                bool p = false;
                while (num > 0)
                {
                    int t = num % 10;
                    num /= 10;
                    if (t == 2 || t == 3 || t == 5 || t == 7)
                    {
                        p = true;
                        break;
                    }
                }
                if (p)
                    arr[i] = 1;
            }
            for (int i = 1; i < mx; i++)
            {
                cum[i] = cum[i - 1] + arr[i];
            }
            int testCase = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for(int i=0; i<testCase; i++)
            {
                int numberOfPrime = int.Parse(Console.ReadLine());
              mylist.Add(cum[numberOfPrime]);
                
            }
            foreach (var value in mylist)
                Console.WriteLine(value);
                Console.Read();

            }
        }
    }

