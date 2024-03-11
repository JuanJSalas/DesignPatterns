using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha() { }

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            double ingredientCost = 0;
            if (_beverage.GetSize() == Size.TALL) { ingredientCost = .20; }
            if (_beverage.GetSize() == Size.GRANDE) { ingredientCost = .25; }
            if (_beverage.GetSize() == Size.VENTI) { ingredientCost = .30; }

            return _beverage.Cost() + ingredientCost;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override Size GetSize()
        {
            return _beverage.GetSize();
        }
    }
}
