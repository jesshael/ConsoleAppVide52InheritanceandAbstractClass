using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVide52InheritanceandAbstractClass
{
    class Hourse : Mammals, ILandmammal, ISportsAnimal, IJumpWhitLegs
    {
        public Hourse(string nameHorse) : base(nameHorse) { }

        public void gallop() {
            Console.WriteLine("I am able to gallop");

            Breathe();
        }

        public bool isOlimpic()
        {
            return true;
        }

        int IJumpWhitLegs.numberofLegs()
        {
            return 2;
        }

        int ILandmammal.numberofLegs()
        {
            return 4;
        }

        public string TypeofSport()
        {
            return "Horse riding";
        }

        public bool itCanJump()
        {
            return true;
        }


    }
}
