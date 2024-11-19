using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus_taviranyito
{
    public class HIFI : IRemoteDevice
    {
        private bool isOn = false;
        private int volume = 20;

        public void PowerOn()
        {
            isOn = true;
            Console.WriteLine("HIFI is now powered on.");
        }

        public void PowerOff()
        {
            isOn = false;
            Console.WriteLine("HIFI is now powered off.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("HIFI does not support channel switching.");
        }

        public void AdjustVolume(int change)
        {
            if (isOn)
            {
                volume += change;
                Console.WriteLine($"Volume adjusted to {volume} on HIFI.");
            }
            else
            {
                Console.WriteLine("HIFI is off. Cannot adjust volume.");
            }
        }
    }

}
