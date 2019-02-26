using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public sealed class MyApplication : Antivirus
    {

        private String Info = "This is my custom application";

        //конструктор, принимает : base (name, programmingLanguage, bitRate, programmType, hasLicense)
        public MyApplication(String name, String programmingLanguage, int bitRate, String programmType, bool hasLicense) : base (name, programmingLanguage, bitRate, programmType, hasLicense)
        {

        }

        public override void showSoftwareDetails()
        {
            //throw new NotImplementedException();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("This is MyApplication : " + this.name);
            Console.WriteLine("Type of this programm is : " + this.programmType);
            Console.WriteLine("MyApplication license is : " + this.hasLicense);
            Console.WriteLine("Info : " + this.Info);
            Console.WriteLine("*******************************************************");
        }

        public override void method1()
        {
            Console.WriteLine("This is MyApplication method1");
        }

        //вызов метода родительского класса при его скрытии
        //new скрывае method2() из Antivirus
        new public void method2()
        {
            Console.WriteLine("This is MyApplication method2");
        }

    }
}
