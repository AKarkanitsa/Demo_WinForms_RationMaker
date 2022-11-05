using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using BusinessObjects;

namespace PresentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Db db = Db.GetInstance();
            List<Category> categories= db.Categories;

            Dictionary<string,List<Product>> products = db.Products;

            foreach (Category c in categories)
                Console.WriteLine(c.CategoryName);

            ProductDao productDao = new ProductDao();
            Product p=productDao.GetProduct("Apple");
            Console.WriteLine(p.Name + " " + p.Calories100);    
            
        }
    }
}
