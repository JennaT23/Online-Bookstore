namespace Online_Bookstore
{
	public class BookFactory : BookFactoryIF
	{
        public List<Book> getBooks(string title, string author, string genre, double price, string media, int quantity)
        {
            List<Book> books = new List<Book>();

            string warehouse = getCheapestWarehouse(title, author, genre, price, media);

            // reflection
            Type t = Type.GetType("Warehouses." + warehouse, true, true);
            ConstructorInfo ci = t.GetConstructor(new[] { typeof(string), typeof(string), typeof(string), typeof(double) });

            for (int i = 0; i < quantity; i++)
            {
                object o = ci.Invoke(new object[] { title, author, genre, price });

                books.Add((Book)o);
            }
            return books;
        }

        private string getCheapestWarehouse(string title, string author, string genre, double price, string media)
        {
            Book book;
            Warehouse1Book book1;
            Warehouse2Book book2;
            string warehouseType;

            if (media == "physical")
            {
                book = new Book(title, author, genre, price);
                book1 = new Warehouse1Book(title, author, genre, price);
                book2 = new Warehouse2Book(title, author, genre, price);

                if (book.price < book1.price && book.price < book2.price)
                {
                    warehouseType = "book";
                }
                else if (book1.price < book.price && book1.price < book2.price)
                {
                    warehouseType = "warehouse1book";
                }
                else// (book2.price < book1.price && book2.price < book.price)
                {
                    warehouseType = "warehouse2book";
                }
            }
            else if (media == "audio")
            {
                book = new AudioBook(title, author, genre, price);
                book1 = new Warehouse1AudioBook(title, author, genre, price);
                book2 = new Warehouse2AudioBook(title, author, genre, price);

                if (book.price < book1.price && book.price < book2.price)
                {
                    warehouseType = "audiobook";
                }
                else if (book1.price < book.price && book1.price < book2.price)
                {
                    warehouseType = "warehouse1audiobook";
                }
                else// (book2.price < book1.price && book2.price < book.price)
                {
                    warehouseType = "warehouse2audiobook";
                }
            }
            else // (media == "digital")
            {
                book = new DigitalBook(title, author, genre, price);
                book1 = new Warehouse1DigitalBook(title, author, genre, price);
                book2 = new Warehouse2DigitalBook(title, author, genre, price);

                if (book.price < book1.price && book.price < book2.price)
                {
                    warehouseType = "digitalbook";
                }
                else if (book1.price < book.price && book1.price < book2.price)
                {
                    warehouseType = "warehouse1digitalbook";
                }
                else// (book2.price < book1.price && book2.price < book.price)
                {
                    warehouseType = "warehouse2digitalbook";
                }
            }

            return warehouseType;
        }
    }
}
