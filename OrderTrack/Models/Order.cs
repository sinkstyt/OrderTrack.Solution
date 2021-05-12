using System.Collections.Generic;
using System;

namespace OrderTrack.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int BaguettePrice = 4;
    public int CroissantPrice = 2;
    public int Id { get; }
    public int OrderPrice { get; }

    private static List<Order> _allOrders = new List<Order> {};
  
    public Order(string title, string description, DateTime date)
    {
      string Title = title;
      string Description = description;
      DateTime Date = date;
    }
  }
}
// string title, string description, DateTime date