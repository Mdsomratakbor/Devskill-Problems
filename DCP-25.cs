using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palingdrom
{
    class Program
    {
        static void Main(string[] args)
        {


            int range = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for(int k = 0; k < range; k++)
            {
                
                string word = Console.ReadLine();

                string reverseword = "";
                char[] firstword = word.ToLower().ToCharArray();
                for (int i = word.Length - 1; i >= 0; --i)
                {
                    reverseword += word[i];

                }
                char[] seceondword = reverseword.ToLower().ToCharArray();

                
                
                    if (firstword[0] == seceondword[0])
                    {
                        list.Add("Yes");
                        //Console.WriteLine("Yes");

                    }
                    else if (firstword[0]== seceondword[0] && firstword[1] == seceondword[1])
                {
                    list.Add("Yes");
                }
                    else
                    {
                        list.Add("No");
                        //Console.WriteLine("No");
                    }
                }
            

            foreach( var value in list)
            {
                Console.WriteLine(value);
            }
           
            Console.Read();


        }
    }
}
