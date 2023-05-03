namespace Online_Bookstore
{
	public class GenreFilter : BookFilterAC
	{
		private string genre;
		public GenreFilter(string genre) : base(genre) { }
		public override BookFilterIF apply(string criteria)
		{
			List<BookListing> filteredBooks = this.bookListings;

			foreach (BookListing book in this.bookListings)
			{
				if (book.author.Equals(criteria))
				{
					filteredBooks.Add(book);
				}
			}
			this.bookListings = filteredBooks;

			return this;
		}
	}
}
