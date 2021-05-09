# Retail Order Tracker MVC App
* keep orders organized by vendor with this web app
* an MVC app using RESTful routing conventions

### Author: *Tyler Sinks*
* _begun 6 May, 2021_

## Description
* enter vendors and orders according to vendor
* view and manage details of vendors and orders
* details include name or title, date, price, order totals by vendor
* navigation to vendors' and orders' detail views and home page

### Technologies Used
* `C#`
* _[Epicodus curriculum: C# Web Applications](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/c-web-applications/to-do-list-mvc-setup)_
* _VS Code_
* _.Net v5.0_
* _MVC framework_
* _Razor_

## Setup and Installation
_namespaces and dependencies will be handled by following these steps_

1. Use a termainl or console to navigate to the desired directory for this project
2. Clone the project to your machine:
> ` $ git clone https://github.com/sinkstyt/OrderTrack.Solution.git `
3. Change directory into the project's root folder:
> ` $ cd OrderTrack.Solution `
4. Restore the project's dependencies:
> ` $ dotnet restore OrderTrack OrderTrack.Tests`
5. To build and run the project:
> ` $ dotnet build `<br />
> ` $ dotnet run `
6. Or examine the files in VS Code instead of step 5:
> ` $ code . `
7. Or run the full gamut of business logic tests:
> ` $ pwd ` //  {User}/OrderTrack.Solution/
> ` $ cd OrderTrack.Tests `
> ` $ dotnet test `

For those completely new to C# and dotnet, please see these detailed instructions:
* [Installing C# and .NET](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)


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

### Known Bugs
* user interface does not appear

### License
* Copyright 2021 :copyright:  Tyler Sinks
* [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/saoud/csharp-TDD-template/blob/main/LICENSE)

### Contact
[Tyler](mailto:tyler.sinks@gmail.com)