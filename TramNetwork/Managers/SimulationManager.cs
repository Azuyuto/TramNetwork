using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TramNetwork.Common.Models;
using TramNetwork.Common.Repositories;
using TramNetwork.Controls;

namespace TramNetwork.Managers
{
    public static class SimulationManager
    {
        public static TimeSpan CurrentTime { get; set; }
        public static List<TramRoute> TramRoutes { get; set; }

        public static void StartSimulation()
        {
            CurrentTime = new TimeSpan(12, 00, 00);
            GetRoutes();
        }

        public static void GetRoutes()
        {
            TramRoutes = TramRouteRepository.GetTestList();
        }

        public static void DoSimulationStep()
        {
            CurrentTime = CurrentTime.Add(new TimeSpan(0, 0, 10));
        }
    }
}
