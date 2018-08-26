using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DifficultExecutor : ICommand
    {
        private string _parameter1;
        private string _parameter2;


        public DifficultExecutor(string parameter1, string parameter2)
        {
            _parameter1 = parameter1;
            _parameter2 = parameter2;
        }

        public void Execute()
        {
            Console.WriteLine($"Execute difficult class-executor with parameters: {_parameter1}, {_parameter2}");
        }
    }
}
