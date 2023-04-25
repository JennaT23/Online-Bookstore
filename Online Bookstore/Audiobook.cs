namespace Online_Bookstore
{
	public class Audiobook : Book
	{
        public Audiobook(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected override double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 2)
            {
                buyerPrice = 1.50;
            }
            else if (length > 2 && length <= 5)
            {
                buyerPrice = 3.00;
            }
            else if (length > 5 && length <= 10)
            {
                buyerPrice = 5.00;
            }
            else if (length > 10)
            {
                buyerPrice = 10.00;
            }

            return buyerPrice;
        }
    }
}
