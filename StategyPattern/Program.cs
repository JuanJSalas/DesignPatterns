using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPattern
{
    internal class Program
    {
        /*  Strategy Pattern
         * 
            It defines a family of algorithms,encapsulates each one,
            and makes them interchangable. Strategy lets the algorithm
            vary independently from clients that use it.
        */
        static void Main(string[] args)
        {
            
            
            Character queen = new Queen();
            queen.Figth();
            queen.SetWeapon(new Axe());
            queen.UseWeapon();
            queen.SetWeapon(new Sword());
            queen.UseWeapon();

        }
    }
}
