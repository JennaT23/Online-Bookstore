using System.Diagnostics;

namespace Online_Bookstore
{
    public class Customer : ObserverIF
    {
        public ObservableIF observable;
        public string name;
        public Bookstore bookstore { set; get; }

        public void notify(ObservableIF book, string message)
        {
            // print the message or something
            Debug.WriteLine(message);
        }
    }
}

