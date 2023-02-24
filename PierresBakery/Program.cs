using System;
using PierresBakery.Models;
using System.Collections.Generic;

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
    Console.WriteLine("Calculating your total...");
    int pastryCount = int.Parse(stringNumber1);  
    int breadCount = int.Parse(stringNumber2);  
    Pastry pastryOrder = new Pastry(pastryCount);
    Bread breadOrder = new Bread(breadCount);
    int breadTotal = breadOrder.CalculateTotal();
    int pastryTotal = pastryOrder.CalculateTotal();
    int grandTotal = breadTotal + pastryTotal;
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine(stringNumber1 + " pastries cost $" + pastryTotal);
    Console.WriteLine(stringNumber2 + " loaves of bread cost $" + breadTotal);
    Console.WriteLine("Your grand total is $" + grandTotal);
    Console.WriteLine("Thank you for your business!");
  }
}
