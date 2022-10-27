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
        protected string type;
        public Animal()
        {
            name = " no name ";
            age = 10;
            type = "zwierze";
        }
        public Animal(string name, byte age)
        {
            this.name = name;
            this.age = age;
            type = "zwierze";
        }
        public Animal(Animal animalToCopy)
        {
            name = animalToCopy.name;
            age = animalToCopy.age;
            type = animalToCopy.type;
            // age = 2; krostruktor kopiujacy nie musi miec 
        }
        public void ShowInfo()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine(type   + name + "ma " + age);
        }
    }
}
