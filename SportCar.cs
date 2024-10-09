using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicPartTwo
{
    internal class SportCar: Car
    {

        public SportCar(string model, int year): base(model, year) { }
        public override void DisplayInfo()
        {
            Console.WriteLine($"This is a {Model} sport car from {Year}.");
        }
        protected override void Accelerate(int speed)
        {
            base.Accelerate(speed);
            Console.WriteLine("Performating a high-speed accelaration");
        }

    }
}
