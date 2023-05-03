namespace Online_Bookstore
{
	public abstract class BookFilterAC : BookFilterIF
	{
		public string criteria { get; set; }
		public List<BookListing> bookListing { get; set; }
		public BookFilterAC(string criteria, List<BookListing> bookListing)
		{
			this.criteria = criteria;
			this.bookListing = bookListing;
		}
		public abstract BookFilterIF apply(string search, List<BookListing> bookListings);
	}
}
