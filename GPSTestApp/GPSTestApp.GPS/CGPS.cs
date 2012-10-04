/**************************************************************************
 *
 * GPS Test App
 * [CGPS.c]
 * Copyright (C) 2012 Shawn Novak - Kernel86@muleslow.net
 *
 *************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;

namespace GPSTestApp.GPS
{
    public class CGPS
    {
    // Private Properties
        private static SerialPort _oCOMPort;
        private static bool _bRun;

        private string _sCOM;
        private int _iBaudRate;

    // Public Properties
        public string COM
        {
            get { return _sCOM; }
            set { _sCOM = value; }
        }

        public int BaudRate
        {
            get { return _iBaudRate; }
            set { _iBaudRate = value; }
        }

    // Constructors
        public CGPS()
        {

        }

        public CGPS(string vsCOM, int viBaudRate)
        {
            _sCOM = vsCOM;
            _iBaudRate = viBaudRate;
        }

    // Events
        public event EventHandler<String> DataReceived;

    // Private Methods

    // Public Methods
        public void Start()
        {
            if (SerialPort.GetPortNames().Contains(_sCOM))
            {
                _oCOMPort = new SerialPort(_sCOM, _iBaudRate);
                _oCOMPort.ReadTimeout = SerialPort.InfiniteTimeout;
                _oCOMPort.Open();
                _oCOMPort.DataReceived += _oCOMPort_DataReceived;
                _bRun = true;
            }
            else
                throw new Exception("Invalid COM Port (" + _sCOM + ").");
        }

        private void _oCOMPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            DataReceived(sender, indata);
        }

        public string ReadLine()
        {
            try
            {
                if (_oCOMPort.IsOpen)
                    return _oCOMPort.ReadLine();
                else
                    return "error";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _bRun = false;
            _oCOMPort.Close();
            _oCOMPort.Dispose();
        }
    }
}
