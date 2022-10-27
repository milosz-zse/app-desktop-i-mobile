using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Cat:Animal
    {
        public Cat()
        {
            name = " puszek ";
            // age = 10;
            type = "kot";
        }
        public Cat(string name, byte age):base(name, age)
        {
            type = "kot";
        }
        public Cat(Cat CatToCopy):base (CatToCopy)
        {
           

            // age = 2; krostruktor kopiujacy nie musi miec 
        }

        public void Meow()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("kot o imieniu" + name + " miałczy");
        }
        public void ClaimOnTree()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("kot o imieniu" + name + " wchodzi na dzrewo");
   
        }
 }
}
