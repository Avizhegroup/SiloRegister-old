using FastReport;
using Newtonsoft.Json.Linq;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using RfidConnectRegister.BussinessLogic;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using RfidConnectRegister.DML;
using RfidConnectRegister.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI.StoreProduct
{
    public partial class frmOnlyPrint : Form
    {
        private List<DML.Print> _savedPrintList = new List<DML.Print>();
        string _printActionId = "";
        bool FlagPrintActionBefore = false;
        string ProductSerialRegisterActionBefore = "";
        string ProductSerialSelectedForEditORDelete = "";


        ApiBusiness api = new ApiBusiness();

        private List<DML.ProductionLine> _listProductionLine = new List<DML.ProductionLine>();
        private List<DML.ProductionShift> _listProductionShift = new List<DML.ProductionShift>();
        private List<DML.WarehouseDto> _listWareHouses = new List<DML.WarehouseDto>();
        List<DynamicFieldDto> _dynamicFieldDtos = new List<DynamicFieldDto>();
        private List<DML.Product> _listProduct = new List<DML.Product>();


        public frmOnlyPrint(string PrintActionId)
        {
            InitializeComponent();
            _printActionId = PrintActionId;
        }

        private void frmOnlyPrint_Load(object sender, EventArgs e)
        {
            GetSavedPrinList(_printActionId);
            ComputeCountPrinted();
            chbdgvPrint.Checked = true;

            if (Properties.Settings.Default.KindRegister.ToString() == "3")
            {
                btnPrintRegisterTags.Visible = false;
            }


        }


        private void CreatePrintButtons()
        {
            int index = 0;
            string[] _printFormatNameList = Directory.GetFiles(Application.StartupPath + "\\Print_Formats");
            foreach (string printFormatNam in _printFormatNameList)
            {
                if (Properties.Settings.Default.ControlPrintFormatByBrand.ToString() == "0" || printFormatNam.Replace(Application.StartupPath + "\\Print_Formats\\", "").Replace(".frx", "").Split('_')[2] == _savedPrintList[0].ProductBrand)//کنترل فایل طراحی چاپ با برند
                {


                    Button btnPreviewFormatPrint = new Button();
                    btnPreviewFormatPrint.Name ="Preview_"+ printFormatNam.Replace(Application.StartupPath + "\\Print_Formats\\", "").Replace(".frx", "").Split('_')[0]; ;
                    btnPreviewFormatPrint.Tag = "Preview_" + printFormatNam;
                    btnPreviewFormatPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                    btnPreviewFormatPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
                    btnPreviewFormatPrint.Cursor = System.Windows.Forms.Cursors.Hand;
                    btnPreviewFormatPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
                    btnPreviewFormatPrint.FlatAppearance.BorderSize = 0;
                    btnPreviewFormatPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    btnPreviewFormatPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    btnPreviewFormatPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btnPreviewFormatPrint.Font = new System.Drawing.Font("IRANSans(FaNum)", 13.25F);
                    btnPreviewFormatPrint.ForeColor = System.Drawing.SystemColors.ControlText;
                    btnPreviewFormatPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                    btnPreviewFormatPrint.ImageKey = "printer.png";
                    btnPreviewFormatPrint.Location = new System.Drawing.Point(5, (index * 45) + (index * 12) + 12);
                    btnPreviewFormatPrint.Size = new System.Drawing.Size(45, 45);
                    btnPreviewFormatPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btnPreviewFormatPrint.ImageKey = "preview";
                    btnPreviewFormatPrint.ImageList = this.imageList1;
                    btnPreviewFormatPrint.UseVisualStyleBackColor = false;

                    btnPreviewFormatPrint.Click += new EventHandler(PreviewPrintSavedFormatAsync);
                    pnlPrintFormat.Controls.Add(btnPreviewFormatPrint);




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
                    btnFormatPrint.Location = new System.Drawing.Point(55, (index * 45) + (index * 12) + 12);
                    btnFormatPrint.Size = new System.Drawing.Size(339, 45);
                    btnFormatPrint.UseVisualStyleBackColor = false;
                    btnFormatPrint.Click += new EventHandler(PrintSavedFormatAsync);
                    pnlPrintFormat.Controls.Add(btnFormatPrint);
                    index++;
                }
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
            foreach (var _prt in _savedPrintList)
            {

                dgvPrint.Rows.Add((_prt.PrintFlag == 0) ? "True" : "False", _prt.Id, _prt.ProductSerial, _prt.ProductCode, _prt.ProductTitle,
                    _prt.ProductENTitle, _prt.ProductCount, _prt.ProductItemCount,
                    _prt.ProductCountInPack, _prt.ProductUnit, _prt.ProductSize, _prt.ProductRegCode,
                    _prt.ProductStatusTitle, _prt.DocumentId, _prt.ProductOldSerial,
                    _prt.ProductProductionLineTitle, _prt.ProductProductionShiftTitle,
                     _prt.PrintType, _prt.PrintUser, (_prt.PrintFlag == 0) ? "چاپ نشده" : ((_prt.PrintFlag == 1) ? "چاپ شده" : ""), _prt.RegisterFlag, _prt.InputFileName, "حذف", _prt.ProductType, _prt.ProductContractType, _prt.TagEpc);
                dgvPrint.Rows[dgvPrint.Rows.Count - 1].DefaultCellStyle.BackColor = (_prt.PrintFlag == 0) ? Color.White : Color.LightGreen;

                if (_prt.PrintFlag == 1)
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

            CreatePrintButtons();

        }

        private void chbdgvPrint_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvPrint.Rows)
            {
                dr.Cells[0].Value = chbdgvPrint.Checked;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pnlAddSerialToPrintList.Visible = true;
            txtAddSerialToPrintList.Text = "";
            txtAddSerialToPrintList.Focus();
        }


        private async void GetPrintDataByByProductSerial(string AddSerialToPrintList)
        {
            var api = new ApiBusiness();
            var _savedPrintListTemp = await api.GetPrintDataByByProductSerial(AddSerialToPrintList);

            foreach (var _prt in _savedPrintListTemp)
            {
                if (_savedPrintList.Count==0 || _savedPrintList.FirstOrDefault(p => p.ProductSerial == _prt.ProductSerial) == null)
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

        private void Clear(int kindClear)
        {
            if (kindClear == 0)
            {


                dgvPrint.Rows.Clear();
            }
            if (kindClear == 1 || kindClear == 0)//Print Data
            {
                lblbtnPrintCountDo.Text = "0";
                lblbtnPrintCount.Text = "0";
                _savedPrintList.Clear();
            }
        }
        private async void PreviewPrintSavedFormatAsync(object sender, EventArgs e)
        {
            if (dgvPrint.Rows.Count == 0)
            {
                MessageBox.Show(@"هنوز هیچ موردی برای چاپ تعریف نشده است", @"خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            int index = 1;


            if (Properties.Settings.Default.MergPrintToPDF.ToString() == "1")
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


           
            DataGridViewRow row = dgvPrint.Rows[0];
                try
                {
                         var _selectedPrint = _savedPrintList.FirstOrDefault(p => p.Id == Convert.ToInt32(row.Cells["dgvPrintId"].Value.ToString()));

                        var btn = (Button)sender;

                        string printFilesName = btn.Tag.ToString().Replace("Preview_","");
                        string printerName = btn.Tag.ToString().Replace(Application.StartupPath + "\\Print_Formats\\", "").Replace(".frx", "").Split('_')[1];


                        if (printerName == "0")
                        {
                            printerName = Properties.Settings.Default.PrinterModel.ToString();
                        }

                        var report = new Report();

                        report.Load(printFilesName);
                        report.PrintSettings.Printer = printerName;
                        report.PrintSettings.ShowDialog = false;
                        report.SetParameterValue("سریال محموله", _selectedPrint.ProductSerial);
                        report.SetParameterValue("سریال قدیمی", _selectedPrint.ProductOldSerial);
                        report.SetParameterValue("کد کالا", _selectedPrint.ProductCode);
                        report.SetParameterValue("عنوان کالا", _selectedPrint.ProductTitle);
                        report.SetParameterValue("کد فنی", _selectedPrint.ProductRegCode);
                        report.SetParameterValue("مقدار محموله", _selectedPrint.ProductCount);
                        report.SetParameterValue("سایز کالا", _selectedPrint.ProductSizeTitle);
                        report.SetParameterValue("وضعیت کالا", _selectedPrint.ProductStatusTitle);
                        report.SetParameterValue("واحد کالا", _selectedPrint.ProductUnit);
                        report.SetParameterValue("تعداد کالا در محموله", _selectedPrint.ProductCountInPack);
                        report.SetParameterValue("مقدار هر کالا", _selectedPrint.ProductItemCount);
                        report.SetParameterValue("شیفت تولید", _selectedPrint.ProductProductionShiftTitle);
                        report.SetParameterValue("تاریخ تولید میلادی", _selectedPrint.PrintActionDateTime);
                        report.SetParameterValue("تاریخ تولید شمسی", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(Convert.ToDateTime(_selectedPrint.PrintActionDateTime)));
                        report.SetParameterValue("کد سند", _selectedPrint.DocumentId);
                        report.SetParameterValue("برند کالا", _selectedPrint.ProductBrandTitle);
                        report.SetParameterValue("شانه کالا", _selectedPrint.ProductGroupTitle);
                        report.SetParameterValue("عنوان کالا لاتین", _selectedPrint.ProductDescription);
                        report.SetParameterValue("ماه_تولید", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(4, 2));
                        report.SetParameterValue("سال_تولید", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(2, 2));


                        if (_selectedPrint.ProductTechnicalData != null && _selectedPrint.ProductTechnicalData != "")
                        {
                            try
                            {
                                var tt = JToken.Parse(_selectedPrint.ProductTechnicalData);
                                foreach (JProperty jj in tt)
                                {
                                    string name = jj.Name;
                                    string value = jj.Value.ToString();
                                    report.SetParameterValue(name, value);
                                }
                            }
                            catch
                            {

                            }
                        }


                        if (_selectedPrint.ProductProperties != null && _selectedPrint.ProductProperties != "")
                        {
                            try
                            {
                                var tt = JToken.Parse(_selectedPrint.ProductProperties);
                                foreach (JProperty jj in tt)
                                {
                                    string name = jj.Name;
                                    string value = jj.Value.ToString();
                                    report.SetParameterValue(name, value);
                                }
                            }
                            catch
                            {

                            }
                        }


                        report.Prepare();

                        if (Properties.Settings.Default.MergPrintToPDF.ToString() == "1")
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
                            }
                             
                        }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
             
         
        }


        private async void PrintSavedFormatAsync(object sender, EventArgs e)
        {
            if (dgvPrint.Rows.Count == 0)
            {
                MessageBox.Show(@"هنوز هیچ موردی برای چاپ تعریف نشده است", @"خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            int index = 1;


            if (Properties.Settings.Default.MergPrintToPDF.ToString() == "1")
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


                        if (printerName == "0")
                        {
                            printerName = Properties.Settings.Default.PrinterModel.ToString();
                        }

                        var report = new Report();

                        report.Load(printFilesName);
                        report.PrintSettings.Printer = printerName;
                        report.PrintSettings.ShowDialog = false;
                        report.SetParameterValue("سریال محموله", _selectedPrint.ProductSerial);
                        report.SetParameterValue("سریال قدیمی", _selectedPrint.ProductOldSerial);
                        report.SetParameterValue("کد کالا", _selectedPrint.ProductCode);
                        report.SetParameterValue("عنوان کالا", _selectedPrint.ProductTitle);
                        report.SetParameterValue("کد فنی", _selectedPrint.ProductRegCode);
                        report.SetParameterValue("مقدار محموله", _selectedPrint.ProductCount);
                        report.SetParameterValue("سایز کالا", _selectedPrint.ProductSizeTitle);
                        report.SetParameterValue("وضعیت کالا", _selectedPrint.ProductStatusTitle);
                        report.SetParameterValue("واحد کالا", _selectedPrint.ProductUnit);
                        report.SetParameterValue("تعداد کالا در محموله", _selectedPrint.ProductCountInPack);
                        report.SetParameterValue("مقدار هر کالا", _selectedPrint.ProductItemCount);
                        report.SetParameterValue("شیفت تولید", _selectedPrint.ProductProductionShiftTitle);
                        report.SetParameterValue("تاریخ تولید میلادی", _selectedPrint.PrintActionDateTime);
                        report.SetParameterValue("تاریخ تولید شمسی", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(Convert.ToDateTime(_selectedPrint.PrintActionDateTime)));
                        report.SetParameterValue("کد سند", _selectedPrint.DocumentId);
                        report.SetParameterValue("برند کالا", _selectedPrint.ProductBrandTitle);
                        report.SetParameterValue("شانه کالا", _selectedPrint.ProductGroupTitle);
                        report.SetParameterValue("عنوان کالا لاتین", _selectedPrint.ProductDescription);
                        report.SetParameterValue("ماه_تولید", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(4, 2));
                        report.SetParameterValue("سال_تولید", BussinessLogic.Time.Time.ConvertMiladi2ShamsiDate(_selectedPrint.PrintActionDateTime).Replace("/", "").Substring(2, 2));

                        report.SetParameterValue("نوع کالا", _selectedPrint.ProductTypeTitle);
                        report.SetParameterValue("سایز کالا", _selectedPrint.ProductSizeTitle);
                        report.SetParameterValue("تعداد کالا در محموله", _selectedPrint.ProductCountInPack.ToString());
                        

                        if (_selectedPrint.ProductTechnicalData != null && _selectedPrint.ProductTechnicalData != "")
                        {
                            try
                            {
                                var tt = JToken.Parse(_selectedPrint.ProductTechnicalData);
                                foreach (JProperty jj in tt)
                                {
                                    string name = jj.Name;
                                    string value = jj.Value.ToString();
                                    report.SetParameterValue(name, value);
                                }
                            }
                            catch
                            {

                            }
                        }


                        if (_selectedPrint.ProductProperties != null && _selectedPrint.ProductProperties != "")
                        {
                            try
                            {
                                var tt = JToken.Parse(_selectedPrint.ProductProperties);
                                foreach (JProperty jj in tt)
                                {
                                    string name = jj.Name;
                                    string value = jj.Value.ToString();
                                    report.SetParameterValue(name, value);
                                }
                            }
                            catch
                            {

                            }
                        }


                        report.Prepare();

                        if (Properties.Settings.Default.MergPrintToPDF.ToString() == "1")
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
                                if (Properties.Settings.Default.PrintPreviewBeforePrint)
                                {
                                    report.ShowPrepared();
                                }
                                if (MessageBox.Show("آیا از اطلاعات در حال چاپ اطمینان دارید ؟", "هشدار ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    report.Print();

                                    if (Properties.Settings.Default.KindRegister.ToString() == "3")
                                    {
                                        string Epc = RfidConnectRegister.BussinessLogic.Tools.ReplaceAllEnglishAlphbet(_selectedPrint.ProductSerial, "");
                                        var resultt =await SaveRegister(_selectedPrint.ProductSerial, Epc, _selectedPrint.ProductCode);
                                        Epc = "";
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                report.Print();
                                if (Properties.Settings.Default.KindRegister.ToString() == "3")
                                {
                                    string Epc = RfidConnectRegister.BussinessLogic.Tools.ReplaceAllEnglishAlphbet(_selectedPrint.ProductSerial, "");
                                    var resultt = await SaveRegister(_selectedPrint.ProductSerial, Epc, _selectedPrint.ProductCode);
                                    Epc = "";
                                }
                            }
                        }
                        index++;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (Properties.Settings.Default.MergPrintToPDF.ToString() == "1")
            {
                CombinePdf(Application.StartupPath + "\\tempfastreport");
            }
            progressBar1.Visible = false;
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
            var result = false;
            try
            {
                result= await _api.SaveRegisterTag(productSerial, ProductCode, "", epclist, DataAccess.Items.OnlineUserName);
            }
            catch
            {

            }
            if(result)
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




            ////Create a new PDF document 
            //PdfDocument document = new PdfDocument();

            ////Set enable memory optimization as true 
            //document.EnableMemoryOptimization = true;

            //foreach (FileInfo file in files)
            //{
            //    //Load the PDF document 
            //    FileStream fileStream = new FileStream(file.FullName, FileMode.Open);
            //    PdfLoadedDocument loadedDocument = new PdfLoadedDocument(fileStream);

            //    //Merge PDF file
            //    PdfDocumentBase.Merge(document, loadedDocument);

            //    //Close the existing PDF document 
            //    loadedDocument.Close(true);
            //}

            ////Save the PDF document
            //document.Save("MergedPDF.pdf");

            ////Close the instance of PdfDocument
            //document.Close(true);
        }

        private void dgvPrint_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblbtnPrintCount.Text = dgvPrint.Rows.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintRegisterTags_Click(object sender, EventArgs e)
        {
            string _productSerialForRegister = "";

            if (dgvPrint.Rows.Count == 1)
            {
                _productSerialForRegister = dgvPrint.Rows[0].Cells["dgvPrintProductSerial"].Value.ToString();
            }
            else
            {
                foreach (DataGridViewRow dr in dgvPrint.Rows)
                {//
                    if (Convert.ToBoolean(dr.Cells["dgvPrintCheck"].Value))
                    {
                        _productSerialForRegister = dr.Cells["dgvPrintProductSerial"].Value.ToString();
                        break;
                    }
                }
            }
            if (Properties.Settings.Default.ActiveRegisterFormByOneSerial)
            {
                if (_productSerialForRegister != "")
                {
                    if (new frmRFIDRegisterByBarfid(_productSerialForRegister).ShowDialog() == DialogResult.OK)
                    {
                        foreach (DataGridViewRow dr in dgvPrint.Rows)
                        {
                            if (dr.Cells["dgvPrintProductSerial"].Value.ToString() == _productSerialForRegister)
                            {
                                if (Properties.Settings.Default.AutoPrintAfterRegister)
                                {
                                    AutoPrintAfterRegister(_productSerialForRegister);
                                }
                                dr.DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("لطفا ابتدا تیک انتخاب یک سریال را در لیست مشخص کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new frmRFIDRegisterByBarfid("").ShowDialog();
            }
        }


        private async void AutoPrintAfterRegister(string ProductSerial)
        {
             
            var api = new ApiBusiness();
            List<DML.Tag> _listProduct = await api.GetTagInfo(ProductSerial);
            if (_listProduct.Count > 0)
            {
                var _selectedPrint = _listProduct[0];
                string printFilesName = Application.StartupPath + "\\PrintTestAfterRegister.frx";
                 
                 string   printerName = Properties.Settings.Default.PrinterModelForAutoPrintAfterRegister.ToString();
                 

                var report = new Report();

                report.Load(printFilesName);
                report.PrintSettings.Printer = printerName;
                report.PrintSettings.ShowDialog = false;
                report.SetParameterValue("سریال محموله", _selectedPrint.ProductSerial);
                report.SetParameterValue("RFID", _selectedPrint.TagEpc);
                
                report.Prepare();
                report.Print();
                 
            }
             
            
        }
        private void btnNotRegisteredSerialList_Click(object sender, EventArgs e)
        {
            pnlNotRegisteredSerialList.Visible = true;
            SearchNotRegisteredSerialList();

        }

        private async void SearchNotRegisteredSerialList()
        {


            ApiBusiness _api = new ApiBusiness();


            var _listProduct = await _api.RepSGetNotRegisteredPrints();

            dgvNotRegisteredSerialList.Rows.Clear();


            int RowIndex = 1;
            foreach (DataRow dr in _listProduct.Rows)
            {

                dgvNotRegisteredSerialList.Rows.Add("true", dr["ProductSerial"].ToString(), dr["ProductCode"].ToString(), dr["ProductName"].ToString(), dr["ProductCount"].ToString());
                RowIndex++;
            }

        }

        private void btnConfirmNotRegisteredSerialList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvNotRegisteredSerialList.Rows)
            {
                if (Convert.ToBoolean(dr.Cells["dataGridViewCheckBoxColumn1"].Value))
                {
                    GetPrintDataByByProductSerial(dr.Cells["dataGridViewTextBoxColumn2"].Value.ToString());
                }
            }
        }

        private void btnCancelNotRegisteredSerialList_Click(object sender, EventArgs e)
        {
            pnlNotRegisteredSerialList.Visible = false;

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }


        private void ShowProductAndEditePanel(string ProductSerialPrintId)
        {

            GetAndFill(ProductSerialPrintId);
            pnlShowProductInfoANDEdit.Visible = true;
            ProductSerialSelectedForEditORDelete = _savedPrintList.FirstOrDefault(p => p.Id.ToString() == ProductSerialPrintId).ProductSerial;
            label3.Text = "نمایش و ویرایش اطلاعات کالا با سریال : " + ProductSerialSelectedForEditORDelete;
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
        private async void GetAllProduct()
        {
            _listProduct = await api.GetAllProduct();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GetAllProduct();

            frmSearchProducts frmsearch = new frmSearchProducts(txtProductCode, _listProduct);
            frmsearch.ShowDialog();
            if (txtProductCode.Text != "")
            {
                txtProductTitle.Text = _listProduct.FirstOrDefault(p => p.ProductCode == txtProductCode.Text).ProductTitle;

            }
        }
    }
} 
