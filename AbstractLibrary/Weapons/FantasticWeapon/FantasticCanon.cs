using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FantasticCanon : ICanon
    {
        public string GetDescription()
        {
            return "BFG-2100";
        }

        public string MakeShot()
        {
            return "oooooOOOOUP! PAW!!!";
        }
    }
}
