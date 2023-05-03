namespace Online_Bookstore
{
	public class Warehouse1Audiobook : Warehouse1Book
	{
        public Warehouse1Audiobook(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.setMedia("audio");
            this.warehousePrice = calcWarehousePrice();
        }

        protected override double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 2)
            {
                buyerPrice = 1.00;
            }
            else if (length > 2 && length <= 5)
            {
                buyerPrice = 3.50;
            }
            else if (length > 5 && length <= 10)
            {
                buyerPrice = 4.00;
            }
            else if (length > 10)
            {
                buyerPrice = 8.00;
            }

            return buyerPrice;
        }
    }
}
