namespace Online_Bookstore
{
	public class GenreFilter : BookFilterAC
	{
		private string genre;
		public GenreFilter(string genre)
		{
			this.genre = genre;
		}
		public override List<BookListing> apply(List<BookListing> books)
		{
			List<BookListing> filteredBooks = new List<BookListing>();

			foreach (BookListing book in books)
			{
				if (book.genre.Equals(genre))
				{
					filteredBooks.Add(book);
				}
			}

			return filteredBooks;
		}
	}
}
