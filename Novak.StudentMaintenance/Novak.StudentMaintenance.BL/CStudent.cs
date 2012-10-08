using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.BL
{
    public class CStudent : CPerson
    {
        private string _id;
        private double _gpa;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
    }
}
