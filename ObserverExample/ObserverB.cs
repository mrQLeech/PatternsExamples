using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class ObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (!(subject is Subject))
            {
                return;
            }

            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.Write("ConcreteObserverB: Reacted to the event.\n");
            }
        }
    }
}
