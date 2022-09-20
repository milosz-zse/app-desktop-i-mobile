using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Person
    {
        // ctrl k d układa ładnie kod
        private string name;
        private string surname;
        private int age;

        public Person() // ctor i 2 razy tab aby zorbic konstruktor 
        {
            name = "Miłosz";// crtl r r wtedy zamieniasz wszyskie zaznaczone nazy 
            surname = "Michta";
            age = 30;

        }
        public Person(string i, string n, int w)
        {
            i = name;
            n = surname;
            w = age;

        }
        public void ShowInfo()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine($"Imie:{name}");
            Console.WriteLine($"nazwisko:{surname}");
            Console.WriteLine($"wiek:{age}");
            Console.WriteLine("********************************************");

        }
        public void SetSurnname(string newSurname)
        {
            if (newSurname != "")
            {
                surname = newSurname;
            }
            else 
            {
               // throw naw Excrption("łze nazwisko")
            }

        }
        public string GetSurname()
        {
            return surname;
        }
    }
}
