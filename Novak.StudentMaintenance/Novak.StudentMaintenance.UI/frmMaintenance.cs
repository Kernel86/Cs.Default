using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Novak.StudentMaintenance.BL;

namespace Novak.StudentMaintenance.UI
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void btnMakePerson_Click(object sender, EventArgs e)
        {
            CPerson oPerson = new CPerson();

            oPerson.Firstname = txtFirstname.Text;
            oPerson.Lastname = txtLastname.Text;

            lblFullname.Text = oPerson.Fullname;

            oPerson = null;
        }
    }
}
