using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (rbtnOk.Checked == true)
            {
                // FOR OK
                MessageBox.Show("This is your customized Ok Message Box", "Customized Ok Message Box", MessageBoxButtons.OK);   
            }
            if (rbtnOkCancel.Checked == true)
            {
                // FOR OK CANCEL
                MessageBox.Show("This is your customized OkCancel Message Box", "Customized OkCancel Message Box", MessageBoxButtons.OKCancel);   
            }
            if (rbtnAbortRetryIgnore.Checked == true)
            {
                // FOR ABORT RETRY IGNORE
                MessageBox.Show("This is your customized AbortRetryIgnore Message Box", "Customized AbortRetryIgnore Message Box", MessageBoxButtons.AbortRetryIgnore);   
            }
            if (rbtnYesNoCancel.Checked == true)
            {
                // FOR YES NO CANCEL
                MessageBox.Show("This is your customized YesNoCancel Message Box", "Customized YesNoCancel Message Box", MessageBoxButtons.YesNoCancel);   
            }
            if (rbtnYesNo.Checked == true)
            {
                // FOR YES NO
                MessageBox.Show("This is your customized YesNo Message Box", "Customized YesNo Message Box", MessageBoxButtons.YesNo);   
            }
            if (rbtnRetryCancel.Checked == true)
            {
                // FOR RETRY CANCEL
                MessageBox.Show("This is your customized RetryCancel Message Box", "Customized RetryCancel Message Box", MessageBoxButtons.RetryCancel);   
            }
        }
    }
}
