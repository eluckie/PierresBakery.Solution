using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCount { get; }
    public Bread(int quantity)
    {
      BreadCount = quantity;
    }
    public int CalculateTotal()
    {
      return BreadCount * 5;
    }
  }
}