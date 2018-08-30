using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExample
{
    class StateB: State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request1.\n");
        }

        public override void Handle2()
        {
            Console.Write("ConcreteStateB handles request2.\n");
            Console.Write("ConcreteStateB wants to change the state of the context.\n");
            this.Context.TransitionTo(new ConcreteStateA());
        }
    }
}
