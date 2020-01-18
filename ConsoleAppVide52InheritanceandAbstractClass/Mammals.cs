using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVide52InheritanceandAbstractClass
{
    class Mammals
    {
        private string nameofLivingBeing;
        int legs;

        public Mammals(string name)
        {
            nameofLivingBeing = name;
        }

        protected void Breathe()
        {
            Console.WriteLine("I am able to breathe ");
        }

        public virtual void Think()
        {
            Console.WriteLine("Basic Instinctive Thinking ");
        }

        public void Caringforoffspring()
        {
            Console.WriteLine("I take care of my young. ");
        }

        public void getName()
        {
            Console.WriteLine("The name of the living being: " + nameofLivingBeing);
        }


    }
    
}
