using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Is_Done
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            while (true)
            {
                var data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                {
                    break;
                }
                var line = data.Split(' ');
                double totalHours = double.Parse(line[0]);
                double totalworker = double.Parse(line[1]);
                double workerHour= 0;
                for (int i=0; i<totalworker; i++)
                {
                    double workerHour1 = double.Parse(Console.ReadLine());
                    workerHour += workerHour1;
                }
                double Day = Math.Ceiling(totalHours / workerHour);
                if (Day == 1)               
                    mylist.Add("Project will finish within " + Day + " day.");
                else
                    mylist.Add("Project will finish within " + Day + " days.");
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
        
    }
}
