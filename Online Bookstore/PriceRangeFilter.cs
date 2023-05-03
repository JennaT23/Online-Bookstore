namespace Online_Bookstore
{
	public class PriceRangeFilter : BookFilterIF
	{
		private double minPrice { get; set; }
		private double maxPrice { get; set; }
		public PriceRangeFilter(double min, double max) {
			this.minPrice = min;
			this.maxPrice = max;
		}
		public override BookFilterIF apply(double min, double max)
		{
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