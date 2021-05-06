# Retail Order Tracker MVC App
* keep orders organized by vendor with this web app

### Author: *Tyler Sinks*
* _begun 6 May, 2021_

## Specs
| Test | Input | Output |
|:---|---:|---|
| Vendor constructor returns instance whose type is Vendor | `new Vendor()`  | `Vendor` |
| Vendor returns vendor name string at key Name | `new Vendor("Chaz")` | `"Chaz"` |
| Vendor returns vendor description string at key Description | `new Vendor("Chaz")` | `coffee spot at 77 Main st` |
| Vendor instance initializes with empty List of Orders | `new Vendor("Cyd")` | `List<Order> Orders {}` |
| Vendor instance assigned unique integer Id | `new Vendor("Liz")`  | 4 |
| Vendor instance initializes self into static List of all vendors | `new Vendor("Liz")`  | `List<Vendor> {Vendor Liz}` |
| YearPurchases returns accurate sum of all Orders in vendorInstance's list of Orders  | `favVendor.YearPurchase();` | `320` |
| Order constructor returns instance whose type is Order  | `new Order()` | `Order` |
| Order instance initializes with unique integer Id  | `new Order()` | `1` |
| Order returns Date of order | `new Order()` | `YYYY-MM-DD` |
| CalcOrderPrice accurately determines integer price of Order | `new Order()` | `Order` |