using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class Warrior
    {
        readonly IWeapon Weapon;

        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Kill()
        {
            Weapon.Kill();
        }
    }
}
