using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI
{
    public partial class frmShowAlert : Form
    {
         public frmShowAlert(string Message)
        {
            InitializeComponent();
            label1.Text = Message;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowAlert_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            System.Media.SystemSounds.Hand.Play();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
