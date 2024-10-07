using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicPartTwo
{
    internal class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string model, int year)
        {
            Model = model;
            Year  = year;
        }
        protected virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: '{Model}', Year: '{Year}'");
        }
        protected virtual void StartEngin()
        {
            Console.WriteLine("Engine Started...");
        }
        protected virtual void Accelerate(int speed) 
        {
            Console.WriteLine($"Accelerating at {speed} mph");
        }


    }
}
