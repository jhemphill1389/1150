using System;
using _06_inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_inheritanceTest
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void CatTesting()
        {
            Animal firstAnimal = new Animal();
            Cat firstCat = new Cat();
            firstAnimal.Move();
            firstCat.Move();
            firstCat.MakeSound();

            Liger oneLiger = new Liger();


        }
    }
}
