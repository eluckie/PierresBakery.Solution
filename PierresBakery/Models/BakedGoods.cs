using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public abstract class BakedGoods
  {
    public int Quantity { get; set; }

    public abstract int CalculateTotal();

    // public static Dictionary<string, int> fullOrder = new Dictionary<string, int> {};

    // public static Dictionary<string, int> ShowCart()
    // {
    //   foreach (KeyValuePair<string, int> good in fullOrder)
    //   {
    //     Console.WriteLine($"{good.Key}: ${good.Value}");
    //   }
    // }
  }
}