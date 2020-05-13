using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_for_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<string> mylist = new List<string>();
            for (int i=0; i<testCase; i++)
            {
                int j = 0, firstStory = 0, secondStory = 0, m = 0;
                string userInput = Console.ReadLine();
                string programming = "programming";
                string coding = "coding";
                char[] userArray = userInput.ToArray();
                char[] programmingArray = programming.ToArray();
                char[] codingArray = coding.ToArray();
                Array.Sort(programmingArray);
                Array.Sort(programmingArray);
                Array.Sort(codingArray);              
                for (int k =0; k < userArray.Length; k++)
                {
                    if(userArray[k] == programmingArray[j])
                    {
                        j++;
                        firstStory++;
                        if(firstStory == programming.Length)
                        {
                            break;
                        }
                    }
                }
                
                for (int l = 0; l < userArray.Length; l++)
                {
                    if (userArray[l] == coding[m])
                    {
                        m++;
                        secondStory++;
                        if (secondStory == coding.Length)
                        {
                            break;
                        }
                    }
                }
                if (firstStory == programming.Length || secondStory == coding.Length)
                    mylist.Add("Yes");
                else
                    mylist.Add("No");

            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
        
    }
}
