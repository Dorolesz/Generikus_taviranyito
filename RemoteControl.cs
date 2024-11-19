using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus_taviranyito
{
    public class RemoteControl<T> where T : IRemoteDevice
    {
        private T device;

        public RemoteControl(T device)
        {
            this.device = device;
        }

        public void PowerOn()
        {
            device.PowerOn();
        }

        public void PowerOff()
        {
            device.PowerOff();
        }

        public void ChangeChannel(int channel)
        {
            device.SetChannel(channel);
        }

        public void VolumeUp()
        {
            device.AdjustVolume(1);
        }

        public void VolumeDown()
        {
            device.AdjustVolume(-1);
        }
    }

}
