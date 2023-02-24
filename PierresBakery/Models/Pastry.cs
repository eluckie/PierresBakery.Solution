using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCount { get; }
    public Pastry(int quantity)
    {
      PastryCount = quantity;
    }
    public int CalculateTotal()
    {
      if(PastryCount % 4 == 0)
      {
        return ((PastryCount / 4) * 6);
      }
      else
      {
        int remainder = PastryCount % 4;
        int adjustedCount = PastryCount - remainder;
        return (remainder * 2) + ((adjustedCount / 4) * 6);
      }
    }
  }
}