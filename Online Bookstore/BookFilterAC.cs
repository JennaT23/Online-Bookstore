namespace Online_Bookstore
{
	public abstract class BookFilterAC : BookFactoryIF
	{
		public abstract List<Book> apply(List<Book> books);
	}
}
