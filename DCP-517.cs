using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_2030
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<testCase; i++)
            {
                int testCountry = int.Parse(Console.ReadLine());
                string answer = "";
                int maximum = -1;
                for (int j=0; j<testCountry; j++)
                {
                    var data = Console.ReadLine().Split(' ');
                    string country = data[0].ToString();
                    int totalGoal = int.Parse(data[1]);                   
                    
                    if (totalGoal>maximum)
                    {
                        maximum = totalGoal;
                        answer = country;
                    }
                }
                mylist.Add(@"Winner: \"+answer+"/");

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();

        }
    }
}
