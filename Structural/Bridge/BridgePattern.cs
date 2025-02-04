using DesignPatterns.Structural.Bridge.Abstraction;
using DesignPatterns.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class BridgePattern
    {
        public static void Call()
        {
            AbstractRemote tvRemote = new TVRemote(new Television());
            tvRemote.OnButton();
            tvRemote.AddVolumeButton();
            tvRemote.ReduceVolumeButton();
            tvRemote.OffButton();
            Console.WriteLine();
            AbstractRemote audioSystemRemote = new AudioSystemRemote(new AudioSystem());
            audioSystemRemote.OnButton();
            audioSystemRemote.AddVolumeButton();
            audioSystemRemote.ReduceVolumeButton();
            audioSystemRemote.OffButton();
        }
    }
}
