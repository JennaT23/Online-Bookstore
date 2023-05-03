namespace Online_Bookstore
{
	public class AuthorFilter : BookFilterAC
	{

		public AuthorFilter(String author) : base(author) {	}

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
