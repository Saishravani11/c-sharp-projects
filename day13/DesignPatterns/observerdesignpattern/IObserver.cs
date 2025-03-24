using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface IObserver
    {
        void update(string news);
    }

    //creating multiple subscribers 

    public class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void update(string news)
        {
            Console.WriteLine($"{_name} received news  : {news}");

        }

    }


    public class NewsAgency
    {

        private List<IObserver> _subscribers = new List<IObserver>();


        public void AddSubscriber(IObserver observer)
        {
            _subscribers.Add(observer);
        }

        public void RemoveSubscriber(IObserver observer)
        {
            _subscribers.Remove(observer);
        }

        public void NotifySubscribers(string news)
        {
            foreach (var subscriber in _subscribers)

                subscriber.update(news);

        }
    }
}

