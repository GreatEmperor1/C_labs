using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void f1(ref DirectoryInfo d)
        {// установить текущий диск/каталог
            d = new DirectoryInfo(".");
        }
        static void f2(DirectoryInfo d)
        {// вывод списка всех каталогов в текущем (пронумерованный)
            foreach (var item in d.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
        }
        static void f3(DirectoryInfo d)
        {// вывод списка всех файлов в текущем каталоге (пронумерованнный)

        }
        static void f4(DirectoryInfo d)
        {// вывод на экран содержимого указанного файла (по номеру)
            f3(d);
            Console.WriteLine("Введите номер файла:");
            int index = Convert.ToInt32(Console.ReadLine());
            FileInfo[] files = d.GetFiles();
            if (files[index].Extension != ".txt")
            {
                Console.WriteLine("Это не текстовый файл!");
                return;
            }
            StreamReader sr = new StreamReader(files[index].FullName);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
        }
        static void f5(DirectoryInfo d)
        {// создание каталога в текущем
        }
        static void f6(DirectoryInfo d)
        {// удаление каталога по номеру, если он пустой

        }
        static void f7(DirectoryInfo d)
        {// удаление файлов с указанными номерами
            f3(d);
            Console.WriteLine("Введите номера первого и последнего файлов для удаления:");
            int index1 = Convert.ToInt32(Console.ReadLine());
            int index2 = Convert.ToInt32(Console.ReadLine());

            FileInfo[] files = d.GetFiles();
            if (index1 > index2 || index2 >= files.Length)
            {
                Console.WriteLine("неверные номера файлов");
                return;
            }
            for (int i = index1; i <= index2; i++)
                files[i].Delete();
            Console.WriteLine(index2 - index1 + 1 + " файлов удалено");
            f3(d);
        }
        static void f8(DirectoryInfo d)
        {// вывод списка всех файлов с указанной датой создания (ищет в текущем каталоге и подкаталогах)

        }
        static void f9(DirectoryInfo d)
        {// вывод списка всех текстовых файлов, в которых содержится указанный текст (ищет в текущем каталоге и подкаталогах)
            Console.WriteLine("Введите текст для поиска в файлах");
            string str = Console.ReadLine();
            FileInfo[] files = d.GetFiles("*", SearchOption.AllDirectories);
            int i = 0;
            foreach (FileInfo x in files)
            {
                if (x.Extension != ".txt") continue;
                StreamReader sr = new StreamReader(x.FullName);
                string buf = sr.ReadToEnd();
                if (buf.Contains(str))
                    Console.WriteLine(++i + ")" + x.DirectoryName + "\\" + x.Name);
            }
        }





        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\");         // текущий каталог
            try
            {
                while (true)
                {
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("*             Главное меню                         *");
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("1 – установить текущий диск/каталог");
                    Console.WriteLine("2 – вывод списка всех каталогов в текущем");
                    Console.WriteLine("3 – вывод списка всех файлов в текущем каталоге");
                    Console.WriteLine("4 – вывод на экран содержимого указанного файла ");
                    Console.WriteLine("5 – создание каталога в текущем");
                    Console.WriteLine("6 – удаление каталога по номеру, если он пустой");
                    Console.WriteLine("7 – удаление файлов с указанными номерами");
                    Console.WriteLine("8 – вывод списка всех файлов с указанной датой создания");
                    Console.WriteLine("9 – вывод списка всех текстовых файлов, в которых текст");
                    Console.WriteLine("0 – выход");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            f1(ref dir);
                            break;
                        case 2:
                            f2(dir);
                            break;
                        case 3:
                            f3(dir);
                            break;
                        case 4:
                            f4(dir);
                            break;
                        case 5:
                            f5(dir);
                            break;
                        case 6:
                            f6(dir);
                            break;
                        case 7:
                            f7(dir);
                            break;
                        case 8:
                            f8(dir);
                            break;
                        case 9:
                            f9(dir);
                            break;
                        case 0: return;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Неверное имя файла");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Неверное имя каталога");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка " + e.Message);
            }
        }
    }
}
