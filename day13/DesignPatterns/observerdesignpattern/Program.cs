using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class ObserverMain
    {

        public static void Main()
        {
            NewsAgency agency = new NewsAgency();


            IObserver sub1 = new Subscriber("Shravs");
            IObserver sub2 = new Subscriber("Harry");

            agency.AddSubscriber(sub1);
            agency.AddSubscriber(sub2);

            agency.NotifySubscribers("There is a change in temperature");
        }
    }
}




