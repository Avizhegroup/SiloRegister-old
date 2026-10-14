using DocumentFormat.OpenXml.Drawing.Charts;
using FastReport;
using Newtonsoft.Json.Linq;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using RfidConnectRegister.BussinessLogic;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using RfidConnectRegister.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI.StoreProduct
{
    public partial class frmPrintRegsiterTags : Form
    {
        private List<DML.Print> _savedPrintList = new List<DML.Print>();
        string _printActionId = "";
        int _countPrint = 0;
        bool FlagPrintActionBefore = false;
        string ProductSerialRegisterActionBefore = "";

        string ProductSerialSelectedForEditORDelete = "";
        private List<DML.ProductionLine> _listProductionLine = new List<DML.ProductionLine>();
        private List<DML.ProductionShift> _listProductionShift = new List<DML.ProductionShift>();
        private List<DML.WarehouseDto> _listWareHouses = new List<DML.WarehouseDto>();
        List<DynamicFieldDto> _dynamicFieldDtos = new List<DynamicFieldDto>();

        ApiBusiness api = new ApiBusiness();



        public frmPrintRegsiterTags(string PrintActionId,int CountPrint)
        {
            InitializeComponent();
            _printActionId = PrintActionId;
            _countPrint = CountPrint;
        }



        private async void frmPrintRegsiterTags_Load(object sender, EventArgs e)
        {
            GetSavedPrinList(_printActionId);
            ComputeCountPrinted();
            if (Properties.Settings.Default.IsZpl)
            {
                CreateZplPrintButtons();
            }
            else
            {
                CreateZminPrintButtons();
            }
            CreatePrintButtons();
            chbdgvPrint.Checked = true;
        }


        private void CreateZplPrintButtons()
        {
            int index = 0;
            string[] _printFormatNameList = Directory.GetFiles(Application.StartupPath + "\\zpl_Formats");
            foreach (string printFormatNam in _printFormatNameList)
            {

                Button btnFormatPrint = new Button();
                btnFormatPrint.Text = "چاپ و رجیستر تگ _ " + printFormatNam.Replace(Application.StartupPath + "\\zpl_Formats\\", "").Replace(".txt", "");
                btnFormatPrint.Name = printFormatNam.Replace(Application.StartupPath + "\\zpl_Formats\\", "").Replace(".txt", ""); ;
                btnFormatPrint.Tag = printFormatNam;



                btnFormatPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                btnFormatPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
                btnFormatPrint.Cursor = System.Windows.Forms.Cursors.Hand;
                btnFormatPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
                btnFormatPrint.FlatAppearance.BorderSize = 0;
                btnFormatPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                btnFormatPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                btnFormatPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnFormatPrint.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
                btnFormatPrint.ForeColor = System.Drawing.SystemColors.ControlText;
                btnFormatPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                btnFormatPrint.ImageKey = "printer.png";
                btnFormatPrint.Location = new System.Drawing.Point(10, (index * 38) + (index * 8) + 8);
                btnFormatPrint.Size = new System.Drawing.Size(339, 38);
                btnFormatPrint.UseVisualStyleBackColor = false;
                btnFormatPrint.Click += new System.EventHandler(this.PrintZplFormatAsync);

                pnlZplButtons.Controls.Add(btnFormatPrint);
                index++;
            }
        }

        private void CreateZminPrintButtons()
        {
            int index = 0;
            string zminFormatsPath = Application.StartupPath + "\\zmin_Formats";

            // Create directory if it doesn't exist
            if (!Directory.Exists(zminFormatsPath))
            {
                Directory.CreateDirectory(zminFormatsPath);
                return;
            }

            string[] _printFormatNameList = Directory.GetFiles(zminFormatsPath, "*.lsf");
            foreach (string printFormatNam in _printFormatNameList)
            {
                Button btnFormatPrint = new Button();
                btnFormatPrint.Text = "چاپ و رجیستر تگ _ " + printFormatNam.Replace(Application.StartupPath + "\\zmin_Formats\\", "").Replace(".lsf", "");
                btnFormatPrint.Name = printFormatNam.Replace(Application.StartupPath + "\\zmin_Formats\\", "").Replace(".lsf", "");
                btnFormatPrint.Tag = printFormatNam;

                btnFormatPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                btnFormatPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
                btnFormatPrint.Cursor = System.Windows.Forms.Cursors.Hand;
                btnFormatPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
                btnFormatPrint.FlatAppearance.BorderSize = 0;
                btnFormatPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                btnFormatPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                btnFormatPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnFormatPrint.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
                btnFormatPrint.ForeColor = System.Drawing.SystemColors.ControlText;
                btnFormatPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                btnFormatPrint.ImageKey = "printer.png";
                btnFormatPrint.Location = new System.Drawing.Point(10, (index * 38) + (index * 8) + 8);
                btnFormatPrint.Size = new System.Drawing.Size(339, 38);
                btnFormatPrint.UseVisualStyleBackColor = false;
                btnFormatPrint.Click += new System.EventHandler(this.PrintZminFormatAsync);

                pnlZplButtons.Controls.Add(btnFormatPrint);
                index++;
            }
        }

        private void CreatePrintButtons()
        {
            int index = 0;
            string[] _printFormatNameList = Directory.GetFiles(Application.StartupPath + "\\Print_Formats");
            foreach (string printFormatNam in _printFormatNameList)
            {

                Button btnFormatPrint = new Button();
                btnFormatPrint.Text = printFormatNam.Replace(Application.StartupPath + "\\Print_Formats\\", "").Replace(".frx", "").Split('_')[0];
                btnFormatPrint.Name = printFormatNam.Replace(Application.StartupPath + "\\Print_Formats\\", "").Replace(".frx", "").Split('_')[0]; ;
                btnFormatPrint.Tag = printFormatNam;



                btnFormatPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                btnFormatPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
                btnFormatPrint.Cursor = System.Windows.Forms.Cursors.Hand;
                btnFormatPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
                btnFormatPrint.FlatAppearance.BorderSize = 0;
                btnFormatPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                btnFormatPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                btnFormatPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnFormatPrint.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
                btnFormatPrint.ForeColor = System.Drawing.SystemColors.ControlText;
                btnFormatPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                btnFormatPrint.ImageKey = "printer.png";
                btnFormatPrint.Location = new System.Drawing.Point(10, (index * 38) + (index * 8) + 8);
                btnFormatPrint.Size = new System.Drawing.Size(339, 38);
                btnFormatPrint.UseVisualStyleBackColor = false;
                btnFormatPrint.Click += new EventHandler(PrintSavedFormat);
                pnlPrintFormat.Controls.Add(btnFormatPrint);
                index++;
            }
        }



        private async Task UpdatePrintStatus(string ProductSerial)
        {
            var _api = new ApiBusiness();
            _api.PrintUpdatePrintStatus(ProductSerial);
        }
        private void ComputeCountPrinted()
        {
            int CountPrinted = 0;
            foreach (var _print in _savedPrintList)
            {
                if (_print.PrintFlag == 1)
                {
                    CountPrinted++;
                }
            }
            lblbtnPrintCountDo.Text = CountPrinted.ToString();
        }

        private async Task GetSavedPrinList(string PrintActionId)
        {

            dgvPrint.Rows.Clear();
            var api = new ApiBusiness();
            _savedPrintList = await api.GetPrintListByPrintActionId(PrintActionId);
            if(_savedPrintList.Count!=_countPrint)
            {
                _savedPrintList = await api.GetPrintListByPrintActionId(PrintActionId);
                if (_savedPrintList.Count != _countPrint)
                {
                    _savedPrintList = await api.GetPrintListByPrintActionId(PrintActionId);
                    if (_savedPrintList.Count != _countPrint)
                    {
                        _savedPrintList = await api.GetPrintListByPrintActionId(PrintActionId);
                    }
                }

            }
            foreach (var _prt in _savedPrintList)
            {
                bool PrintStatus = true;
                if (_prt.PrintFlag == 1)
                {
                    PrintStatus = false;
                }
                else
                {
                    if (_prt.TagEpc != "")
                    {
                        PrintStatus = false;
                    }
                }

                dgvPrint.Rows.Add((PrintStatus) ? "True" : "False", _prt.Id, _prt.ProductSerial, _prt.ProductCode, _prt.ProductTitle,
                    _prt.ProductENTitle, _prt.ProductCount, _prt.ProductItemCount,
                    _prt.ProductCountInPack, _prt.ProductUnit, _prt.ProductSize, _prt.ProductRegCode,
                    _prt.ProductStatusTitle, _prt.DocumentId, _prt.ProductOldSerial,
                    _prt.ProductProductionLineTitle, _prt.ProductProductionShiftTitle,
                     _prt.PrintType, _prt.PrintUser, (PrintStatus) ? "چاپ نشده" : "چاپ شده", _prt.RegisterFlag, _prt.InputFileName, "حذف", _prt.ProductType, _prt.ProductContractType, _prt.TagEpc);
                dgvPrint.Rows[dgvPrint.Rows.Count - 1].DefaultCellStyle.BackColor = (PrintStatus) ? Color.White : Color.LightGreen;

                if (!PrintStatus)
                {
                    FlagPrintActionBefore = true;
                }

                if (_prt.TagEpc != "")
                {
                    ProductSerialRegisterActionBefore += _prt.ProductSerial + "  -  " + _prt.ProductOldSerial + Environment.NewLine;
                }
            }

            if (FlagPrintActionBefore)
            {
                if (MessageBox.Show("همه یا برخی از سریال های این عملیات قبلا چاپ شده است ! " + Environment.NewLine + "آیا از ادامه عملیات اطمینان دارید؟؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    this.Close();
                }
            }

            if (ProductSerialRegisterActionBefore != "")
            {
                if (MessageBox.Show("سریال های زیر قبلا رجیستر شده اند " + Environment.NewLine + ProductSerialRegisterActionBefore + Environment.NewLine + "آیا از ادامه عملیات اطمینان دارید؟؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    this.Close();
                }
            }

        }

        private void chbdgvPrint_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvPrint.Rows)
            {
                dr.Cells[0].Value = chbdgvPrint.Checked;
            }
        }

        private void dgvPrint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvPrint.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == dgvPrint.Rows[e.RowIndex].Cells["btnDgvEditData"].ColumnIndex)
                {
                    ShowProductAndEditePanel(dgvPrint.Rows[e.RowIndex].Cells["dgvPrintId"].Value.ToString());
                }
            }
        }

        private void ShowProductAndEditePanel(string ProductSerialPrintId)
        {

            GetAndFill(ProductSerialPrintId);
            pnlShowProductInfoANDEdit.Visible = true;
            ProductSerialSelectedForEditORDelete = _savedPrintList.FirstOrDefault(p => p.Id.ToString() == ProductSerialPrintId).ProductSerial;
            label3.Text = "نمایش و ویرایش اطلاعات کالا با سریال : " + ProductSerialSelectedForEditORDelete;
        }


        private async Task GetAndFill(string ProductSerialPrintId)
        {
            _listProductionLine = await api.GetAllProductionLine();
            _listProductionShift = await api.GetAllProductionShift();
            _listWareHouses = await api.GetAllWarehouses();




            cmbProductionLine.DataSource = _listProductionLine;
            cmbProductionLine.DisplayMember = "ProductionLineTitle";
            cmbProductionLine.ValueMember = "ProductionLineCode";

            if (cmbProductionLine.Items.Count == 1)
            {
                cmbProductionLine.SelectedIndex = 0;
                cmbProductionLine.Enabled = false;
            }
            else
                cmbProductionLine.SelectedIndex = -1;


            cmbProductionShift.DataSource = _listProductionShift;
            cmbProductionShift.DisplayMember = "ProductionShiftTitle";
            cmbProductionShift.ValueMember = "ProductionShiftCode";


            if (cmbProductionShift.Items.Count == 1)
            {
                cmbProductionShift.SelectedIndex = 0;
                cmbProductionShift.Enabled = false;
            }
            else
                cmbProductionShift.SelectedIndex = -1;


            cmbStore.DataSource = _listWareHouses.Where(p => p.IsActive = true && p.OperationalType == DestinationOperationalType.Production && p.InventoryType == DestinationInventoryType.Physical).ToList();
            cmbStore.DisplayMember = "DestinationTitle";
            cmbStore.ValueMember = "DestinationCode";

            if (cmbStore.Items.Count == 1)
            {
                cmbStore.SelectedIndex = 0;
                cmbStore.Enabled = false;
            }
            else
                cmbStore.SelectedIndex = -1;

            ///متد زیر را اجرا میکند
            ///

            var _selectedPrint = _savedPrintList.FirstOrDefault(p => p.Id.ToString() == ProductSerialPrintId);
            if (_selectedPrint != null)
            {
                txtDocumentId.Text = _selectedPrint.DocumentId;
                txtProductCode.Text = _selectedPrint.ProductCode;
                txtProductTitle.Text = _selectedPrint.ProductTitle;
                txtProductPackValue.Text = _selectedPrint.ProductCount.ToString();
                cmbProductionLine.SelectedValue = _selectedPrint.ProductProductionLine;
                cmbProductionShift.SelectedValue = _selectedPrint.ProductProductionShift;

                if (_selectedPrint.ProductProperties != null && _selectedPrint.ProductProperties != "")
                {
                    try
                    {
                        GetANDSetDynamicFieldDtos(_selectedPrint.ProductProperties);


                    }
                    catch
                    {

                    }
                }
                cmbStore.SelectedValue = _selectedPrint.WareHouseCode;


            }

        }



        private async Task GetANDSetDynamicFieldDtos(string _selectedPrintProductProperties)
        {
            _dynamicFieldDtos = await api.GetDynamicFieldsByActionTypeId("0");
            var tt = JToken.Parse(_selectedPrintProductProperties);

            int index = 0;
            foreach (DynamicFieldDto field in _dynamicFieldDtos.OrderBy(p => p.Id))
            {
                //switch (field.DataTyp)
                //{
                //    case "":

                string value = "";

                foreach (JProperty jj in tt)
                {
                    if (jj.Name.ToLower().Trim() == field.Title.ToLower().Trim())
                    {
                        value = jj.Value.ToString();

                        foreach (var _dynamicFieldDto in _dynamicFieldDtos)
                        {
                            if (_dynamicFieldDto.Title.ToLower().Trim() == jj.Name.ToLower().Trim())
                            {
                                _dynamicFieldDto.Value = jj.Value.ToString();
                                break;
                            }
                        }

                        break;

                    }
                }



                System.Windows.Forms.Label lable_temp = new System.Windows.Forms.Label();

                string[] _DataTemp = field.RelatedTitle1.Split(',');

                lable_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

                lable_temp.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
                lable_temp.Location = new System.Drawing.Point(255 + (pnlDynamicFeilds.Size.Width - 376), (index * 36) + (index * 4) + 0);
                lable_temp.Name = "label" + field.Id;
                lable_temp.Size = new System.Drawing.Size(134, 36);
                lable_temp.TabIndex = 2;
                lable_temp.Text = field.Title + ":";
                lable_temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                pnlDynamicFeilds.Controls.Add(lable_temp);

                if (_DataTemp.Length > 1)
                {
                    System.Windows.Forms.ComboBox combo_temp = new ComboBox();




                    combo_temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));

                    combo_temp.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);
                    combo_temp.FormattingEnabled = true;
                    combo_temp.Location = new System.Drawing.Point(2, (index * 36) + (index * 4) + 0);
                    combo_temp.Name = "dynamic_Control" + field.Title;
                    combo_temp.Tag = field.Id;
                    combo_temp.Size = new System.Drawing.Size(252 + (pnlDynamicFeilds.Size.Width - 376), 36);
                    combo_temp.TabIndex = 7;
                    combo_temp.Leave += new System.EventHandler(this.DynamicField_Leave);




                    for (int i = 0; i < _DataTemp.Length; i++)
                        combo_temp.Items.Add(_DataTemp[i]);


                    combo_temp.SelectedItem = value;
                    pnlDynamicFeilds.Controls.Add(combo_temp);
                }
                else
                {

                    System.Windows.Forms.TextBox TextBox_temp = new System.Windows.Forms.TextBox();



                    TextBox_temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));

                    TextBox_temp.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);

                    TextBox_temp.Location = new System.Drawing.Point(2, (index * 36) + (index * 4) + 0);
                    TextBox_temp.Name = "dynamic_Control" + field.Title;
                    TextBox_temp.Tag = field.Id;
                    TextBox_temp.Size = new System.Drawing.Size(252 + (pnlDynamicFeilds.Size.Width - 376), 36);
                    TextBox_temp.TabIndex = 7;
                    TextBox_temp.Leave += new System.EventHandler(this.DynamicField_Leave);



                    TextBox_temp.Text = value;

                    pnlDynamicFeilds.Controls.Add(TextBox_temp);
                }



                //        break;
                //}
                index++;
            }


        }

        private void DynamicField_Leave(object sender, EventArgs e)
        {
            _dynamicFieldDtos.FirstOrDefault(p => p.Id.ToString() == ((Control)sender).Tag.ToString()).Value = ((Control)sender).Text;

        }


        private void showPrintPageData(DML.Print _selectedPrint)
        {
            //try
            //{
            //    lblPrintFormProductCode.Text= _selectedPrint.ProductCode;
            //    lblPrintForm_OldSerial.Text = _selectedPrint.ProductOldSerial.ToString();
            //    lblPrintFormTitle.Text = _selectedPrint.ProductTitle;
            //    //lblPrintFormQc.Text = _selectedPrint.ProductStatusTitle;
            //    lblPrintFormRegCode.Text = _selectedPrint.ProductRegCode;
            //    //lblPrintFormSize.Text = _selectedPrint.ProductSize;
            //    //lblPrintFormCountInPack.Text = _selectedPrint.ProductCountInPack.ToString();
            //    //lblPrintFormItemCount.Text = _selectedPrint.ProductItemCount.ToString();
            //    //lblPrintFormProductCount.Text = _selectedPrint.ProductCount.ToString();
            //    lblPrintFormSerial.Text = _selectedPrint.ProductSerial;
            //    //lblPrintFormUnit2.Text = _selectedPrint.ProductUnit;
            //    //lblPrintFormUnit.Text = _selectedPrint.ProductUnit;
            //    lblPrintFormDate.Text = BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(2, 4)+_selectedPrint.DocumentId;
            //    lblProductContractTypeText.Text=((_selectedPrint.ProductContractType=="1") ? "نیمه آماده" : "");
            //}
            //catch
            //{

            //}


        }

        private async void btnAddSerialToPrintList_ClickAsync(object sender, EventArgs e)
        {
            if (txtAddSerialToPrintList.Text != "")
            {
                GetPrintDataByByProductSerial(txtAddSerialToPrintList.Text);
                pnlAddSerialToPrintList.Visible = false;
            }
        }

        private void btnCancelAddSerialToPrintList_Click(object sender, EventArgs e)
        {
            pnlAddSerialToPrintList.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pnlAddSerialToPrintList.Visible = true;
            txtAddSerialToPrintList.Text = "";
            txtAddSerialToPrintList.Focus();
        }

        private void btnPrintPage_Click(object sender, EventArgs e)
        {
            RFIDPrint();
        }




        private void Clear(int kindClear)
        {
            if (kindClear == 0)
            {


                dgvPrint.Rows.Clear();
            }
            if (kindClear == 1 || kindClear == 0)//Print Data
            {
                lblbtnPrintCountDo.Text = "0";
                //             lblPrintForm_OldSerial.Text=lblPrintFormDate.Text=lblPrintFormProductCode.Text=lblPrintFormRegCode.Text=lblPrintFormSerial.Text=lblPrintFormTitle.Text="";
                lblbtnPrintCount.Text = "0";
                _savedPrintList.Clear();
            }
        }


        private async Task<Boolean> SaveRegister(string productSerial, string epc, string ProductCode)
        {

            ApiBusiness _api = new ApiBusiness();

            //if (await _api.CheckTagEPC(epc))
            //{
            //    if (MessageBox.Show("شناسه این تگ  قبلا برای یک سریال دیگر " + Environment.NewLine + " رجیستر شده است آیا مایل به حذف آن " + Environment.NewLine + " از سریال قبلی و اختصاص آن به " + Environment.NewLine + " سریال جدید  هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            //    {
            //        return true;
            //    }
            //}
            //  int ProductSerialStatus = await _api.IsProductSerialExist(productSerial, "", "", "");

            //else if (ProductSerialStatus == 1) // serial dar tbl_print mojod ast ama register nashode
            //{
            string[] epclist = { epc };
            if (await _api.SaveRegisterTag(productSerial, ProductCode, "", epclist, DataAccess.Items.OnlineUserName))
            {
                string[] RowData = { ((dgvPrint.Rows.Count) + 1).ToString(), productSerial, epc, "کالا با موفقیت رجیستر شد" };
                return true;
            }
            else
            {
                string[] RowData = { ((dgvPrint.Rows.Count) + 1).ToString(), productSerial, epc, "خطایی در عملیات رجیستر تگ رخ داده است" };

                return false;
            }
            // اضافه شدن به لیست با رنگ سبز و پیغام ثبت شد 
            //}
        }

        private async void RFIDPrint()
        {

        }

        private async void PrintZplFormatAsync(object sender, EventArgs e)
        {
            try
            {


                if (dgvPrint.Rows.Count == 0)
                {
                    MessageBox.Show(@"هنوز هیچ موردی برای چاپ تعریف شده است", @"خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }


                if (ProductSerialRegisterActionBefore != "")
                {
                    if (MessageBox.Show("سریال های زیر قبلا رجیستر شده اند " + Environment.NewLine + ProductSerialRegisterActionBefore + Environment.NewLine + "آیا از ادامه عملیات اطمینان دارید؟؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                pnlZplButtons.Enabled = false;

                ApiBusiness _api = new ApiBusiness();
                var list = new List<DML.Product>();
                var flag = false;
                foreach (DataGridViewRow row in dgvPrint.Rows)
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        var _selectedPrint = _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString()));

                        var DataProuduct = _api.GetAllProductByTechnicalData(_selectedPrint.ProductCode.ToString());
                        var printerName = Properties.Settings.Default.PrinterModel;
                        if (printerName == string.Empty)
                        {
                            MessageBox.Show("ابتدا چاپگر را برای این نوع از جاپ مشخص کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        var btn = (Button)sender;

                        string ZplTemp = File.ReadAllText(btn.Tag.ToString());





                        if (ZplTemp.Contains("[سریال_قدیمی]"))
                        {
                            ZplTemp = ZplTemp.Replace("[سریال_قدیمی]", _selectedPrint.ProductOldSerial);
                        }
                        if (ZplTemp.Contains("[سریال_محموله]"))
                        {
                            ZplTemp = ZplTemp.Replace("[سریال_محموله]", _selectedPrint.ProductSerial);
                        }
                        if (ZplTemp.Contains("[عنوان_کالا]"))
                        {
                            ZplTemp = ZplTemp.Replace("[عنوان_کالا]", _selectedPrint.ProductTitle);
                        }
                        if (ZplTemp.Contains("[عنوان_لاتین]"))
                        {
                            ZplTemp = ZplTemp.Replace("[عنوان_لاتین]", _selectedPrint.ProductDescription);
                        }
                        if (ZplTemp.Contains("[کد_کالا]"))
                        {
                            ZplTemp = ZplTemp.Replace("[کد_کالا]", _selectedPrint.ProductCode);
                        }
                        if (ZplTemp.Contains("[تاریخ_تولید]"))
                        {
                            ZplTemp = ZplTemp.Replace("[تاریخ_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime));
                        }
                        if (ZplTemp.Contains("[روز_تولید]"))
                        {
                            ZplTemp = ZplTemp.Replace("[روز_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(6, 2));
                        }
                        if (ZplTemp.Contains("[ماه_تولید]"))
                        {
                            ZplTemp = ZplTemp.Replace("[ماه_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(4, 2));
                        }
                        if (ZplTemp.Contains("[سال_تولید]"))
                        {
                            ZplTemp = ZplTemp.Replace("[سال_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(2, 2));
                        }
                        if (ZplTemp.Contains("[کد_فنی]"))
                        {
                            ZplTemp = ZplTemp.Replace("[کد_فنی]", _selectedPrint.ProductRegCode);
                        }
                        if (ZplTemp.Contains("[مقدار_محموله]"))
                        {
                            ZplTemp = ZplTemp.Replace("[مقدار_محموله]", _selectedPrint.ProductRegCode);
                        }
                        if (ZplTemp.Contains("[کد_سند]"))
                        {
                            ZplTemp = ZplTemp.Replace("[کد_سند]", _selectedPrint.DocumentId);
                        }

                        if (_selectedPrint.ProductTechnicalData != "")
                        {
                            var tt = JToken.Parse(_selectedPrint.ProductTechnicalData);
                            foreach (JProperty jj in tt)
                            {
                                string name = jj.Name;
                                string value = jj.Value.ToString();
                                ZplTemp = ZplTemp.Replace("[" + name + "]", value);
                            }
                        }

                        Random rdm = new Random();
                        string Random = rdm.Next(1, 999).ToString().PadLeft(3, '0'); //3char
                        string EpcProductCode = _selectedPrint.ProductCode;
                        string EpcProductSerial = (_selectedPrint.ProductSerial.Length <= 9) ? _selectedPrint.ProductSerial : _selectedPrint.ProductSerial.Substring(_selectedPrint.ProductSerial.Length - 9, 9);
                        if (EpcProductCode == EpcProductSerial)
                        {
                            EpcProductSerial = rdm.Next(100000000, 999999999).ToString().PadLeft(9, '0');
                        }
                        string Epc = "000000000000000000004321";//(RfidConnectRegister.BussinessLogic.Tools.ReplaceAllEnglishAlphbet(EpcProductCode, "").PadLeft(12, '0') + Random + RfidConnectRegister.BussinessLogic.Tools.ReplaceAllEnglishAlphbet(EpcProductSerial, "").PadRight(9, '0')).PadLeft(24, '0').Substring(0, 24);// await _api.CreateEpc(_selectedPrint.ProductSerial, _selectedPrint.ProductCode, _selectedPrint.ProductRegCode);

                        if (ZplTemp.Contains("[شناسه_تگ]"))
                        {
                            ZplTemp = ZplTemp.Replace("[شناسه_تگ]", Epc);
                        }
                        string ZplFinal = ZplTemp.Replace("\n", "").Replace("\r", "");

                        bool PrintedFlag = false;

                        var resultt = await SaveRegister(_selectedPrint.ProductSerial, Epc, _selectedPrint.ProductCode);
                        Epc = "";
                        Thread.Sleep(400);


                        if (resultt)
                        {
                             ZPLHelper.PrintLabelZpl(printerName, ZplFinal);
                            UpdatePrintStatus(_selectedPrint.ProductSerial);
                            _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString())).PrintFlag = 1;
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.Cells["dgvPrintPrintFlag"].Value = "ثبت شده";
                            PrintedFlag = true;
                        }


                        Thread.Sleep(500);

                        if (!PrintedFlag)
                        {
                            if (resultt)
                            {
                                ZPLHelper.PrintLabelZpl(printerName, ZplFinal);
                                UpdatePrintStatus(_selectedPrint.ProductSerial);
                                _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString())).PrintFlag = 1;
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                                row.Cells["dgvPrintPrintFlag"].Value = "ثبت شده";
                                PrintedFlag = true;
                            }

                            if (!PrintedFlag)
                            {
                                Thread.Sleep(500);
                                if (resultt)
                                {
                                    ZPLHelper.PrintLabelZpl(printerName, ZplFinal);
                                    UpdatePrintStatus(_selectedPrint.ProductSerial);
                                    _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString())).PrintFlag = 1;
                                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                                    row.Cells["dgvPrintPrintFlag"].Value = "ثبت شده";
                                    PrintedFlag = true;
                                }
                            }
                        }
                    }
                pnlZplButtons.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"در انجام عملیات مشکلی بوجود آمده است", @"خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                pnlZplButtons.Enabled = true;


            }
        }

        private async void PrintZminFormatAsync(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrint.Rows.Count == 0)
                {
                    MessageBox.Show(@"هنوز هیچ موردی برای چاپ تعریف نشده است", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ProductSerialRegisterActionBefore != "")
                {
                    if (MessageBox.Show("سریال های زیر قبلا رجیستر شده اند " + Environment.NewLine + ProductSerialRegisterActionBefore + Environment.NewLine + "آیا از ادامه عملیات اطمینان دارید؟؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }

                pnlZplButtons.Enabled = false;
                ApiBusiness _api = new ApiBusiness();

                // Get label file path from button
                var btn = (Button)sender;
                string labelfilepath = btn.Tag.ToString();

                // Initialize printer once for all labels
                LabelPrinter.ZMPrinter thiszmprinter = new LabelPrinter.ZMPrinter();
                thiszmprinter.printerinterface = LabelPrinter.PrinterStyle.RFID_USB;
                //thiszmprinter.printerdpi = 300;
                //thiszmprinter.printSpeed = 8;
                //thiszmprinter.printDarkness = 5;
                //thiszmprinter.labelhavegap = true;

                foreach (DataGridViewRow row in dgvPrint.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        var _selectedPrint = _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString()));

                        // Check printer status before printing
                        int printerStatus = GetPrinterStatus(thiszmprinter);
                        if (printerStatus != 0)
                        {
                            continue; // Skip this label if printer has issues
                        }

                        LabelPrinter.ZMLabel thiszmlabel = new LabelPrinter.ZMLabel();
                        List<LabelPrinter.LabelObject> prints = new List<LabelPrinter.LabelObject>();
                        string openstatus = new LabelPrinter.LSFUtility().OpenLabel(labelfilepath, ref thiszmprinter, ref thiszmlabel, ref prints);
                        string readEpc = "";
                        try
                        {

                            readEpc = "000";// new LabelPrinter.PrintUtility().GetUHFTagData(thiszmprinter, thiszmlabel, 1, 15, 0, 2000);

                            if (string.IsNullOrEmpty(readEpc))
                            {
                                Thread.Sleep(1000);
                            }

                            if (string.IsNullOrEmpty(readEpc))
                            {
                                MessageBox.Show("خطا در خواندن تگ RFID. لطفا تگ را نزدیک چاپگر قرار دهید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                        }
                        catch (Exception readEx)
                        {
                            MessageBox.Show("خطا در خواندن تگ RFID: " + readEx.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        // Update label objects with product data
                        foreach (LabelPrinter.LabelObject labelObject in prints)
                        {
                            if (!labelObject.Variables.Any())
                            {
                                continue;
                            }

                            var var = labelObject.Variables[0];

                            if (!string.IsNullOrEmpty(labelObject.Variables[0].data))
                            {
                                var.data = labelObject.Variables[0].data
                                    .Replace("[سریال_قدیمی]", _selectedPrint.ProductOldSerial ?? "")
                                    .Replace("[سریال_محموله]", _selectedPrint.ProductSerial ?? "")
                                    .Replace("[عنوان_کالا]", _selectedPrint.ProductTitle ?? "")
                                    .Replace("[عنوان_لاتین]", _selectedPrint.ProductDescription ?? "")
                                    .Replace("[کد_کالا]", _selectedPrint.ProductCode ?? "")
                                    .Replace("[تاریخ_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime))
                                    .Replace("[روز_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(6, 2))
                                    .Replace("[ماه_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(4, 2))
                                    .Replace("[سال_تولید]", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(2, 2))
                                    .Replace("[کد_فنی]", _selectedPrint.ProductRegCode ?? "")
                                    .Replace("[مقدار_محموله]", _selectedPrint.ProductCount.ToString())
                                    .Replace("[کد_سند]", _selectedPrint.DocumentId ?? "")
                                    .Replace("[شناسه_تگ]", readEpc)
                                    .Replace("[وضعیت_کالا]", _selectedPrint.ProductStatusTitle)
                                    .Replace("[نوع_کالا]", _selectedPrint.ProductTypeTitle)
                                    .Replace("[سایز_کالا]", _selectedPrint.ProductSizeTitle)
                                    .Replace("[تعداد_کالا_در_محموله]", _selectedPrint.ProductCountInPack.ToString());

                                labelObject.Variables.Clear();

                                labelObject.Variables.Add(var);

                                // Replace technical data placeholders
                                if (!string.IsNullOrEmpty(_selectedPrint.ProductTechnicalData))
                                {
                                    var tt = JToken.Parse(_selectedPrint.ProductTechnicalData);
                                    foreach (JProperty jj in tt)
                                    {
                                        string name = jj.Name;
                                        string value = jj.Value.ToString();
                                        labelObject.objectdata = labelObject.objectdata.Replace("[" + name + "]", value);
                                    }
                                }
                            }
                        }

                        // Remove RFID writing objects from prints list
                        prints.RemoveAll(p => p.ObjectName != null && p.ObjectName.ToLower().StartsWith("rfid"));

                        bool PrintedFlag = false;

                        // STEP 3: REGISTER - Register the READ EPC in database
                        var resultt = await SaveRegister(_selectedPrint.ProductSerial, _selectedPrint.ProductSerial, _selectedPrint.ProductCode);

                        if (resultt)
                        {
                            string returnmsg = new LabelPrinter.PrintUtility().PrintLabel(thiszmprinter, thiszmlabel, prints, true, true); // false = no RFID writing

                            if (!returnmsg.StartsWith("Error:"))
                            {
                                UpdatePrintStatus(_selectedPrint.ProductSerial);
                                _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString())).PrintFlag = 1;
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                                row.Cells["dgvPrintPrintFlag"].Value = "ثبت شده";
                                PrintedFlag = true;
                            }
                            else
                            {
                                MessageBox.Show(returnmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        Thread.Sleep(1000);
                    }
                }

                pnlZplButtons.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"در انجام عملیات مشکلی بوجود آمده است: " + ex.Message, @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlZplButtons.Enabled = true;
            }
        }

        /// <summary>
        /// Check printer status including cutter detection
        /// </summary>
        private int GetPrinterStatus(LabelPrinter.ZMPrinter thiszmprinter)
        {
            string errormsg = "";
            int printerstatuscode = new LabelPrinter.PrintUtility().getPrinterStatusCode(thiszmprinter);

            if (printerstatuscode != 0)
            {
                if (printerstatuscode == 86)
                {
                    errormsg = "خطای تشخیص برش دهنده چاپگر رخ داده است. لطفا بررسی کنید که عملکرد برش دهنده فعال است یا خیر.";
                }
                else if (printerstatuscode == 96)
                {
                    errormsg = "جداکننده کاغذ در انتظار برداشتن برچسب است.";
                }
                else if (printerstatuscode == 88)
                {
                    errormsg = "چاپگر در حال حاضر در حالت توقف است. فشار دادن دکمه \"توقف\" روی چاپگر، چاپ را مجددا شروع می کند.";
                }
                else if (printerstatuscode == 81)
                {
                    errormsg = "نقص سخت افزاری مادربرد، لطفا برای تعمیر با خدمات پس از فروش تماس بگیرید.";
                }
                else if (printerstatuscode == 82)
                {
                    errormsg = "خطای تشخیص نوار کربن چاپگر رخ داده است. لطفا بررسی کنید که آیا نوار کربن به درستی نصب شده است.";
                }
                else if (printerstatuscode == 83)
                {
                    errormsg = "خطای تشخیص برچسب چاپگر رخ داده است. لطفا بررسی کنید که آیا برچسب به درستی نصب شده است. توصیه می شود عملیات کالیبراسیون کاغذ را انجام دهید.";
                }
                else if (printerstatuscode == 89)
                {
                    errormsg = "کاغذ برچسب تمام شده است. لطفا برچسب جدید نصب کنید.";
                }
                else if (printerstatuscode == 90)
                {
                    errormsg = "خطا در خواندن یا نوشتن تگ RFID.";
                }
                else if (printerstatuscode == 91 || printerstatuscode == 92)
                {
                    errormsg = "کالیبراسیون سیگنال تگ RFID ناموفق بود.";
                }
                else if (printerstatuscode == 99 || printerstatuscode == 120)
                {
                    errormsg = "چاپگر به روز رسانی را تکمیل کرده است. لطفا دستورالعمل های ابزار ارتقاء را دنبال کنید.";
                }
                else if (printerstatuscode == 1)
                {
                    errormsg = "چاپگر دستورالعمل نادرستی دریافت کرده است. لطفا فرمت دستورالعمل های ارسال شده را بررسی کرده و چاپگر را مجددا راه اندازی کنید.";
                }
                else
                {
                    errormsg = "خطای چاپگر، کد خطا:" + printerstatuscode.ToString();
                }

                MessageBox.Show(errormsg, "خطای وضعیت چاپگر", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return printerstatuscode;
        }
        private void PrintSavedFormat(object sender, EventArgs e)
        {
            int index = 1;


            if (Properties.Settings.Default.MergPrintToPDF == "1")
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(Application.StartupPath + "\\tempfastreport");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }


            progressBar1.Maximum = dgvPrint.Rows.Count;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            foreach (DataGridViewRow row in dgvPrint.Rows)
            {
                progressBar1.Value++;
                try
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {

                        var _selectedPrint = _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString()));

                        var btn = (Button)sender;

                        string printFilesName = btn.Tag.ToString();
                        string printerName = btn.Tag.ToString().Replace(Application.StartupPath + "\\Print_Formats\\", "").Replace(".frx", "").Split('_')[1];


                        if (printerName == string.Empty)
                        {
                            MessageBox.Show("ابتدا چاپگر را برای این نوع از جاپ مشخص کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var report = new Report();

                        report.Load(printFilesName);


                        report.SetParameterValue("سریال محموله", _selectedPrint.ProductSerial);
                        report.SetParameterValue("سریال قدیمی", _selectedPrint.ProductOldSerial);
                        report.SetParameterValue("کد کالا", _selectedPrint.ProductCode);
                        report.SetParameterValue("عنوان کالا", _selectedPrint.ProductTitle);
                        report.SetParameterValue("کد فنی", _selectedPrint.ProductRegCode);
                        report.SetParameterValue("مقدار محموله", _selectedPrint.ProductCount);
                        report.SetParameterValue("تاریخ تولید", _selectedPrint.RegisterDate);
                        report.SetParameterValue("کد سند", _selectedPrint.DocumentId);

                        if (_selectedPrint.ProductTechnicalData != "")
                        {
                            var tt = JToken.Parse(_selectedPrint.ProductTechnicalData);
                            foreach (JProperty jj in tt)
                            {
                                string name = jj.Name;
                                string value = jj.Value.ToString();
                                report.SetParameterValue(name, value);

                            }
                        }

                        report.Prepare();

                        if (Properties.Settings.Default.MergPrintToPDF == "1")
                        {
                            FastReport.Export.Pdf.PDFExport _exportpdf = new FastReport.Export.Pdf.PDFExport();
                            _exportpdf.EmbeddingFonts = true;
                            report.Export(_exportpdf,
                           Application.StartupPath + "\\tempfastreport" + "\\" + index +
                           ".pdf");
                        }
                        else
                        {
                            if (index == 1)
                            {
                                report.ShowPrepared();
                                if (MessageBox.Show("آیا از اطلاعات در حال چاپ اطمینان دارید ؟", "هشدار ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    report.Print();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                report.Print();
                            }

                        }
                        index++;
                    }
                }
                catch
                {

                }
            }
            if (Properties.Settings.Default.MergPrintToPDF == "1")
            {
                CombinePdf(Application.StartupPath + "\\tempfastreport");
            }
            progressBar1.Visible = false;
        }

        private void CombinePdf(string FolderPath)
        {
            List<int> _fileNameindexList = new List<int>();
            //Get the folder path into DirectoryInfo
            DirectoryInfo directoryInfo = new DirectoryInfo(FolderPath);

            //Get the PDF files in folder path into FileInfo
            FileInfo[] files = directoryInfo.GetFiles("*.pdf");


            foreach (FileInfo file in files)
            {
                _fileNameindexList.Add(Convert.ToInt32(file.Name.Replace(".pdf", "")));
            }

            _fileNameindexList.Sort();
            //Create a new PDF document 
            PdfDocument document = new PdfDocument();
            List<PdfDocument> _pdfDocumentList = new List<PdfDocument>();
            foreach (int fileindex in _fileNameindexList)
            {
                _pdfDocumentList.Add(PdfReader.Open(FolderPath + "\\" + fileindex.ToString() + ".pdf", PdfDocumentOpenMode.Import));
            }
            using (PdfDocument outPdf = new PdfDocument())
            {
                foreach (PdfDocument _pdf in _pdfDocumentList)
                {
                    CopyPages(_pdf, outPdf);
                }

                outPdf.Save("MergPdf.pdf");
                Thread.Sleep(1000);


                System.Diagnostics.Process.Start(Application.StartupPath + "\\MergPdf.pdf");
            }

            void CopyPages(PdfDocument from, PdfDocument to)
            {
                for (int i = 0; i < from.PageCount; i++)
                {
                    to.AddPage(from.Pages[i]);
                }
            }
        }


        private void dgvPrint_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblbtnPrintCount.Text = dgvPrint.Rows.Count.ToString();
        }

        private void pnlPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            new frmTestRegisterGroup().ShowDialog();
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            new frmCancelRegisterTag().ShowDialog();
        }

        /// <summary>
        /// Check all properties of a LabelObject to find values that start with '[' or ']'
        /// </summary>
        private List<string> CheckLabelObjectForPlaceholders(LabelPrinter.LabelObject labelObject)
        {
            List<string> placeholderProperties = new List<string>();

            if (labelObject == null)
                return placeholderProperties;

            // Get all properties of the LabelObject class
            PropertyInfo[] properties = typeof(LabelPrinter.LabelObject).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                try
                {
                    // Only check string properties
                    if (property.PropertyType == typeof(string))
                    {
                        string value = property.GetValue(labelObject) as string;

                        // Check if value is not null and starts with '[' or ']'
                        if (!string.IsNullOrEmpty(value) && (value.StartsWith("[") || value.StartsWith("]")))
                        {
                            placeholderProperties.Add($"{property.Name} = {value}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle any property access errors
                    Debug.WriteLine($"Error checking property {property.Name}: {ex.Message}");
                }
            }

            return placeholderProperties;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlShowProductInfoANDEdit.Visible = false;
            ProductSerialSelectedForEditORDelete = "";
        }

        private void btnEditpnlShowProductInfoANDEdit_Click(object sender, EventArgs e)
        {
            if (ProductSerialSelectedForEditORDelete != "")
            {
                var _ProductRegisterStatus = (_savedPrintList.FirstOrDefault(p => p.ProductSerial == ProductSerialSelectedForEditORDelete).TagEpc != "") ? true : false;
                if (!_ProductRegisterStatus)
                {
                    try
                    {
                        SavePrintEdit(ProductSerialSelectedForEditORDelete, txtProductCode.Text, txtProductPackValue.Text, _printActionId, cmbProductionLine.SelectedValue.ToString(), cmbProductionShift.SelectedValue.ToString(), txtDocumentId.Text, cmbStore.SelectedValue.ToString(), "");
                    }
                    catch
                    {
                        MessageBox.Show("خطایی در اطلاعات وارده وجود دارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("برای سریال انتخاب شده تگ صادر شده و امکان ویرایش اطلاعات آن از این طریق امکان ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task SavePrintEdit(string ProductSerial, string ProductCode, string ProductCount, string PrintActionId, string ProductProductionLine, string ProductProductionShift, string DocumentId, string WareHouseCode, string ProductOldSerial)
        {
            if (await api.SDeletePrintByPrintId(_savedPrintList.FirstOrDefault(p => p.ProductSerial == ProductSerialSelectedForEditORDelete).Id.ToString()))
            {

                DML.Print _print = new DML.Print
                {
                    ProductSerial = ProductSerial,
                    ProductCode = ProductCode,
                    ProductCount = Convert.ToDecimal(ProductCount),
                    ProductProductionLine = ProductProductionLine,
                    ProductProductionShift = ProductProductionShift,
                    PrintActionId = Convert.ToInt32(_printActionId),
                    PrintActionDateTime = DateTime.Now,
                    PrintFlag = 0,
                    PrintType = "",
                    RegisterFlag = 0,
                    ProductContractType = "0",
                    DocumentId = (DocumentId == "") ? "0" : DocumentId,
                    PrintUser = RfidConnectRegister.DataAccess.Items.OnlineUserCode,
                    WareHouseCode = WareHouseCode,
                    ProductOldSerial = ProductOldSerial


                };

                dynamic exo = new System.Dynamic.ExpandoObject();

                foreach (var field in _dynamicFieldDtos)
                {
                    ((IDictionary<String, Object>)exo).Add(field.Title, field.Value);
                }

                var dynamicFieldWithValue = Newtonsoft.Json.JsonConvert.SerializeObject(exo);

                if (await api.SavePrintBySerial(_print, "1", dynamicFieldWithValue))
                {
                    foreach (DataGridViewRow dr in dgvPrint.Rows)
                    {
                        if (dr.Cells["dgvPrintProductSerial"].Value.ToString() == ProductSerial)
                        {
                            dgvPrint.Rows.Remove(dr);
                            break;
                        }
                    }

                    _savedPrintList.RemoveAll(p => p.ProductSerial == ProductSerial);
                    GetPrintDataByByProductSerial(ProductSerial);
                    //dgvPrint.Rows[dgvPrint.Rows.Count - 1].Selected = true;
                    MessageBox.Show("ویرایش اطلاعات با موفقیت ثبت شد ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlShowProductInfoANDEdit.Visible = false;
                }
                else
                {
                    MessageBox.Show("در ثبت اطلاعات خطایی رخ داده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("در ثبت اطلاعات خطایی رخ داده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private async void GetPrintDataByByProductSerial(string AddSerialToPrintList)
        {
            var api = new ApiBusiness();
            var _savedPrintListTemp = await api.GetPrintDataByByProductSerial(AddSerialToPrintList);

            foreach (var _prt in _savedPrintListTemp)
            {
                if (_savedPrintList.Count == 0 || _savedPrintList.FirstOrDefault(p => p.ProductSerial == _prt.ProductSerial) == null)
                {
                    dgvPrint.Rows.Add((_prt.PrintFlag == 0) ? "True" : "False", _prt.Id, _prt.ProductSerial, _prt.ProductCode, _prt.ProductTitle,
                        _prt.ProductENTitle, _prt.ProductCount, _prt.ProductItemCount,
                        _prt.ProductCountInPack, _prt.ProductUnit, _prt.ProductSize, _prt.ProductRegCode,
                        _prt.ProductStatusTitle, _prt.ProductWeight, _prt.ProductVolume,
                        _prt.ProductProductionLineTitle, _prt.ProductProductionShiftTitle,
                         _prt.PrintType, _prt.PrintUser, (_prt.PrintFlag == 0) ? "چاپ نشده" : ((_prt.PrintFlag == 1) ? "چاپ شده" : ""), _prt.RegisterFlag, _prt.InputFileName, "حذف", _prt.ProductType);
                    dgvPrint.Rows[dgvPrint.Rows.Count - 1].DefaultCellStyle.BackColor = (_prt.PrintFlag == 0) ? Color.White : Color.LightGreen;

                    _savedPrintList.Add(_prt);
                }
            }


        }



        private async Task DeletePrintByPrintId(string ProductSerial)
        {
            if (await api.SDeletePrintByPrintId(_savedPrintList.FirstOrDefault(p => p.ProductSerial == ProductSerialSelectedForEditORDelete).Id.ToString()))
            {


                foreach (DataGridViewRow dr in dgvPrint.Rows)
                {
                    if (dr.Cells["dgvPrintProductSerial"].Value.ToString() == ProductSerial)
                    {
                        dgvPrint.Rows.Remove(dr);
                        break;
                    }
                }

                _savedPrintList.RemoveAll(p => p.ProductSerial == ProductSerial);
                MessageBox.Show("حذف اطلاعات با موفقیت ثبت شد ", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlShowProductInfoANDEdit.Visible = false;

            }
            else
            {
                MessageBox.Show("در حذف اطلاعات خطایی رخ داده است ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void btnDeletepnlShowProductInfoANDEdit_Click(object sender, EventArgs e)
        {
            if (ProductSerialSelectedForEditORDelete != "")
            {
                var _ProductRegisterStatus = (_savedPrintList.FirstOrDefault(p => p.ProductSerial == ProductSerialSelectedForEditORDelete).TagEpc != "") ? true : false;
                if (!_ProductRegisterStatus)
                {
                    DeletePrintByPrintId(ProductSerialSelectedForEditORDelete);
                }
                else
                {
                    MessageBox.Show("برای سریال انتخاب شده تگ صادر شده و امکان ویرایش اطلاعات آن از این طریق امکان ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
