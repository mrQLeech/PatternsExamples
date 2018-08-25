using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ClassicGun : IGun
    {
        public string GetDescription()
        {
            return "Colt 1911";
        }

        public string Hitting()
        {
            return "Bam!";
        }

        public string MakeShot()
        {
            return "Pif! Paf!";
        }
    }
}
