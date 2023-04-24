namespace Online_Bookstore
{
	public class Warehouse2Book : Book
	{
        public Warehouse2Book(string title, string author, string genre, double price) : base(title, author, genre, price)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (price > 0 && price <= 10)
            {
                buyerPrice = price + price * 0.01;
            }
            else if (price > 10 && price <= 20)
            {
                buyerPrice = price + price * 0.04;
            }
            else if (price > 20 && price <= 30)
            {
                buyerPrice = price + price * 0.06;
            }
            else if (price > 30)
            {
                buyerPrice = price + price * 0.09;
            }
            else
            {
                // invalid price
            }
            return buyerPrice;
        }

        public double getWarehousePrice()
        {
            return warehousePrice;
        }
    }
}
