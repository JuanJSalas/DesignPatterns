using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPattern
{
    internal class Queen : Character
    {
        public override void Figth()
        {
            Console.WriteLine("Queen: I'm fighting!");
        }
    }
}
