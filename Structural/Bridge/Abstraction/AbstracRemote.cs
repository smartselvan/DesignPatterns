using DesignPatterns.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    public abstract class AbstractRemote
    {
        protected IDevice _device;
        public AbstractRemote(IDevice device)
        {
            _device = device;
        }
        public virtual void OnButton() {
            Console.WriteLine("Remote: Pressed OnButton");
        }
        public virtual void OffButton()
        {
            Console.WriteLine("Remote: Pressed OffButton");
        }
        public virtual void AddVolumeButton()
        {
            Console.WriteLine("Remote: Pressed AddVolumeButton");
        }
        public virtual void ReduceVolumeButton()
        {
            Console.WriteLine("Remote: Pressed ReduceVolumeButton");
        }
    }
}
