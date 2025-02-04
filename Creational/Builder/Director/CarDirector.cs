using DesignPatterns.Creational.Builder.Builder;

namespace DesignPatterns.Creational.Builder.Director
{
    public class CarDirector
    {
        private ICarBuilder _carBuilder;
        public ICarBuilder CarBuilder { set {  _carBuilder = value; } }
        public void BuildBasicCar()
        {
            _carBuilder.AddMVPParts();
        }

        public void BuildMediumEndCar()
        {
            _carBuilder.AddMVPParts();
            _carBuilder.AddExtraParts();
        }

        public void BuildLuxuryCar()
        {
            _carBuilder.AddMVPParts();
            _carBuilder.AddExtraParts();
            _carBuilder.AddLuxuryItems();
        }
    }
}
