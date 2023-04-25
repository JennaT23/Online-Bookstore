	namespace Online_Bookstore
{
	public abstract class BookFilterAC : BookFilterIF
	{
		public abstract List<Book> apply(List<Book> books);
	}
}
