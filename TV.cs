using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus_taviranyito
{
    public class TV : IRemoteDevice
    {
        private bool isOn = false;
        private int currentChannel = 1;
        private int volume = 10;

        public void PowerOn()
        {
            isOn = true;
            Console.WriteLine("TV is now powered on.");
        }

        public void PowerOff()
        {
            isOn = false;
            Console.WriteLine("TV is now powered off.");
        }

        public void SetChannel(int channel)
        {
            if (isOn)
            {
                currentChannel = channel;
                Console.WriteLine($"Channel changed to {channel} on TV.");
            }
            else
            {
                Console.WriteLine("TV is off. Cannot change channel.");
            }
        }

        public void AdjustVolume(int change)
        {
            if (isOn)
            {
                volume += change;
                Console.WriteLine($"Volume adjusted to {volume} on TV.");
            }
            else
            {
                Console.WriteLine("TV is off. Cannot adjust volume.");
            }
        }
    }

}
