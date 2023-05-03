namespace Online_Bookstore
{
	public class Warehouse2Audiobook : Warehouse2Book
	{
        public Warehouse2Audiobook(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.setMedia("audio");
            this.warehousePrice = calcWarehousePrice();
        }

        protected override double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 2)
            {
                buyerPrice = 2.50;
            }
            else if (length > 2 && length <= 5)
            {
                buyerPrice = 4.00;
            }
            else if (length > 5 && length <= 10)
            {
                buyerPrice = 5.50;
            }
            else if (length > 10)
            {
                buyerPrice = 9.50;
            }

            return buyerPrice;
        }
    }
}
