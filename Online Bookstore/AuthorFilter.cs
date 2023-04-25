namespace Online_Bookstore
{
	public class AuthorFilter : BookFilterAC
	{

		private String author;

		public AuthorFilter(String author)
		{
			this.author = author;
		}

		public override List<BookListing> apply(List<BookListing> books)
		{
			List<BookListing> filteredBooks = new List<BookListing>();

			foreach (BookListing book in books)
			{
				if (book.author.Equals(author))
				{
					filteredBooks.Add(book);
				}
			}

			return filteredBooks;
		}
	}
}
