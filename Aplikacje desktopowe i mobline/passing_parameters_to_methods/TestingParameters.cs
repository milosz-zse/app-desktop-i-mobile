using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_parameters_to_methods
{
    struct PersonSturct 
    {
        public string name;
        public string surname;
        public int age;

    }
    class TestingParameters
    {
       #region "ref" and "out"
        public void Test1()
        {
            byte number = 15;
            Console.WriteLine("zmienna nubmer=" + number);
            ChangeValue(number);
            ChangeValueV2(ref number);//gdy chce się na orginale pracowac można uzyć  out gdy go uzywamy
                                      //można uzyć  out gdy go uzywamy zmienna nie musi miec przypisanej wartości
                                      //przez to jak chcemy uzyc np random to trzeba uzyc out

            // ChangeValueV2(ref 6);
            Console.WriteLine("zmienna nubmer=" + number);
            int random = 0;
            GetRandomNumber(ref random);

        }
        private void ChangeValue(byte value)
        {
            Console.WriteLine("zmienna nubmer=" + value);
            value = (byte)(value + 10);
            Console.WriteLine("zmienna nubmer=" + value);

        }
        private void ChangeValueV2(ref byte value)
        {
            Console.WriteLine("zmienna nubmer=" + value);
            value = (byte)(value + 10);
            Console.WriteLine("zmienna nubmer=" + value);

        }
        private int GetRandomNumber()
        {
            return new Random().Next();
        }
        private void GetRandomNumber(ref int value)
        {
            value = new Random().Next();
        }
        #endregion
       #region skrót
        // public TestingParameters()//ctor + tab+tab tworzy 
        // {

        // }
        #endregion
        #region
        public void Test2()
        {
            Person person = new Person();
            person.ShowInfo();
            GetPerson(person)
            person.ShowInfo();

        }
        private void GetPerson(Person p)
        {
            p.ShowInfo();
            p.Age = 40;
            p.ShowInfo();
        }

        #endregion

        #region przekazywanie struktor 
        public void test3()
        {
            PersonSturct ps = new PersonSturct();
            ps.name = "adam";       

        }
        #endregion
    }
}
