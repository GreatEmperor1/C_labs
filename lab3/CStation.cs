﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class CStation
    {
        private String name;
        private String city;
        private CTrain[] trains = new CTrain[20];

        //constructors
        public CStation()
        {

        }

        public CStation(String name, String city)
        {
            this.name = name;
            this.city = city;
        }

        public CStation(String name, String city, CTrain[] trains)
        {
            this.name = name;
            this.city = city;
            this.trains = trains;
        }

        //GET/SET
        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public String getCity()
        {
            return this.city;
        }

        public void setCTrains(CTrain[] trains)
        {
            this.trains = trains;
        }

        public CTrain[] getCTrains()
        {
            return this.trains;
        }

        //print out
        public void print()
        {
            foreach (CTrain train in this.trains)
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("Train: " + train.getTrainNumber() + " " + train.getTrainName());
                foreach (CCarriage carriage in train.getTrainCarriages())
                {
                    Console.WriteLine("Carriage: " + carriage.getNumber() + " " + carriage.getType() + " " + carriage.getCCaro().getCargoName() + " " + carriage.getCCaro().getCargoType());
                }
                Console.WriteLine("****************************************************");
            }
        }

    }
}
