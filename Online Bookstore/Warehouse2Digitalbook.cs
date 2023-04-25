namespace Online_Bookstore
{
	public class Warehouse2Digitalbook : Warehouse2Book
	{
        public Warehouse2Digitalbook(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 100)
            {
                buyerPrice = 2.50;
            }
            else if (length > 100 && length <= 300)
            {
                buyerPrice = 5.00;
            }
            else if (length > 300 && length <= 600)
            {
                buyerPrice = 8.50;
            }
            else if (length > 600)
            {
                buyerPrice = 12.00;
            }

            return buyerPrice;
        }
    }
}
