using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Game : Software, DecreaseCost
    {
        private String licenseAgreement;

        public Game(String name, int bugs, double cost, String licenseAgreement) : base(name, bugs, cost)
        {
            this.licenseAgreement = licenseAgreement;
        }

        public void setLicenseAgreement(String licenseAgreement)
        {
            this.licenseAgreement = licenseAgreement;
        }

        public String getLicenseAgreement()
        {
            return this.licenseAgreement;
        }

        public void decreaseCost()
        {
            this.cost = this.cost - 50;
            Console.WriteLine("Cost : " + this.cost);
        }

        // склеивание info() общий метод для двух интерфейсов
        public void info()
        {
            base.info();
            Console.WriteLine("License Agreement " + this.licenseAgreement);
        }

        // явное указание интерфейса(кастинг)
        void DecreaseCost.information()
        {
            Console.WriteLine("Game cost " + this.name + " " + " = " + this.cost);
        }

        void DecreaseCost.statistic()
        {
            Console.WriteLine("Cost statistic for game " + this.name + " " + " = " + this.bugs / this.cost);
        }

        // кастинг + обертывание
        public void statisticDecreaseCost()
        {
            ((DecreaseCost)this).statistic();
        }

        public void statisticIncreaseCost()
        {
            ((IncreaseCost)this).statistic();
        }


    }
}
