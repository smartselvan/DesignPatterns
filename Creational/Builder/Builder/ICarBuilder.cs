using DesignPatterns.Creational.Builder.Product;

namespace DesignPatterns.Creational.Builder.Builder
{
    public interface ICarBuilder
    {
        void AddMVPParts();
        void AddExtraParts();
        void AddLuxuryItems();
        Car BuildBasicCar();
        Car BuildMediumEndCar();
        Car BuildLuxuryCar();
    }
}
