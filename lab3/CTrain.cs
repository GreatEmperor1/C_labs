using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class CTrain
    {
        public delegate void MethodContainer3(int j, string k);
        public delegate void MethodContainer4(object someObject);
        public event EventHandler onArrival; //событие с параметрами
        public event Action onDeparture;     //событие без параметров

        private int trainNumber;
        private String trainName;
        private CCarriage[] trainCarriages;

        //constructors
        public CTrain()
        {
            this.trainNumber = 0;
            this.trainName = "DEFAULT_NAME";
            CCarriage carriage3 = new CCarriage(3, "For food");
            CCargo cargo3 = new CCargo("Food", "Cargo with food");
            carriage3.setCargo(cargo3);
            cargo3.setCargoCarriage(carriage3);
            this.trainCarriages = new CCarriage[1] {carriage3};  //КОМПОЗИЦИЯ
        }

        public CTrain(int number, String name)
        {
            this.trainNumber = number;
            this.trainName = name;
            this.trainCarriages = null;
        }

        public CTrain(int number, String name, CCarriage[] carriages)
        {
            this.trainNumber = number;
            this.trainName = name;
            this.trainCarriages = carriages;
        }

        //GET/SET
        public void setTrainNumber(int number)
        {
            this.trainNumber = number;
        }

        public int getTrainNumber()
        {
            return this.trainNumber;
        }

        public void setTrainName(String name)
        {
            this.trainName = name;
        }

        public String getTrainName()
        {
            return this.trainName;
        }

        public void setTrainCarriages(CCarriage[] carriages)
        {
            this.trainCarriages = carriages;
        }

        public CCarriage[] getTrainCarriages()
        {
            return this.trainCarriages;
        }

        //-----------------------------------------------------------------------------------------------------------------------

        public void TakeTime(DateTime now) //во время работы этого метода будут вызываться события
        {
            if (now.Hour >= 8)
            {
                onDeparture?.Invoke(); //генерируем оповещение
            }
            else
            {
                onArrival?.Invoke(this, null); //генерируем оповещение; вместо null можно передавать доп.параметры
            }
        }

        public String trainInfo() //будем вызывать в анонимном делегате
        {
            return this.trainNumber.ToString() + " " + this.trainName;
        }

        public void infoChanger(int j, string k)
        {
            this.trainNumber = j;
            this.trainName = k;
        }

        //обработчики событий
        public static void Tr1_onArrival(object sender, EventArgs e) //обработчик события с параметрами
        {
            if (sender is CTrain) //безопасное приведение sender к CTrain
            {
                Console.WriteLine($"{((CTrain)sender).getTrainName()} находится в депо.");
            }
        }

        public static void Tr1_onDeparture() //обработчик события без параметров
        {
            Console.WriteLine("Поезд в пути. Перевозит " + CCargo.cargoInfo()); //вызов статического метода из CCargo

        }


    }
}
