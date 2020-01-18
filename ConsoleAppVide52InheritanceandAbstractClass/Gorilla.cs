using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVide52InheritanceandAbstractClass
{
    class Gorilla : Mammals, ILandmammal
    {
        public Gorilla(string nameofGorilla) : base(nameofGorilla) { }

        public void climb()
        {
            Console.WriteLine("I am able to climb");
        }

        public override void Think()
        {
            Console.WriteLine("Medium Instinctive Thinking");
        }

        public int numberofLegs()
        {
            return 2;
        }
    }
}
