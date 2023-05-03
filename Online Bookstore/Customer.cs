namespace Online_Bookstore
{
    public class Customer : ObserverIF
    {
        public ObservableIF observable;
        public string name;
		internal ThreadStart runCustomer1;

		public Bookstore bookstore { set; get; }

        public void notify(ObservableIF book, string message)
        {
            // print the message or something
            //Debug.WriteLine(message);
        }
    }
}

