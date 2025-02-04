using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Implementations
{
    public class AudioSystem : IDevice
    {
        public void AddVolume()
        {
            Console.WriteLine("AudioSystem: Added AudioSystem Volume");
        }

        public void ReduceVolume()
        {
            Console.WriteLine("AudioSystem: Reduced AudioSystem Volume");
        }

        public void SwitchOff()
        {
            Console.WriteLine("AudioSystem: Switched off");
        }

        public void SwitchOn()
        {
            Console.WriteLine("AudioSystem: Switched on");
        }
    }
}
