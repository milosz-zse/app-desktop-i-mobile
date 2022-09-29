using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_parameters_to_methods
{
    class TestingParameters
    {
        public void Test1()
        {
            byte number = 15;
            Console.WriteLine("zmienna nubmer=" + number);
            ChangeValue(number);
            ChangeValueV2(ref number);//gdy chce się na orginale pracowac 
          // ChangeValueV2(ref 6);
            Console.WriteLine("zmienna nubmer=" + number);
            int random = 0;
            GetRandomNumber(ref random);

        }
        private void ChangeValue(byte value)
        {
            Console.WriteLine("zmienna nubmer=" + value);
            value=(byte)(value+10);
             Console.WriteLine("zmienna nubmer=" + value);
            
        }
          private void ChangeValueV2( ref byte value)
        {
           Console.WriteLine("zmienna nubmer=" + value);
           value=(byte)(value+10);
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
    }
}
