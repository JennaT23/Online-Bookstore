namespace Online_Bookstore
{
	public class GenreFilter : BookFilterAC
	{
		public GenreFilter(string criteria, List<BookListing> bookListing) : base(criteria, bookListing) {	}
		public override BookFilterIF apply(string criteria, List<BookListing> bookListings)
		{
			List<BookListing> filteredBooks = new List<BookListing>();

			foreach (BookListing book in bookListings)
			{
				if (book.genre.Equals(criteria))
				{
					filteredBooks.Add(book);
				}
			}
			this.bookListing = filteredBooks;

			return this;
		}
	}
}