using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using TramNetwork.Common.Models.ZTP;

namespace TramNetwork.Common.Repositories
{
    public static class ZTPRepository
    {
        public static List<LineZTP> Lines { get; set; }
        public static List<TripZTP> Trips { get; set; }
        public static List<StopZTP> Stops { get; set; }

        public static void Initialize()
        {
            ReadStopInfo();
        }

        public static void ReadStopInfo()
        {
            try
            {
                Stops = new List<StopZTP>();
                using (StreamReader sr = new StreamReader("ZTP/stops.txt"))
                {
                    sr.ReadLine(); // ignore header
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Vector2 coord = new Vector2();
                        List<string> stop_line = new List<String>();
                        var nextStop = new StopZTP();
                        stop_line = line.Split(',').ToList();
                        nextStop.StopID = stop_line[0];
                        nextStop.StopName = stop_line[2].Trim('"');
                        coord.X = float.Parse(stop_line[4], CultureInfo.InvariantCulture);
                        coord.Y = float.Parse(stop_line[5], CultureInfo.InvariantCulture);
                        nextStop.StopCoordinates = coord;
                        Stops.Add(nextStop);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
