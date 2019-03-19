using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class CTrain
    {
        public delegate void MethodContainer();
        public event EventHandler onArrival;
        public event Action onDeparture;
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

        public void TakeTime(DateTime now)
        {
            if (now.Hour >= 8)
            {
                onDeparture?.Invoke();
            }
            else
            {
                onArrival?.Invoke(this, null);
            }
        }

    }
}
