using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        delegate void MethodContainer(CTrain x);
        delegate string MethodContainer2(CTrain x);

        static void Main(string[] args)
        {
            #region lab 3 execution
            //грузы
            CCargo cargo1 = new CCargo("Machinegun","light");
            CCargo cargo2 = new CCargo("Tank","Heavy");

            //вагоны
            CCarriage carriage1 = new CCarriage(1, "For light cargo");
            CCarriage carriage2 = new CCarriage(2, "For heavy cargo");

            cargo1.setCargoCarriage(carriage1);
            carriage1.setCargo(cargo1);
            cargo2.setCargoCarriage(carriage2);
            carriage2.setCargo(cargo2);

            //массив вагонов 1 + поезд1
            CCarriage[] carriagesHeavy = new CCarriage[2];
            carriagesHeavy[0] = carriage2;
            carriagesHeavy[1] = carriage2;
            CTrain train1 = new CTrain(1, "MINSK-MOSCOV", carriagesHeavy);

            //массив вагонов 2 + поезд 2
            CCarriage[] carriagesLight = new CCarriage[3];
            carriagesLight[0] = carriage1;
            carriagesLight[1] = carriage1;
            carriagesLight[2] = carriage1;
            CTrain train2 = new CTrain(2, "МИНСК-ЮРМАЛА", carriagesLight);

            //композиция(массив вагонов trainCarriages создаётся при создании поезда)
            CTrain train3 = new CTrain();
            
            
            //массив поездов, для станции
            CTrain[] trains = new CTrain[3];
            trains[0] = train1;
            trains[1] = train2;
            trains[2] = train3;
            //станция
            CStation station = new CStation("Station1", "Minsk", trains);

            station.print();
            #endregion

            CTrain tr1 = new CTrain();
            tr1.onDeparture += CTrain.Tr1_onDeparture; //подписываемся на событие
            tr1.onArrival += CTrain.Tr1_onArrival;     //подписываемся на событие
            tr1.TakeTime(DateTime.Parse("19.03.2019 06:30:00"));
            tr1.TakeTime(DateTime.Parse("19.03.2019 08:30:00"));


             
            MethodContainer container = delegate (CTrain x) //определяем переменную делегата и передаём ей delegate - анонимный метод с параметром
            {
                Console.WriteLine("\nДанные из анонимного метода: " + x.trainInfo());
            };                                              // надо ставить ;
            container(tr1);                                 //вызываем делегат и передаём ему объект

            MethodContainer2 container2 = (CTrain x) => "\nДанные из лямбда-выражения: " + x.getTrainNumber().ToString() + " " + x.getTrainName();
            Console.WriteLine(container2(tr1));

            CTrain.MethodContainer3 myDel = new CTrain.MethodContainer3(tr1.infoChanger); 
            myDel(7, "My train");
            Console.WriteLine(tr1.trainInfo());


        }

        


    }
}  
