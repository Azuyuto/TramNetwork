using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using TramNetwork.Common.Models;

namespace TramNetwork.Common.Repositories
{
    public static class TramRouteRepository
    {
        public static List<TramRoute> GetTestList()
        {
            return new List<TramRoute>() {
                new TramRoute(){
                    Name = "Bronowice - Bronowice",
                    Coordinators = new List<Vector2>(){
                        new Vector2(100, 100),
                        new Vector2(100, 200),
                        new Vector2(200, 200),
                        new Vector2(200, 100),
                        new Vector2(100, 100),
                    }
                }
            };
        }
    }
}
