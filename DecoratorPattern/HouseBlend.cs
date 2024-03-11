using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(Size size)
        {
            _description = "House Blend Coffee";
            _size = size;
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
