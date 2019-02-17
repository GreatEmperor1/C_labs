using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class CCargo
    {
        private String name;
        private String type;
        private CCarriage carriage;

        //constructors
        public CCargo()
        {
            this.name = "DEFAULT_CARGO_NAME";
            this.type = "DEFAULT_CARGO_TYPE";
        }

        public CCargo(String name, String type)
        {
            this.name = name;
            this.type = type;
            this.carriage = null;
        }

        public CCargo(String name, String type, CCarriage carriage)
        {
            this.name = name;
            this.type = type;
            this.carriage = carriage;
        }

        public void setCargoName(String name)
        {
            this.name = name;
        }

        public String getCargoName()
        {
            return this.name;
        }

        public void setCargoType(String type)
        {
            this.type = type;
        }

        public String getCargoType()
        {
            return this.type;
        }

        public void setCargoCarriage(CCarriage carriage)
        {
            this.carriage = carriage;
        }

        public CCarriage getCargoCarriage()
        {
            return this.carriage;
        }


    }
}
