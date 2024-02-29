using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPattern
{
    internal class BowAndArrow : IWeapon
    {
        public void Weapon()
        {
            Console.WriteLine("I'm using a bow and arrow.");
        }
    }
}
