using DesignPatterns.Creational.Builder.Builder;
using DesignPatterns.Creational.Builder.Product;
using DesignPatterns.Creational.Builder.Director;

namespace DesignPatterns.Creational.Builder
{
    public class BuilderPattern
    {
        public static void Call()
        {
            // The client code creates a builder object, passes it to the director and
            // *** then initiates the construction process and then end
            // result is retrieved from the builder object ***.

            CarBuilder builder = new CarBuilder();
            CarDirector director = new CarDirector();
            director.CarBuilder = builder;

            Console.WriteLine("Building medium end car using Director:");
            director.BuildMediumEndCar();
            Car mediumEndCar = builder.GetCar();
            Console.WriteLine(mediumEndCar.ToString() + "\n");

            Console.WriteLine("Building luxury car using Director:");
            director.BuildLuxuryCar();
            Car luxuryCar = builder.GetCar();
            Console.WriteLine(luxuryCar.ToString() + "\n");

            Console.WriteLine("Building basic car using Director:");
            director.BuildBasicCar();
            Car basicCar = builder.GetCar();
            Console.WriteLine(basicCar.ToString() + "\n");


            Console.WriteLine("Building luxury car using Builder:");
            builder.AddMVPParts();
            builder.AddExtraParts();
            builder.AddLuxuryItems();
            Car luxuryCarUsingBuilder = builder.GetCar();
            Console.WriteLine(luxuryCarUsingBuilder.ToString() + "\n");

            Console.WriteLine("Building basic car using Builder:");
            builder.AddMVPParts();
            Car basicCarUsingBuilder = builder.GetCar();
            Console.WriteLine(basicCarUsingBuilder.ToString() + "\n");
        }
    }
}
