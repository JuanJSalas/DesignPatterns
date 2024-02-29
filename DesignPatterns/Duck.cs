using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void PerformQuack() 
        {
            quackBehavior.Quack();
        }
        public void PerformFly() 
        {
            flyBehavior.Fly();
        }
        public void Swim() 
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
        public virtual void Display() { }
    }
}
