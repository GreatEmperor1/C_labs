using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Store
    {
        private string storeName;
        private int numberOfSellers;
        private double summIncome;
        private double avgSalary;
        public double purchaseCost;
        public double overheadCosts;

        public string StoreName
        {

            get
            {
                return storeName;
            }
        }

        public int NumberOfSellers
        {
            get
            {
                return numberOfSellers;
            }
            set
            {
                if (value < 0)
                {
                    numberOfSellers = 1;
                    Console.WriteLine("At least one seller should be in a store! " + storeName);
                }
                else numberOfSellers = value;
            }
        }

        public double SummIncome
        {
            get
            {
                return summIncome;
            }
            set
            {
                if (value < 0)
                {
                    summIncome = value;
                    Console.WriteLine("Store " + storeName + " has no income!");
                }
                else
                {
                    summIncome = value;
                    Console.WriteLine("Our store " + storeName + " gained some money!!!!");
                }
            }
        }

        public double AvgSalary
        {
            get
            {
                return avgSalary;
            }
            set
            {
                if (value > 500)
                {
                    avgSalary = 500;
                    Console.WriteLine("It's RB baby!!!");
                }
                else
                {
                    avgSalary = value;
                }
            }
        }

        
        //конструкторы
        public Store() : this("Read Or Die", 3, 100000, 499, 1000, 30)
        { }

        public Store(string storeName, int numberOfSellers, double summIncome, double avgSalary, double purchaseCost, double overheadCost)
        {
            this.storeName = storeName;
            NumberOfSellers = numberOfSellers;
            SummIncome = summIncome;
            AvgSalary = avgSalary;
            this.purchaseCost = purchaseCost;
            this.overheadCosts = overheadCost;
        }

        public Store(int numberOfSellers, double summIncome, double avgSalary, double purchaseCost, double overheadCost)
            : this("Read Or Die", numberOfSellers, summIncome, avgSalary, purchaseCost, overheadCost)
        { }


        public Store(string storeName, int numberOfSellers, double summIncome)
            : this(storeName, numberOfSellers, summIncome, 600, 1000, 30)
        { }

        //print()
        public void Print()
        {
            Console.WriteLine("Имя магазина = " + StoreName + "\n" + "Число продавцов = " + numberOfSellers + "\n" 
                + "Суммарная выручка = " + summIncome + "\n" + "Средняя зарплата = " + avgSalary + "\n" 
                + "Стоимость закупки = " + purchaseCost + "\n" + "Накладные расходы = " + overheadCosts + "\n");
        }

        //метод для определения премии 
        public double Bonus()
        {
            double bonus = 0;
            bonus = summIncome - purchaseCost - overheadCosts / numberOfSellers;
            Console.WriteLine("Премия в магазине " + storeName + " = " + bonus + "\n");
            return bonus;
        }

        //метод, определяющий, падение рентабельности
        public bool DetectDecrease()
        {
            double income = summIncome - purchaseCost - overheadCosts;
            double rent = (summIncome * 10) / 100;
            if (income < rent)
            {
                return true;
            }
                return false;
        }

        //метод, определяющий более рентабельную фирму из двух 
        public bool CompareStores(Store n2)
        {
            double rent1 = (this.summIncome * 10) / 100;
            double rent2 = (n2.summIncome * 10) / 100;
            if (rent2 > rent1)
            {
                return false;
            }
            return true;
        }

        public static Store CompareStores2(Store n1, Store n2, Store n3)
        {
            Store result = new Store();
            double rent1 = (n1.summIncome * 10) / 100;
            double rent2 = (n2.summIncome * 10) / 100;
            double rent3 = (n3.summIncome * 10) / 100;
            if (rent1 > rent2 && rent1 > rent3)
            {
                result = n1;
                return n1;
            } else if (rent2 > rent1 && rent2 > rent3)
            {
                result = n2;
                return n2;
            } else if (rent3 > rent1 && rent3 > rent2)
            {
                result = n3;
                return n3;
            }
            return result;
        }

    }
}
