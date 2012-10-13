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
        public event EventHandler<String> Send;

    // Private Methods

    // Public Methods
        public void Enable()
        {
            if (!IsPortInUse("COM8") && !IsGPSEnabled())
            {
                SerialPort oCOM = new SerialPort("COM8", 9600, Parity.Odd, 8, StopBits.One);

                oCOM.Open();

                Thread.Sleep(1000);
                oCOM.Write("AT+CFUN=1\r\n");
                oCOM.BaseStream.Flush();

                bool loop = true;
                while (loop)
                {
                    string read = oCOM.ReadLine();
                    if (read == "OK\r")
                    {
                        oCOM.WriteLine("AT*E2GPSCTL=1,1,1");
                        loop = false;
                    }
                }

                oCOM.Close();
                oCOM.Dispose();
                oCOM = null;
            }
        }

        public void Disable()
        {
            if (IsPortInUse("COM8") && IsGPSEnabled())
            {
                SerialPort oCOM = new SerialPort("COM8", 9600, Parity.Odd, 8, StopBits.One);

                oCOM.Open();

                Thread.Sleep(1000);
                oCOM.Write("AT+CFUN=4\r\n");
                oCOM.BaseStream.Flush();

                oCOM.Close();
                oCOM.Dispose();
                oCOM = null;
            }
        }

        private bool IsPortInUse(string port)
        {
            try
            {
                SerialPort oCOM = new SerialPort(port);
                oCOM.Open();

                if (oCOM.IsOpen)
                {
                    oCOM.Close();
                    oCOM.Dispose();
                    oCOM = null;
                    return false;
                }
                else
                    return true;

            }
            catch (UnauthorizedAccessException)
            {
                return true;
            }
        }

        private bool IsGPSEnabled()
        {
            if (!IsPortInUse("COM8"))
            {
                SerialPort oCOM = new SerialPort("COM8", 9600, Parity.Odd, 8, StopBits.One);
                oCOM.Open();

                oCOM.DiscardInBuffer();
                oCOM.Write("AT+CFUN?\r\n");
                oCOM.BaseStream.Flush();

                oCOM.DiscardOutBuffer();
                string read = oCOM.ReadLine();
                read = oCOM.ReadLine();

                oCOM.Close();
                oCOM.Dispose();
                oCOM = null;

                if (read == "+CFUN: 1\r")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void enable_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Send(sender, indata);
        }

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
            Disable();
        }
    }
}
