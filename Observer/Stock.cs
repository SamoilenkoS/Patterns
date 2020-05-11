using System;
using System.Collections.Generic;

namespace Observer
{
    class Stock : IObservable
    {
        private StockInfo stockInfo; // информация о торгах

        private List<IObserver> observers;
        public Stock()
        {
            observers = new List<IObserver>();
            stockInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(stockInfo);
            }
        }

        public void Market()
        {
            Random random = new Random();
            stockInfo.USD = random.Next(20, 40);
            stockInfo.Euro = random.Next(30, 50);
            NotifyObservers();
        }
    }
}
