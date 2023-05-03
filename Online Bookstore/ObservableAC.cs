namespace Online_Bookstore
{
    public abstract class ObservableAC : ObservableIF
    {
        private List<ObserverIF> observers;

        public ObservableAC()
        {
            observers = new List<ObserverIF>();
        }

        protected void changed(string message)
        {
            foreach (ObserverIF observer in observers)
            {
                observer.notify(this, message);
            }
        }

        public void deregister(ObserverIF observer)
        {
            foreach (var o in observers)
            {
                if (observer == o)
                {
                    observers.Remove(o);
                    break;
                }
            }
        }

        public void register(ObserverIF observer)
        {
            observers.Add(observer);
        }

        protected abstract string getMessage(double newPrice, double oldPrice);

    }
}

