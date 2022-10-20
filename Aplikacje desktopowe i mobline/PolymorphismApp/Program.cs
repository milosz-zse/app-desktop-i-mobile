using System;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            Dog secondDog = new Dog("burek", 5);


            Dog thieDog = new Dog(secondDog);
            
        }
    }
}
