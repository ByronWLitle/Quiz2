using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for price of item
            Console.Write("Enter item price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            //Prompt user for sales tax in decimal form
            Console.Write("Enter sales tax (Ex. 0.05 for 5 %): ");
            decimal tax = Convert.ToDecimal(Console.ReadLine());
            //Prompts user for discount price in decimal form
            Console.Write("Enter promotion discount (Ex. 0.05 for 5 %): ");
            decimal discount = Convert.ToDecimal(Console.ReadLine());
            //Calculate for total price
            int discPrice = Convert.ToInt32((price * discount));

            int total = Convert.ToInt32((price- discPrice) * tax);
            //Display total for user
            Console.WriteLine($"Your total is ${total}.");
            Console.ReadLine();
        }
    }
}
