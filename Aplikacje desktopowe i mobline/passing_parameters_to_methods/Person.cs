using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_parameters_to_methods
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
        public person()
        {
            name = "Adam";
            surname = "Nowak";
            age = 30;
        }
        public person(string i, string n, int w)
        {
            name = i;
            surname = n;
            age = w;
        }
        public void showInfo()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
            Console.WriteLine("*******************************");
        }
        public void setSurname(String newSurname)
        {
            if (newSurname != "")
            {
                surname = newSurname;
            }
            else
            {
                throw new Exception("Nazwisko zakazane");
            }
        }
        public string getSurname()
        {
            return surname;
        }

    }



    }
