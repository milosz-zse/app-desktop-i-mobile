using System;

namespace PolymorphismApp
    // dry dont repeat yourself
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            Dog secondDog = new Dog("burek", 5);


            Dog thieDog = new Dog(secondDog);

            firstDog.ShowInfo();
            secondDog.Bark();
            thieDog.ChasePostman();

            Cat firstCat = new Cat("Mruczek", 12);
            firstCat.ShowInfo();
            firstCat.Meow();
            firstCat.ClaimOnTree();

        }
    }
}
