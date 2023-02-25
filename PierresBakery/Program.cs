using System;
using PierresBakery.Models;
using PierresBakery.UserInterfaceModels;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.WriteLine("We sell both pastries & bread and have some amazing sales going on!");
      Console.WriteLine("---------------------------------------------------------------------");
      Console.WriteLine("PASTRIES\n$2 per pastry or Buy 3, Get 1 free\n");
      Console.WriteLine("BREAD\n$5 per loaf or Buy 2, Get 1 free");
      Console.WriteLine("---------------------------------------------------------------------");
      Console.WriteLine("Would you like to place an order?");
      Console.WriteLine("Enter 'y' for yes or press any key to exit");
      string placeOrder = Console.ReadLine();
      if(placeOrder.ToUpper() == "Y")
      {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Please enter how many pastries you'd like:");
      string pastryQtyString = Console.ReadLine();  
      Console.WriteLine("Please enter how many loaves of bread you'd like:");
      string breadQtyString = Console.ReadLine();  
      int pastryCount = int.Parse(pastryQtyString);  
      int breadCount = int.Parse(breadQtyString);  
      Pastry pastryOrder = new Pastry(pastryCount);
      Bread breadOrder = new Bread(breadCount);
      ConfirmOrEditOrder(pastryOrder, breadOrder);
      }
      else
      {
        Console.WriteLine(GoodbyeBanner.Goodbye);
        Console.WriteLine("Thanks for stopping by");
        Console.WriteLine("Have the best day!");
      }
    }
    static void ConfirmOrEditOrder(Pastry pastryOrder, Bread breadOrder)
    {
      Console.WriteLine("Please confirm that you entered your order correctly:");
      if(pastryOrder.Quantity == 1)
      {
        Console.WriteLine("You've chosen 1 pastry");
      }
      else
      {
        Console.WriteLine($"You've chosen {pastryOrder.Quantity} pastries");
      }
      if(breadOrder.Quantity == 1)
      {
        Console.WriteLine("and 1 loaf of bread");
      }
      else
      {
        Console.WriteLine($"and {breadOrder.Quantity} loaves of bread");
      }
      Console.WriteLine("Is this correct? Enter 'yes' to confirm, or enter any key to update your quantities");
      string userInput = Console.ReadLine();  
      if (userInput.ToUpper() == "YES")
      {
        CalculateGrandTotal(pastryOrder, breadOrder);
      }
      else
      {
        Console.WriteLine("Let's update your order! Please enter your desired quantities again.");
        Console.WriteLine("Please enter how many pastries you'd like:");
        string pastryQtyString = Console.ReadLine();  
        Console.WriteLine("Please enter how many loaves of bread you'd like:");
        string breadQtyString = Console.ReadLine();  
        int pastryCount = int.Parse(pastryQtyString);  
        int breadCount = int.Parse(breadQtyString);  
        Pastry updatedPastryOrder = new Pastry(pastryCount);
        Bread updatedBreadOrder = new Bread(breadCount);
        ConfirmOrEditOrder(updatedPastryOrder, updatedBreadOrder);
        CalculateGrandTotal(updatedPastryOrder, updatedBreadOrder);
      }
    }
    static void CalculateGrandTotal(Pastry pastryOrder, Bread breadOrder)
    {
      int breadTotal = breadOrder.CalculateTotal();
      int pastryTotal = pastryOrder.CalculateTotal();
      int orderTotal = breadTotal + pastryTotal;
      Console.WriteLine("Calculating your total...");
      Console.WriteLine("CONFIRMED");
      // Console.WriteLine("This order has been added to your cart!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      if(pastryOrder.Quantity == 1)
      {
        Console.WriteLine("1 pastry: $2");
      }
      else
      {
        Console.WriteLine(pastryOrder.Quantity + " pastries: $" + pastryTotal);
      }
      if(breadOrder.Quantity == 1)
      {
        Console.WriteLine("1 loaf of bread: $5");
      }
      else
      {
        Console.WriteLine(breadOrder.Quantity+ " loaves of bread: $" + breadTotal);
      }
      Console.WriteLine("Your order total is $" + orderTotal);
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      // Console.WriteLine("If you would like to view your cart total, enter 'c'");
      Console.WriteLine("If you would like to add another order, enter 'yes'");
      Console.WriteLine("To exit, enter any other key.");
      string userResponse = Console.ReadLine();
      // if (userResponse.ToUpper() == "C")
      // {
        
      // }
      // else
      if (userResponse.ToUpper() == "YES")
      {
        Main();
      }
      else
      {
        Console.WriteLine(GoodbyeBanner.Goodbye);
        Console.WriteLine("Thanks for your order");
        Console.WriteLine("Have the best day!");
      }
    }
  }
}
