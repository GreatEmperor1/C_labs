using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Chars arr = new Chars(new char[] { 's', 't', 'a', 'c', 'k', '*' });
            //Console.WriteLine("--------Индексирование---------");
            //Console.WriteLine(arr[2]);
            //arr[2] = 'd';
            //Console.WriteLine(arr[2]);
            arr.PrintArray();
            Chars arr2 = new Chars(new char[] {'o', 'v', 'e', 'r', 'f', 'l', 'o', 'w' });
            arr2.PrintArray();


            Console.WriteLine("--------Создаём массив с контролем корректности вводимых значений---------");
            Chars arr3 = new Chars(new char[] { '*', 'a', 'z', 'a', 'z', 'a', '*' });       
            arr3.PrintArray();

            Chars a = new Chars();
            a.addCharacter('d');
            a.addCharacter('H');
            a.addCharacter('J');
            a.addCharacter('j');
            a.addCharacter('r');
            a.addCharacter('w');

            a.addCharacter('4');
            a.addCharacter('4');
            a[8] = '4';
            a.PrintArray(); 

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(arr);
            Console.WriteLine(arr2);
            Console.WriteLine(arr3);

            Console.WriteLine("--------Перегруженный оператор + ---------");
            Console.WriteLine("\nМассив '{0}'   плюс   '{1}'", arr3, arr);
            arr3 = arr3 + arr;
            arr3.PrintArray();

            Console.WriteLine("--------Перегруженный оператор - ---------");
            Console.WriteLine("\nМассив '{0}'   минус   '{1}'", arr3, arr);
            arr3 = arr3 - arr;
            Console.WriteLine(arr3);

            Console.WriteLine("--------Перегруженный оператор * ---------");
            Console.WriteLine("\nПересечение '{0}'  и  '{1}'", arr2, a);
            arr2 = arr2 * a;
            //arr.PrintArray();
            //arr2.PrintArray();
            //arr3.PrintArray();
            Console.WriteLine("\nРезультат пересечения = {0}", arr2);

            Console.WriteLine("----------------------------------------------------------------");
            Chars arr4 = new Chars(new char[] { '*', 'a', 'z', 'a', 'z', 'a', '*' });
            Chars arr5 = new Chars(new char[] { '*', 'a', 'z', 'a', 'z', 'a', '*' });
            
            Console.WriteLine("--------Сравнение массивов == и != ---------");
            Console.WriteLine(arr4 == arr5);
            Console.WriteLine(arr4 != arr5);

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("--------Перегруженный true и false ---------");
            Chars arr6 = new Chars();
            //arr6.ArrayContent = new char[] { '*' };
            if (arr6)
            {
                Console.WriteLine("Множество не пустое");
            }
            else { Console.WriteLine("Множество пустое"); }

            Console.WriteLine("----------------------------------------------------------------");
            Chars new_str = new Chars(new char[] { 'o', 'v', 'e', 'r'});
            new_str.PrintArray();
            Console.WriteLine("--------В string неявно ---------");
            string str = "a";
            str = new_str;
            Console.WriteLine(str);
            Console.WriteLine("--------Из string назад явно ---------");
            Chars new_str2 = new Chars();
            new_str2 = (Chars)str;
            new_str2.PrintArray();

        }
    }
}
