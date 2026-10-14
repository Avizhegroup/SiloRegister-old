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
    public partial class frmChangeTagRegisterData : Form
    {
        BllConectToDeskReader _connectToDeskReader;
        private static string _port = string.Empty;

        public frmChangeTagRegisterData()
        {
            InitializeComponent();

            _port = GetSettingDictionary.DicSetting[ConfigKeys.ReaderPort].ToString();
            _connectToDeskReader = new BllConectToDeskReader();

        }

        private void frmChangeTagRegisterData_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            try
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
                _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc, null, 1);
            }
            catch (Exception ex)
            {
                pictureBox7.BackColor = Color.Red;
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void frmChangeTagRegisterData_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Focus();
            try
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
                _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc, null, 1);
            }
            catch (Exception ex)
            {
                pictureBox7.BackColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEpc_TextChanged(object sender, EventArgs e)
        {
            if (txtEpc.Text.Length == 24)
            {
                GetRegisterInfo(txtEpc.Text);

            }
        }

        private async void GetRegisterInfo(string Epc)
        {
            var api = new ApiBusiness();
            List<DML.Tag> _listProduct = new List<DML.Tag>();
            _listProduct = await api.GetTagInfo(Epc);
            if (_listProduct.Count > 0)
            {
                lblRegisterPCode.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductCode;
                lblRegisterPRegCode.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).RegCode;
                lblRegisterPSerial.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductSerial;
                lblRegisterPSize.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductSize;
                lblRegisterPStatus.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductStatusTitle;
                lblRegisterPTitle.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductName;
                lblTagStatusTitle.Text= _listProduct.FirstOrDefault(p => p.TagEpc == Epc).TagStatusTitle;
                lblInspectStatusTitle.Text= _listProduct.FirstOrDefault(p => p.TagEpc == Epc).InspectStatusTitle;
            if(lblInspectStatusTitle.Text== "بازرسی نشده" && lblTagStatusTitle.Text== "انبارهای تولید")

                {
                    lblTestResult.Text = "امکان ویرایش تاریخ ثبت وجود دارد";
                    btnCancelRegister.Enabled = true;
                    this.BackColor = Color.White;

                }
                else
                {
                    lblTestResult.Text = "کالا بازرسی شده و به انبار وارد شده است و امکان ویرایش تاریخ ثبت آن وجود ندارد";
                    btnCancelRegister.Enabled = false;
                    this.BackColor = Color.Red;

                }
            }
            else
            {
                lblRegisterPCode.Text = "";
                lblRegisterPRegCode.Text = "";
                lblRegisterPSerial.Text = "";
                lblRegisterPSize.Text = "";
                lblRegisterPStatus.Text = "";
                lblRegisterPTitle.Text = "";
                lblTagStatusTitle.Text = "";
                lblInspectStatusTitle.Text = "";
                lblTestResult.Text = "تگ رجیستر نشده است"; 
                btnCancelRegister.Enabled = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            ChangeRegisterDate();
        }

        private async void ChangeRegisterDate()
        {
            if (txtEpc.Text.Length == 24 && lblRegisterPSerial.Text!="")
            {
                if(txtNewDate.Text.Length==10 && txtNewTime.Text.Length==5)
                {
                    ApiBusiness _api = new ApiBusiness();
                   var Result= await _api.ChangeRegisterDate(lblRegisterPSerial.Text, txtNewDate.Text, txtNewTime.Text);
                    if (Result)
                    {
                        lblTestResult.Text = "تاریخ ثبت با موفقیت تغییر یافت";
                        this.BackColor = Color.LimeGreen;
                        timerClear.Enabled = true;
                    }
                    else
                    {
                        lblTestResult.Text = "خطایی در ثبت اطلاعات رخ داده است";
                        this.BackColor = Color.Red;

                    }
                }
                
            }
        }

        private void timerClear_Tick(object sender, EventArgs e)
        {
            textBox1.Focus();

            timerClear.Enabled = false;
            this.BackColor = Color.White;
            lblRegisterPCode.Text = lblRegisterPRegCode.Text = lblRegisterPSerial.Text = lblRegisterPSize.Text = lblRegisterPStatus.Text = lblRegisterPTitle.Text = "";
            txtEpc.Text = "";
            lblTestResult.Text = "";
            lblTestResult.BackColor = Color.White;
            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            var sp = new SerialPort(_port);
            if (sp.IsOpen)
            {
                sp.Close();
            }

            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc, null, 1);
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRegisterPSerial_Click(object sender, EventArgs e)
        {

        }
    }
}
