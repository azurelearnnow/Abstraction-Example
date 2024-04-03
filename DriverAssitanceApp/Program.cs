using CarShowroomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverAssitanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This will be fun. ");
             
            string cartype= Console.ReadLine();

            Car mycar = new CarShowRoomService1().Getcar(cartype);
            List<string> instruction = mycar.GetCarDrivingIntructions(); // Here we have applied  the abstraction princple.

            foreach(string instruction1 in instruction)
            {
                Console.WriteLine(instruction1);
            }

            Console.ReadLine();
            // this is a new comment from azure now.

        }
    }
}
