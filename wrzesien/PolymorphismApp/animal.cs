
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Animal //: Object
    {
        protected string name;
        protected byte age;
        protected string type;

        public Animal()
        {
            name = "No name";
            age = 10;
            type = "Zwierze";
        }

        public Animal(string name, byte age)
        {
            this.name = name;
            this.age = age;
            type = "Zwierze";
        }

        public Animal(Animal animalToCopy)
        {
            name = animalToCopy.name;
            age = animalToCopy.age;
            type = animalToCopy.type;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("***********************");
            Console.WriteLine(type + " o imieniu " + name + " ma " + age + " lat");
            Console.WriteLine("***********************");
        }
    }
}