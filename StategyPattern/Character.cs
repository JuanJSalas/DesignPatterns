using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPattern
{
    internal abstract class Character
    {
        protected IWeapon _weapon;

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void UseWeapon()
        {
            _weapon.Weapon();
        }

        public virtual void Figth() { }
    }
}
