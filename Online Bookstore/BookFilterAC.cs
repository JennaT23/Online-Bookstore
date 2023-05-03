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

		protected BookFilterAC(double min, double max)
		{
		}

		public abstract BookFilterIF apply(string search);
		public abstract BookFilterIF apply(double min, double max);
	}
}
