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
      if(BreadCount % 3 == 0)
      {
        return ((BreadCount / 3) * 10);
      }
      else
      {
        int remainder = BreadCount % 3;
        int adjustedCount = BreadCount - remainder;
        return (remainder * 5) + ((adjustedCount / 3) * 10);
      }
    }
  }
}