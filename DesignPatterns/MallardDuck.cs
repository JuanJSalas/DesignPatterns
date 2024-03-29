﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();            
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}
