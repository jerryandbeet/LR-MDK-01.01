namespace LAB3
{
    public class Product
    {
        private string name_;
        private decimal price_;
        private int stock_;
        public Product(string name, decimal price, int stock)
        {
            name_ = name;
            price_ = price;
            stock_ = stock;
        }

        public string GetName()
        {
            return name_;
        }
        public decimal GetPrice()
        {
            return price_;
        }
        public int GetStock()
        {
            return stock_;
        }
        public void ReduceStock(int quantity)
        {
            stock_ -= quantity;
        }
    }
}
