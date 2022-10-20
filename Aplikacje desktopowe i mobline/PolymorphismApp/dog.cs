using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Dog
    {
        private string name;
        private byte age ;
            public Dog()
        {
            name = "azor";
            age = 10;
        }
        public Dog(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }
        public Dog(Dog dogToCopy)
        {
            name = dogToCopy.name;
        }
        public void ShowInfo()
        {
            Console.WriteLine("*********************************"); 
            Console.WriteLine("pies o imieniu " + name + "ma " + age);
            Console.WriteLine("*********************************");
        }
        public void Bark()
        {
            
            Console.WriteLine("pies o imieniu" + name + "szczeka");
          
        }
        public void ChasePostman()
        {
            Console.WriteLine("pies o imi9eniu " + name + "goni listonosza");
        }
    }

}
