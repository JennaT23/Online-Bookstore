namespace Online_Bookstore
{
	public class PriceRangeFilter : BookFilterAC
	{
		private double minPrice;
		private double maxPrice;
		public PriceRangeFilter(double minPrice, double maxPrice) {
			this.minPrice = minPrice;
			this.maxPrice = maxPrice;
		}
		public override List<BookListing> apply(List<BookListing> books)
		{
			List<BookListing> filteredBooks = new List<BookListing>();	

			foreach (BookListing book in books) 
			{
				if (book.getPrice() >= minPrice && book.getPrice() <= maxPrice)
				{
					filteredBooks.Add(book);
				}
			}
			return filteredBooks;
		}
	}
}