using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage _beverage;

        public abstract string GetDescription();
    }
}
