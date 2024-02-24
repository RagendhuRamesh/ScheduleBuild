// See https://aka.ms/new-console-template for more information;
using ScheduleBuildA4;

Console.WriteLine("Welcome to My Products.......!");
ProductMng obj = new ProductMng();
foreach (var item in obj.AllProducts())
{
    Console.WriteLine($"Product ID        : {item.Key}");
    Console.WriteLine($"Name              : {item.Value.Name}");
    Console.WriteLine($"Price             : {item.Value.Price}");
    Console.WriteLine($"Brand             : {item.Value.Brand}");
    Console.WriteLine($"Manufacturing Date: {item.Value.ManufacturingDate.ToShortDateString()}");
    Console.WriteLine($"Expiry Date       : {item.Value.ExpiryDate.ToShortDateString()}");
    Console.WriteLine("----------------------------------");
}