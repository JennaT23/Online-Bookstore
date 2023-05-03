namespace Online_Bookstore
{
	public class Warehouse2Book : Book
	{
        public Warehouse2Book(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.setMedia("physical");
            this.warehousePrice = calcWarehousePrice();
        }

        protected override double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 50)
            {
                buyerPrice = 4.00;
            }
            else if (length > 50 && length <= 150)
            {
                buyerPrice = 8.00;
            }
            else if (length > 150 && length <= 300)
            {
                buyerPrice = 13.50;
            }
            else if (length > 300)
            {
                buyerPrice = 23.00;
            }

            return buyerPrice;
        }

    }
}
