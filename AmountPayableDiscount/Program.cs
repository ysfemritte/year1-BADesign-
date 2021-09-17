using System;

namespace AmountPayableDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 3.15: Write an app that asks the buyer to enter 
            //the price of three items, calculates an applicable 10% discount 
            //on the items and displays the net amount payable.
            
            //Declaring Variables
            double item1, item2, item3, totalprice, discount, amountpayable;

            //Input Prices
            Console.WriteLine("Please input the price of item 1: ");
            item1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input the price of item 2: ");
            item2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input the price of item 3: ");
            item3 = double.Parse(Console.ReadLine());

            //Calculate Total Price 
            totalprice = item1 + item2 + item3;
            Console.WriteLine($"Total Price is {totalprice}");

            discount = 0.1 * totalprice;
            Console.WriteLine($"Discount is {discount}");

            amountpayable = totalprice - discount;
            Console.WriteLine($"Amount Payable is {amountpayable}");
        }
    }
}
