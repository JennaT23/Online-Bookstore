namespace Online_Bookstore
{
    public class BookListing : ObservableIF
    {
        public int quantity { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        private double price;

        public BookListing(string title, string author, string genre, double price, int quantity)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.quantity = quantity;
            this.price = price;
        }

        public double getPrice() { return price; }

        public void setPrice(double price) // maybe lock ?
        {
            string message = getMessage(price, this.price);
            this.price = price;
            changed(message);
        }


        protected override string getMessage(double newPrice, double oldPrice)
        {
            string message = "The price of " + title + " went from " + oldPrice + " to " + newPrice + ".";
            return message;
        }
    }
}

