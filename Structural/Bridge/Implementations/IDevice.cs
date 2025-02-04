using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Implementations
{
    public interface IDevice
    {
        void SwitchOn();
        void SwitchOff();
        void AddVolume();
        void ReduceVolume();
    }
}
