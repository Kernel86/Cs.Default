using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.Utilities.PL
{
    public class CFile
    {
        private string _filename;
        private string _location;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public bool Open()
        {
            return true;
        }

        public void Close()
        {

        }

        public void Read()
        {

        }

        public void Write()
        {

        }
    }
}
