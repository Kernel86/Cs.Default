using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace GPSTestApp.Location.Services
{
    public class CLocation
    {
        // Public Properties

        // Private Properties
        private GeoCoordinateWatcher _watcher;

        // Constructors
        public CLocation()
        {
            _watcher = new GeoCoordinateWatcher();
        }

        public CLocation(GeoPositionAccuracy vAccuracy)
        {
            _watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            _watcher.StatusChanged += _StatusChanged;
            _watcher.PositionChanged += _PositionChanged;
        }

        // Events
        public event EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>> PositionChanged;
        private void _PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            PositionChanged(sender, e);
        }

        public event EventHandler<GeoPositionStatusChangedEventArgs> StatusChanged;
        private void _StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            StatusChanged(sender, e);
        }

        // Public Enums
        // Enum for globe planes
        public enum Plane
        {
            Horizontal,
            Vertical
        }

        // Public Methods
        // Start Watcher
        public void Start()
        {
            _watcher.Start();
        }

        // Convert decimal coordinates to formatted degrees
        public string decimalToDegree(double coordinate, Plane plane)
        {
            string pole = String.Empty;

            // Get compass direction
            if (plane == Plane.Horizontal)
            {
                // 90(N)-0-90(S)
                if (coordinate > 0)
                    pole = "N";
                else if (coordinate < 0)
                    pole = "S";
            }
            else if (plane == Plane.Vertical)
            {
                // 180(E)-0-180(W)
                if (coordinate > 0)
                    pole = "E";
                else if (coordinate < 0)
                    pole = "W";
            }

            // Degrees are the integer portion of the coordinate
            int degree = (int)coordinate;
            // Total seconds are the decimal porttion of the coordinate times 3600, the number of seconds in a degree
            double totalseconds = -1 * (coordinate - degree) * 3600;
            // Minutes
            int minutes = (int)(totalseconds / 60);
            double seconds = totalseconds - minutes * 60;

            // Return the formatted coordinate
            return pole + " " + degree.ToString() + "°" + minutes.ToString() + "'" + seconds.ToString("N3") + "\"";
        }
    }
}
