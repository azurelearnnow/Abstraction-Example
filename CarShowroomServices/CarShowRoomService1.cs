using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomServices
{
    public class CarShowRoomService1
    {
        public Car Getcar(string Cartype)
        {
            switch(Cartype)
            {
                case "Maruti": return new MarutiCar(); 

                case "BMW": return new BMWCar();

                case "Mahindra": return new MahindraCar();

                default: return null;
            }
        }

    }
}
