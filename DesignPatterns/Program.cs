﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.PerformQuack();
            duck.PerformFly();
        }
    }
}
