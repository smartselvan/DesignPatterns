using DesignPatterns.Creational.Builder.Product;

namespace DesignPatterns.Creational.Builder
{
    internal class BuilderProgram
    {
        public static void Call()
        {
            ICarBuilder builder = new CarBuilder();
            Console.WriteLine("Building basic car:");
            Car basicCar = builder.BuildBasicCar();
            Console.WriteLine(basicCar.ToString() + "\n");

            Console.WriteLine("Building medium end car:");
            Car mediumEndCar = builder.BuildMediumEndCar();
            Console.WriteLine(mediumEndCar.ToString() + "\n");

            Console.WriteLine("Building luxury car:");
            Car luxuryCar = builder.BuildLuxuryCar();
            Console.WriteLine(luxuryCar.ToString() + "\n");

        }
    }
}
