using System.Collections.Generic;

namespace OrderTrack.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; }
    public int Id { get; }
    
    private static List<Vendor> _allVendors = new List<Vendor>{};
    
    public Vendor(string name)
    {
      Name = name;
      List<Order> Orders = new List<Order> {};
      _allVendors.Add(this);
      int Id = _allVendors.Count;
    }

    public List<Order> GetOrdersThisVendor()
    {
      return Orders;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public void ClearAllOrders()
    {
      Orders.Clear();
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
    }
  } 
}