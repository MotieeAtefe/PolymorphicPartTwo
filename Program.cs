namespace PolymorphicPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car reqularCar = new Car("Sedan", 2022);
            SportCar sportCar = new SportCar("Supercar", 2023);
            ElectricalCar electricalCar = new ElectricalCar("Tesla", 2022);


            reqularCar.DisplayInfo();
            sportCar.DisplayInfo();
            electricalCar.DisplayInfo();
        }


    }
}