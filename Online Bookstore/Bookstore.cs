using System.Diagnostics;

namespace Online_Bookstore
{
	public class Bookstore
	{
        // a list of tuples that hold title, quantity, and all copies of each book
        private List<(string title, string media, int quantity, List<Book> copies)> books;
        private Object lockObject;
        public BookFactoryIF warehouse;
        private List<BookListing> bookListings;


        public Bookstore()
        {
            books = new List<(string title, string media, int quantity, List<Book> copies)>();
            lockObject = new Object();
            warehouse = new BookFactory();
            bookListings = new List<BookListing>();
        }

        public void addBooks(List<Book> books)
        {
            bool found = false;
            string title = null;
            string media = null;
            //var newBook = this.books[0];

            foreach (var b in this.books)
            {
                if (books[0].title == b.title && books[0].getMedia() == b.media)
                {
                    title = b.title;
                    media = b.media;
                    //newBook = b;
                    b.copies.AddRange(books);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                double price = determinePrice(books[0].GetType().ToString(), books[0].warehousePrice);
                this.books.Add((books[0].title, books[0].getMedia(), books.Count, books));
                bookListings.Add(new BookListing(books[0].title, books[0].author, books[0].genre, books[0].getMedia(), price, books.Count));
            }
            else
            {
                foreach (var b in this.bookListings)
                {
                    if (b.title == title && b.media == media)
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

        public List<Book> buy(string title, string media, int quantity) // don't know if this should go in customer or here
        {
            List<Book> customerBook = new List<Book>();

            lock (lockObject)
            {
                foreach (var b in books)
                {
                    if (b.title == title && b.media == media)
                    {
                        // do something about buying the book/ giving it to the customer
                        if (b.copies.Count < quantity) // not enough books
                        {
                            Debug.WriteLine("not enough books in stock");
                            break;
                        }
                        int amt = 0;
                        do
                        {
                            customerBook.Add(b.copies[amt]);
                            amt++;
                        } while (amt < quantity);

                        foreach (var bl in bookListings)
                        {
                            if (bl.title == title && bl.media == media)
                            {
                                bl.quantity -= quantity; // decrease the quantity 
                                break;
                            }
                        }

                        break;
                    }
                }
            }
            return customerBook;
        }
    }
}
