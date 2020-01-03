using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            int Totalinput = Int32.Parse(Console.ReadLine());
            int Case = 0;
            List<string> mylist = new List<string>();
            for (int i = 0; i < Totalinput; i++)
            {
                int TotalProductBuy = Int32.Parse(Console.ReadLine());

                var ProductPrice = 0.00;
                double TotalPrice;
                for (int j = 0; j < TotalProductBuy; j++)
                {
                    var line = Console.ReadLine();
                    var data = line.Split(' ');
                    double Price = double.Parse(data[0]);
                    float Quantity = float.Parse(data[1]);
                    ProductPrice += Price * Quantity;
                }
                int Payableamount = Int32.Parse(Console.ReadLine());
                TotalPrice = Convert.ToDouble(Payableamount - ProductPrice);
                TotalPrice = Math.Floor(TotalPrice);
                Case++;
                mylist.Add("Case " + Case + ": " + TotalPrice);
            }
            foreach (var value in mylist)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
