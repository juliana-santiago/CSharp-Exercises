using System;
using System.Collections.Generic;
using System.Text;

namespace DiamondProblemExample.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
