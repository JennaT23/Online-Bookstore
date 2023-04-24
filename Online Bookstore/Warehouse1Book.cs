namespace Online_Bookstore
{
	public class Warehouse1Book : Book
	{
        public Warehouse1Book(string title, string author, string genre, double price) : base(title, author, genre, price)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (price > 0 && price <= 10)
            {
                buyerPrice = price + price * 0.03;
            }
            else if (price > 10 && price <= 20)
            {
                buyerPrice = price + price * 0.06;
            }
            else if (price > 20 && price <= 30)
            {
                buyerPrice = price + price * 0.08;
            }
            else if (price > 30)
            {
                buyerPrice = price + price * 0.11;
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
