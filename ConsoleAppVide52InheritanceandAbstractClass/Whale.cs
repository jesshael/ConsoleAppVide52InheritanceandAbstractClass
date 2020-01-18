using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVide52InheritanceandAbstractClass
{
    class Whale : Mammals
    {
        public Whale(string nameofWhale) : base(nameofWhale){ }

        public void swim()
        {
            Console.WriteLine("I am able to swim");
        }
    }
}
