using Orderframework.Models;
using OrderFramework.Data;

using OrderFrameworkContext context = new OrderFrameworkContext();

foreach (Customer c in context.Customers)
{
    Console.WriteLine(c.FirstLast);
}

