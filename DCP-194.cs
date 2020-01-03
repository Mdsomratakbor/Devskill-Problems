using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Number_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            string Outputvalue = "";
            List<string> mylist = new List<string>();
            for (int i = 0; i<UserInput; i++)
            {
                string inputMobileNumber =Console.ReadLine();
                char[] mobilearray = new char[] { '8', '8', '0', '1', '8', '7', '9', '1', '5', '6' };
                char [] mynumber = inputMobileNumber.ToCharArray();
                if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1]) {
                    if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1] && mynumber[2] == mobilearray[2] && mynumber[3] == mobilearray[3] && mynumber[4] == mobilearray[4])
                    {
                        Outputvalue = "Robi";
                    }
                    else if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1] && mynumber[2] == mobilearray[2] && mynumber[3] == mobilearray[3] && mynumber[4] == mobilearray[5])
                    {
                        Outputvalue = "Grameenphone";
                    }
                    else if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1] && mynumber[2] == mobilearray[2] && mynumber[3] == mobilearray[3] && mynumber[4] == mobilearray[6])
                    {
                        Outputvalue = "Banglalink";
                    }
                    else if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1] && mynumber[2] == mobilearray[2] && mynumber[3] == mobilearray[3] && mynumber[4] == mobilearray[7])
                    {
                        Outputvalue = "Citycell";
                    }
                    else if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1] && mynumber[2] == mobilearray[2] && mynumber[3] == mobilearray[3] && mynumber[4] == mobilearray[8])
                    {
                        Outputvalue = "Teletalk";
                    }
                    else
                    {
                        Outputvalue = "Airtel";
                    }
                    if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1])
                    {
                        mylist.Add(inputMobileNumber + " " + Outputvalue);
                    }
                    else
                    {
                        mylist.Add("88" + inputMobileNumber + " " + Outputvalue);
                    }
                }
                else
                {
                    if (mynumber[2] == mobilearray[4])
                    {
                        Outputvalue = "Robi";
                    }
                    else if ( mynumber[2] == mobilearray[5])
                    {
                        Outputvalue = "Grameenphone";
                    }
                    else if ( mynumber[2] == mobilearray[6])
                    {
                        Outputvalue = "Banglalink";
                    }
                    else if ( mynumber[2] == mobilearray[7])
                    {
                        Outputvalue = "Citycell";
                    }
                    else if ( mynumber[2] == mobilearray[8])
                    {
                        Outputvalue = "Teletalk";
                    }
                    else
                    {
                        Outputvalue = "Airtel";
                    }

                    // Add list output
                    if (mynumber[0] == mobilearray[0] && mynumber[1] == mobilearray[1])
                    {
                        mylist.Add(inputMobileNumber + " " + Outputvalue);
                    }
                    else
                    {
                        mylist.Add("88" + inputMobileNumber + " " + Outputvalue);
                    }
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
