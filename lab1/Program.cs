using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store bookStore = new Store();
            Store bookStore2 = new Store("Just Read It", -2, 15000);
            Store bookStore3 = new Store("Just Read It2", 2, -15000, 777, 777, 777);
            bookStore.Print();
            bookStore2.Print();
            bookStore3.Print();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Рентабельность магазина ");
            if (bookStore.DetectDecrease())
            {
                Console.WriteLine("Рентабельность магазина " + bookStore.StoreName + " падает!");
            }
            else { Console.WriteLine("Магазин " + bookStore.StoreName + " рентабелен."); }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Рентабельность 2-х магазинов");
            if (bookStore.CompareStores(bookStore2))
            {
                Console.WriteLine("Магазин1 " + bookStore2.StoreName + " более рентабелен.");
            }
            else { Console.WriteLine("Магазин " + bookStore.StoreName + " более рентабелен."); }

            //bookStore.CompareStores(Store.CompareStores2(bookStore, bookStore2), bookStore3);

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Самый рентабельный из 3-х магазинов");
            Store.CompareStores2(bookStore, bookStore2, bookStore3).Print();

            //Console.WriteLine(bookStore.StoreName);
            //bookStore2.NumberOfSellers = -1;
            //bookStore2.Print();

            /* Создать еще одну переменную, присвоив ей один из предыдущих объектов. 
 * Продемонстрировать, что две переменные ссылаются на один объект 
 * (поменять поле в одном объекте и вывести его в другом).*/
            bookStore = bookStore3;
            bookStore.Print();
            bookStore3.SummIncome = 8000;
            bookStore.Print();
        }
    }
}
