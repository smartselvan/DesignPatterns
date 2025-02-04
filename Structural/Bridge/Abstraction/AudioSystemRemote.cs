using DesignPatterns.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    internal class AudioSystemRemote : AbstractRemote
    {
        public AudioSystemRemote(IDevice device) : base(device)
        {
        }

        public override void AddVolumeButton()
        {
            Console.WriteLine("AudioSystemRemote: Pressed Add Volume");
            _device.AddVolume();
        }

        public override void OffButton()
        {
            Console.WriteLine("AudioSystemRemote: Pressed Off");
            _device.SwitchOff();
        }

        public override void OnButton()
        {
            Console.WriteLine("AudioSystemRemote: Pressed On");
            _device.SwitchOn();
        }

        public override void ReduceVolumeButton()
        {
            Console.WriteLine("AudioSystemRemote: Pressed Reduce Volume");
            _device.ReduceVolume();
        }
    }
}
