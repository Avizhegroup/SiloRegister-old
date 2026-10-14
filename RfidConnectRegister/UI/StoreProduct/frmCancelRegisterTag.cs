using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using RfidConnectRegister.DML;
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
    public partial class frmCancelRegisterTag : Form
    {
        BllConectToDeskReader _connectToDeskReader;
        private static string _port = string.Empty;
        private List<WarehouseDto> _WarehouseList = new List<WarehouseDto>();
        bool _destinationCancelAllow = false;
        ApiBusiness api = new ApiBusiness();

        public frmCancelRegisterTag( )
        {
            InitializeComponent();

            _port = GetSettingDictionary.DicSetting[ConfigKeys.ReaderPort].ToString();
            _connectToDeskReader = new BllConectToDeskReader();
            GetAllWarehouses();
        }

        private async void GetAllWarehouses()
        {
            _WarehouseList =await api.GetAllWarehouses();

        }

        private void frmCancelRegisterTag_Load(object sender, EventArgs e)
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
                _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);
            }
            catch(Exception ex)
            {
                pictureBox7.BackColor = Color.Red;
            }
        }

        private void frmCancelRegisterTag_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtEpc_TextChanged(object sender, EventArgs e)
        {
            if (txtEpc.Text.Length == 24)
            {
                GetRegisterInfo(txtEpc.Text);
                
            }
        }

        private async void GetRegisterInfo(string Epc)
        {
            List<DML.Tag> _listProduct = new List<DML.Tag>();
            _listProduct = await api.GetTagInfo(Epc);
            if (_listProduct.Count > 0 && _WarehouseList.Count>0)
            {
                lblRegisterPCode.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductCode;
                lblRegisterPRegCode.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).RegCode;
                lblRegisterPSerial.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductSerial;
                lblRegisterPSize.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductSize;
                lblRegisterPStatus.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductStatusTitle;
                lblRegisterPTitle.Text = _listProduct.FirstOrDefault(p => p.TagEpc == Epc).ProductName;
                _destinationCancelAllow = _WarehouseList.FirstOrDefault(H => H.DestinationCode == (_listProduct.FirstOrDefault(p => p.TagEpc == Epc).TagInDestinationId)).allowCancel;
            }
            else
            {
                lblRegisterPCode.Text = "";
                lblRegisterPRegCode.Text = "";
                lblRegisterPSerial.Text = "";
                lblRegisterPSize.Text = "";
                lblRegisterPStatus.Text = "";
                lblRegisterPTitle.Text = "";                  
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

        private async void btnCancelRegister_Click(object sender, EventArgs e)
        {
            if (txtEpc.Text.Length == 24)
            {
                if (_destinationCancelAllow)
                {
                    ApiBusiness _api = new ApiBusiness();
                    if (await _api.CancelRegisterTag(txtEpc.Text, DataAccess.Items.OnlineUserName))
                    {
                        lblTestResult.Text = "ابطال با موفقیت ثبت شد";
                        this.BackColor = Color.Green;

                    }
                    else
                    {
                        lblTestResult.Text = "خطا در عملیات ثبت ابطال تگ ";
                        this.BackColor = Color.Red;
                    }
                    
                }
                else
                {
                    lblTestResult.Text = "این سریال مجاز به ابطال نمی باشد";
                    this.BackColor = Color.Red;
                }
                timerClear.Enabled = true;
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

            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);
        }
    }
}
