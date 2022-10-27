using System;
using System.Numerics;

namespace TramNetwork.Common.Models
{
    public class TramModel
    {
        public string Name { get; set; }
        public double VisionRange { get; set; }
        public double Speed { get; set; }

        public Vector2 Coordinates { get; set; }
    }
}
