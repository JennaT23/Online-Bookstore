namespace Online_Bookstore
{
	public class PriceRangeFilter : BookFilterAC
	{
		public double minPrice { get; set; }
		public double maxPrice { get; set; }

		public PriceRangeFilter(string criteria, List<BookListing> bookListing) : base(criteria, bookListing) {	}
		public override BookFilterIF apply(string criteria, List<BookListing> bookListing)
		{
			string[] prices = criteria.Split(',');
			string min = prices[0]; // number before comma separation is min price number 
			string max = prices[1];
			List<BookListing> filteredBooks = new List<BookListing>();	

			foreach (BookListing book in this.bookListing) 
			{
				if (book.getPrice() >= minPrice && book.getPrice() <= maxPrice)
				{
					filteredBooks.Add(book);
				}
			}
			this.bookListing = filteredBooks;
			return this;
		}
	}
}