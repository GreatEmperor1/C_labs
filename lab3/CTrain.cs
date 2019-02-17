using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class CTrain
    {
        private int trainNumber;
        private String trainName;
        private CCarriage[] trainCarriages;

        //constructors
        public CTrain()
        {
            this.trainNumber = 0;
            this.trainName = "DEFAULT_NAME";
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

    }
}
