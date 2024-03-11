using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(Size size) 
        {
            _description = "Dark Roast";
            _size = size;
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
