using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Software
    {
        protected String name;
        protected String programmingLanguage;
        protected int bitRate;

        //конструктор
        public Software(String name, String programmingLanguage, int bitRate)
        {
            this.name = name;
            this.programmingLanguage = programmingLanguage;
            this.bitRate = bitRate;
        }

        //методы с реализацией
        public void setting()
        {
            Console.WriteLine("setting : " + this.name + " successfully");
        }

        public void tunning()
        {
            Console.WriteLine("tunning : " + this.name + " successfully");
        }

        //АБСТРАКТНЫЙ МЕТОД
        abstract public void showSoftwareDetails();

        //get/set
        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setProgrammingLanguage(String programmingLanguage)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public String getProgramingLanguage()
        {
            return this.programmingLanguage;
        }

        public void setBitRate(int bitRate)
        {
            this.bitRate = bitRate;
        }

        public int getBitRate()
        {
            return this.bitRate;
        }


    }
}
