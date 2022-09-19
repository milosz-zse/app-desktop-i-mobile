using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class FirstPerson
    {
        // ctrl k d układa ładnie kod
        private string person;
        private string LastName;
        private int age;

        public FirstPerson() // ctor i 2 razy tab aby zorbic konstruktor 
        {
            person = "adam";// crtl r r wtedy zamieniasz wszyskie zaznaczone nazy 
            LastName = "Michta";
            age = 30;

        }
        public FirstPerson(string i, string n, int w)
        {
            i = person;
            n = LastName;
            w = age;

        }
        public void ShowInfo()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine($"Imie:{name}");
            Console.WriteLine($"nazwisko:{LastName}");
            Console.WriteLine($"wiek:{age}");
            Console.WriteLine("********************************************");

        }

    }
}
