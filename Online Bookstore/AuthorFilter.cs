namespace Online_Bookstore
{
	public class AuthorFilter : BookFilterAC
	{
		public AuthorFilter(string criteria, List<BookListing> bookListing) : base(criteria, bookListing) { }
		public override BookFilterIF apply(string criteria, List<BookListing> books)
		{
			List<BookListing> filteredBooks = new List<BookListing>();
			//this.bookListing = new;
			foreach (BookListing book in this.bookListing)
			{
				if (book.author.Equals(criteria))
				{
					filteredBooks.Add(book);
				}
			}
			this.bookListing = filteredBooks;

			return this;
		}
	}
}
