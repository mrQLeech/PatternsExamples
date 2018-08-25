using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FantasticRifle : IRifle
    {
        public string BayonetHitting()
        {
            return "Ooops... This rifle haven't bayonet";
        }

        public string GetDescription()
        {
            return "Automatic LazerGun-2000";
        }

        public string MakeShot()
        {
            return "Ouuuuuip. Piu-piu-piu! Ooooouip";
        }
    }
}
