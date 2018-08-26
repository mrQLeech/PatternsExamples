using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Executor : ICommand
    {
        private string _parameters;
        

        public Executor(string parameters)
        {
            _parameters = parameters;
        }


        public void Execute()
        {
            Console.WriteLine($"Execute class-executor with paramter: {_parameters}");
        }
    }
}
