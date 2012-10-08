using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.BL
{
    public abstract class CPerson
    {
        // Private Fields
        private string _id;
        private string _firstname;
        private string _lastname;

        // Public Properties
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string Fullname
        {
            get { return _lastname + ", " + _firstname; }
        }
    }
}
