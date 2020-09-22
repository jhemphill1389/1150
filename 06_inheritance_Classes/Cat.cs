using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _06_inheritance_Classes
{
    public class Cat : Animal //use colon to get can only inheret from one class
    {
        public double ClawLength { get; set; } //property

        public Cat()
        {
            Console.WriteLine("This is the Cat constructor"); //constructor
            IsMammal = true;
            TypeOfDiet = DietType.Carnivore;
        }

        public override void Move() //all methods pascal case, using virtual allows for override
        {
            Console.WriteLine($"The {GetType().Name} moves quickly.");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow.");
        }
    }
    public class Liger : Cat
    {
        public Liger()
        {
            Console.WriteLine("This is the liger constructor");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks it's prey");
            base.Move();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar.");
        }
    }
}

