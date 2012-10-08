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

        private void btnOp_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
            {
                if (oCalc.PendingOp == false)
                {
                    if (lblResult.Text.Length > 0)
                    {
                        oCalc.Op = ((Button)sender).Text;
                        oCalc.A = decimal.Parse(lblResult.Text);
                    }
                }
                else
                {
                    if (lblResult.Text.Length > 0)
                    {
                        oCalc.B = decimal.Parse(lblResult.Text);
                        try
                        {
                            oCalc.Update();
                            lblResult.Text = oCalc.Result.ToString();
                        }
                        catch (Exception ex)
                        {
                            lblResult.Text = ex.Message;
                        }
                        oCalc.Op = ((Button)sender).Text;
                    }
                }
            }
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            oCalc = new CCalculator();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
            {
                if (oCalc.PendingOp == true && oCalc.A.ToString() == lblResult.Text)
                {
                    lblResult.Text = string.Empty;
                }

                if (oCalc.Result.ToString() == lblResult.Text)
                    lblResult.Text = string.Empty;

                string sChar = ((Button)sender).Text;
                if (sChar != "." || (sChar == "." && lblResult.Text.IndexOf(".") == -1))
                    lblResult.Text += ((Button)sender).Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
            {
                if (oCalc.PendingOp == true && lblResult.Text.Length > 0)
                {
                    oCalc.B = decimal.Parse(lblResult.Text);
                    try
                    {
                        oCalc.Update();
                        lblResult.Text = oCalc.Result.ToString();
                    }
                    catch (Exception ex)
                    {
                        lblResult.Text = ex.Message;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            oCalc.Clear();
            lblResult.Text = string.Empty;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = oCalc.Sign(decimal.Parse(lblResult.Text)).ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = oCalc.SquareRoot(decimal.Parse(lblResult.Text)).ToString();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (oCalc.Exception == false)
                if (lblResult.Text.Length > 0)
                    lblResult.Text = oCalc.Reciprocal(decimal.Parse(lblResult.Text)).ToString();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            dlgAbout frmAbout = new dlgAbout();
            frmAbout.ShowDialog();
            frmAbout.Dispose();
        }
    }
}
