namespace Online_Bookstore
{
	public interface BookFilterIF
	{
		public BookFilterIF apply(string search);
		public BookFilterIF apply(double min, double max);
	}
}
