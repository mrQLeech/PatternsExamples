using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{ 
    public class ClassicCanon : ICanon
    {
        public string GetDescription()
        {
            return "Mortire";
        }

        public string MakeShot()
        {
            return "KA-BOOOM!!!";
        }
    }
}
