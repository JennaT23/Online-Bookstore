namespace Online_Bookstore
{
	public class Book
	{
		private string title;
		private string author;
		private string genre;
		private double price;
		private double warehousePrice;

		public string getTitle() { return title; }
		public string getAuthor() { return author; }
		public string getGenre() {  return genre; }
		public double getPrice() { return price; }
		public double getWarehousePrice() {  return warehousePrice; }
	}
}
