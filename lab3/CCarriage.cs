using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class CCarriage
    {
        private int number;
        private String type;
        private CCargo cargo;

        //constructors
        public CCarriage()
        {

        }

        public CCarriage(int number, String type)
        {
            this.number = number;
            this.type = type;
            this.cargo = null;
        }

        public CCarriage(int number, String type, CCargo cargo)
        {
            this.number = number;
            this.type = type;
            this.cargo = cargo;
        }

        //GET/SET
        public void setNumber(int number)
        {
            this.number = number;
        }

        public int getNumber()
        {
            return this.number;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public String getType()
        {
            return this.type;
        }

        public void setCargo(CCargo cargo)
        {
            this.cargo = cargo;
        }

        public CCargo getCCaro()
        {
            return this.cargo;
        }

    }
}
