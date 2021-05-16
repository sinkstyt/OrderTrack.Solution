using System.Collections.Generic;

namespace OrderTrack.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _allVendors = new List<Vendor>{};
    public int VendorId { get; }
    
    
    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order> {};
      _allVendors.Add(this);
      VendorId = _allVendors.Count;
    }

    public static List<Vendor> GetAllVendors()
    {
      return _allVendors;
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

    public static void ClearAllVendors()
    {
      _allVendors.Clear();
    }

    public static Vendor Find(int findId)
    {
      return _allVendors[ findId - 1];
    }
  } 
}