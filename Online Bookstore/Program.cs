//namespace Bookstore3
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new Form1());
//        }
//    }
//}



using Bookstore3;
using Online_Bookstore;
using System.Diagnostics;
//using Warehouses;

namespace Bookstore3
{

	internal partial class Program
	{

		static void Main()
		{
			Bookstore b = new Bookstore();
			Customer customer = new Customer();

			customer.bookstore = b;

			// start a customer thread using the runCustomer thread
			// Thread customerThread = new Thread(new ThreadStart(customer.runCustomer));

			List<Book> bookList = b.warehouse.getBooks("Lord of the Rings", "J.R.R. Tolkien", "Fantasy", 1, "audio", 10);

			b.addBooks(bookList);
			//Debug.WriteLine(bookList.Count);

			bookList = b.warehouse.getBooks("Lord of the Rings", "J.R.R. Tolkien", "Fantasy", 500, "physical", 5);
			b.addBooks(bookList);
			//Debug.WriteLine(bookList.Count);

			//List<Book> myBook = customer.bookstore.buy("Lord of the Rings", "physical", 1);
			//Debug.WriteLine(myBook.Count);
			//Debug.WriteLine(myBook[0].title);


			ObservableIF ob = new BookListing("Lord of the Rings", "J.R.R. Tolkien", "Fantasy", "physical", 3, 10);
			//ob.register(customer);

			//List<Book> bookList2 = b.warehouse.getBooks("Harry Potter", "J.K Rowling", "fantasy", 500, "physical", 50);
			//b.addBooks(bookList2);

			//List<Book> booklist3 = b.warehouse.getBooks("Fuck", "Fuck", "depression", 300, "physical", 50);
			//b.addBooks(booklist3);

			//List<Book> booklist4 = b.warehouse.getBooks("The hunger games", "idk", "dystopian", 234, "physical", 30);
			//b.addBooks(booklist4);

			//List<Book> booklist5 = b.warehouse.getBooks("Hi", "Bye", "life", 234, "physical", 30);
			//b.addBooks(booklist5);

			List<BookListing> bookListings = new List<BookListing>();
			BookListing book1 = new BookListing("Lord of the Rings", "J.R.R. Tolkien", "fantasy", "audio", 10, 10);
			bookListings.Add(book1);
			BookListing book2 = new BookListing("Harry Potter", "J.K Rowling", "fantasy", "physical", 50, 500);
			bookListings.Add(book2);
			BookListing book3 = new BookListing("Fuck", "Fuck", "depression", "physical", 30, 50);
			bookListings.Add(book3);
			BookListing book4 = new BookListing("The hunger games", "idk", "dystopian", "physical", 234, 30);
			bookListings.Add(book4);
			BookListing book5 = new BookListing("It", "Stephen King", "horror", "physical", 10, 40);
			bookListings.Add(book5);
			BookListing book6 = new BookListing("The Mist", "Stephen King", "horror", "physical", 10, 40);
			bookListings.Add(book6);
			BookListing book7 = new BookListing("Pet sematary", "Stephen King", "horror", "physical", 15, 50);
			bookListings.Add(book7);
			BookListing book8 = new BookListing("The Haunting of Hill House", "Shirley Jackson", "horror", "physical", 20, 50);
			bookListings.Add(book8);
			BookListing book9 = new BookListing("Frankenstein", "Mary Shelley", "horror", "physical", 25, 50);
			bookListings.Add(book9);
			BookListing book10 = new BookListing("Fairy Tale", "Stephen King", "fantasy", "physical", 25, 50);
			bookListings.Add(book10);

			//b.filter = new AuthorFilter("Stephen King", bookListings);
			//b.filter = b.filter.apply("Stephen King");

			//b.filter = new GenreFilter("horror", bookListings);
			//b.filter = b.filter.apply("horror", bookListings);
			//foreach (BookListing book in b.filter.bookListing)
			//{
			//	Console.WriteLine(book.title);
			//}

			//Console.WriteLine("Author");
			//b.filter = new AuthorFilter("Stephen King", b.filter.bookListing);
			//b.filter = b.filter.apply("Stephen King", b.filter.bookListing);
			////b.filter = new GenreFilter("horror", b.filter.bookListing);
			////b.filter = b.filter.apply("horror");
			//foreach (BookListing book in b.filter.bookListing)
			//{
			//	Console.WriteLine(book.title);
			//}
			//Customer customer2 = new Customer();
			//Customer customer3 = new Customer();
			//Customer customer4 = new Customer();


			//customer2.bookstore = b;
			//customer3.bookstore = b;
			//customer4.bookstore = b;


			//customer.name = "customer1";
			//customer2.name = "customer2";
			//customer3.name = "customer3";
			//customer4.name = "customer4";

			//customer.observable = ob;
			//customer2.observable = ob;
			//customer3.observable = ob;
			//customer4.observable = ob;


			//Thread bookstoreThread = new Thread(new ThreadStart(b.runBookstore));


			//// start a customer thread using the runCustomer thread
			//Thread customerThread1 = new Thread(new ThreadStart(customer.runCustomer1));
			//Thread customerThread2 = new Thread(new ThreadStart(customer2.runCustomer2));
			//Thread customerThread3 = new Thread(new ThreadStart(customer3.runCustomer3));
			//Thread customerThread4 = new Thread(new ThreadStart(customer4.runCustomer1));

			//customerThread1.Start();
			//customerThread2.Start();
			//bookstoreThread.Start();
			//customerThread3.Start();
			//customerThread4.Start();


			//customerThread1.Join();
			//customerThread2.Join();
			//customerThread3.Join();
			//customerThread4.Join();
			//bookstoreThread.Join();

			Debug.WriteLine("\ndone");


		}


	}


}