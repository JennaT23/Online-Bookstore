namespace Online_Bookstore
{
	public interface BookFilterIF
	{
		public List<BookListing> apply(List<BookListing> books);
	}
}
