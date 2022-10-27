using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Dog :Animal//w c# nie okresla sie czy dziedziczenie publiczne
    {
      
            public Dog()//:base() ==to jest domyslne //C# może dziedziczyc tyko jedną klase
        {
            name = "azor";
            //age = 10;
        }
        public Dog(string name, byte age) : base()
        {
      //      this.name = name;
     //       this.age = age;
        }
        public Dog(Dog dogToCopy) : base(dogToCopy)
        {
       //     name = dogToCopy.name;
        //    age = dogToCopy.age;

            // age = 2; krostruktor kopiujacy nie musi miec 
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
