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
      if(PastryCount == 4)
      {
        return 6;
      }
      else
      {
        return PastryCount * 2;
      }
    }
  }
}