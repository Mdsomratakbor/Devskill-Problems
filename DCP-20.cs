using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            int Case = 0;
            List<string> Mylist = new List<string>();
            string Outvalue = "";
            for (int i=0; i<UserInput; i++)
            {
               
                var data = Console.ReadLine();
                var line = data.Split(' ');
                int CX = Int32.Parse(line[0]);
                int CY = Int32.Parse(line[1]);
                float R = float.Parse(line[2]);
                int PX = Int32.Parse(line[3]);
                int PY = Int32.Parse(line[4]);
                int CPXX = CX - PX;
                int CPYY = CY - PY;
                //CX *= CX;
                //CY *= CY;
                
                CPXX *= CPXX;
                CPYY *= CPYY;
                int Total = CPXX + CPYY;
                R *= R;
         
                    if (Total > R)
                    {
                        Outvalue = "Outside";

                    }
                    else if (Total < R)
                    {
                        Outvalue = "Inside";
  
                }
                else if(Total==R)
                {
                    Outvalue = "OnCircle";

                }
                Case++;
                Mylist.Add("Case "+ Case + ": " + Outvalue);
                
            }
            foreach (var value in Mylist)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
