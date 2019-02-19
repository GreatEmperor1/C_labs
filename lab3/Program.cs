using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            CCargo cargo1 = new CCargo("Machinegun","light");
            CCargo cargo2 = new CCargo("Tank","Heavy");

            CCarriage carriage1 = new CCarriage(1, "For light cargo");
            CCarriage carriage2 = new CCarriage(2, "For heavy cargo");
            CCarriage carriage3 = new CCarriage(3, "For food");

            CCarriage[] carriagesHeavy = new CCarriage[2];
            carriagesHeavy[0] = carriage2;
            carriagesHeavy[1] = carriage2;

            CTrain train1 = new CTrain();
            CTrain train2 = new CTrain(1, "МИНСК-ЮРМАЛА");
            CTrain train3 = new CTrain(2, "MINSK-MOSCOV", carriagesHeavy);

            CTrain[] trains = new CTrain[3];
            trains[0] = train1;
            trains[1] = train2;
            trains[2] = train3;

            CStation station = new CStation("Station1", "Minsk", trains);

            station.print();


        }
    }
}
