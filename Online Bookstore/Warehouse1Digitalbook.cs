namespace Online_Bookstore
{
    public class Warehouse1Digitalbook : Warehouse1Book
    {
        public Warehouse1Digitalbook(string title, string author, string genre, int length) : base(title, author, genre, length)
        {
            this.warehousePrice = calcWarehousePrice();
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 100)
            {
                buyerPrice = 5.00;
            }
            else if (length > 100 && length <= 300)
            {
                buyerPrice = 9.00;
            }
            else if (length > 300 && length <= 600)
            {
                buyerPrice = 13.00;
            }
            else if (length > 600)
            {
                buyerPrice = 20.00;
            }

            return buyerPrice;
        }
    }

}
