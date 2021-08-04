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
    public partial class RemoveIsolatesForm : Form
    {

        public RemoveIsolatesForm()
        {
            InitializeComponent();
            EnableButton();
            EnableChecked();
        }

        public int MinGroupSize
        {
            get { return (int)(minGrpSz.Value); }
        }

        public bool RemoveIsolates
        {
            get { return (bool)(rmvIsolatesT.Checked); }
        }

        public bool Popup
        {
            get { return !((bool)(popupChkBx.Checked)); }
        }

        private void EnableChecked()
        {
            rmvIsolatesT.AutoCheck = true;
            rmvIsolatesF.AutoCheck = true;
        }

        private void EnableButton()
        {
            doneBt.Enabled = false;
            if(rmvIsolatesT.Checked || rmvIsolatesF.Checked)
            {
                doneBt.Enabled = true;
            }
        }

        private void rmvIsolatesT_CheckedChanged(object sender, EventArgs e)
        {
            if(rmvIsolatesT.Checked)
            {
                EnableButton();
            }
        }

        private void rmvIsolatesF_CheckedChanged(object sender, EventArgs e)
        {
            if(rmvIsolatesF.Checked)
            {
                EnableButton();
            }
        }

        private void doneBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
