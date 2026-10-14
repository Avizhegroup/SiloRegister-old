using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;

namespace RfidConnectRegister.UI.StoreProduct
{
    public partial class frmRFIDRegisterByBarfid : Form
    {
        string _epcCode = "";
        string _barcode = "";
        Boolean _isOperationOn = false;
        Boolean _isEpcTrue = false;
        private readonly Dictionary<string, string> _epcBarcodePair;
       // private readonly ConnectTo6061 _connectTo6061;
        private readonly BllConectToDeskReader _connectToDeskReader;
        private static string _port = string.Empty;
        int SerialLength = 6;
        string _inputProductSerial = "";
        public frmRFIDRegisterByBarfid(string ProductSerial)
        {
            InitializeComponent();

            _port = GetSettingDictionary.DicSetting[ConfigKeys.ReaderPort].ToString();

            _connectToDeskReader = new BllConectToDeskReader();


            _isOperationOn = false;
            _barcode = string.Empty;
            _epcCode = string.Empty;
            _epcBarcodePair = new Dictionary<string, string>();

            _inputProductSerial = ProductSerial;
        }

        private void frmRFIDRegisterByBarfid_Load(object sender, EventArgs e)
        {
            try
            {
                SerialLength = Properties.Settings.Default.SerialLength;
                if (_inputProductSerial != "")
                {
                    txtSerialCode.Text = _inputProductSerial;
                }
            }
            catch
            {

            }
            StartRegister();
        }



        private void txtSerialCode_TextChanged(object sender, EventArgs e)
        {
            if (!_isOperationOn)
            {
                txtSerialCode.Text = string.Empty;
                txtSerialCode.Focus();
                return;
            }

            if (txtSerialCode.Text.Length > SerialLength)
            {
                txtSerialCode.Text = string.Empty;
                txtSerialCode.Focus();
            }
        }

        private void txtEpc_TextChanged(object sender, EventArgs e)
        {
            if (!_isOperationOn)
            {
                txtEpc.Text = string.Empty;
                return;
            }

            if (txtEpc.Text.Length > 24)
            {
                txtEpc.Text = string.Empty;
                return;
            }
            if (txtEpc.Text != "")
            {
                lblConnectToReaderStatus.BackColor=Color.Green;
                timerClearEPCWhenDontReadBarcode.Enabled = true;
                if (_connectToDeskReader.StartIndentifyStatus)
                {
                    _connectToDeskReader.StopIndentifyTagByDeskReader() ;
                }
                _epcCode = txtEpc.Text;
                lblShowEpc.Text = txtEpc.Text;
                txtEpc.Text = "";
                txtEpc.Clear();
                pbxRfid.BackColor = Color.Lime;
            }

        }


