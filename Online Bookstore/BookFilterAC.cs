	namespace Online_Bookstore
{
	public abstract class BookFilterAC : BookFilterIF
	{
		public abstract List<BookListing> apply(List<BookListing> books);
	}
}
