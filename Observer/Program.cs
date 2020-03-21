using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Banck banck = new Banck("Bank 1 ", stock);
            Banck banck2 = new Banck("Bank 2 ", stock);
            Broker broker = new Broker("Broker 1", stock);
            stock.Market();
            stock.Market();
            broker.StopTrade();
            banck.StopTrade();
            banck2.StopTrade();
            Console.Read();
        }
    }

    interface IObserver
    {
        void Update(Object obj);
    }
    interface IObservable
    {
        //IEnumerable<IObserver> observers;
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class Stock : IObservable
    {
        StockInfo sInfo;
        List<IObserver> observers;

        public Stock()
        {
            this.observers = new List<IObserver>();
            sInfo = new StockInfo();
        }

        public void NotifyObservers()
        {
            foreach (var item in observers)
            {
                item.Update(sInfo);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(20,40);
            sInfo.Euro = rnd.Next(30,50);
            NotifyObservers();
        }

    }

    internal class StockInfo
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }

    class Broker : IObserver
    {
        public string name { get; set; }

        IObservable stock;

        public Broker(string name, IObservable stock)
        {
            this.name = name;
            this.stock = stock;
            this.stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo sInfo = (StockInfo)obj;
            if (sInfo.USD > 30)
                Console.WriteLine("USB > 30");
            else
                Console.WriteLine("USB < 30");
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }

    class Banck : IObserver
    {
        public string name { get; set; }

        IObservable stock;

        public Banck(string name, IObservable stock)
        {
            this.name = name;
            this.stock = stock;
            this.stock.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            StockInfo sInfo = (StockInfo)obj;
            if (sInfo.Euro > 40)
                Console.WriteLine("EURO > 40");
            else
                Console.WriteLine("EURO < 40");
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }

}