        private void StartRegister()
        {
            try
            {

                lblMessages.BackColor = Color.Snow;
                lblMessages.Text = @"لطفا برگه محصول را از سمتی که بارکد آن رو به بالا است نزدیک دستگاه کنید ";
                txtSerialCode.Text = txtEpc.Text = _epcCode = _barcode = string.Empty;
                _isOperationOn = true;

                if (_connectToDeskReader.StartIndentifyStatus)
                {
                    _connectToDeskReader.StopIndentifyTagByDeskReader();
                }

                //var sp = new SerialPort(_port);
                //if (sp.IsOpen)
                //{
                //    sp.Close();
                // }

                _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);

                if (_connectToDeskReader.StartIndentifyStatus && _connectToDeskReader.ConnectionStatus)
                {
                    lblConnectToReaderStatus.BackColor=Color.Yellow;
                    lblConnectToReaderStatus.Text = "اتصال موفق به ریدر";

                }
                else
                {
                    lblConnectToReaderStatus.BackColor = Color.Red;
                    lblConnectToReaderStatus.Text = "خطا در اتصال به ریدر";
                }

                timerCheckFillings.Enabled = true;
                txtSerialCode.Focus();

              if(_inputProductSerial!="")
                {
                    _barcode = _inputProductSerial;
                    CheckBarcode(_barcode);
                    timerTextboxBarcode.Enabled = true;
                    timerClearBarcodWhenDontReadTag.Interval = 100000;
                    btnCancelRegister.Visible = false;
                    button11.Visible = false;
                }

            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void ClearAllPictureBoxes()
        {
            try
            {
                pbxBarcode.BackColor = Color.Transparent;
                pbxRfid.BackColor = Color.Transparent;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void StopRegister()
        {
            try
            {
                _isOperationOn =  timerTextboxBarcode.Enabled = timerCheckFillings.Enabled = false;
                lblMessages.Text = @"توقف عملیات قرائت تگ";
                lblMessages.BackColor = Color.Snow;

                ClearAllPictureBoxes();
                timerCheckFillings.Enabled = false;
                txtEpc.Clear();
                txtSerialCode.Clear();

                _epcCode = _barcode = string.Empty;
                _connectToDeskReader.StopIndentifyTagByDeskReader();
                Thread.Sleep(1000);
                var sp = new SerialPort(_port);
                if (sp.IsOpen)
                {
                    sp.Close();
                 }

                lblConnectToReaderStatus.BackColor = Color.Red;


            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                var sp = new SerialPort(_port);
                if (sp.IsOpen)
                {
                    sp.Close();
                 }
            }
        }


        private async void timerCheckFillings_Tick(object sender, EventArgs e)
        {

            try
            {
                if (!_isOperationOn)
                {
                    timerCheckFillings.Enabled = false;
                    _isOperationOn = false;
                    _barcode = string.Empty;
                    _epcCode = string.Empty;
                    return;
                }

                txtSerialCode.Select();
                if (_epcCode == string.Empty || _barcode == string.Empty)
                    return;



                string _tempEpc = _epcCode;
                string _tempBarcode = _barcode;
                _epcCode = "";
                txtSerialCode.Text = "";
                txtEpc.Text = "";
                _barcode = "";
                if (await SaveRegister(_tempBarcode, _tempEpc)) // 
                {
                    //  lblMessages.Text = @"مشخصات با موفقیت ثبت شد";
                    // lblMessages.BackColor = Color.Lime;
                    //  _counter++;

                    _epcBarcodePair.Add(_tempBarcode, _tempEpc);
                    //  _isProgressBarCode = false;
                    

                    pbxRfid.BackColor = Color.Transparent;
                    pbxBarcode.BackColor = Color.Transparent;

 
                    lblShowEpc.Text = "";
                    lblShowBarcode.Text = "";
                    txtEpc.Clear();
                    txtSerialCode.Clear();
                    txtSerialCode.Clear();
                    txtEpc.Clear();
                    _barcode = string.Empty;
                    _epcCode = string.Empty;
                    txtSerialCode.Focus();
                    Thread.Sleep(300);
                    _isEpcTrue = false;
                    _isOperationOn = true;

                    this.DialogResult = DialogResult.No;
                    if (_inputProductSerial!="")
                    {
                        MessageBox.Show("رجیستر تگ مربوط به سریال کالا : " + _inputProductSerial + " با موفقیت انجام شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                 }
                else
                {
                    //lblMessages.Text = @"توقف عملیات : مشکل در ثبت اطلاعات در دیتابیس" + Environment.NewLine + @"دوباره تلاش کنید";
                    //lblMessages.BackColor = Color.DarkRed;
                    //btnOperationStart.ForeColor = Color.Lime;
                    //btnOperationStart.Text = @"شروع عملیات";
                    timerCheckFillings.Enabled = false;
                    _isOperationOn = false;
                }

                txtSerialCode.Clear();
                txtEpc.Clear();
                _barcode = string.Empty;
                _epcCode = string.Empty;
                txtSerialCode.Focus();

                lblMessages.Text = @"لطفا برگه محصول را از سمتی که بارکد آن رو به بالا است نزدیک دستگاه کنید ";

            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }


        private async Task<Boolean> SaveRegister(string productSerial, string epc)
        {
            ApiBusiness _api = new ApiBusiness();
            string CheckassignedTagEpcToSerial = await _api.CheckTagEPC(epc);
            if (CheckassignedTagEpcToSerial!="")
            {
                if (MessageBox.Show("شناسه این تگ  قبلا برای سریال :  " + CheckassignedTagEpcToSerial+ Environment.NewLine + " رجیستر شده است آیا مایل به حذف آن " + Environment.NewLine + " از سریال قبلی و اختصاص آن به " + Environment.NewLine + " سریال جدید  هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    return false;
                }
            }
            int ProductSerialStatus = await _api.IsProductSerialExist(productSerial);
            if (ProductSerialStatus == 0) // serial register Nashode va dar tbl_print mojod nist
            {
                // اضافه شدن به لیست با رنگ قرمز و پغیام  
                string[] RowData = { ((dgvRegister.Rows.Count) + 1).ToString(), "--", productSerial, epc, "اطلاعاتی برای رجیستر این سریال یافت نشد" };
                dgvRegister.Rows.Add(RowData);
                dgvRegister.Rows[dgvRegister.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                return false;
            }
            else if (ProductSerialStatus == 1) // serial dar tbl_print mojod ast ama register nashode
            {
                string[] epclist = { epc };
                var _ResultSaveRegisterTag = await _api.SaveRegisterTag(productSerial, "", "", epclist, DataAccess.Items.OnlineUserName);
                 if (_ResultSaveRegisterTag)
                {
                    try
                    {
 
                        string[] RowData = { ((dgvRegister.Rows.Count) + 1).ToString(), productSerial, epc, "کالا با موفقیت رجیستر شد" };
                        dgvRegister.Rows.Add(RowData);
                        dgvRegister.Rows[dgvRegister.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
 
                        Thread.Sleep(500);
                        return true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                     
                    string[] RowData = { ((dgvRegister.Rows.Count) + 1).ToString(), productSerial, epc, "خطایی در عملیات رجیستر تگ رخ داده است" };
                    dgvRegister.Rows.Add(RowData);
                    dgvRegister.Rows[dgvRegister.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    return false;
                }
                // اضافه شدن به لیست با رنگ سبز و پیغام ثبت شد 
            }
            else if (ProductSerialStatus == 2)// serial dar tbl_tags mojod yani register shode
            {
                if (MessageBox.Show("سریال " + productSerial + " قبلا رجیستر شده است "+Environment.NewLine+" آیا مایل به ویرایش آن با تگ جدیدی هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] epclist = { epc };

                    if (await _api.SaveRegisterTag(productSerial, "", "", epclist, ""))
                    {
                        string[] RowData = { ((dgvRegister.Rows.Count) + 1).ToString(), productSerial, epc, "رجیستر تگ با موفیت ویرایش شد" };
                        dgvRegister.Rows.Add(RowData);
                        dgvRegister.Rows[dgvRegister.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightYellow;
                        return true;
                    }
                    else
                    {
                        string[] RowData = { ((dgvRegister.Rows.Count) + 1).ToString(), productSerial, epc, "خطایی در عملیات ویرایش تگ رخ داده است" };
                        dgvRegister.Rows.Add(RowData);
                        dgvRegister.Rows[dgvRegister.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                        return false;
                    }
                }
            }

            return true;
        }

        private void timerTextboxBarcode_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTextboxBarcode.Enabled = false;
            }
            catch (Exception ex)
            {
                // Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }
        private void CheckBarcode(string barcode)
        {
            try
            {
                if (string.IsNullOrEmpty(barcode)) return;
                if (barcode.Length > SerialLength) return;

                var arrayQrCode = barcode.Trim().Split(char.Parse(GetSettingDictionary.DicSetting[ConfigKeys.BarcodeSpliter]));
                switch (arrayQrCode.Length)
                {
                    case 3:
                        barcode = arrayQrCode[2];
                        break;
                    case 2:
                        barcode = arrayQrCode[1];
                        break;
                }

                _barcode = barcode.Trim();

                //if (DictionaryContains(_barcode, false))
                //{
                //    txtSerialCode.Clear();
                //    _barcode = string.Empty;
                //    pbxBarcode.BackColor = Color.Transparent;
                //    return;
                //}
                lblShowBarcode.Text = _barcode;
                txtSerialCode.Text = string.Empty;
                if (!_isEpcTrue)
                {
                    lblMessages.Text = @"منتظر خواندن تگ...";
                }

                pbxBarcode.BackColor = Color.Lime;

                timerClearBarcodWhenDontReadTag.Enabled = true;

            }
            catch (IndexOutOfRangeException ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                //   ClearAndUnableAll();
                lblMessages.Text = @"ایندکس وارد شده در تنظیمات مقدار خارج از محدوده است";
                lblMessages.BackColor = Color.DarkRed;
            }
            catch (FormatException ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                // ClearAndUnableAll();
                lblMessages.Text = @"ایندکس وارد شده در تنظیمات مقدار درستی نیست";
                lblMessages.BackColor = Color.DarkRed;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void timerClearBarcodWhenDontReadTag_Tick(object sender, EventArgs e)
        {

            timerClearBarcodWhenDontReadTag.Enabled = false;
            _barcode = string.Empty;
            txtSerialCode.Text = string.Empty;
            pbxBarcode.BackColor = Color.Transparent;
            lblShowBarcode.Text = "";
            txtSerialCode.Focus();
        }

        private void timerClearEPCWhenDontReadBarcode_Tick(object sender, EventArgs e)
        {
            timerClearEPCWhenDontReadBarcode.Enabled = false;
            _epcCode = string.Empty;
            txtEpc.Text = string.Empty;
            pbxRfid.BackColor = Color.Transparent;
            lblShowEpc.Text = "";
            if (_connectToDeskReader.StartIndentifyStatus)
            {
                _connectToDeskReader.StopIndentifyTagByDeskReader();
            }
            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc,null,1);
            txtSerialCode.Focus();

        }

        private void txtSerialCode_KeyDown(object sender, KeyEventArgs e)
        {

            if (!_isOperationOn)
            {
                timerTextboxBarcode.Enabled = false;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if ((txtSerialCode.Text.Length <= SerialLength || txtSerialCode.Text.Length >= SerialLength) && _barcode == "")
                    {
                        _barcode = txtSerialCode.Text;
                        CheckBarcode(_barcode);

                        //if (!_isProgressBarCode)
                        //{
                        //    return;
                        //}

                        if (!_isOperationOn)
                        {
                            txtSerialCode.Text = string.Empty;
                            return;
                        }

                        timerTextboxBarcode.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    Tools.ExceptionLogger.WriteExceptionLogs(ex);
                }
            }

        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            StopRegister();
            Thread.Sleep(500);
            new frmCancelRegisterTag().ShowDialog();
            Thread.Sleep(500);
            StartRegister();
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            StopRegister();
            Thread.Sleep(500);
           new frmTestRegister().ShowDialog();
            Thread.Sleep(500);
            StartRegister();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRFIDRegisterByBarfid_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lblConnectToReaderStatus_Click(object sender, EventArgs e)
        {

        }

        private async Task TestRegister()
        {
            await SaveRegister("594616", "E200421914506013TESTTEST");

        }

        private void button2_ClickAsync(object sender, EventArgs e)
        {
            TestRegister();
        }
    }
}
