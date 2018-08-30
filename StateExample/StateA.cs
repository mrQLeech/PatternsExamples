using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateA handles request1.\n");
            Console.Write("ConcreteStateA wants to change the state of the context.\n");
            this.Context.TransitionTo(new StateB());
        }

        public override void Handle2()
        {
            Console.Write("ConcreteStateA handles request2.\n");
        }
    }
}
