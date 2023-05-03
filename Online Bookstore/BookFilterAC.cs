namespace Online_Bookstore
{
	public abstract class BookFilterAC : BookFilterIF
	{
		public string criteria { get; set; }
		public List<BookListing> bookListings { get; set; }
		public BookFilterAC(string criteria)
		{
			this.criteria = criteria;
		}
		public abstract BookFilterIF apply(string search);
	}
}
