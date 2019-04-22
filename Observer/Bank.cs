using System;

namespace Observer
{
    class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
        public Bank(string name, IObservable observers)
        {
            Name = name;
            stock = observers;
            stock.RegisterObserver(this);
        }
        public void Update(object obj)
        {
            StockInfo sInfo = (StockInfo)obj;

            if (sInfo.Euro > 40)
                Console.WriteLine("Bank {0} sold Euro; Euro price: {1}", Name, sInfo.Euro);
            else
                Console.WriteLine("Bank {0} bought Euro; Euro price: {1}", Name, sInfo.Euro);
        }
    }
}
