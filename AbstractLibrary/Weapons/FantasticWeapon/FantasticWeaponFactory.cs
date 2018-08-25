using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FantasticWeaponFactory: IWeaponFactory
    {
        public ICanon CreateCanon()
        {
            return new FantasticCanon();
        }

        public IGun CreateGun()
        {
            return new FantasticGun();
        }

        public IRifle CreateRifle()
        {
            return new FantasticRifle();
        }
    }
}
