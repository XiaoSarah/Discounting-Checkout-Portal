// User to select items to add to bag before checkout
using System;

class Program
{
    static void Main(string[] args)
    {
        // Items in store to assign prices to    
        string[] items = new string[5];
        items[0] = "Smart watch";
        items[1] = "Smart TV";
        items[2] = "Smart phone";
        items[3] = "Laptop";
        items[4] = "Tablet";

        // System applies discount to items in bag based on total price
        double total = input;
        total = total >= 2000 ? total * 0.70 : total;
        total = total >= 1000 ? total * 0.85 : total;
        total = total >= 500 ? total * 0.9 : total;

        // System calculates tax and total price
        double tax = total * 0.13;
        Console.WriteLine(total.ToString("C"));
        Console.WriteLine("HST:" + tax.ToString("C"));

        // Displaying total price after tax and amount saved to user before checkout
        double total_after_tax = total + tax;
        Console.WriteLine("Your total is: " + total_after_tax.ToString("C"));

        // Placeholder for more logics and rules before the payment gateway: only show amount saved if discount applies, incentives to spend more for the next discount percentage (e.g. "$400 away from 30% off your total"), etc.

        Console.WriteLine("Congrats on saving " + (total - total_after_tax).ToString("C") + "!");
        Console.WriteLine("Please proceed to checkout.");
    }
}
