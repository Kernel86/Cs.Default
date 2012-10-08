/*************************
 * [frmCalc.cs]
 * C# Intermediate
 * Shawn Novak
 * 2012-10-07
 *************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Novak.Calculator.Logic;

namespace Novak.Calculator.UI
{
    public partial class frmCalc : Form
    {
        CCalculator oCalc;

        public frmCalc()
        {
            InitializeComponent();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            oCalc = new CCalculator();
        }

        // Set calculator operation
        private void btnOp_Click(object sender, EventArgs e)
        {
            // Check for an exception
            if (oCalc.Exception == false)
            {
                // Check if there is already a pending operation
                if (oCalc.PendingOp == false)
                {
                    if (lblResult.Text.Length > 0)
                    {
                        // Store last value and new operation
                        oCalc.Op = ((Button)sender).Text;
                        oCalc.A = decimal.Parse(lblResult.Text);
                    }
                }
                else // If there is a pending operation perform it, then store new values
                {
                    if (lblResult.Text.Length > 0)
                    {
                        // Store new value
                        oCalc.B = decimal.Parse(lblResult.Text);

                        // Perform pending operation and check for exception
                        try
                        {
                            oCalc.Update();
                            // Display the result
                            lblResult.Text = oCalc.Result.ToString();
                        }
                        catch (Exception ex)
                        {
                            // Display the exception in the input box
                            lblResult.Text = ex.Message;
                        }

                        // Store new operation
                        oCalc.Op = ((Button)sender).Text;
                    }
                }
            }
        }

        // Create numbers from buttons
        private void btnNum_Click(object sender, EventArgs e)
        {
            // Check for an exception
            if (oCalc.Exception == false)
            {
                // Check for a pending operation and a completed previous operation and reset the input
                if (oCalc.PendingOp == true && oCalc.A.ToString() == lblResult.Text)
                    lblResult.Text = string.Empty;

                // Check for a completed operation and clear the result and input
                if (oCalc.Result.ToString() == lblResult.Text)
                {
                    oCalc.Result = 0;
                    lblResult.Text = string.Empty;
                }

                // Get next digit
                string sChar = ((Button)sender).Text;

                // Make sure there's no more than one dot and add digit to input
                if (sChar != "." || (sChar == "." && lblResult.Text.IndexOf(".") == -1))
                    lblResult.Text += ((Button)sender).Text;
            }
        }

        // Delete the last digit from the input
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
        }

        // Perform operation
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Check for an exception
            if (oCalc.Exception == false)
            {
                // Check for a pending operation and input value, or a repeat operation
                if ((oCalc.PendingOp == true && lblResult.Text.Length > 0) || oCalc.Result.ToString() == lblResult.Text)
                {
                    // Store the input
                    oCalc.B = decimal.Parse(lblResult.Text);

                    // Perform the operation and check for an exception
                    try
                    {
                        oCalc.Update();
                        // Display the result
                        lblResult.Text = oCalc.Result.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Display the exception in the input box
                        lblResult.Text = ex.Message;
                    }
                }
            }
        }

        // Reset the Calculator
        private void btnClear_Click(object sender, EventArgs e)
        {
            oCalc.Clear();
            lblResult.Text = string.Empty;
        }

        // Invert the sign
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = oCalc.Sign(decimal.Parse(lblResult.Text)).ToString();
        }

        // Get teh square root
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = oCalc.SquareRoot(decimal.Parse(lblResult.Text)).ToString();
        }

        // Get the reciprocal
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = oCalc.Reciprocal(decimal.Parse(lblResult.Text)).ToString();
        }

        // Show the About dialog
        private void btnAbout_Click(object sender, EventArgs e)
        {
            dlgAbout frmAbout = new dlgAbout();
            frmAbout.ShowDialog();
            frmAbout.Dispose();
        }
    }
}
