namespace Online_Bookstore
{
	public class PriceRangeFilter : BookFilterIF
	{
		public double minPrice { get; set; }
		public double maxPrice { get; set; }
		public List<BookListing> bookListings { get; set; }

		public PriceRangeFilter(double min, double max) {
			this.minPrice = min;
			this.maxPrice = max;
		}
		public BookFilterIF apply(string criteria)
		{
			string[] min = criteria.Split(',');
			List<BookListing> filteredBooks = new List<BookListing>();	

			foreach (BookListing book in this.bookListings) 
			{
				if (book.getPrice() >= minPrice && book.getPrice() <= maxPrice)
				{
					filteredBooks.Add(book);
				}
			}
			this.bookListings = filteredBooks;
			return this;
		}
	}
}