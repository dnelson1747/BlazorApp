using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    
    public class Product
    {
        private int _name;
        public int ProdID
        {
            get => _name;
            set => _name;
        }
        public string ProdName { get; set; }
        public double SalesPrice { get; set; }
        public DateTime PurchaseDate { get; set; }

        public double Price { get; set; }
    }
}
