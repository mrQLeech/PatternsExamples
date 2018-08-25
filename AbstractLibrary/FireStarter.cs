using System;

namespace AbstractFactory
{
    public class FireStarter
    {
        private IWeaponFactory _weaponFactory { get; set; }

        public FireStarter(IWeaponFactory weaponFactory)
        {
            _weaponFactory = weaponFactory;
        }


        public void UseGun()
        {
            var gun = _weaponFactory.CreateGun();
            Console.WriteLine($"I take my {gun.GetDescription()}");
            Console.WriteLine($"I shoot from gun: {gun.MakeShot()}");
            Console.WriteLine($"I hitting the enemy. {gun.Hitting()}");
            Console.WriteLine();
        }


        public void UseRifle()
        {
            var rifle = _weaponFactory.CreateRifle();
            Console.WriteLine($"I take my {rifle.GetDescription()}");
            Console.WriteLine($"I shoot from rifle: {rifle.MakeShot()}");
            Console.WriteLine($"I hitting the enemy by bayonet: {rifle.BayonetHitting()}");
            Console.WriteLine();
        }


        public void UseCanon()
        {
            var canon = _weaponFactory.CreateCanon();
            Console.WriteLine($"I take my {canon.GetDescription()}");
            Console.WriteLine($"I shoot from canon: {canon.MakeShot()}");
            Console.WriteLine();
        }
    }
}
