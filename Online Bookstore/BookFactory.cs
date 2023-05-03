namespace Online_Bookstore
{
	public class BookFactory : BookFactoryIF
	{
        public List<Book> getBooks(string title, string author, string genre, int length, string media, int quantity)
        {
            List<Book> books = new List<Book>();

            string warehouse = getCheapestWarehouse(title, author, genre, length, media);

            Assembly assembly = Assembly.Load("Warehouses"); // laod in the assebly the class is in
            Type type = assembly.GetType("Warehouses." + warehouse, true, true); // get the type of the desired class

            for (int i = 0; i < quantity; i++)
            {
                // create an object instance of the class using a constructor that takes parameters
                object instance = Activator.CreateInstance(type, new object[] { title, author, genre, length });

                books.Add((Book)instance);
            }
            return books;
        }

        private string getCheapestWarehouse(string title, string author, string genre, int length, string media)
        {
            Book book;
            Warehouse1Book book1;
            Warehouse2Book book2;
            string warehouseType;

            if (media == "physical")
            {
                book = new Book(title, author, genre, length);
                book1 = new Warehouse1Book(title, author, genre, length);
                book2 = new Warehouse2Book(title, author, genre, length);

                if (book.warehousePrice < book1.warehousePrice && book.warehousePrice < book2.warehousePrice)
                {
                    warehouseType = "Book";
                }
                else if (book1.warehousePrice < book.warehousePrice && book1.warehousePrice < book2.warehousePrice)
                {
                    warehouseType = "Warehouse1Book";
                }
                else// (book2.price < book1.price && book2.price < book.price)
                {
                    warehouseType = "Warehouse2Book";
                }
            }
            else if (media == "audio")
            {
                book = new Audiobook(title, author, genre, length);
                book1 = new Warehouse1Audiobook(title, author, genre, length);
                book2 = new Warehouse2Audiobook(title, author, genre, length);

                if (book.warehousePrice < book1.warehousePrice && book.warehousePrice < book2.warehousePrice)
                {
                    warehouseType = "AudioBook";
                }
                else if (book1.warehousePrice < book.warehousePrice && book1.warehousePrice < book2.warehousePrice)
                {
                    warehouseType = "Warehouse1Audiobook";
                }
                else// (book2.price < book1.price && book2.price < book.price)
                {
                    warehouseType = "Warehouse2Audiobook";
                }
            }
            else // (media == "digital")
            {
                book = new Digitalbook(title, author, genre, length);
                book1 = new Warehouse1Digitalbook(title, author, genre, length);
                book2 = new Warehouse2Digitalbook(title, author, genre, length);

                if (book.warehousePrice < book1.warehousePrice && book.warehousePrice < book2.warehousePrice)
                {
                    warehouseType = "DigitalBook";
                }
                else if (book1.warehousePrice < book.warehousePrice && book1.warehousePrice < book2.warehousePrice)
                {
                    warehouseType = "Warehouse1Digitalbook";
                }
                else// (book2.price < book1.price && book2.price < book.price)
                {
                    warehouseType = "Warehouse2Digitalbook";
                }
            }

            return warehouseType;
        }
    }
}
