namespace Online_Bookstore
{
	public class Bookstore
	{
        // a list of tuples that hold title, quantity, and all copies of each book
        private List<(string title, int quantity, List<Book> copies)> books;
        private Object lockObject;
        public BookFactoryIF warehouse;
        private List<BookListing> bookListings;


        public Bookstore()
        {
            books = new List<(string title, int quantity, List<Book> copies)>();
            lockObject = new Object();
            warehouse = new BookFactory();
            bookListings = new List<BookListing>();
        }

        public void addBooks(List<Book> books)
        {
            bool found = false;
            string title = null;
            //var newBook = this.books[0];

            foreach (var b in this.books)
            {
                if (books[0].title == b.title)
                {
                    title = b.title;
                    //newBook = b;
                    b.copies.AddRange(books);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                double price = determinePrice(books[0].GetType().ToString(), books[0].warehousePrice);
                this.books.Add((books[0].title, books.Count, books));
                bookListings.Add(new BookListing(books[0].title, books[0].author, books[0].genre, price, books.Count));
            }
            else
            {
                foreach (var b in this.bookListings)
                {
                    if (b.title == title)
                    {
                        b.quantity += books.Count;
                        break;
                    }
                }
            }
        }

        private double determinePrice(string type, double warehousePrice)
        {
            double price = 0;

            if (type.ToLower().Contains("audio"))
            {
                price = warehousePrice + warehousePrice * 0.03;
            }
            else if (type.ToLower().Contains("digital"))
            {
                price = warehousePrice + warehousePrice * 0.05;
            }
            else // book
            {
                price = warehousePrice + warehousePrice * 0.08;
            }

            return price;
        }

        public void buy(string title, int quantity) // don't know if this should go in customer or here
        {
            lock (lockObject)
            {
                foreach (var b in books)
                {
                    if (b.title == title)
                    {
                        // do something about buying the book/ giving it to the customer


                        foreach (var bl in bookListings)
                        {
                            if (bl.title == title)
                            {
                                bl.quantity -= quantity; // decrease the quantity 
                            }
                        }

                        break;
                    }
                }
            }
        }
    }
}
