using SchoolApp.database;
using SchoolApp.database.entities;
using SchoolApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class School
    {
        private SchoolDatabaseContext schoolDatabaseContext = new SchoolDatabaseContext();
        public void Run()
        {
            while (true)
            {
                ShowMenu();
                int chosenOption = GetOption();
                
                switch (chosenOption)
                {
                    case 1:
                        //metoda
                        CreateNewSchoolClass();
                        break;
                    case 2:
                        ReadAllSchoolClasses();
                        break;
                    case 3:
                        DeleteSchoolClass();
                        break;

                    case 0:
                        return;

                    default :
                        break;

                }
            }
        }
        private int GetOption()
        {
            int option;
            do
            {
                Console.WriteLine("wybierz opcje");
            } while (!int.TryParse(Console.ReadLine(), out option));

            return option;
        }


        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("wybierz opcje");
            Console.WriteLine("1.Dodaj nową klase w szkole");
            Console.WriteLine("2. wyświetl wszystkie klasy w szkole ");
            Console.WriteLine("3. Usuń klase w szkole");
            Console.WriteLine("0.Koniec Programu");
        }
        private void CreateNewSchoolClass()
        {
            Console.WriteLine("Podaj nazwe klawsy:");
            string className = Console.ReadLine();

            SchoolClass schoolClass = new SchoolClass()
            {
                Name = className
            };
            schoolDatabaseContext.SchoolClasses.Add(schoolClass);// dodaje tylko lokalnie (nie idzie do bazy danych)
            schoolDatabaseContext.SaveChanges();//wysłanie do bazy danych

        }
        private void ReadAllSchoolClasses()
        {
            foreach (SchoolClass schoolClass in schoolDatabaseContext.SchoolClasses)
            {
                Console.WriteLine("Id: " + schoolClass.Id + " Nazwa: " + schoolClass.Name);
            } 
            Console.ReadKey();
        }
        private void DeleteSchoolClass()
        {
            Console.WriteLine("Podaj Id klasy: ");
            if(int.TryParse(Console.ReadLine(),out int idSchoolClassToDelete))
            {
                Console.WriteLine( "Nie podałeś poprwnej danej");
                Console.ReadKey();
                return;
            }
            SchoolClass SchoolClassToDelete = schoolDatabaseContext.SchoolClasses.FirstOrDefault(sc => sc.Id == idSchoolClassToDelete);  // przypiszemy ścieszke do bd  gdzie pobieramy 1 rekord 
            if (SchoolClassToDelete != null) {
                schoolDatabaseContext.SchoolClasses.Remove(SchoolClassToDelete);
                schoolDatabaseContext.SaveChanges();
                Console.WriteLine("udało się usunąć ");
             }
        }
    }
}
