using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jersey_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=1; i<=testInput; i++)
            {
                int playerNumber = int.Parse(Console.ReadLine());
                string answer = "";
                int mx = -1;
                for (int j=1; j<=playerNumber; j++)
                {
                    var data = Console.ReadLine().Split(' ');
                    string playerName = data[0];
                    int playerExperience = int.Parse(data[1]);

                    if (playerExperience >= mx)
                    {
                        mx = playerExperience;
                        answer = playerName;
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
