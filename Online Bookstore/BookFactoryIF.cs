namespace Online_Bookstore
{
	public interface BookFactoryIF
	{
        public List<Book> getBooks(string title, string author, string genre, double price, string media, int quantity);
    }
}
