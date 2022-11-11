
using System.Collections.Generic;

namespace ConerDairy
{
    public class Store
    {
        public List<Product> ProductList { get; set; }
        public List<Product> ShoppingList { get; set; }

        public Store()
        {
            ProductList = new List<Product>();
            ShoppingList = new List<Product>();
        }

        public decimal Checkout()
        {
            decimal totalPrice = 0;
            foreach(var product in ShoppingList)
            {
                totalPrice = totalPrice + product.ProductPrice;
            }
            return totalPrice;
        }
    }
}