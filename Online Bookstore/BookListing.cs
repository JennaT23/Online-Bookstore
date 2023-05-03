namespace Online_Bookstore
{
    public class BookListing : ObservableAC
    {
        public int quantity { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        private double price;
        public string media { get; set; }

        // needs to be static so all bookListings share the same lock
        private static MyReadWriteLock myLock = new MyReadWriteLock();

        public BookListing(string title, string author, string genre, string media, double price, int quantity)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.media = media;
            this.quantity = quantity;
            this.price = price;
        }

        // change back
        public double getPrice()
        {
            myLock.readLock();
            double price = this.price;
            myLock.done();
            return price;
        }

        // change back
        public void setPrice(double price)
        {
            myLock.writeLock();
            string message = getMessage(price, this.price);
            this.price = price;
            myLock.done();
            changed(message);
        }

        protected override string getMessage(double newPrice, double oldPrice)
        {
            string message = "The price of " + title + " went from " + oldPrice + " to " + newPrice + ".";
            return message;
        }
    }
}

