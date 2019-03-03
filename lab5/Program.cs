using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            IncreaseCost[] applications = new IncreaseCost[4];
            IncreaseCost app0 = new Game("Heroes3", 15, 200, "No license");
            IncreaseCost app1 = new Game("Disciples", 5, 500, "Official license");
            IncreaseCost app2 = new Software("Util_1", 0, 30);
            IncreaseCost app3 = new Software("Util_1", 0, 40);

            applications[0] = app0;
            applications[1] = app1;
            applications[2] = app2;
            applications[3] = app3;

            foreach(IncreaseCost app in applications)
            {
                if (app is DecreaseCost)
                {
                    Console.WriteLine("*************************************************************");
                    ((DecreaseCost)app).decreaseCost();
                    ((DecreaseCost)app).information();
                    ((DecreaseCost)app).statistic();
                    Console.WriteLine("*************************************************************");
                }
            }

            //Сортировка массива, используя стандартный метод Sort.Array
            //и интерфейс IComparable (в Software).
            Console.WriteLine();
            Array.Sort(applications);
            foreach (Software app in applications)
            {
                Console.WriteLine(app.getName());
            }

            //Сортировка, используя интерфейс IComparer. 
            Console.WriteLine();
            Console.WriteLine(new SoftwareCostComparer().Compare((Software)applications[0], (Software)applications[1]));
            Console.WriteLine();
            Console.WriteLine(new SoftwareNameComparer().Compare((Software)applications[2], (Software)applications[3]));

        }
    }
}
