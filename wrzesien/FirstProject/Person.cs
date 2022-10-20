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
        public string Name
        {
            private set
            {
                name = value;
            }
            get
            {
                return name;
            }
            
        }

        private int age;
        public int Age// properties to jest
        {
            get
            {
                return age;
            }
        }
        private string surname;
        public string Surname// properties to jest
        {
            set
            {
                if (value != "")
                    surname = value;
            }
            get
            {
                return surname;
            }
        }
        private int height;
        private int Height { get; set; }

        public Person() // ctor i 2 razy tab aby zorbic konstruktor 
        {
            name = "Miłosz";// crtl r r wtedy zamieniasz wszyskie zaznaczone nazy 
            surname = "Michta";
            age = 30;
            int aEdasdx = name.Length;// przypisanie do x długosci name

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
            Console.WriteLine("*******************************************");

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
