using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TramNetwork.Common.Models
{
    public class TramRoute
    {
        public string Name { get; set; }
        public List<Vector2> Coordinators { get; set; }
    }
}
