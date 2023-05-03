namespace Online_Bookstore
{
	public class Book
	{
        public string author { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public int length { get; set; }
        public double warehousePrice { get; set; }

        private string media;

        public Book(string title, string author, string genre, int length)
        {
            this.media = "physical";
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.length = length;

            this.warehousePrice = calcWarehousePrice();
        }

        public string getMedia()
        {
            return media;
        }

        protected void setMedia(string media)
        {
            this.media = media;
        }

        protected virtual double calcWarehousePrice()
        {
            double buyerPrice = 0;
            if (length > 0 && length <= 50)
            {
                buyerPrice = 5.00;
            }
            else if (length > 50 && length <= 150)
            {
                buyerPrice = 10.00;
            }
            else if (length > 150 && length <= 300)
            {
                buyerPrice = 15.00;
            }
            else if (length > 300)
            {
                buyerPrice = 20.00;
            }

            return buyerPrice;
        }
    }
}
