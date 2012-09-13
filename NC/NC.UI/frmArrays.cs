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

        private void btnArrayFor_Click(object sender, EventArgs e)
        {
            // Statically create and array of doubles
            double[] numbers = new double[4];

            // Set the values
            numbers[0] = 2.4;
            numbers[1] = 1.2;
            numbers[2] = 5.66;
            numbers[3] = 7;

            // Enumerate and output the contents of that array
            for (int iCnt = 0; iCnt < 4; iCnt++)
                lstOutput.Items.Add(numbers[iCnt].ToString());
        }

        private void btn2dArray_Click(object sender, EventArgs e)
        {
            // Create a 2d array
            double[,] numbers = new double[2, 3];

            numbers[0, 0] = 2.3;
            numbers[0, 1] = 7.8;
            numbers[0, 2] = 5.9;
            numbers[1, 0] = 1.9;
            numbers[1, 1] = 9.4;
            numbers[1, 2] = 10.4;

        }
    }
}
