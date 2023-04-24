namespace Online_Bookstore
{
	public class Bookstore
	{
        // a list of tuples that hold title, quantity, and all copies of each book
        private List<(string title, int quantity, List<Book> copies)> books;
        private Object lockObject;
        private BookFactoryIF warehouse;


        public Bookstore()
        {
            books = new List<(string title, int quantity, List<Book> copies)>();
            lockObject = new Object();
            warehouse = new BookFactory();
        }

        public void addBooks(List<Book> books)
        {
            bool found = false;
            var newBook = this.books[0];

            foreach (var b in this.books)
            {
                if (books[0].title == b.title)
                {
                    newBook = b;
                    b.copies.AddRange(books);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                this.books.Add((books[0].title, books.Count, books));

            }
            else
            {
                newBook.quantity += books.Count;
            }
        }

        private int getQuantity(string title)
        {
            lock (lockObject)
            {
                int quantity = 0;
                foreach (var b in books)
                {
                    if (b.title == title)
                    {
                        return b.quantity;
                    }
                }
                return quantity;
            }
        }

        public void buy(string title, int quantity) // don't know if this should go in customer or here
        {
            lock (lockObject)
            {
                foreach (var b in books)
                {
                    if (b.title == title)
                    {
                        // do something about buying the book

                        break;
                    }
                }
            }
        }
    }
}
