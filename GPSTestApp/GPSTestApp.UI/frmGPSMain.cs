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

using GPSTestApp.Location.Services;
using GPSTestApp.GPS;

namespace GPSTestApp.UI
{
    public partial class frmGPSMain : Form
    {
        CLocation _location; // Location Services

        public frmGPSMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Configure Location Class
            if (_location == null)
            {
                _location = new CLocation(GeoPositionAccuracy.High);
                _location.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(_location_StatusChanged);
                _location.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(_location_PositionChanged);
            }

            // Start _location
            _location.Start();
        }

        // Handle location services status changes
        private void _location_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
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
        private void _location_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            lblStatus.Text = String.Empty;

            // Check if Location Services have located us
            if (e.Position.Location.IsUnknown)
                lblStatus.Text = "Please wait while your position is determined....";
            else
            {
                // Display values
                lblTime.Text = e.Position.Timestamp.ToString();
                lblLat.Text = _location.decimalToDegree(e.Position.Location.Latitude, CLocation.Plane.Horizontal);
                lblLong.Text = _location.decimalToDegree(e.Position.Location.Longitude, CLocation.Plane.Vertical);

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
