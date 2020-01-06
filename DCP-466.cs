using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanvi_and_TreeMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            for (int i=0; i<testCase; i++)
            {
                var value = Console.ReadLine().Split(' ');
                string firstCity = value[0].ToString();
                string seceondCity = value[1].ToString();
                if (firstCity == "Dhaka")
                {
                    if (seceondCity == "Chittagong")
                        mylist.Add(200);
                    else if (seceondCity == "Rajshahi")
                        mylist.Add(300);
                    else if (seceondCity == "Kathmandu")
                        mylist.Add(3200);
                    else if (seceondCity == "Butwal")
                        mylist.Add(8200);
                    else
                        mylist.Add(0);
                }
                else if (firstCity == "Chittagong")
                {
                    if (seceondCity == "Kathmandu")
                        mylist.Add(3000);
                    else if (seceondCity == "Butwal")
                        mylist.Add(8000);
                    else if (seceondCity == "Dhaka")
                        mylist.Add(200);
                    else if (seceondCity == "Rajshahi")
                        mylist.Add(500);
                    else
                        mylist.Add(0);
                }
                else if (firstCity == "Rajshahi")
                {
                    if (seceondCity == "Dhaka")
                        mylist.Add(300);
                    else if (seceondCity == "Chittagong")
                        mylist.Add(500);
                    else if (seceondCity == "Kathmandu")
                        mylist.Add(3500);
                    else if (seceondCity == "Butwal")
                        mylist.Add(8500);
                    else
                        mylist.Add(0);

                }
                else if (firstCity == "Kathmandu")
                {
                    if (seceondCity == "Chittagong")
                        mylist.Add(3000);
                    else if (seceondCity == "Butwal")
                        mylist.Add(11000);
                    else if (seceondCity == "Dhaka")
                        mylist.Add(3200);
                    else if (seceondCity == "Rajshahi")
                        mylist.Add(3500);
                    else
                        mylist.Add(0);

                }
                else
                {
                    if (seceondCity == "Chittagong")
                        mylist.Add(8000);
                    else if (seceondCity == "Kathmandu")
                        mylist.Add(11000);
                    else if (seceondCity == "Dhaka")
                        mylist.Add(8200);
                    else if (seceondCity == "Rajshahi")
                        mylist.Add(8500);
                    else
                        mylist.Add(0);

                }
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
