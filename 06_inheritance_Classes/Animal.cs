using System;

namespace _06_inheritance_Classes
{
    public enum DietType {  herbivore = 1, Omnivore, Carnivore }
    public class Animal
    {
        public int NumberofLegs { get; set; }
        public bool IsMammal { get; set;  }
        public bool HasFur { get; set; }

        public DietType TypeOfDiet { get; set;  }

        public Animal()
        {
            Console.WriteLine("This is the Animal Constuctor");
        }
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves quickly.");
        }
    }
}
