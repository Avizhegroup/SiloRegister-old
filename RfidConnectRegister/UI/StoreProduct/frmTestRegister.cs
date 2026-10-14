using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI.StoreProduct
{
    public partial class frmTestRegister : Form
    {
        BllConectToDeskReader _connectToDeskReader;
        private static string _port = string.Empty;

        public frmTestRegister()
        {
            InitializeComponent();

            _port = GetSettingDictionary.DicSetting[ConfigKeys.ReaderPort].ToString();

            _connectToDeskReader = new BllConectToDeskReader();
          
        }


        private async void GetPrintInfoFromBarocde(string ProductSerial)
        {
            try
            {
                var api = new ApiBusiness();
                List<DML.Tag> _listProduct = new List<DML.Tag>();
                _listProduct = await api.GetPrintInfo(ProductSerial, DataAccess.Items.OnlineUserCode);
                if (_listProduct.Count > 0)
                {
                    lblLablePCode.Text = _listProduct.FirstOrDefault(p => p.ProductSerial == ProductSerial).ProductCode;
                    lblLablePStatus.Text = _listProduct.FirstOrDefault(p => p.ProductSerial == ProductSerial).ProductStatus.ToString();
                    lblLablePTitle.Text = _listProduct.FirstOrDefault(p => p.ProductSerial == ProductSerial).ProductName;
                }
                else
                {
                    lblLablePCode.Text = "";
                    //lblLablePSerial.Text = "";
                    lblLablePStatus.Text = "";
                    lblLablePTitle.Text = "";
                    //this.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void GetRegisterInfo(string Epc)
        {
            var api = new ApiBusiness();
            List<DML.Tag> _listProduct = new List<DML.Tag>();
            _listProduct = await api.GetTagInfo(Epc);
            if(_listProduct.Count>0)
            {
                lblRegisterPCode.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductCode;
                lblRegisterPRegCode.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).RegCode;
                lblRegisterPSerial.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductSerial;
                lblRegisterPSize.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductSize;
                lblRegisterPStatus.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductStatusTitle;
                lblRegisterPTitle.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductName;
            }
            else
            {
                lblRegisterPCode.Text = "";
                lblRegisterPRegCode.Text = "";
                lblRegisterPSerial.Text ="";
                lblRegisterPSize.Text = "";
                lblRegisterPStatus.Text = "";
                lblRegisterPTitle.Text ="";
                lblTestResult.Text = "تگ رجیستر نشده است";
                timerClear.Enabled = true;
                this.BackColor = Color.Red;
             }
            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            var sp = new SerialPort(_port);
            if (sp.IsOpen)
            {
                sp.Close();
            }
        }

        private void TestRegister(string PrintProductSerial,string RegisterProductSerial)
        {
            if(PrintProductSerial.Length>0 && RegisterProductSerial.Length>0)
            {
                timerClear.Enabled = true;

                if (PrintProductSerial!= RegisterProductSerial)
                {
                    this.BackColor = Color.Red;
                    lblTestResult.Text = "تگ برای سریال دیگری رجیستر شده است";
                }
                else
                {
                    this.BackColor = Color.Green;
                    lblTestResult.Text = "تگ به صورت صحیح رجیستر شده است";

                }
            }
        }

        private void frmTestRegister_Load(object sender, EventArgs e)
        {
            

          
            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            var sp = new SerialPort(_port);
            if (sp.IsOpen)
            {
                sp.Close();
            }
            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);
            timerFocus.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSerialCode.Focus();
        }

        private void txtSerialCode_TextChanged(object sender, EventArgs e)
        {
            if(txtSerialCode.Text!="")
            timerCheckBarcode.Enabled = true;
            else
                timerCheckBarcode.Enabled = false;

        }

        private void timerCheckBarcode_Tick(object sender, EventArgs e)
        {
            timerCheckBarcode.Enabled = false;
            lblLablePSerial.Text = txtSerialCode.Text.Trim();
            GetPrintInfoFromBarocde(txtSerialCode.Text);
            txtSerialCode.Text = "";
        }

        private void timerClear_Tick(object sender, EventArgs e)
        {
            timerClear.Enabled = false;
            this.BackColor = Color.White;
            lblLablePCode.Text =lblLablePSerial.Text = lblLablePStatus.Text = lblLablePTitle.Text = lblRegisterPCode.Text = lblRegisterPRegCode.Text = lblRegisterPSerial.Text = lblRegisterPSize.Text = lblRegisterPStatus.Text = lblRegisterPTitle.Text = "";
            txtSerialCode.Text = "";
            txtEpc.Text = "";
            txtSerialCode.Focus();
            lblTestResult.Text = "";

         


            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            var sp = new SerialPort(_port);
            if (sp.IsOpen)
            {
                sp.Close();
            }

            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);
        }

        private void lblLablePSerial_TextChanged(object sender, EventArgs e)
        {
       //     GetPrintInfoFromBarocde(lblLablePSerial.Text);
            TestRegister(lblLablePSerial.Text, lblRegisterPSerial.Text);
        }

        private void lblRegisterPSerial_TextChanged(object sender, EventArgs e)
        {
            TestRegister(lblLablePSerial.Text, lblRegisterPSerial.Text);

        }

        private void txtEpc_TextChanged(object sender, EventArgs e)
        {
            if (txtEpc.Text.Length==24)
            {
                GetRegisterInfo(txtEpc.Text);
                
             }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            lblLablePCode.Text = lblLablePSerial.Text = lblLablePStatus.Text = lblLablePTitle.Text = lblRegisterPCode.Text = lblRegisterPRegCode.Text = lblRegisterPSerial.Text = lblRegisterPSize.Text = lblRegisterPStatus.Text = lblRegisterPTitle.Text = "";
            txtSerialCode.Text = "";
            txtEpc.Text = "";
            txtSerialCode.Focus();
            lblTestResult.Text = "";

          
            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            var sp = new SerialPort(_port);
            if (sp.IsOpen)
            {
                sp.Close();
            }
            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);
        }

        private void frmTestRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            var sp = new SerialPort(_port);
            if (sp.IsOpen)
            {
                sp.Close();
            }
        }
    }
}
