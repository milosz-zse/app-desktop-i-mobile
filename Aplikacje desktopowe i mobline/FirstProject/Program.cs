using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "jan";
            string nazwisko= "kowalski";
            //nazwisko.Length
            Console.WriteLine("witaj"+nazwisko+" "+imie+"tutaj");
            Console.WriteLine("witaj {0},{1} tutaj",imie,nazwisko);
            Console.WriteLine($"witaj {imie},{nazwisko} tutaj");

            Console.WriteLine("Prętkość to km\\h");//zanak "\ " jest specjany  i program nie działa jak użyje się 2 razy \ to zadziała
            Console.WriteLine(@"Prętkość to km\h");//można zamiast 2 razy \ można wstawić @ przed tekstem 

            int LiczbaCalkowita=5;
            double LiczbaRzeczywista=6.6;

            Person FirstPerson = new Person();
            FirstPerson.ShowInfo();

            Person seconPerson= FirstPerson;
            seconPerson.ShowInfo();

            Person thirdPerson = new Person("ala", "kowalska", 52);
            thirdPerson.ShowInfo();

            thirdPerson.SetSurnname("nowakowska");
            thirdPerson.ShowInfo();


            //string data = thirdPerson.GetSurname;
            //dana = thirdPerson.surname;

            //thirdPerson.Age=50 jest źle
            int d = thirdPerson.Age;


        }
    }
}
