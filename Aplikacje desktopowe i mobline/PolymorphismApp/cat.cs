using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Cat
    {
        private string name;
        private byte age;
        public Cat()
        {
            name = "puszek";
            age = 10;
        }
        public Cat(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }
        public Cat(Cat CatToCopy)
        {
            name = CatToCopy.name;
            age = CatToCopy.age;

            // age = 2; krostruktor kopiujacy nie musi miec 
        }
        public void ShowInfo()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("kot o imieniu " + name + "ma " + age);
            Console.WriteLine("*********************************");
        }
        public void Meow()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("kot o imieniu" + name + "miałczy");
            Console.WriteLine("*********************************");
        }
        public void ClaimOnTree()
        {
            Console.WriteLine("*********************************");

            Console.WriteLine("kot o imieniu" + name + "wchodzi na dzrewo");
            Console.WriteLine("*********************************");
        }

    }
}
