using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollection
{
    class ArrayTest
    {
        public void Test()
        {
            /* !!!!!!!!!!!!!!! tablice maja staly rozmiar !!!!!!!!!!!!!!!!!!!!!
             *   C++
             *   int tab[5] wielkosc 5  musi to byc stała 
             *   tab[2]=77 jak chcemy odwołac sie do 3 komurki | *(tab +2)=77
             *   
             *   C#      tablica jest obiektem (array obiekt)c
             *    tab //tab to nazwa 
             */
            int[] tab = new int[5];//int[] tab to wskaźnik    dopiero  = new int[5]; tworzy tablice 
            // tab= new int[8] utworzenie nowej tablicy (nie usuwajac wczesniejszej ktora ma 8 pol)
            tab[2] = 77; //do 3 elementu przypisujemy 77;
            for (int i = 0; i < tab.Length; i++)//  tab.Length wielkosc tablicy ponieważ jest obiektem  
            {
                tab[i] = 2;// przypisanie do kazdego pola  liczbe 2 
            }

        }
    }
}
