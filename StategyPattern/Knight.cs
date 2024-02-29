using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPattern
{
    internal class Knight : Character
    {
        public override void Figth()
        {
            Console.WriteLine("Knight: I'm fighting!");
        }
    }
}
