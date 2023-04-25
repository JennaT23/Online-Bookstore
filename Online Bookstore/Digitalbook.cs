namespace Online_Bookstore
{
	public class Digitalbook : Book
	{
        public Digitalbook(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected override double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 50)
            {
                buyerPrice = 3.00;
            }
            else if (length > 50 && length <= 150)
            {
                buyerPrice = 7.00;
            }
            else if (length > 150 && length <= 300)
            {
                buyerPrice = 10.00;
            }
            else if (length > 300)
            {
                buyerPrice = 15.00;
            }

            return buyerPrice;
        }

    }
}
