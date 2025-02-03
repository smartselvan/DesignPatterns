using DesignPatterns.Creational.Builder.Product;

namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : ICarBuilder
    {
        Car car = new Car();
        public void AddExtraParts()
        {
            car.IsCameraSystemAdded = true;
            car.IsAudioSystemAdded = true;
            Console.WriteLine("Added Camera and Audio system");
        }

        public void AddLuxuryItems()
        {
            car.IsAutomationAdded = true;
            Console.WriteLine("Added Automation");
        }

        public void AddMVPParts()
        {
            car.IsBodyAdded = true;
            car.IsSteeringAdded = true;
            car.IsEngineAdded = true;
            Console.WriteLine("Added Engine, Body and Steering");
        }

        public Car BuildBasicCar()
        {
            AddMVPParts();
            return car;
        }

        public Car BuildMediumEndCar()
        {
            AddMVPParts();
            AddExtraParts();
            return car;
        }

        public Car BuildLuxuryCar()
        {
            AddMVPParts();
            AddExtraParts();
            AddLuxuryItems();
            return car;
        }
    }
}
