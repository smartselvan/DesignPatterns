using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Implementations
{
    public class Television : IDevice
    {
        public void AddVolume()
        {
            Console.WriteLine("TV: Added TV Volume");
        }

        public void ReduceVolume()
        {
            Console.WriteLine("TV: Reduced TV Volume");
        }

        public void SwitchOff()
        {
            Console.WriteLine("TV: Switched off");
        }

        public void SwitchOn()
        {
            Console.WriteLine("TV: Switched on");
        }
    }
}
