using JSON_Task.Models;

namespace JSON_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product("Alma", 1);
            Product pro2 = new Product("Armud",2);
            Product pro3 = new Product("Gilas", 3);
            Category category = new Category("Meyve");
            category.Products.Add(pro1);
            category.Products.Add(pro2);
            category.Products.Add(pro3);
            foreach(Product item in category.Products)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}