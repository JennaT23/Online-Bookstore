namespace Online_Bookstore
{
	public class Digitalbook : Book
	{
        public Digitalbook(string title, string author, string genre, double price) : base(title, author, genre, price)
        {

        }

        protected override double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (price > 0 && price <= 10)
            {
                buyerPrice = price + price * 0.02;
            }
            else if (price > 10 && price <= 20)
            {
                buyerPrice = price + price * 0.05;
            }
            else if (price > 20 && price <= 30)
            {
                buyerPrice = price + price * 0.07;
            }
            else if (price > 30)
            {
                buyerPrice = price + price * 0.1;
            }
            else
            {
                // invalid price
            }
            return buyerPrice;
        }
    }
}
