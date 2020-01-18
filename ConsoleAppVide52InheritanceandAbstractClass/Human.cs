using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVide52InheritanceandAbstractClass
{
    //Inheritance of Mamals
    class Human : Mammals
    {
        //Constructor
        public Human(string nameofHuman) : base(nameofHuman) { }

        public override void Think()
        {
            Console.WriteLine("I am able to think");
        }
    }
}
