namespace Online_Bookstore
{
	public interface BookFilterIF
	{
		public List<Book> apply(List<Book> books);
	}
}
