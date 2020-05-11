using System;

namespace Observer
{
    class Broker : IObserver
    {
        public string Name { get; set; }
        private IObservable stock;

        public Broker(string name, IObservable observers)
        {
            Name = name;
            stock = observers;
            stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo sInfo = (StockInfo)obj;

            if (sInfo.USD > 30)
            {
                Console.WriteLine("Brocker {0} sold dollars;  Dollar price: {1}", Name, sInfo.USD);
            }
            else
            {
                Console.WriteLine("Brocker {0} bought dollars;  Dollar price: {1}", Name, sInfo.USD); 
            }
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
