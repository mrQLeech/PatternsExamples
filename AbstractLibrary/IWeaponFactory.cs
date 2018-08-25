using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IWeaponFactory
    {
        IGun CreateGun();
        ICanon CreateCanon();
        IRifle CreateRifle();
    }
}
