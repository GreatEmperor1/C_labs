using System;
using System.Collections.Generic;
using System.Linq;
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

        }
    }
}
