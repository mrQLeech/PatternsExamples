using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class ObserverA : IObserver
    {
        public void Update (ISubject subject)
        {
            if (!(subject is Subject))
            {
                return;
            }

            if ((subject as Subject).State < 3)
            {
                Console.Write("ConcreteObserverA: Reacted to the event.\n");
            }
        }
    }
}
