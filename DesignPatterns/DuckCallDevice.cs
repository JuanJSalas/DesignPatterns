using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class DuckCallDevice : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I'm imitating quacking.");
        }
    }
}
