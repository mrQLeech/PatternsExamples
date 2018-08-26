using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoker
    {
        private ICommand firstExecutor;
        private ICommand secondExecutor;

        public void SetPrepareOperation(ICommand prepareOperation)
        {
            firstExecutor = prepareOperation;
        }

        public void SetCompleteOperation(ICommand completeOperation)
        {
            secondExecutor = completeOperation;
        }


        public void Operate()
        {
            if (firstExecutor != null)
            {
                firstExecutor.Execute();
            }

            Console.WriteLine("Execute some code");
            if (secondExecutor != null)
            {
                secondExecutor.Execute();
            }
        }
    }
}
