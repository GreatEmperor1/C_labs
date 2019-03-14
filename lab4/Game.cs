using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab4
{
    [Serializable]
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

        public void printGame()
        {
            Console.WriteLine("Game name = " + getName() + "\n" + "Language = " + getProgramingLanguage() + "\n" + "Bit rate = " + getBitRate() + "\n" + "Hardware required = " + this.hardwareRequirements + "\n" + "OS type = " + this.typeOS);
        }


        public static void SaveClass(string filename)
        {
            Type t = typeof(Game);
            StreamWriter f = new StreamWriter(filename);
            f.WriteLine("Полное имя класса:" + t.FullName);
            if (t.IsAbstract) f.WriteLine("Абстрактный класс");
            if (t.IsClass) f.WriteLine("Обычный класс");
            if (t.IsInterface) f.WriteLine("Интерфейс");
            if (t.IsEnum) f.WriteLine("Перечисление");
            if (t.IsSealed) f.WriteLine("Закрыт для наследования");
            f.WriteLine("Базовый класс - " + t.BaseType);
            FieldInfo[] fields = t.GetFields();
            if (fields.Count() > 0)
                f.WriteLine("*** Поля класса: ***");
            foreach (var field in fields)
            {
                f.WriteLine(field);
            }
            PropertyInfo[] properties = t.GetProperties();
            if (properties.Count() > 0)
                f.WriteLine("*** Свойства класса: ***");
            foreach (var property in properties)
            {
                f.WriteLine(property);
            }
            MethodInfo[] methods = t.GetMethods();
            if (methods.Count() > 0)
                f.WriteLine("*** Методы класса: ***");
            foreach (var method in methods)
            {
                f.WriteLine(method);
            }
            f.Close();

        }
        public void SaveObject(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(name);
            bw.Write(programmingLanguage);
            bw.Write(bitRate);
            bw.Write(hardwareRequirements);
            bw.Write(typeOS);
            fs.Close();

        }
        public static Game LoadObject(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            String name = br.ReadString();
            String programmingLanguage = br.ReadString();
            int bitRate = br.ReadInt32();
            String hardwareRequirements = br.ReadString();
            String typeOS = br.ReadString();
            fs.Close();
            return new Game(name, programmingLanguage, bitRate, hardwareRequirements, typeOS);

        }
        public void Serialize(string filename)
        {
            Stream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter fmt = new BinaryFormatter();
            fmt.Serialize(fs, this);
            fs.Close();

        }
        public static Game Deserialize(string filename, FileMode open)
        {
            Stream fs = new FileStream(filename, FileMode.Open);
            BinaryFormatter fmt = new BinaryFormatter();
            Game game = (Game)fmt.Deserialize(fs);
            fs.Close();
            return game;


        }
    }
}







