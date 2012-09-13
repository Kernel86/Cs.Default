using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NC.UI
{
    public partial class frmArrays : Form
    {
        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            // Statically create and array of doubles
            double[] numbers = { 2.4, 1.2, 5.66, 7 };

            // Enumerate and output the contents of that array
            foreach (double number in numbers)
                lstOutput.Items.Add(number.ToString());
        }
    }
}
