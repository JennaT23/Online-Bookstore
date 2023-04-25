namespace Online_Bookstore
{
    public interface ObserverIF
    {
        public void notify(ObservableIF book, string message);
    }
}

