using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.Typical
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            List<string> mylist = new List<string>();

                str = Console.ReadLine();
                if (str == "never" || str == "be" || str == "so" || str == "happy" || str == "when" || str == "you" || str == "are" ||
                 str == "and" || str == "sad")
                    mylist.Add("YES");
                else
                    mylist.Add("NO");

               

            
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
