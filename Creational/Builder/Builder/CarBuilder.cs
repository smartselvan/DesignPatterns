using DesignPatterns.Creational.Builder.Product;

namespace DesignPatterns.Creational.Builder.Builder
{
    public class CarBuilder : ICarBuilder
    {
        Car car = new Car();

        public CarBuilder() {
            Reset();
        }
        public void Reset()
        {
            this.car = new Car();
        }
        public void AddExtraParts()
        {
            this.car.IsCameraSystemAdded = true;
            this.car.IsAudioSystemAdded = true;
            Console.WriteLine("Added Camera and Audio system");
        }

        public void AddLuxuryItems()
        {
            this.car.IsAutomationAdded = true;
            Console.WriteLine("Added Automation");
        }

        public void AddMVPParts()
        {
            this.car.IsBodyAdded = true;
            this.car.IsSteeringAdded = true;
            this.car.IsEngineAdded = true;
            Console.WriteLine("Added Engine, Body and Steering");
        }

        public Car GetCar() { 
            Car car = this.car;
            Reset();
            return car;
        }
    }
}
