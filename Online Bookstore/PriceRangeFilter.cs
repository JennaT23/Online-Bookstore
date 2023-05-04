namespace Online_Bookstore
{
	public class PriceRangeFilter : BookFilterAC
	{
		public double minPrice { get; set; }
		public double maxPrice { get; set; }

		public PriceRangeFilter(string criteria, List<BookListing> bookListing) : base(criteria, bookListing) {	}
		public override BookFilterIF apply(string criteria, List<BookListing> bookListings)
		{
			string[] price = criteria.Split(',');
			minPrice = Double.Parse(price[0]); // number before comma separation is min price number 
			maxPrice = Double.Parse(price[1]);
			Console.WriteLine(minPrice + ", " + maxPrice);
			string max = price[1];
			List<BookListing> filteredBooks = new List<BookListing>();	

			foreach (BookListing book in bookListings) 
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