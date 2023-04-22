namespace Online_Bookstore
{
	public class AuthorFilter : BookFilterAC
	{

	private String author;

	public AuthorFilter(String author)
	{
		this.author = author;
	}

	public List<Book> apply(List<Book> books)
	{
		List<Book> filteredBooks = new ArrayList<>();

		for (Book book : books)
		{
			if (book.getAuthor().equals(author))
			{
				filteredBooks.add(book);
			}
		}

		return filteredBooks;
	}
}

}
