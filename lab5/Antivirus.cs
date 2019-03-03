using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Antivirus : DecreaseCost
    {
        private String name;
        private int missedBugs;
        protected double cost;

        public Antivirus(String name, int missedBugs, double cost)
        {
            this.name = name;
            this.missedBugs = missedBugs;
            this.cost = cost;
        }

        public void decreaseCost()
        {
            this.cost = this.cost - 50;
            Console.WriteLine("Cost : " + this.cost);
        }

        public void information()
        {
            Console.WriteLine("Antivirus cost " + this.name + " " + " = " + this.cost);
        }

        public void statistic()
        {
            Console.WriteLine("Cost statistic for Antivirus " + this.name + " " + " = " + this.missedBugs / this.cost);
        }

        public void info()
        {
            Console.WriteLine("Name " + this.name);
            Console.WriteLine("Missed bugs " + this.missedBugs);
            Console.WriteLine("Cost " + this.cost);
        }

    }
}
