using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Antivirus : Software
    {
        protected String programmType;
        protected bool hasLicense;

        //конструктор
        public Antivirus(String name, String programmingLanguage, int bitRate, String programmType, bool hasLicense) : base (name, programmingLanguage, bitRate)
        {
            this.programmType = programmType;
            this.hasLicense = hasLicense;
        }

        //get/set
        public void setProgrammType(String programmType)
        {
            this.programmType = programmType;
        }

        public String getProgrammType()
        {
            return this.programmType;
        }

        public void setHasLicense(bool hasLicense)
        {
            this.hasLicense = hasLicense;
        }

        public bool getHasLicense()
        {
            return this.hasLicense;
        }

        //перегрузка метода родителя
        public override void showSoftwareDetails()
        {
            //throw new NotImplementedException();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("This is Antvirus : " + this.name);
            Console.WriteLine("Type of this programm is : " + this.programmType);
            Console.WriteLine("Antivirus license is : " + this.hasLicense);
            Console.WriteLine("*******************************************************");
        }

        //виртуальный метод
        public virtual void method1()
        {
            Console.WriteLine("This is antivirus method1");
        }

        public void method2()
        {
            Console.WriteLine("This is antivirus method2");
        }

    }
}
