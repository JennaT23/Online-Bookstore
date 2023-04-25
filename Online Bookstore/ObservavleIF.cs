namespace Online_Bookstore
{
    public interface ObservableIF
    {
        public void register(ObserverIF observer);
        public void deregister(ObserverIF observer);
    }
}

