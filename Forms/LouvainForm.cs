using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkGUI.Forms
{
    public partial class LouvainForm : Form
    {
        double precision = 0.0;

        public LouvainForm()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(precisionVal.Text, out precision))
            {
                this.Close();
            } else
            {
                MessageBox.Show(precisionVal.Text + " is not a decimal number! Please try again!", "Error!");
            }
        }

        private void unlimitedIter_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void maxIter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void precisionVal_TextChanged(object sender, EventArgs e)
        {

        }

        public double Precision
        {
            get { return precision; }
        }

        public bool UnlimitedIterations
        {
            get { return unlimitedIter.Checked; }
        }

        public int MaxIterations
        {
            get { return (int)maxIter.Value; }
        }
    }
}
