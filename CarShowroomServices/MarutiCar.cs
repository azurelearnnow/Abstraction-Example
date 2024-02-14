using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomServices
{
    internal class MarutiCar :Car
    {
        //Properties

        int nofoseat;
        int noofwheels;
        int headlights;
        string Modelno;
        string YearofManufacture;
        int noofHeadlights;
        int noofEngine;

        //Methods
        public void CheckCarEngine() { }

        public void CheckCarBrakes() { }

        public void StartCar() { }

        public void StopCar() { }

        public void SpeedupCar() { }

        public void SpeedDownCar() { }

        public override List<string> GetCarDrivingIntructions()
        {
            List<string> instructions = new List<string>();
            instructions.Add("Instruction 1 for driving Maruti car;");
            instructions.Add("Instruction 2 for driving Maruti car;");
            instructions.Add("Instruction 3 for driving Maruti car;");
            instructions.Add("Instruction 4 for driving Maruti car;");
            instructions.Add("Instruction 5 for driving Maruti car;");
            instructions.Add("Instruction 6 for driving Maruti car;");

            return instructions;
        }
    }

    internal class Aulto :MarutiCar
    {

    }

}
