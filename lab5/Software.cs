using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Software : IncreaseCost, IComparable
    {
        protected String name;
        protected int bugs;
        protected double cost;

        public Software(String name, int bugs, double cost)
        {
            this.name = name;
            this.bugs = bugs;
            this.cost = cost;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        public void setBugs(int bugs)
        {
            this.bugs = bugs;
        }

        public int getBugs()
        {
            return this.bugs;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public double getCost()
        {
            return this.cost;

        }

        public void increaseCost()
        {
            this.cost = this.cost + 100;
            Console.WriteLine("Cost : " + this.cost);
        }

        public void information()
        {
            Console.WriteLine("Sotware cost " + this.name + " " + " = " + this.cost);
        }

        public void statistic()
        {
            Console.WriteLine("Cost statistic for software " + this.name + " " + " = " + this.bugs / this.cost);
        }

        public void info()
        {
            Console.WriteLine("Name " + this.name);
            Console.WriteLine("Bugs " + this.bugs);
            Console.WriteLine("Cost " + this.cost);
        }

        public int CompareTo(object obj)
        {
            Software tmp = (Software)obj; //obj as Software;
            if (tmp != null)
            {
                return this.name.CompareTo(tmp.name);
            }
            else
            {
                throw new ArgumentException("Object is not a Software!");
            }
        }
    }
}
