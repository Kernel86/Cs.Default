/**************************************************************************
 *
 * GPS Test App
 * [frmGPSMain.c]
 * Copyright (C) 2012 Shawn Novak - Kernel86@muleslow.net
 *
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace GPSTestApp.UI
{
    public partial class frmGPSMain : Form
    {
        GeoCoordinateWatcher _watcher;

        public frmGPSMain()
        {
            InitializeComponent();

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Configure Watcher
            if (_watcher == null)
            {
                _watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                _watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(_watcher_StatusChanged);
                _watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(_watcher_PositionChanged);
            }

            // Start _watcher
            _watcher.Start();
        }

        // Enum for globe planes
        private enum Plane
        {
            Horizontal,
            Vertical
        }

        // Convert decimal coordinates to formatted degrees
        private string decimalToDegree(double coordinate, Plane plane)
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

        // Handle location services status changes
        private void _watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case GeoPositionStatus.Disabled:
                    lblStatus.Text = "Location Service is not enabled on the device";
                    break;
                case GeoPositionStatus.NoData:
                    lblStatus.Text = "The Location Service is working, but it cannot get location data.";
                    break;
                default:
                    lblStatus.Text = String.Empty;
                    break;
            }
        }

        // Handle location change updates
        private void _watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            lblStatus.Text = String.Empty;

            // Check if Location Services have located us
            if (e.Position.Location.IsUnknown)
                lblStatus.Text = "Please wait while your position is determined....";
            else
            {
                // Display values
                lblTime.Text = e.Position.Timestamp.ToString();
                lblLat.Text = decimalToDegree(e.Position.Location.Latitude, Plane.Horizontal);
                lblLong.Text = decimalToDegree(e.Position.Location.Longitude, Plane.Vertical);

                if (e.Position.Location.VerticalAccuracy.ToString() == "NaN")
                    lblAccuracy.Text = "0 m";
                else
                    lblAccuracy.Text = e.Position.Location.HorizontalAccuracy.ToString() + " m";

                if (e.Position.Location.Altitude.ToString() == "NaN")
                    lblAlt.Text = "0 m";
                else
                    lblAlt.Text = e.Position.Location.Altitude.ToString() + " m";

                if (e.Position.Location.Speed.ToString() == "NaN")
                    lblSpeed.Text = "0 m/s";
                else
                    lblSpeed.Text = e.Position.Location.Speed.ToString() + " m/s";

                if (e.Position.Location.Course.ToString() == "NaN")
                    lblCourse.Text = "0°";
                else
                    lblCourse.Text = e.Position.Location.Course.ToString() + "°";
            }
        }
    }
}
