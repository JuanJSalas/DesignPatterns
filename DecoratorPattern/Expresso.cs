using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Expresso : Beverage
    {
        public Expresso(Size size)
        {
            _description = "Expresso";
            _size = size;
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
