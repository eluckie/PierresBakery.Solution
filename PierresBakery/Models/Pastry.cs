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
  }
}