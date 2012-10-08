using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.BL
{
    public enum AddressType : int
    {
        Local,
        Permanent
    }

    public class CAddress
    {
        private int _id;
        private AddressType _type;
        private string _street;
        private string _city;
        private string _state;
        private string _zip;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public AddressType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
    }
}
