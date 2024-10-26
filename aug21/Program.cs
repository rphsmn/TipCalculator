using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace aug21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double totalamount, tip, splitCount, total;
            Console.WriteLine("Welcome to the tip calculator!");

            Console.WriteLine($"What was the total bill? ");
            totalamount = double.Parse(Console.ReadLine());

            Console.WriteLine("How much would you like to give? 10, 12, or 15");
            tip = double.Parse(Console.ReadLine());


            Console.WriteLine("How many people to split the bill?");
            splitCount = double.Parse(Console.ReadLine());

            //total = ((((tip/100)) + totalamount) + totalamount) / splitCount);

            double tipPercentage = tip / 100;
            double tipPercentageTotal = totalamount + tipPercentage;
            double totalBillWithTip = totalamount + tipPercentageTotal;
            total = totalBillWithTip / splitCount;

            Console.WriteLine($"Each person should pay: {total}");

        }
    }
}
