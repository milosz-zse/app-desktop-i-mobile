using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersToMethod
{
    class Person
    {
        private string name;
        private string surname;

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Person()
        {
            name = "Adam";
            surname = "Nowak";
            age = 30;
        }

        public Person(string i, string n, int w)
        {
            name = i;
            surname = n;
            age = w;
        }

        public void ShowInfo()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine($"Imie: {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
            Console.WriteLine("********************************************");
        }

    }
}