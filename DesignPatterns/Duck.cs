using System;

namespace DesignPatterns
{
    internal abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void PerformQuack() 
        {
            quackBehavior.Quack();
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        
        public void Swim() 
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public virtual void Display() { }
    }
}
