using EF_Task.Data;
using EF_Task.Models;

namespace EF_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbcontext = new ApplicationDbContext();
            var products = dbcontext.Products.ToList();
            Console.WriteLine("products :");
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
            }
            Console.WriteLine("---------------------------------------");
            var orders = dbcontext.Orders.ToList();
            Console.WriteLine("orders :");
            foreach (var order in orders)
            {
                Console.WriteLine(order.Address);
            }
            {
                var FirstName = dbcontext.Products.First(e => e.Id == 1);
                FirstName.Name = "Iphone 11";
                FirstName.Price = 200;
                dbcontext.SaveChanges();

                var createdAt = dbcontext.Orders.FirstOrDefault(e => e.OrderId == 1);
                if (createdAt != null)
                {
                    createdAt.CreatedAt = DateTime.Now.AddDays(1);
                    dbcontext.SaveChanges();
                }
                var product = dbcontext.Products.FirstOrDefault(e => e.Id == 2);
                if (product != null)
                {
                    dbcontext.Products.Remove(product);
                    dbcontext.SaveChanges();
                }
                var order = dbcontext.Orders.FirstOrDefault(e => e.OrderId == 3);
                if (order != null)
                {
                    dbcontext.Orders.Remove(order);
                    dbcontext.SaveChanges();
                }
                
            }         
        }
    }
}
