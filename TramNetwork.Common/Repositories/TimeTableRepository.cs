using System;
using System.Collections.Generic;
using System.Text;
using TramNetwork.Common.Models;

namespace TramNetwork.Common.Repositories
{
    public static class TimeTableRepository
    {
        public static List<TimeTable> GetTestList()
        {
            return new List<TimeTable>()
            {
                new TimeTable() {
                Name = "Bronowice - Bronowice",
                Hours = new List<TimeSpan>() {
                        new TimeSpan(12, 00, 00),
                        new TimeSpan(12, 20, 00)
                    }
                }
            };
        }
    }
}
