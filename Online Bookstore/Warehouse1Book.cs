namespace Online_Bookstore
{
	public class Warehouse1Book : Book
	{
        public Warehouse1Book(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 50)
            {
                buyerPrice = 5.50;
            }
            else if (length > 50 && length <= 150)
            {
                buyerPrice = 12.99;
            }
            else if (length > 150 && length <= 300)
            {
                buyerPrice = 15.50;
            }
            else if (length > 300)
            {
                buyerPrice = 25.00;
            }

            return buyerPrice;
        }

    }
}
