using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangla_Wash
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<UserInput; i++)
            {
                // First line input 
                var data1 = Console.ReadLine();
                var line = data1.Split(' ');
                int FirstMFirstI = Int32.Parse(line[0]);
                int FirstMSeceondI = Int32.Parse(line[1]);
                int FirstMThridI = Int32.Parse(line[2]);
                int FirstMFourthI = Int32.Parse(line[3]);
                // Seceond line input
                var data2 = Console.ReadLine();
                var line2 = data2.Split(' ');
                int SeceondMFirstI = Int32.Parse(line2[0]);
                int SeceondMSeceondI = Int32.Parse(line2[1]);
                int SeceondMThirdI = Int32.Parse(line2[2]);
                int SeceondMFourthI = Int32.Parse(line2[3]);
                // Bangladesh Two Matche Total Run
                int TotalBangladehsRun1 = FirstMFirstI + FirstMSeceondI;
                int TotalBangladeshRun2 = SeceondMFirstI + SeceondMSeceondI;

                // Pakistan Two Mtche Total Run
                int TotalPakistanRun1 = FirstMThridI + FirstMFourthI;
                int TotalPakistanRun2 = SeceondMThirdI + SeceondMFourthI;
                String UserOutput = " ";
                if (TotalBangladehsRun1 > TotalPakistanRun1 && TotalBangladeshRun2> TotalPakistanRun2)
                {
                    UserOutput = "Banglawash";
                }
                else
                {
                    UserOutput = "Miss";
                }
                mylist.Add(UserOutput);

            }
            foreach(var value in mylist)
            {
                Console.WriteLine(value);
            }
            
            Console.ReadLine();
        }
    }
}
