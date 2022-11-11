namespace ConerDairy
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantities { get; set; }
        public decimal ProductPrice { get; set; }

        public Product(int id, string name, int quantity, decimal price)
        {
            //this.ProductID = id;
            ProductID = id;
            ProductName = name;
            Quantities = quantity;
            ProductPrice = price;
        }

        public override string ToString()
        {
            return ("ID: " + ProductID + " " + "Product: " +ProductName + " $" + ProductPrice + " Quantities: " + Quantities);
        }
    }
}