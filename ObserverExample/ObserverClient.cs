using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class ObserverClient
    {
        public static void ClientCode()
        {
            var subj = new Subject();
            var o1 = new ObserverA();
            subj.Attach(o1);

            var o2 = new ObserverB();
            subj.Attach(o2);

            subj.SomeBusinessLogic();
            subj.SomeBusinessLogic();

            subj.Detach(o2);

            subj.SomeBusinessLogic();
        }
    }
}
