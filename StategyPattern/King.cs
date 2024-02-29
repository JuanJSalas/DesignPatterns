using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPattern
{
    internal class King : Character
    {
        public override void Figth()
        {
            Console.WriteLine("King: I'm fighting!");
        }
    }
}
