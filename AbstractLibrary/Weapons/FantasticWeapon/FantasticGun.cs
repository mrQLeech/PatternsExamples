using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FantasticGun : IGun
    {
        public string GetDescription()
        {
            return "Bluster";
        }


        public string Hitting()
        {
            return "Bluster has broken down";
        }


        public string MakeShot()
        {
            return "Piu! Piu!";
        }
    }
}
