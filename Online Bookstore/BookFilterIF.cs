namespace Online_Bookstore
{
	public interface BookFilterIF
	{
		public List<BookListing> bookListing { get; set; }
		public string criteria { get; set; }

		public BookFilterIF apply(string search, List<BookListing> bookListing);
	}
}
