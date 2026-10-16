
using Microsoft.Extensions.Configuration;
using OrderFramework.Data;
using OrderFramework.Models;

using OrderContext context = new OrderContext();

var pepperoniDeluxe = context.Products.Where(p => p.Name == "Pepperoni Deluxe").FirstOrDefault();

if (pepperoniDeluxe is Product)
{
    context.Remove(pepperoniDeluxe);
}
context.SaveChanges();

var products = context.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name);

foreach (Product p in products)
{
    Console.WriteLine(p.Id);
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Price);
}