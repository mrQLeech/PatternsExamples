using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ClassicRifle : IRifle
    {
        public string BayonetHitting()
        {
            return "Chup!";
        }

        public string GetDescription()
        {
            return "AK-74";
        }

        public string MakeShot()
        {
            return "Tra-ta-ta!";
        }
    }
}
