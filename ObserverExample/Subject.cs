using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.Write("Subject: Attached an observer.\n");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            foreach (var elem in _observers)
            {
                if (elem == observer)
                {
                    _observers.Remove(observer);
                    Console.Write("Subject: Detached an observer.\n");
                    break;
                }
            }
        }

        public void Notify()
        {
            Console.Write("Subject: Notifying observers...\n");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.Write("\nSubject: I'm doing something important.\n");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.Write("Subject: My state has just changed to: " + this.State + "\n");
            this.Notify();
        }
    }
}
