using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        public void Start()
        {
            SportCar sportCar = new SportCar() { MaxSpeed = 16, DrivenDistance = 0 };
            PassengerCar passengerCar = new PassengerCar() { MaxSpeed = 13, DrivenDistance = 0 };
            CargoCar cargoCar = new CargoCar() { MaxSpeed = 10, DrivenDistance = 0 };
            Bus bus = new Bus() { MaxSpeed = 8, DrivenDistance = 0 };

            sportCar.Finish += () =>
            {
                Console.WriteLine("#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#\nСпорткар доехал до финиша\n#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#");
            };
            passengerCar.Finish += () =>
            {
                Console.WriteLine("#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#\nЛегковушка доехала до финиша\n#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#");
            };
            cargoCar.Finish += () =>
            {
                Console.WriteLine("#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#\nКарго доехало до финиша\n#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#");
            };
            bus.Finish += () =>
            {
                Console.WriteLine("#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#\nАвтобус доехал до финиша\n#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#o#");
            };

            int countSec = 0;
            Console.WriteLine("Секунд\t\tСпорткар\tЛегковушка\tКарго\t\tАвтобус");
            while (true)
            {
                sportCar.Drive();
                passengerCar.Drive();
                cargoCar.Drive();
                bus.Drive();
                Console.WriteLine(countSec++ +"\t\t"+ sportCar.DrivenDistance + "m\t\t"+ passengerCar.DrivenDistance + "m\t\t"+ cargoCar.DrivenDistance + "m\t\t"+ bus.DrivenDistance + "m");
                
                if (sportCar.DrivenDistance >= 100 || passengerCar.DrivenDistance >= 100 || cargoCar.DrivenDistance >= 100 || bus.DrivenDistance >= 100)
                {
                    break;
                }
            }
                
			
                
                  
            
            
        }
    }
}
