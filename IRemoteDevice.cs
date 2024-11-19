using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus_taviranyito
{
    public interface IRemoteDevice
    {
        void PowerOn();
        void PowerOff();
        void SetChannel(int channel);
        void AdjustVolume(int change);
    }

}
