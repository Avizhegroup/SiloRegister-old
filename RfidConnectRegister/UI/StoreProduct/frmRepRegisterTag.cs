using FastReport;
using FastReport.DevComponents.DotNetBar;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using RfidConnectRegister.BussinessLogic.Time;
using RfidConnectRegister.DML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI.StoreProduct
{
    public partial class frmRepRegisterTag : Form
    {

        private List<DML.ProductPropertyC> _listProductSize = new List<DML.ProductPropertyC>();
        private List<DML.ProductStatus> _listProductStatus = new List<DML.ProductStatus>();
        private List<DML.ProductionLine> _listProductionLine = new List<DML.ProductionLine>();
        private List<DML.ProductionShift> _listProductionShift = new List<DML.ProductionShift>();
        private List<DML.User> _listUser = new List<DML.User>(); 
        private List<DML.Tag> _listTagTajamoee = new List<DML.Tag>();
        private List<DML.Tag> _listTag = new List<DML.Tag>();
        DataTable _dtTabPage2 = new DataTable();
        Boolean FlagChange = false;


        public frmRepRegisterTag()
        {
            InitializeComponent();
        }

        private async void frmRepRegisterTag_Load(object sender, EventArgs e)
        {
            var api = new ApiBusiness();
            _listProductionLine = await api.GetAllProductionLine();
            _listProductionShift = await api.GetAllProductionShift();
            _listProductStatus = await api.GetAllProductStatus();
            _listProductSize = await api.GetAllProductPropertyC();
            _listUser = await api.GetAllUser();


            cmbProductionLine.DataSource = _listProductionLine;
            cmbProductionLine.DisplayMember = "ProductionLineTitle";
            cmbProductionLine.ValueMember = "ProductionLineCode";
            cmbProductionLine.SelectedIndex = -1;


            cmbProductionShift.DataSource = _listProductionShift;
            cmbProductionShift.DisplayMember = "ProductionShiftTitle";
            cmbProductionShift.ValueMember = "ProductionShiftCode";
            cmbProductionShift.SelectedIndex = -1;


            cmbProductSize.DataSource = _listProductSize;
            cmbProductSize.DisplayMember = "ProductPropertyC_Title";
            cmbProductSize.ValueMember = "ProductPropertyC_Id";
            cmbProductSize.SelectedIndex = -1;



            cmbProductStatus.DataSource = _listProductStatus;
            cmbProductStatus.DisplayMember = "ProductStatusTitle";
            cmbProductStatus.ValueMember = "ProductStatusCode";
            cmbProductStatus.SelectedIndex = -1;




            cmbUsers.DataSource = _listUser;
            cmbUsers.DisplayMember = "UserName";
            cmbUsers.ValueMember = "UserName";
            cmbUsers.SelectedIndex = -1;


            Clear();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            frmSearchProducts frmsearch = new frmSearchProducts(txtProductCode,null);
            frmsearch.ShowDialog();
            
        }

        private async  void Search(string ProductCode, string FromDate, string ToDate, string ProductLine, string ProductShift,string User,string TechnicalCode,string productStatus,string productSerial,string FromTime,string ToTime,string ProductSize,string OldSerial,string DocumentId)
        {
            if (FlagChange)
            {
                if (cmbProductionLine.SelectedIndex > -1)
                {
                    if (FromDate != "")
                    {
                        string[] temp = FromDate.Split('/');
                        FromDate = temp[0] + temp[1] + temp[2];
                    }

                    if (ToDate != "")
                    {
                        string[] temp = ToDate.Split('/');
                        ToDate = temp[0] + temp[1] + temp[2];
                    }


                    if(FromTime.Trim() != ":")
                    {
                        FromTime = FromTime.Replace(":", "")+"00";
                    }
                    else
                    {
                        FromTime = "";
                    }


                    if (ToTime.Trim() != ":")
                    {
                        ToTime = ToTime.Replace(":", "") + "00"; ;

                    }
                    else
                    {
                        ToTime = "";
                    }

                    ApiBusiness _api = new ApiBusiness();


                    GetRegisterRequestFilter rep = new GetRegisterRequestFilter
                    {
                        ContractStatus = (DocumentId.Trim() != "") ? DocumentId : "-1",
                        FromDate = (FromDate != "") ? FromDate : "-1",
                        InspectStatus = "-1",
                        Line = (ProductLine != "") ? ProductLine : "-1",
                        ProductBrand = "-1",
                        ProductCode = (ProductCode != "") ? ProductCode : "-1",
                        ProductGroup = "-1",
                        ProductSerial = (productSerial != "") ? productSerial : "-1",
                        Qc = "-1",
                        RegisterDevice = "0",
                        Shift = (ProductShift != "") ? ProductShift : "-1",
                        Size = (ProductSize!="")? ProductSize:"-1",
                        TechnicalCode = (TechnicalCode != "") ? TechnicalCode : "-1",
                        TechnicalCodeLike = false,
                        ToDate = (ToDate != "") ? ToDate : "-1",
                        User = (User != "") ? User : "-1",
                        FromTime= (FromTime != "") ? FromTime : "-1",
                        ToTime= (ToTime != "") ? ToTime : "-1",
                        ProductOldSerial= (OldSerial.Trim() != "") ? ToTime : "-1"
                         


                    };

                    dataGridView1.DataSource = null;
                    _listTagTajamoee = await _api.RepRegisterTagTajamoeeProductCode(rep);

                    _dtTabPage2 = await _api.RepRegisterTagSummaryGroupBySizeANDRegCode(rep);
                    if (_dtTabPage2.Columns.Count > 0)
                    {
                        decimal[] Sum = new decimal[_dtTabPage2.Columns.Count - 4];
                        foreach (DataRow dr in _dtTabPage2.Rows)
                        {
                            for (int i = 0; i < _dtTabPage2.Columns.Count - 4; i++)
                            {
                                if (dr[i + 4].ToString() == "")
                                    dr[i + 4] = "0";
                                Sum[i] += Convert.ToDecimal(dr[i + 4].ToString());

                            }
                        }
                        if (_dtTabPage2.Rows.Count > 0)
                        {
                            switch (Sum.Length)
                            {
                                case 1:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString() );
                                    break;
                                case 2:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString()  );
                                    break;
                                case 3:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString()  );
                                    break;
                                case 4:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString(), Sum[3].ToString()  );
                                    break;
                                case 5:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString(), Sum[3].ToString(), Sum[4].ToString());
                                    break;
                                case 6:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString(), Sum[3].ToString(), Sum[4].ToString(), Sum[5].ToString());
                                    break;
                                case 7:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString(), Sum[3].ToString(), Sum[4].ToString(), Sum[5].ToString(), Sum[6].ToString());
                                    break;
                                case 8:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString(), Sum[3].ToString(), Sum[4].ToString(), Sum[5].ToString(), Sum[6].ToString(), Sum[7].ToString());
                                    break;
                                case 9:
                                    _dtTabPage2.Rows.Add("همه", "", "", "", Sum[0].ToString(), Sum[1].ToString(), Sum[2].ToString(), Sum[3].ToString(), Sum[4].ToString(), Sum[5].ToString(), Sum[6].ToString(), Sum[7].ToString(), Sum[8].ToString());
                                    break;
                            }
                        }
                        dataGridView1.DataSource = _dtTabPage2;
                    }
                    _listTag = await _api.RepRegisterTag(rep);
                    dgvSearchTajamoee.Rows.Clear();
                    decimal productSumValue = 0;
                    int CountPack = 0;
                    int CountNotEntered = 0;
                    foreach (DML.Tag pr in _listTagTajamoee)
                    {
                        //   string[] Row = { pr.ProductCode, pr.RegCode, pr.ProductName, pr.ProductSize, pr.ProductStatusTitle, pr.ProductSerial, pr.ProductCount.ToString() };
                        dgvSearchTajamoee.Rows.Add(pr.fld_ProductPropertyATitle, pr.RegCode, pr.ProductName, pr.ProductSize, pr.ProductCode, pr.ProductStatusTitle,pr.ContractStatus, pr.ProductSerial, pr.ProductCount.ToString());
                        productSumValue += Convert.ToDecimal(pr.ProductCount.ToString());
                        CountPack += Convert.ToInt32(pr.ProductSerial);
                        CountNotEntered += Convert.ToInt32(pr.NotEnterCount);
                    }
                    dgvSearchTajamoee.Rows.Add("", "", "همه", "", "","", CountPack, productSumValue,"0");


                    lblSummaryCoutCode.Text = dgvSearchTajamoee.Rows.Count.ToString();
                    lblSummaryCoutSerial.Text = CountPack.ToString();
                    lblSummarySumValue.Text = productSumValue.ToString();
                    dgvSearchItems.Rows.Clear();

                }
            else
                {
                    MessageBox.Show("لطفا ابتدا سالن تولید مورد نظر را انتخاب کنید");
                    cmbProductionLine.Focus();
                }
            }
        }


        private void SetDataToGrid()
        {

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FlagChange = true;
            Search(txtProductCode.Text, (txtRegisterDateFrom.Text.Length >= 10) ? txtRegisterDateFrom.Text : "", (txtRegisterDateTo.Text.Length >= 10) ? txtRegisterDateTo.Text : "", (cmbProductionLine.SelectedIndex != -1) ? cmbProductionLine.SelectedValue.ToString() : "", (cmbProductionShift.SelectedIndex != -1) ? cmbProductionShift.SelectedValue.ToString() : "", (cmbUsers.SelectedIndex != -1) ? cmbUsers.SelectedValue.ToString() : "", txtTechnicalCode.Text.Trim(), (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductSerial.Text.Trim(),txtFromTime.Text,txtToTime.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "",txtOldSerial.Text.Trim(),txtDocumentId.Text.Trim());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            lblSummarySumValue.Text = lblSummaryCoutSerial.Text = lblSummaryCoutCode.Text = "0";
       txtProductSerial.Text=    txtTechnicalCode.Text= txtRegisterDateTo.Text = txtRegisterDateFrom.Text = txtProductCode.Text = "";
            cmbProductionLine.SelectedIndex = -1;
            cmbProductionShift.SelectedIndex = -1;
            cmbProductStatus.SelectedIndex = -1;
            cmbUsers.SelectedIndex = -1;
            dgvSearchItems.Rows.Clear();
            dgvSearchTajamoee.Rows.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            txtRegisterDateFrom.Text = Time.ConvertMiladi2ShamsiDate(DateTime.Now);
            txtRegisterDateTo.Text = Time.ConvertMiladi2ShamsiDate(DateTime.Now.AddDays(1));
            txtProductCode.Focus();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvSearchTajamoee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
                if (FlagChange)
                {
                    int RowIndex = 1;
                    dgvSearchItems.Rows.Clear();
                    foreach (DML.Tag pr in _listTag)
                    {
                        if (dgvSearchTajamoee.Rows[e.RowIndex].Cells["Column7"].Value.ToString()=="" ||   pr.ProductCode == dgvSearchTajamoee.Rows[e.RowIndex].Cells["Column7"].Value.ToString() )
                        {
                            string[] Rows = { RowIndex.ToString(), pr.ProductSerial, pr.ProductCode, pr.ProductName, pr.ProductSize, pr.RegCode, pr.ProductStatusTitle, pr.ProductCount.ToString(), pr.TagRegisterShamsiUnixDate, pr.TagRegisterUser, pr.fld_ProductPropertyATitle, pr.fld_ProductPropertyBTitle, pr.ProductProperties,pr.TagStatusTitle,"..." };
                            dgvSearchItems.Rows.Add(Rows);
                            RowIndex++;
                        }

                    }
                }
            }
        }

        private void dgvSearchTajamoee_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void dgvSearchTajamoee_Leave(object sender, EventArgs e)
        {
            FlagChange = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSearchItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex>=0 && dgvSearchItems.Columns[e.ColumnIndex].Name== "btnTagHistory")
            {
              //  new frmTagHistory(dgvSearchItems.Rows[e.RowIndex].Cells["dgvColumnProductSerial"].Value.ToString()).Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (FlagChange)
                {
                    int RowIndex = 1;
                    dgvSearchItems.Rows.Clear();
                    foreach (DML.Tag pr in _listTag)
                    {
                        if (  pr.fld_ProductPropertyATitle == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() && pr.RegCode == dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() && pr.ProductSize == dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                        {
                            string[] Rows = { RowIndex.ToString(), pr.ProductSerial, pr.ProductCode, pr.ProductName, pr.ProductSize, pr.RegCode, pr.ProductStatusTitle, pr.ProductCount.ToString(), pr.TagRegisterShamsiUnixDate, pr.TagRegisterUser, pr.fld_ProductPropertyATitle, pr.fld_ProductPropertyBTitle, pr.ProductProperties, pr.TagStatusTitle, "..." };
                            dgvSearchItems.Rows.Add(Rows);
                            RowIndex++;
                        }

                    }
                }
            }
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Title = @"فایل مورد نظر را انتخاب کنید";
                saveFileDialog1.Filter = @"Excel Document (*.xls , *.xlsx)| *.xls; *.xlsx;";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtExportExcel = BussinessLogic.Tools.ConvertDatagridViewToDatatable(((tabControl1.SelectedTab==tabPage1)? dgvSearchTajamoee:dataGridView1));

                    AvizheExcel.ExcelExport.ExportDatatable(dtExportExcel, saveFileDialog1.FileName);
                    MessageBox.Show("فایل اکسل مورد نظر در مسیر انتخاب شده ذخیره شد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ذخیره فایل اکسل با خطا مواجه شده است\n" + ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(2);
        }


        private string CreateFilterDesc()
        {
            string Desc = "";
            if (txtRegisterDateFrom.Text.Length >= 10)
            {
                Desc += " از تاریخ : " + txtRegisterDateFrom.Text + " _ ";
                if (txtFromTime.Text.Trim().Length < 3)
                {
                    Desc += " 06:00 _ ";

                }

            }
            if (txtRegisterDateTo.Text.Length >= 10)
            {
                Desc += " تا تاریخ : " + txtRegisterDateTo.Text + " _ ";
                if (txtToTime.Text.Trim().Length < 3)
                {
                    Desc += " 06:00 _ ";

                }

            }
            if (txtFromTime.Text.Trim().Length >= 3)
            {
                Desc += " از ساعت : " + txtFromTime.Text + " _ ";

            }
            if (txtToTime.Text.Trim().Length >= 3)
            {
                Desc += " تا ساعت : " + txtToTime.Text + " _ ";

            }
            if (cmbProductionLine.SelectedIndex > -1)
            {
                Desc += " سالن تولید : " + cmbProductionLine.Text + " _ ";

            }
            if (cmbProductionShift.SelectedIndex > -1)
            {
                Desc += " شیفت تولید : " + cmbProductionShift.Text + " _ ";

            }
            if (cmbProductSize.SelectedIndex > -1)
            {
                Desc += " سایز محصول : " + cmbProductSize.Text + " _ ";

            }
            if (cmbProductStatus.SelectedIndex > -1)
            {
                Desc += " درجه کیفی : " + cmbProductStatus.Text + " _ ";

            }
            if (cmbUsers.SelectedIndex > -1)
            {
                Desc += " کاربر رجیستر : " + cmbUsers.Text + " _ ";

            }
            if (txtProductCode.Text!="")
            {
                Desc += " کد کالای : " + txtProductCode.Text + " _ ";

            }
            if (txtTechnicalCode.Text != "")
            {
                Desc += " کد طرح : " + txtTechnicalCode.Text + " _ ";

            }
            if (txtProductSerial.Text != "")
            {
                Desc += " سریال : " + txtProductSerial.Text + " _ ";

            }
            return Desc;
        }
        private void Print(int TypePrint)
        {


            if (TypePrint == 2)
            {
                var report = new Report();
                report.Load(Application.StartupPath + "\\" + "reports\\" + "RepRegisterTab2.frx");
                report.SetParameterValue("RepTime", DateTime.Now.ToShortTimeString());
                report.SetParameterValue("RepDate", Time.PersinaNowDate());
                report.SetParameterValue("RepFilter", CreateFilterDesc());



                List<RepPrintType2> studentDetails = new List<RepPrintType2>();
                studentDetails = ConvertDataTable<RepPrintType2>(_dtTabPage2);



                report.RegisterData(studentDetails.Select(p =>
                        new
                        {
                            Line = p.Line.ToString(),
                            Size = p.Size.ToString(),
                            ProductType = p.ProductType,
                            RegCode = p.RegCode.ToString(),
                            ProductStatus1 = p.ProductStatus1.ToString(),
                            ProductStatus2 = p.ProductStatus2.ToString(),
                            ProductStatus3 = p.ProductStatus3.ToString(),
                            ProductStatusSPC = (p.ProductStatusSPC!=null)?p.ProductStatusSPC.ToString():"0",
                            ProductStatusEkh6 = (p.ProductStatusEkh6 != null) ? p.ProductStatusEkh6.ToString() : "0",
                            ProductStatusEkh7 = (p.ProductStatusEkh7 != null) ? p.ProductStatusEkh7.ToString() : "0",
                            ProductStatusEkh8 = (p.ProductStatusEkh8 != null) ? p.ProductStatusEkh8.ToString() : "0",
                            ProductStatusDepo = (p.ProductStatusDepo != null) ? p.ProductStatusDepo.ToString():"0"
                        })
                   , "Table");

                report.GetDataSource("Table").Enabled = true;
                (report.FindObject("Data1") as DataBand).DataSource = report.GetDataSource("Table");


                report.Prepare();
                report.PrintSettings.ShowDialog = false;
                report.PrintSettings.Printer = Properties.Settings.Default.PrinterModel;
                report.Print();
            }
        }


        class RepPrintType2
        {
            public string Line { get; set; }
            public string Size { get; set; }
            public string RegCode { get; set; }
            public string ProductType { get; set; }
       

            public string ProductStatus1 { get; set; }
            public string ProductStatus2 { get; set; }
            public string ProductStatus3 { get; set; }
            public string ProductStatusSPC { get; set; }
            public string ProductStatusEkh6 { get; set; }
            public string ProductStatusEkh7 { get; set; }
            public string ProductStatusEkh8 { get; set; }
            public string ProductStatusDepo { get; set; }


         }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

          
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
 

        string ColumnName = "";
                    switch (column.ColumnName)
                    {
                        case "خط تولید":
                            ColumnName = "Line";
                            break;
                        case "سایز":
                            ColumnName = "Size";
                            break;
                        case "کد طرح":
                            ColumnName = "RegCode";
                            break;                    
                        case "عنوان طرح":
                            ColumnName = "ProductType";
                            break;
                        case "1":
                            ColumnName = "ProductStatus1";
                            break;
                        case "2":
                            ColumnName = "ProductStatus2";
                            break;
                        case "3":
                            ColumnName = "ProductStatus3";
                            break;
                        case "SPC":
                            ColumnName = "ProductStatusSPC";
                            break;
                        case "اختلاطی 6":
                            ColumnName = "ProductStatusEkh6";
                            break;
                        case "اختلاطی 7":
                            ColumnName = "ProductStatusEkh7";
                            break;
                        case "اختلاطی 8":
                            ColumnName = "ProductStatusEkh8";
                            break;
                        case "دپو":
                            ColumnName = "ProductStatusDepo";
                            break;

                    }

                    if (pro.Name == ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
