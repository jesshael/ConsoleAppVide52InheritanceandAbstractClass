using System;

namespace ConsoleAppVide52InheritanceandAbstractClass
{
    /// <summary>
    /// Sample Maked by Jesshael Cabrera 
    /// email: jesshael@outlook.com
    /// Inheritance, AbstractClass and Interfaces, principle of substitution, polymorphims.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Hourse hourse = new Hourse("Azabache");
            Human human = new Human("Jessy");
            Gorilla gorilla = new Gorilla("Snowflake");

            Mammals animal = new Mammals("Donkey");

            Hourse Mule = new Hourse("Donkey");

            //polymorphism
            animal = Mule;

            Object myAnimal = new Hourse("Azabache");
            Object myHuman = new Human("Jhon");
            Object myMammal = new Mammals("SnowFlake");

            //Declare Array of Object of Mamals 
            Mammals[] recipientAnimals = new Mammals[3];
            
            // Principle of Substitution ES-UN
            IJumpWhitLegs jumpWhitLegs = hourse;

            recipientAnimals[0] = Mule;
            recipientAnimals[1] = human;
            recipientAnimals[2] = gorilla;

            for (int i = 0; i < 3; i++)
            {
                recipientAnimals[i].Think();
            }

            Mammals myMammals = new Mammals("");

            Whale myWhale = new Whale("Whilly");
            myWhale.swim();

            Console.WriteLine();
            Console.WriteLine("No. of legs used in the jump: " + jumpWhitLegs.numberofLegs() );


            human.getName();
            human.Think();
            human.Caringforoffspring();

            hourse.Caringforoffspring();

            gorilla.getName();
            gorilla.climb();
        }
    }
}
