using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus_taviranyito
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            RemoteControl<TV> tvRemote = new RemoteControl<TV>(tv);

            tvRemote.PowerOn();
            tvRemote.ChangeChannel(5);
            tvRemote.VolumeUp();
            tvRemote.PowerOff();

            HIFI hifi = new HIFI();
            RemoteControl<HIFI> hifiRemote = new RemoteControl<HIFI>(hifi);

            hifiRemote.PowerOn();
            hifiRemote.VolumeUp();
            hifiRemote.PowerOff();
        }
    }

}