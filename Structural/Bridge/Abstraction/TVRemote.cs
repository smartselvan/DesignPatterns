using DesignPatterns.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    public class TVRemote : AbstractRemote
    {
        public TVRemote(IDevice device) : base(device)
        {
        }

        public override void AddVolumeButton()
        {
            Console.WriteLine("TVRemote: Pressed Add Volume");
            _device.AddVolume();
        }

        public override void OffButton()
        {
            Console.WriteLine("TVRemote: Pressed Off");
            _device.SwitchOff();
        }

        public override void OnButton()
        {
            Console.WriteLine("TVRemote: Pressed On");
            _device.SwitchOn();
        }

        public override void ReduceVolumeButton()
        {
            Console.WriteLine("TVRemote: Pressed Reduce Volume");
            _device.ReduceVolume();
        }
    }
}
