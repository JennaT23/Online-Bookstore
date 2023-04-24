namespace Online_Bookstore
{
	public class GenreFilter : BookFilterAC
	{
		public override List<Book> apply(List<Book> books)
		{
			List<Book> filteredBooks = new List<>();

			for (Book book : books)
			{
				if (book.getGenre().equals(author))
				{
					filteredBooks.add(book);
				}
			}

			return filteredBooks;
		}
	}
}
