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
        GeoCoordinateWatcher watcher;

        public frmGPSMain()
        {
            InitializeComponent();

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (watcher == null)
            {
                watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                //watcher.MovementThreshold = 0;

                watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);
                watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            }
            watcher.Start();
        }

        void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
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


        private enum Plane
        {
            Horizontal,
            Vertical
        }

        private string decimalToDegree(double coordinate, Plane plane)
        {
            string pole = String.Empty;

            if (plane == Plane.Horizontal)
            {
                if (coordinate > 0)
                    pole = "N";
                else if (coordinate < 0)
                    pole = "S";
            }
            else
            {
                if (coordinate > 0)
                    pole = "E";
                else if (coordinate < 0)
                    pole = "W";
            }

            int degree = (int)coordinate;
            double seconds = (coordinate - degree) * 3600;
            int feet = (int)(seconds / 60);
            double inches = seconds - feet * 60;

            return pole + " " + degree.ToString() + "°" + feet.ToString() + "'" + inches.ToString("N3") + "\"";
        }

        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            if (e.Position.Location.IsUnknown)
            {
                lblStatus.Text = "Please wait while your position is determined....";
                return;
            }
            else
                lblStatus.Text = String.Empty;

            lblTime.Text = e.Position.Timestamp.ToString();

            lblLat.Text = decimalToDegree(e.Position.Location.Latitude, Plane.Horizontal);

            lblLong.Text = decimalToDegree(e.Position.Location.Longitude, Plane.Vertical);
            if (e.Position.Location.Altitude.ToString() == "NaN")
                lblAlt.Text = "0 m";
            else
                lblAlt.Text = e.Position.Location.Altitude.ToString() + " m";
            if (e.Position.Location.VerticalAccuracy.ToString() == "NaN")
                lblAccuracy.Text = "0 m";
            else
                lblAccuracy.Text = e.Position.Location.VerticalAccuracy.ToString() + " m";
            if (e.Position.Location.Speed.ToString()  == "NaN")
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
