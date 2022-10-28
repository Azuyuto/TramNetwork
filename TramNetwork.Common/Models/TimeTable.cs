using System;
using System.Collections.Generic;
using System.Text;

namespace TramNetwork.Common.Models
{
    public class TimeTable
    {
        public string Name { get; set; }
        public List<TimeSpan> Hours { get; set; }
    }
}
