using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Soy() { }

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            double ingredientCost = 0;
            if (_beverage.GetSize() == Size.TALL) { ingredientCost = .15; }
            if (_beverage.GetSize() == Size.GRANDE) { ingredientCost = .20; }
            if (_beverage.GetSize() == Size.VENTI) { ingredientCost = .25; }

            return _beverage.Cost() + ingredientCost;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override Size GetSize()
        {
            return _beverage.GetSize();
        }
    }
}
