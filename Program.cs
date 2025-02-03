using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("----Creational Patterns----\n");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("----Singleton Pattern----\n");
            SingletonPattern.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Prototype Pattern----\n");
            PrototypePattern.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Factory Pattern----\n");
            FactoryPattern.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Abstract Factory Pattern----\n");
            AbstractFactoryPattern.Call();
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n----Builder Pattern----\n");
            BuilderPattern.Call();
            Console.WriteLine("---------------------------------------------------------");


            Console.WriteLine("----Structural Patterns----\n");
            Console.WriteLine("---------------------------------------------------------");

        }
    }
}