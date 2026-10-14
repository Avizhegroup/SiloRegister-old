using FastReport;
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
    public partial class frmSetParent : Form
    {
        BllConectToDeskReader _connectToDeskReader;
        private static string _port = string.Empty;
        
        private List<DML.Tag> _savedPrintList = new List<DML.Tag>();
        public frmSetParent()
        {
            InitializeComponent();

            _port = GetSettingDictionary.DicSetting[ConfigKeys.ReaderPort].ToString();

            try
            {
                _connectToDeskReader = new BllConectToDeskReader();
            }
            catch
            {

            }
        }

        private void frmSetParent_Load(object sender, EventArgs e)
        {
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
            catch
            {

            }
            rdbBarcode.Checked = true;
        }


        private async void GetPrintDataByByProductSerial(string AddSerialToPrintList)
        {
            var api = new ApiBusiness();
            var _savedPrintListTemp = await api.GetTagInfo(AddSerialToPrintList);

            foreach (var _prt in _savedPrintListTemp)
            {
                if (_savedPrintList.Count == 0 || _savedPrintList.FirstOrDefault(p => p.ProductSerial == _prt.ProductSerial) == null)
                {
                    dgvSearchItems.Rows.Add(_prt.ProductSerial, _prt.ProductCode, _prt.ProductName,
                          _prt.ProductCount, (_prt.TagTreeParentSerial == "") ? "" : " دارای رول با کد :" + _prt.TagTreeParentSerial.ToString(), "حذف");
 
                    _savedPrintList.Add(_prt);
                }
            }


        }


        private async void GetTagListDataByByParentSerialANDEPC(string ParentSerial, string ParentEPC)
        {
            var api = new ApiBusiness();
            var _savedPrintListTemp = await api.GetTagListByParentCode(ParentSerial, ParentEPC);
            try
            {
                if (_savedPrintListTemp != null && _savedPrintListTemp[0] != null)
                {
                    dgvSearchItems.Rows.Clear();
                    foreach (var _prt in _savedPrintListTemp)
                    {
                        if (_savedPrintList.Count == 0 || _savedPrintList.FirstOrDefault(p => p.ProductSerial == _prt.ProductSerial) == null)
                        {
                            dgvSearchItems.Rows.Add(_prt.ProductSerial, _prt.ProductCode, _prt.ProductName,
                                  _prt.ProductCount, "", "حذف");

                            _savedPrintList.Add(_prt);
                        }
                    }

                    if (ParentSerial != "")
                        lblEpc.Text = _savedPrintListTemp[0].TagTreeParentsEpc;
                    if (ParentEPC != "")
                        txtPackageId.Text = _savedPrintListTemp[0].TagTreeParentSerial;

                }
            }
            catch
            {

            }
        }

        private void rdbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbBarcode.Checked)
            {
                timer_barcode.Enabled = true;
                btnAddSerial.Enabled = false;
            }
        }

        private void rdbType_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbType.Checked)
            {
                timer_barcode.Enabled = false;
                btnAddSerial.Enabled = true;
            }
        }

        private void timer_barcode_Tick(object sender, EventArgs e)
        {
            txtProductSerial.Select();
            txtProductSerial.Focus();
        }

        private void txtProductSerial_TextChanged(object sender, EventArgs e)
        {
            if(txtProductSerial.Text.Trim().Length==Properties.Settings.Default.SerialLength && timer_barcode.Enabled)
            {
                string _tempSerial = txtProductSerial.Text.Trim();
                GetPrintDataByByProductSerial(_tempSerial);
                txtProductSerial.Text = "";
            }
        }

        private void btnAddSerial_Click(object sender, EventArgs e)
        {
           
                string _tempSerial = txtProductSerial.Text.Trim();
                GetPrintDataByByProductSerial(_tempSerial);
                txtProductSerial.Text = "";
            
        }

        private void txtEpc_TextChanged(object sender, EventArgs e)
        {
            if (txtEpc.Text.Length == 24)
            {

                lblEpc.Text = txtEpc.Text;
                txtEpc.Text = "";
                GetTagListDataByByParentSerialANDEPC("", lblEpc.Text);

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

        private void frmSetParent_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvSearchItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = dgvSearchItems.Rows.Count.ToString();
        }


        private void  btnStartRFID_Click(object sender, EventArgs e)
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

        private async void SavePackage()
        {
            var api = new ApiBusiness();

            List<string> _listSerial = new List<string>();
             if (lblEpc.Text != "")
            {
                if (dgvSearchItems.Rows.Count > 0)
                {
                    foreach(DataGridViewRow dr in dgvSearchItems.Rows)
                    {
                        _listSerial.Add( dr.Cells["dgvColumnProductSerial"].Value.ToString());
                     }
                    if( await api.SRegisterNextlevelProductUnit(lblEpc.Text, _listSerial, DataAccess.Items.OnlineUserCode ))
                    {
                        txtPackageId.Text =await api.GetLatestNextlevelProductUnitbyEpc(lblEpc.Text) ;
                        lblSavePackageMessage.Text = "تعریف بسته با موفقیت انجام شد";
                        txtPackageId.BackColor = Color.Green;
                    }
                    else
                    {
                        txtPackageId.Text = "0";
                        lblSavePackageMessage.Text = "در تعریف بسته خطایی رخ داده است";
                        txtPackageId.BackColor = Color.Pink;

                    }

                }
            }




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePackage();

        }
        private void PrintPackLable()
        {
            if(txtPackageId.Text!="" && txtPackageId.Text != "-1" && txtPackageId.Text != "0")
            {
                int Count = dgvSearchItems.Rows.Count;
                decimal SumValue = 0;
                string SerialList = "";
                
                foreach (DataGridViewRow dr in dgvSearchItems.Rows)
                {
                    SumValue += Convert.ToDecimal(dr.Cells["dgvColumnProductCount"].Value);
                    SerialList += dr.Cells["dgvColumnProductSerial"].Value.ToString() +" - "+ dr.Cells["dgvColumnProductTitle"].Value.ToString() + "\n";
                }

                
                 

                var report = new Report();

                report.Load(Application.StartupPath + "\\PrintPackFormat.frx");
                report.PrintSettings.Printer = Properties.Settings.Default.PrinterModel.ToString(); ;
                report.PrintSettings.ShowDialog = false;
                report.SetParameterValue("کد بسته بندی", txtPackageId.Text);
                report.SetParameterValue("تعداد اقلام", Count.ToString());
                report.SetParameterValue("جمع مقدار اقلام", SumValue.ToString());
                report.SetParameterValue("لیست سریال ها", SerialList);

                report.Prepare();
                report.Print();
            }
            else
            {
                MessageBox.Show("لطفا ابتدا بسته را ثبت نمایید");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintPackLable();
        }

        private void txtPackageId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(txtPackageId.Text!="" && txtPackageId.Text!="0")
                {
                    GetTagListDataByByParentSerialANDEPC(txtPackageId.Text, "");

                }
            }
        }

        
        private async void DeleteTagFromPack(string ProductSerial)
        {
            var api = new ApiBusiness();

            List<string> _listSerial = new List<string>();
            _listSerial.Add(ProductSerial);

            await api.SRegisterNextlevelProductUnit("-1", _listSerial, DataAccess.Items.OnlineUserCode);      
        }

        private void dgvSearchItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgvSearchItems.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex==5)
            {
                DeleteTagFromPack(dgvSearchItems.Rows[e.RowIndex].Cells["dgvColumnProductSerial"].Value.ToString());
                dgvSearchItems.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("حذف سریال از رول با موفقیت ثبت شد");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvSearchItems.Rows.Clear();
            txtEpc.Text = "";
            txtPackageId.Text = "";
            lblCount.Text = "0";
            lblEpc.Text = "";
            lblSavePackageMessage.Text = "";
            txtProductSerial.Text = "";
            rdbBarcode.Checked = true;
            _savedPrintList.Clear();
        }
    }
}
