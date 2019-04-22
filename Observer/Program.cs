using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            Stock stock = new Stock();
            Bank bank = new Bank("UnitBank", stock);
            Broker broker = new Broker("Ivan Ivanich", stock);
            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();

            Console.ReadKey();
        }
    }
}
