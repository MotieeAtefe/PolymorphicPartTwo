using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicPartTwo
{
    internal class ElectricalCar:Car
    {
        public ElectricalCar(string model, int year): base(model, year){ }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ElectricalCar-Mode: {Model}, Year:{Year}");
        }
        protected override void StartEngin()
        {
            Console.WriteLine("Starting electric motor..");
        }
        protected override void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerate silently at {speed} mph");
        }



    }
}
