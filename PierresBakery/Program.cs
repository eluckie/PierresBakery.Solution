using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("We sell both pastries & bread and have some amazing sales going on!");
      Console.WriteLine("PASTRIES - $2 per pastry or Buy 3, Get 1 free");
      Console.WriteLine("BREAD - $5 per loaf or Buy 2, Get 1 free");
      Console.WriteLine("------------------------------------------------------------------");
      Console.WriteLine("Please enter how many pastries you'd like:");
      string stringNumber1 = Console.ReadLine();  
      Console.WriteLine("Please enter how many loaves of bread you'd like:");
      string stringNumber2 = Console.ReadLine();  
      int pastryCount = int.Parse(stringNumber1);  
      int breadCount = int.Parse(stringNumber2);  
      Pastry pastryOrder = new Pastry(pastryCount);
      Bread breadOrder = new Bread(breadCount);
      ConfirmOrEditOrder(pastryOrder, breadOrder);
    }
    static void ConfirmOrEditOrder(Pastry pastryOrder, Bread breadOrder)
    {
      Console.WriteLine("Please confirm that you entered your order correctly:");
      Console.WriteLine($"You've chosen {pastryOrder.PastryCount} pastries");
      Console.WriteLine($"and {breadOrder.BreadCount} loaves of bread");
      Console.WriteLine("Is this correct? Enter 'yes' to confirm, or 'no' to re-enter your desired quantities");
      string userInput = Console.ReadLine();  
      if (userInput.ToUpper() == "YES")
      {
        CalculateGrandTotal(pastryOrder, breadOrder);
      }
      else
      {
        Console.WriteLine("Let's update your order! Please enter your desired quantities again.");
        Console.WriteLine("Please enter how many pastries you'd like:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Please enter how many loaves of bread you'd like:");
        string stringNumber2 = Console.ReadLine();  
        int pastryCount = int.Parse(stringNumber1);  
        int breadCount = int.Parse(stringNumber2);  
        Pastry updatedPastryOrder = new Pastry(pastryCount);
        Bread updatedBreadOrder = new Bread(breadCount);
        ConfirmOrEditOrder(updatedPastryOrder, updatedBreadOrder);
        CalculateGrandTotal(updatedPastryOrder, updatedBreadOrder);
      }
    }
    static void CalculateGrandTotal(Pastry pastryOrder, Bread breadOrder)
    {
      int breadQuantity = breadOrder.BreadCount;
      int pastryQuantity = pastryOrder.PastryCount;
      int breadTotal = breadOrder.CalculateTotal();
      int pastryTotal = pastryOrder.CalculateTotal();
      int grandTotal = breadTotal + pastryTotal;
      Console.WriteLine("Calculating your total...");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("CONFIRMED");
      Console.WriteLine(pastryQuantity + " pastries cost $" + pastryTotal);
      Console.WriteLine(breadQuantity + " loaves of bread cost $" + breadTotal);
      Console.WriteLine("Your grand total is $" + grandTotal);
      Console.WriteLine("Would you like to place a new order?");
      Console.WriteLine("Please enter 'yes' to place a new order. To exit, enter any key.");
      string userResponse = Console.ReadLine(); 
      if (userResponse.ToUpper() == "YES")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thank you for your order!");
      }
    }
  }
}
