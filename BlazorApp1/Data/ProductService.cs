using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ProductService
    {
        List<Product> products = new()
        {
            new Product() { ProdID = 1, ProdName = "Car Wash", SalesPrice = 10, PurchaseDate = Convert.ToDateTime("01-May-2021") },
            new Product() { ProdID = 2, ProdName = "Gas", SalesPrice = 3, PurchaseDate = Convert.ToDateTime("01-May-2021") },
            new Product() { ProdID = 3, ProdName = "Tune Up", SalesPrice = 15, PurchaseDate = Convert.ToDateTime("01-May-2021") },
            new Product() { ProdID = 4, ProdName = "Vacuum", SalesPrice = 5, PurchaseDate = Convert.ToDateTime("01-May-2021") },
            new Product() { ProdID = 5, ProdName = "Spark Plugs", SalesPrice = 8, PurchaseDate = Convert.ToDateTime("01-May-2021") },
            new Product() { ProdID = 6, ProdName = "Oil Change", SalesPrice = 12, PurchaseDate = Convert.ToDateTime("01-May-2021") }

        };

        
        public async Task<List<Product>> ProductList()
        {
            return await Task.FromResult(products);
        }


    }
}
