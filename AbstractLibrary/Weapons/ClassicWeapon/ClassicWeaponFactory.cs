using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ClassicWeaponFactory : IWeaponFactory
    {
        public ICanon CreateCanon()
        {
            return new ClassicCanon();
        }

        public IGun CreateGun()
        {
            return new ClassicGun();
        }

        public IRifle CreateRifle()
        {
            return new ClassicRifle();
        }
    }
}
