using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Animal
    {
        protected string name;
        protected byte age;
        public Animal()
        {
            name = " no name ";
            age = 10;
        }
        public Animal(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }
        public Animal(Animal animalToCopy)
        {
            name = animalToCopy.name;
            age = animalToCopy.age;

            // age = 2; krostruktor kopiujacy nie musi miec 
        }
    }
}
