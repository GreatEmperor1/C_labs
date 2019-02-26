using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Game : Software
    {

        private String hardwareRequirements;
        private String typeOS;

        //вызов конструктора родительского класса при наследовании
        //конструктор, принимающий : base(name, programmingLanguage, bitRate) из базового класса 
        public Game(String name, String programmingLanguage, int bitRate, String hardwareRequirements, String typeOS) : base(name, programmingLanguage, bitRate)
        {
            this.hardwareRequirements = hardwareRequirements;
            this.typeOS = typeOS;
        }

        //get/set
        public void setHardwareRequirements(String hardwareRequirements)
        {
            this.hardwareRequirements = hardwareRequirements;
        }

        public String getHardwareRequirements()
        {
            return this.hardwareRequirements;
        }

        public void setTypeOS(String typeOS)
        {
            this.typeOS = typeOS;
        }

        public String getTypePs()
        {
            return this.typeOS;
        }

        //перегрузка метода родителя
        public override void showSoftwareDetails()
        {
            //throw new NotImplementedException();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("This is a Game : " + this.name);
            Console.WriteLine("Required hardware is : " + this.hardwareRequirements);
            Console.WriteLine("Required OS Type : " + this.typeOS);
            Console.WriteLine("*******************************************************");
        }

    }
}
