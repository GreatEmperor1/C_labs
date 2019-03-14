using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Software app1 = new Game("Disciples III", "C#", 64, "hardware1", "Windows");
            Software app2 = new Antivirus("ESET NOD32", "java", 64, "PC protection", true);
            Software app3 = new MyApplication("PLEX Mobile", "java", 64, "Enterprise", false);
            
            Software[] applications = new Software[3];
            applications[0] = app1;
            applications[1] = app2;
            applications[2] = app3;

            foreach (Software app in applications)
            {
                app.setting();
                app.tunning();
                app.showSoftwareDetails();
            }

            Console.WriteLine();
            Console.WriteLine("*********************************************************");

            //вызов метода родительского класса при его скрытии
            foreach (Software app in applications)
            {
                if (app is Antivirus)
                {
                    ((Antivirus)app).method1();
                    ((Antivirus)app).method2();
                }
            }

            Console.WriteLine("*********************************************************");

            foreach (Software app in applications)
            {
                if (app is MyApplication)
                {
                    ((MyApplication)app).method1();
                    ((MyApplication)app).method2();
                }
            }
            Console.WriteLine("*********************************************************");
            ((Antivirus)app2).method1();
            ((Antivirus)app2).method2();
            ((Antivirus)app3).method1();
            ((Antivirus)app3).method2();
            //Antivirus app4 = new Antivirus("ESET NOD32", "java", 64, "PC protection", true);
            //MyApplication app5 = new MyApplication("PLEX Mobile", "java", 64, "Enterprise", false);
            //app4.method1();
            //app4.method2();
            //app5.method1();
            //app5.method2();
            Console.WriteLine("7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/7.2/ \n");


            Game g1 = new Game("Disciples III", "C#", 64, "hardware1", "Windows");
            Console.WriteLine("Вывод только что созданной игры");
            g1.printGame();
            Console.WriteLine();

            Game.SaveClass("game.txt");
            Console.WriteLine("Сохранили информацию о классе");
            Console.WriteLine();

            g1.SaveObject("game1.bin");        // сохранили в файл информацию об объекте
            Console.WriteLine("Сохранили информацию об объекте");
            Console.WriteLine();

            g1.setName("Heroes3");
            g1.setBitRate(32);                       // изменили объект
            Console.WriteLine("Изменили игру:");
            g1.printGame();                  // вывели игру
            Console.WriteLine();

            g1 = Game.LoadObject("game1.bin"); // прочитали объект
            Console.WriteLine("Прочитали сохраненное значение игры");
            g1.printGame();                  // вывели игру
            Console.WriteLine();

            Stream fs = File.Open("game2.bin", FileMode.Create); //если нет файла - создаём
            BinaryFormatter fmt = new BinaryFormatter();
            fmt.Serialize(fs, g1);
            fs.Close();
            Console.WriteLine("Сериализовали игру");
            Console.WriteLine();

            g1.setName("King's Bounty");
            g1.setBitRate(64);                       // изменили объект
            Console.WriteLine("Изменили игру:");
            g1.printGame();                  // вывели игру
            Console.WriteLine();


            fs = File.Open("game2.bin", FileMode.Open);
            fmt = new BinaryFormatter();

            g1 = (Game)fmt.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Десериализовали игру:");
            g1.printGame();                  // вывели игру





        }
    }
}
