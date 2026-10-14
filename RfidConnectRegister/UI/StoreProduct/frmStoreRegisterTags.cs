using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Word;
using FastReport;
using FastReport.DevComponents.DotNetBar;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json.Linq;
using RfidConnectRegister.BussinessLogic;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI.StoreProduct
{

    public partial class frmStoreRegisterTags : Form
    {
        ApiBusiness api = new ApiBusiness();

        Product _choosedProduct = new Product();
        int KindArrowPlane = 0;
        private List<DML.Product> _listProduct = new List<DML.Product>();
        private List<DML.Print> _savedPrintList = new List<DML.Print>();

        private List<DML.Print> _NotsavedPrintList = new List<DML.Print>();
        System.Data.DataTable _listOfRemainProductByDocumentId = new System.Data.DataTable();
        private List<DML.ProductionLine> _listProductionLine = new List<DML.ProductionLine>();
        private List<DML.ProductionShift> _listProductionShift = new List<DML.ProductionShift>();
        private List<DML.ProductStatus> _listProductStatus = new List<DML.ProductStatus>();
        private List<DML.WarehouseDto> _listWareHouses = new List<DML.WarehouseDto>();
        string _epcCode = "";
        string _barcode = "";
        Boolean _isOperationOn = false;
        Boolean _isEpcTrue = false;
        private readonly Dictionary<string, string> _epcBarcodePair;
        private readonly ConnectTo6061 _connectTo6061;
        private static string _port = string.Empty;
        List<DML.DocumentItem> _documentItem = new List<DML.DocumentItem>();
        bool GetDocumentDataFlag = false;
        List<DynamicFieldDto> _dynamicFieldDtos = new List<DynamicFieldDto>();
        public frmStoreRegisterTags()
        {
            InitializeComponent();

            //// LoadSetting();
            //if (Properties.Settings.Default..ComPairDevice] == string.Empty)
            //{
            //    MessageBox.Show(@"ابتدا تنظیمات مربوط به دستگاه را انجام دهید", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    Hide();
            //    new FormSetting().Show();
            //}

            //_port = Properties.Settings.Default..ComPairDevice].Split(':')[1];
            //try
            //{
            //    _connectTo6061 = new ConnectTo6061(_port, int.Parse(Properties.Settings.Default..ReaderPower]));
            //}
            //catch (Exception ex)
            //{
            //   // Tools.ExceptionLogger.WriteExceptionLogs(ex);
            //}

            //_isOperationOn = false;
            //_barcode = string.Empty;
            //_epcCode = string.Empty;
            //_epcBarcodePair = new Dictionary<string, string>();

        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (panel3.Height <= 10)
            {
                pnlProductTechnicalData.Visible = false;
                pnlProductTechnicalData.SendToBack();
                panel3.BringToFront();
            }
            else
            {
                pnlProductTechnicalData.Visible = true;

                panel3.SendToBack();
                pnlProductTechnicalData.BringToFront();
            }

            if (panel3.Height == 120)
            {
                timer1.Enabled = true;
                KindArrowPlane = -10;
            }
            else if (panel3.Height == 10)
            {
                timer1.Enabled = true;
                KindArrowPlane = +10;
            }
            else
            {


            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            panel3.Size = new System.Drawing.Size(panel3.Size.Width, panel3.Size.Height + KindArrowPlane);
            panel3.Location = new System.Drawing.Point(panel3.Location.X, panel3.Location.Y - KindArrowPlane);
            pictureBox5.Location = new System.Drawing.Point(pictureBox5.Location.X, pictureBox5.Location.Y - KindArrowPlane);



            if (panel3.Height >= 120 || panel3.Height <= 10)
            {
                timer1.Enabled = false;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnDefineProduct_Click(object sender, EventArgs e)
        {
            new frmDefineProducts().Show();
        }

        private async void frmStoreRegisterTags_Load(object sender, EventArgs e)
        {
            lblWaiting.Dock=DockStyle.Fill;
            timer_clock.Enabled = true;
            lblUserName.Text = DataAccess.Items.OnlineUserName;
            await GetAndFill();


            GetANDSetDynamicFieldDtos();

            Clear(0);
             if(Properties.Settings.Default.MultiProductInOnePrintActionId)
            {
                btnNew.Visible = false;
                btnSave.Text = "اضافه کردن به لیست";
                 
                btnGetSerialsList.Visible = false;
            }

            if (Properties.Settings.Default.MultiProductInOnePrintActionId)
            {
                pnlMultiProductInOnePrintActionId.Visible = true;
            }
            if(Properties.Settings.Default.ComputeAverageProductPackValueFromAllWeight)
            {
                btnGetSerialsList.Text = "وزن میانگین";
                btnGetSerialsList.Visible = true;
            }

            if(!Properties.Settings.Default.SetParentForSerials)
            {
                btnSetParrents.Visible = false;
            }    
            }

        private async Task GetANDSetDynamicFieldDtos()
        {
            _dynamicFieldDtos = await api.GetDynamicFieldsByActionTypeId("0");

            int index = 0;
            foreach (DynamicFieldDto field in _dynamicFieldDtos.OrderBy(p => p.Id))
            {
                //switch (field.DataTyp)
                //{
                //    case "":

                System.Windows.Forms.Label lable_temp = new System.Windows.Forms.Label();

                string[] _DataTemp = field.RelatedTitle1.Split(',');

                lable_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

                 lable_temp.Font = new System.Drawing.Font("IRANSans(FaNum)", 11F);
                lable_temp.Location = new System.Drawing.Point(255+ (pnlDynamicFeilds.Size.Width - 376), (index*36) + (index * 4) + 0);
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
                combo_temp.Name = "dynamic_Control"+ field.Title;
                combo_temp.Tag = field.Id;
                combo_temp.Size = new System.Drawing.Size(252+(pnlDynamicFeilds.Size.Width- 376), 36);
                combo_temp.TabIndex = 7;
                combo_temp.Leave += new System.EventHandler(this.DynamicField_Leave);
               


                
                    for(int i=0;i< _DataTemp.Length;i++)
                        combo_temp.Items.Add(_DataTemp[i]);

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
                        

                      


                        pnlDynamicFeilds.Controls.Add(TextBox_temp);
                    }
                


                    //        break;
                    //}
                    index++;
            }

            if (_dynamicFieldDtos.Count <= 2)
            {

                this.pnlDynamicFeilds.Visible = true;
                this.pnlDynamicFeilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
                this.pnlDynamicFeilds.BackColor = System.Drawing.Color.White;
                this.pnlDynamicFeilds.Location = new System.Drawing.Point(988, 629);
                this.pnlDynamicFeilds.Name = "pnlDynamicFeilds";
                this.pnlDynamicFeilds.Size = new System.Drawing.Size(376, 109);
            }
            else
            {
                this.pnlDynamicFeilds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
                this.pnlDynamicFeilds.BackColor = System.Drawing.Color.White;
                this.pnlDynamicFeilds.Location = new System.Drawing.Point(180, 10);
                this.pnlDynamicFeilds.Name = "pnlDynamicFeilds";
                this.pnlDynamicFeilds.Size = new System.Drawing.Size(557, 640);
                if (Properties.Settings.Default.MultiProductInOnePrintActionId)
                {
                    this.pnlDynamicFeilds.Visible = false;
                }
                else
                {
                    this.pnlDynamicFeilds.Visible = true;
                }

            }

                 
        }

        private string GetAutoShift()
        {
            string ShiftName = "";

            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 14)
            {
                ShiftName = "SHIFT 1";

            }
            else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour < 22)
            {
                ShiftName = "SHIFT 2";

            }
            else if (DateTime.Now.Hour < 6 && DateTime.Now.Hour >= 22)
            {
                ShiftName = "SHIFT 3";

            }



            return ShiftName;
        }


        private async Task GetAndFill()
        {
            _listProduct = await api.GetAllProduct();
            _listProductionLine = await api.GetAllProductionLine();
            _listProductionShift = await api.GetAllProductionShift();
            _listProductStatus = await api.GetAllProductStatus();
            _listWareHouses = await api.GetAllWarehouses();


             cmbProductStatus.DataSource = _listProductStatus;
            cmbProductStatus.DisplayMember = "ProductStatusTitle";
            cmbProductStatus.ValueMember = "ProductStatusCode";


            if (cmbProductStatus.Items.Count == 1)
            {
                cmbProductStatus.SelectedIndex = 0;
                cmbProductStatus.Enabled = false;
            }
            else
                cmbProductStatus.SelectedIndex = -1;


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

        }

        private async Task GetSavedPrinList(string PrintActionId)
        {

            dgvTempSerialList.Rows.Clear();
            var api = new ApiBusiness();
            _savedPrintList = await api.GetPrintListByPrintActionId(PrintActionId);
            txtCount.Text = _savedPrintList.Count.ToString();
            foreach (var _prt in _savedPrintList)
            {

                dgvTempSerialList.Rows.Add(_prt.ProductOldSerial);
            }
            txtGetSerialListCount.Text = dgvTempSerialList.Rows.Count.ToString();
            if (_savedPrintList.Count != 0)
            {
                txtProductCode.Text = _savedPrintList.FirstOrDefault().ProductCode;

                FillProductLableInfo(_savedPrintList.FirstOrDefault().ProductCode, "", "");
            }
        }



        private async Task Clear(int kindClear)
        {
            if (kindClear == 0)
            {
                _listOfRemainProductByDocumentId = null;
                GetDocumentDataFlag = false;
                if (Properties.Settings.Default.GetListSerial.ToString() == "0")
                {
                    if(Properties.Settings.Default.ComputeAverageProductPackValueFromAllWeight)
                    {
                        btnGetSerialsList.Visible = true;
                    }
                    else
                        btnGetSerialsList.Visible = false;
                }
                    
                await GetNewPrintActionId();
                lblPrintActionStatus.Text = "0";

                foreach (Control cnt in pnlDynamicFeilds.Controls)
                {
                    if (cnt.Name.Contains("dynamic"))
                        cnt.Text = "";
                }

                foreach (DynamicFieldDto _dto in _dynamicFieldDtos)
                {
                    _dto.Value = "";
                }
                lblCountMultiProductInOnePrintActionId.Text = "0";
                dgvMultiProductInOnePrintActionId.Rows.Clear();

            }
            if (kindClear == 1 || kindClear == 0)//Print Data
            {
                lblPrintActionStatus.Text = "0";

                dgvTempSerialList.Rows.Clear();
                txtGetSerialListCount.Text = "0";
                txtProductType.Text = "";
                txtFromSerial.Text = "0";
                txtToSerial.Text = "0";
                txtDeleteCharFrom.Text = "0";
                txtDeleteCharTo.Text = "0";
                txtDocumentId.Text = "000";
                 btnGetSerialsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                 txtProductCode.Text = txtProductCountInPack.Text = txtProductENTitle.Text = txtProductPackValue.Text = txtProductPackVolume.Text = txtProductPackWeight.Text = txtProductRegCode.Text = txtProductSize.Text = txtProductTitle.Text = txtProductUnit.Text = txtProductValue.Text = "";
               
                if(Properties.Settings.Default.RegisterCountEvryTimeIsOne)
                {
                    txtCount.Text = "1";
                    txtCount.ReadOnly = true;
                }
                else
                {
                    txtCount.Text = "";
                    txtCount.ReadOnly = false;
                }
                txtDeleteCharTo.Text = "4";
                _NotsavedPrintList.Clear();
                _savedPrintList.Clear();
                lblDate.Text.Replace("/", "").Substring(2, 4);

                if (cmbProductionLine.Items.Count == 1)
                {
                    cmbProductionLine.SelectedIndex = 0;
                }
                else
                    cmbProductionLine.SelectedIndex = -1;


                pnlProductTechnicalData.Controls.Clear();

                if (cmbProductionShift.Items.Count == 1)
                {
                    cmbProductionShift.SelectedIndex = 0;
                }
                else
                {
                    if (Properties.Settings.Default.AutoDetecteShift.ToString() == "1")
                    {
                        cmbProductionShift.Text = GetAutoShift();
                    }
                    else
                    {
                        cmbProductionShift.SelectedIndex = -1;
                    }

                }

                if (cmbProductStatus.Items.Count == 1)
                {
                    cmbProductStatus.SelectedIndex = 0;
                }
                else
                    cmbProductStatus.SelectedIndex = -1;


                lblShiftTitle.Text = GetAutoShift();
            }
            else if(kindClear==2)
            {
                txtProductType.Text =  txtProductCode.Text = txtProductCountInPack.Text = txtProductENTitle.Text = txtProductPackValue.Text = txtProductPackVolume.Text = txtProductPackWeight.Text = txtProductRegCode.Text = txtProductSize.Text = txtProductTitle.Text = txtProductUnit.Text = txtProductValue.Text = "";
                if (Properties.Settings.Default.RegisterCountEvryTimeIsOne)
                {
                    txtCount.Text = "1";
                    txtCount.ReadOnly = true;
                }
                else
                {
                    txtCount.Text = "";
                    txtCount.ReadOnly = false;
                }
                cmbProductStatus.SelectedIndex = -1;
            }

            
        }
        private async Task GetNewPrintActionId()
        {
            try
            {
                var api = new ApiBusiness();
                lblPrintActionId.Text = await api.GetNewPrintActionId();
                 pnlData.Enabled = true;
                lblWaiting.Visible = false;
            }
            catch
            {

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttxtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillProductLableInfo(txtProductCode.Text.Trim(), txtProductRegCode.Text.Trim(), (cmbProductStatus.SelectedValue != null) ? cmbProductStatus.SelectedValue.ToString() : "");
            }
        }


        private async Task FillProductLableInfo(string ProductCode, string ProductTechnicalCode, string ProductStatus)
        {
            if (GetDocumentDataFlag && _documentItem.Count > 0)
            {
                if (_documentItem.FirstOrDefault(p => p.ProductCode == ProductCode) == null)
                {
                    MessageBox.Show("کالای انتخاب شده با اقلام برنامه تولید تعیین شده تطابق ندارد");
                    return;
                }
            }
            _choosedProduct = _listProduct.FirstOrDefault(p => p.ProductCode == ProductCode);
            
            if (_choosedProduct != null)
            {
                txtProductCountInPack.Text = _choosedProduct.ProductCountInPack;
                txtProductENTitle.Text = _choosedProduct.ProductENTitle;
                txtProductPackValue.Text = _choosedProduct.ProductPackValue;
                txtProductPackVolume.Text = _choosedProduct.ProductPackVolume;
                txtProductPackWeight.Text = _choosedProduct.ProductPackWeight;
                txtProductSize.Text = _choosedProduct.ProductSizeTitle;
                cmbProductStatus.SelectedValue = _choosedProduct.ProductStatus;
                txtProductRegCode.Text = _choosedProduct.ProductTechnicalCode;
                txtProductTitle.Text = _choosedProduct.ProductTitle;
                txtProductUnit.Text = _choosedProduct.ProductUnit;
                txtProductValue.Text = _choosedProduct.ProductValue;
                txtProductType.Text = _choosedProduct.ProductType;
                FillTechnicalDataPanel(_choosedProduct.ProductTechnicalData);

            }
            else
            {
                ClearProductLableInfo();
            }
        }

        private void FillTechnicalDataPanel(string ProdutTechnicalData)
        {
            try
            {
                if(ProdutTechnicalData=="")
                {
                    pnlProductTechnicalData.Visible = false;
                }
                else

                {
                    pnlProductTechnicalData.Visible = true;
                }

                pnlProductTechnicalData.Controls.Clear();
                int index = 0;
                var tt = JToken.Parse(ProdutTechnicalData);
                foreach (JProperty jj in tt)
                {
                    string name = jj.Name;
                    string value = jj.Value.ToString();




                 
                    System.Windows.Forms.TextBox TextBox_temp = new System.Windows.Forms.TextBox();



                  // TextBox_temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) )));

                    TextBox_temp.Font = new System.Drawing.Font("IRANSans(FaNum)", 13F);

                    TextBox_temp.Location = new System.Drawing.Point(2, (index * 36) + (index * 4) + 0);
                    TextBox_temp.Name = "dynamic_Control" + name;
                    TextBox_temp.Tag = name;
                    TextBox_temp.Size = new System.Drawing.Size(150 + (pnlDynamicFeilds.Size.Width - 376), 36);
                    TextBox_temp.TabIndex = 7;
                    TextBox_temp.Text = name + " : " + value;
                    TextBox_temp.ReadOnly = true;


                    if (!pnlProductTechnicalData.Controls.Contains(TextBox_temp))
                    {
                        pnlProductTechnicalData.Controls.Add(TextBox_temp);
                        index++;
                    }
                }

            }
            catch
            {

            }
        }

        private void ClearProductLableInfo()
        {
            cmbProductStatus.SelectedIndex = -1;
            txtProductType.Text = txtProductPackWeight.Text = txtProductTitle.Text = txtProductRegCode.Text = txtProductUnit.Text = txtProductValue.Text = txtProductSize.Text = txtProductCode.Text = txtProductCountInPack.Text = txtProductENTitle.Text = txtProductPackValue.Text = txtProductPackVolume.Text = txtProductCountInPack.Text = "";
            txtProductCode.Focus();
            _choosedProduct = null;

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtProductTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductTechnicalCode_TextChanged(object sender, EventArgs e)
        {
        }









        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString().Substring(0, 8);
            lblDate.Text = BussinessLogic.Time.Time.PersinaNowDate();
            lblDayName.Text = BussinessLogic.Time.Time.GetDayNameFromDateTime(DateTime.Now);
        }

        private void lblDate_TextChanged(object sender, EventArgs e)
        {
        }


        private string CheckProductCodeANDCountByDocItems(string ProductCode,int Count)
        {
            string CheckResult = "";
            if (Properties.Settings.Default.CheckRegisterByDocItems && _listOfRemainProductByDocumentId !=null)
            {
               
                foreach (DataRow dtdr in _listOfRemainProductByDocumentId.Rows)
                {

                    if (dtdr["ProductCode"] != null && dtdr["ProductCode"].ToString() != "" && dtdr["ProductCode"].ToString() == ProductCode)
                    {
                        if (Count > Convert.ToInt32(dtdr["Count"].ToString()))
                        {
                            CheckResult = "تعداد وارد شده بیشتر از مقدار باقی مانده در سند تولید می باشد";
                        }
                    }
                }
            }
            return CheckResult;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckUserAccessSavePrint())
            {
                if (CheckSavePrintData())
                {
                    if (MessageBox.Show("آیا از ثبت اطلاعات اطمینان دارید ؟" + Environment.NewLine + "شما در حال ثبت   " + Environment.NewLine + " تعداد : " + txtCount.Text + " سریال " + Environment.NewLine + "   از  کالا با عنوان      " + Environment.NewLine + txtProductTitle.Text + Environment.NewLine + "  با کد تولید    " + Environment.NewLine + txtProductRegCode.Text + Environment.NewLine + "  و با کد رول   " + Environment.NewLine + txtDocumentId.Text + Environment.NewLine + " می باشید ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!Properties.Settings.Default.MultiProductInOnePrintActionId)
                        {
                            var _checkResult = CheckProductCodeANDCountByDocItems(txtProductCode.Text, (Convert.ToInt32(txtCount.Text) * ((Properties.Settings.Default.CountInPackEqualCount)? Convert.ToInt32(txtProductCountInPack.Text):1)));

                            if (_checkResult == "")
                            {
                                await SavePrint(lblPrintActionId.Text, txtProductCode.Text, txtProductRegCode.Text, txtProductTitle.Text, txtProductENTitle.Text, txtProductSize.Text, txtProductValue.Text, txtProductUnit.Text, txtProductCountInPack.Text, txtProductPackValue.Text, txtProductPackVolume.Text, txtProductPackWeight.Text, cmbProductStatus.SelectedValue.ToString(), cmbProductionLine.SelectedValue.ToString(), cmbProductionShift.SelectedValue.ToString(), txtProductType.Text, 0, _NotsavedPrintList, txtDocumentId.Text, cmbStore.SelectedValue.ToString());

                                if (MessageBox.Show("ثبت با موفقیت انجام شد ، آیا قصد چاپ لیبل ها را دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    btnPrintRegisterTags_Click(sender, e);
                                }
                            }
                            else
                            {
                                MessageBox.Show(_checkResult, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            var _checkResult = CheckProductCodeANDCountByDocItems(txtProductCode.Text, (Convert.ToInt32(txtCount.Text) * Convert.ToInt32(txtProductCountInPack.Text)));

                            if (_checkResult == "")
                            {
                                pnlMultiProductInOnePrintActionId.Visible = true;
                                string[] Row = { txtProductCode.Text, txtProductRegCode.Text, txtProductTitle.Text, txtCount.Text, txtProductValue.Text, txtProductCountInPack.Text, txtProductPackValue.Text, "0",Math.Round( Convert.ToDecimal(txtCount.Text) * Convert.ToDecimal(txtProductPackValue.Text),2).ToString(),txtDocumentId.Text.Trim() };
                                dgvMultiProductInOnePrintActionId.Rows.Add(Row);
                                int Count = 0;
                                foreach (DataGridViewRow dr in dgvMultiProductInOnePrintActionId.Rows)
                                {
                                    Count += Convert.ToInt32(dr.Cells[3].Value.ToString());
                                }
                                lblCountMultiProductInOnePrintActionId.Text = Count.ToString();
                                Clear(2);
                                SGetListOfRemainProductByDocumentId(txtDocumentId.Text);
                            }
                            else
                            {
                                MessageBox.Show(_checkResult, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("کاربر گرامی شما مجاز ثبت سریال جدید نمی باشید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean CheckUserAccessSavePrint()
        {
            bool FlagResult = false;

            if (Properties.Settings.Default.HaveLogin)
            {
                string[] tempUser = { "admin", "f.entezari", "m.shabani", "s.dehghani", "f.kafinia", "mr.abedini", "j.saeidi", "m.heidari", "m.mofatah", "fathi" , "a.dost", "m.Ghafeli" };
                List<string> UserNameList = new List<string>();

                UserNameList.AddRange(tempUser);

                if (UserNameList.FirstOrDefault(p => p.ToString().ToLower() == DataAccess.Items.OnlineUserName.ToLower()) != null)
                {
                    FlagResult = true;
                }
            }
            else
            {
                FlagResult = true;
            }
            return FlagResult;
        }

        private Boolean CheckSavePrintData()
        {
            bool FlagCheck = true;
            if (cmbProductionLine.SelectedIndex == -1)
            {
                FlagCheck = false;
                errorProvider1.SetError(cmbProductionLine, "خط تولید باید مشخص شود");

            }
            if (cmbProductionShift.SelectedIndex == -1)
            {
                FlagCheck = false;
                errorProvider1.SetError(cmbProductionShift, "شیفت تولید باید مشخص شود");

            }
            if (cmbStore.SelectedIndex == -1)
            {
                FlagCheck = false;
                errorProvider1.SetError(cmbStore, "انبار تولید باید مشخص شود");

            }
            if (txtProductCode.Text == "")
            {
                FlagCheck = false;
                errorProvider1.SetError(txtProductCode, "کد کالا باید مشخص شود");

            }
            if (txtCount.Text == "0" || txtCount.Text == "")
            {
                FlagCheck = false;
                errorProvider1.SetError(txtCount, "تعداد باید مشخص شود");

            }

            if (txtDocumentId.Text == "0" || txtDocumentId.Text == "" )
            {
                FlagCheck = false;
                errorProvider1.SetError(txtDocumentId, "کد رول باید مشخص شود");

            }
            if (cmbProductStatus.SelectedIndex == -1)
            {
                FlagCheck = false;
                errorProvider1.SetError(cmbProductStatus, "کنترل کیفی کالا باید مشخص شود");

            }

            if (cmbProductStatus.SelectedIndex == -1)
            {
                FlagCheck = false;
                errorProvider1.SetError(cmbProductStatus, "کنترل کیفی کالا باید مشخص شود");

            }

            return FlagCheck;
        }

        private async Task SavePrint(string PrintActionId, string ProductCode, string ProductRegCode, string ProductTitle, string ProductENTitle, string ProductSize, string ProductItemCount, string ProductUnit, string ProductCountInPack, string ProductCount, string ProductVolume, string ProductWeight, string ProductStatus, string ProductProductionLine, string ProductProductionShift, string ProductType, int ReProduct, List<Print> _PrintList, string DocumentId, string WareHouseCode)
        {

            ApiBusiness _api = new ApiBusiness();
            if (Properties.Settings.Default.MultiProductInOnePrintActionId)
            {
                foreach (DataGridViewRow dr in dgvMultiProductInOnePrintActionId.Rows)
                {
                    if (dr.Cells["dgvMultiProductFlagSave"].Value.ToString() == "0")
                    {

                        DML.Print print = new DML.Print
                        {
                            ProductSerial = "",
                            ProductOldSerial = "",
                            ProductCode = dr.Cells["dgvMultiProductCode"].Value.ToString(),
                            ProductRegCode = "",
                            ProductTitle = "",
                            ProductENTitle = "",
                            ProductSize = "",
                            ProductItemCount = Convert.ToDecimal(dr.Cells["dgvMultiProductItemCount"].Value.ToString()),
                            ProductUnit = "",
                            ProductCountInPack = Convert.ToDecimal(dr.Cells["dgvMultiProductCountInPack"].Value.ToString()),
                            ProductCount = Convert.ToDecimal(dr.Cells["dgvMultiProductCount"].Value.ToString()),
                            ProductVolume = 0,
                            ProductWeight = 0,
                            ProductStatus = "",
                            ProductProductionLine = ProductProductionLine,
                            ProductProductionShift = ProductProductionShift,
                            PrintActionId = Convert.ToInt32(PrintActionId),
                            PrintActionDateTime = DateTime.Now,
                            PrintFlag = 0,
                            PrintType = "",
                            RegisterFlag = 0,
                            ProductType = "",
                            ProductContractType = ReProduct.ToString(),
                            DocumentId = (dr.Cells["dgvMultiDocCode"].Value.ToString() == "") ? "0" : dr.Cells["dgvMultiDocCode"].Value.ToString(),
                            PrintUser = RfidConnectRegister.DataAccess.Items.OnlineUserCode,
                            WareHouseCode = WareHouseCode,
                            ProductBrand = "",
                            ProductGroup = ""

                        };

                        dynamic exo = new System.Dynamic.ExpandoObject();

                        foreach (var field in _dynamicFieldDtos)
                        {
                            ((IDictionary<String, Object>)exo).Add(field.Title, field.Value);
                        }

                        var dynamicFieldWithValue = Newtonsoft.Json.JsonConvert.SerializeObject(exo);
                        await _api.SavePrintBySerial(print, dr.Cells["dgvMultiCount"].Value.ToString(), dynamicFieldWithValue);
                        dr.Cells["dgvMultiProductFlagSave"].Value = "1";
                    }
                }
            }
            else
            {
                if (_PrintList.Count != 0)
                {
                    foreach (Print Print in _PrintList)
                    {
                        DML.Print _print = new DML.Print
                        {
                            ProductSerial = Print.ProductSerial,
                            ProductOldSerial = Print.ProductOldSerial,
                            ProductCode = ProductCode,
                            ProductRegCode = ProductRegCode,
                            ProductTitle = ProductTitle,
                            ProductENTitle = ProductENTitle,
                            ProductSize = ProductSize,
                            ProductItemCount = Convert.ToDecimal(ProductItemCount),
                            ProductUnit = ProductUnit,
                            ProductCountInPack = Convert.ToDecimal(ProductCountInPack),
                            ProductCount = Convert.ToDecimal(ProductCount),
                            ProductVolume = Convert.ToDecimal(ProductVolume),
                            ProductWeight = Convert.ToDecimal(ProductWeight),
                            ProductStatus = ProductStatus,
                            ProductProductionLine = ProductProductionLine,
                            ProductProductionShift = ProductProductionShift,
                            PrintActionId = Convert.ToInt32(PrintActionId),
                            PrintActionDateTime = DateTime.Now,
                            PrintFlag = 0,
                            PrintType = "",
                            RegisterFlag = 0,
                            ProductType = ProductType,
                            ProductContractType = ReProduct.ToString(),
                            DocumentId = (DocumentId == "") ? "0" : DocumentId,
                            PrintUser = RfidConnectRegister.DataAccess.Items.OnlineUserCode,
                            WareHouseCode = WareHouseCode,
                            ProductBrand = _choosedProduct.ProductBrand,
                            ProductGroup = _choosedProduct.ProductGroup


                        };

                        dynamic exo = new System.Dynamic.ExpandoObject();

                        foreach (var field in _dynamicFieldDtos)
                        {
                            ((IDictionary<String, Object>)exo).Add(field.Title, field.Value);
                        }

                        var dynamicFieldWithValue = Newtonsoft.Json.JsonConvert.SerializeObject(exo);

                        _api.SavePrintBySerial(_print, "1", dynamicFieldWithValue);
                    }
                }
                else if (txtCount.Text != "" && txtCount.Text != "0")
                {

                    DML.Print print = new DML.Print
                    {
                        ProductSerial = "",
                        ProductOldSerial = "",
                        ProductCode = ProductCode,
                        ProductRegCode = ProductRegCode,
                        ProductTitle = ProductTitle,
                        ProductENTitle = ProductENTitle,
                        ProductSize = ProductSize,
                        ProductItemCount = Convert.ToDecimal(ProductItemCount),
                        ProductUnit = ProductUnit,
                        ProductCountInPack = Convert.ToDecimal(ProductCountInPack),
                        ProductCount = Convert.ToDecimal(ProductCount),
                        ProductVolume = Convert.ToDecimal(ProductVolume),
                        ProductWeight = Convert.ToDecimal(ProductWeight),
                        ProductStatus = ProductStatus,
                        ProductProductionLine = ProductProductionLine,
                        ProductProductionShift = ProductProductionShift,
                        PrintActionId = Convert.ToInt32(PrintActionId),
                        PrintActionDateTime = DateTime.Now,
                        PrintFlag = 0,
                        PrintType = "",
                        RegisterFlag = 0,
                        ProductType = ProductType,
                        ProductContractType = ReProduct.ToString(),
                        DocumentId = (DocumentId == "") ? "0" : DocumentId,
                        PrintUser = RfidConnectRegister.DataAccess.Items.OnlineUserCode,
                        WareHouseCode = WareHouseCode,
                        ProductBrand = _choosedProduct.ProductBrand,
                        ProductGroup = _choosedProduct.ProductGroup

                    };

                    dynamic exo = new System.Dynamic.ExpandoObject();

                    foreach (var field in _dynamicFieldDtos)
                    {
                        ((IDictionary<String, Object>)exo).Add(field.Title, field.Value);
                    }

                    var dynamicFieldWithValue = Newtonsoft.Json.JsonConvert.SerializeObject(exo);
                    await _api.SavePrintBySerial(print, txtCount.Text, dynamicFieldWithValue);
                }
            }
            lblPrintActionStatus.Text = "1";

            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear(0);
            Clear(1);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
             pnlData.Visible = true;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radBarcode1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrintFormSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task UpdatePrintStatus(string ProductSerial)
        {
            var _api = new ApiBusiness();
            _api.PrintUpdatePrintStatus(ProductSerial);
        }

        private void txtProductTitle_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void lblPrint_ProductTitle_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtProductValue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtProductPackValue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }






        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }


        private void timerEpc_Tick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new UI.FormSetting().ShowDialog();
        }

        private bool DictionaryContains(string searchValue, bool isKey)
        {
            try
            {
                if (isKey)
                {
                    foreach (var key in _epcBarcodePair.Keys)
                    {
                        if (key == searchValue)
                            return true;
                    }
                }
                else
                {
                    foreach (var value in _epcBarcodePair.Values)
                    {
                        if (value == searchValue)
                            return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                // BussinessLogic.Tools.ExceptionLogger.WriteExceptionLogs(ex);
                return false;
            }
        }

        private async Task GetAllProduct()
        {
            _listProduct = await api.GetAllProduct();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (_listProduct == null)
            {
                GetAllProduct();
            }
            frmSearchProducts frmsearch = new frmSearchProducts(txtProductCode, _listProduct);
            frmsearch.ShowDialog();
            if (txtProductCode.Text != "")
            {
                FillProductLableInfo(txtProductCode.Text.Trim(), txtProductRegCode.Text.Trim(), (cmbProductStatus.SelectedValue != null) ? cmbProductStatus.SelectedValue.ToString() : "");

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }


        private void btnNextActionId_Click(object sender, EventArgs e)
        {
            lblPrintActionId.Text = (Convert.ToInt32(lblPrintActionId.Text) + 1).ToString();
            GetSavedPrinList(lblPrintActionId.Text);

        }

        private void btnPreviousActionId_Click(object sender, EventArgs e)
        {
            lblPrintActionId.Text = ((Convert.ToInt32(lblPrintActionId.Text) - 1).ToString() != "0") ? (Convert.ToInt32(lblPrintActionId.Text) - 1).ToString() : "1";
            lblPrintActionStatus.Text = "1";
            GetSavedPrinList(lblPrintActionId.Text);
        }

        private void frmStoreRegisterTags_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void dgvPrint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bntComputeProductPackCount_Click(object sender, EventArgs e)
        {
            if (txtProductCountInPack.Text != "" && txtProductValue.Text != "")
            {
                txtProductPackValue.Text = (Convert.ToDecimal(txtProductCountInPack.Text) * Convert.ToDecimal(txtProductValue.Text)).ToString();
            }
        }

        private void txtProductCountInPack_Leave(object sender, EventArgs e)
        {
            if (txtProductCountInPack.Text != "" && txtProductValue.Text != "")
            {
                txtProductPackValue.Text = (Convert.ToDecimal(txtProductCountInPack.Text) * Convert.ToDecimal(txtProductValue.Text)).ToString();
            }
        }

        private void btnRepCancelRegisterTag_Click(object sender, EventArgs e)
        {
            new frmRepCancelRegister().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new frmRepErrorInRegisterTag().Show();
        }

        private void btnDefineProductType_Click(object sender, EventArgs e)
        {
            new frmDefineProductType().ShowDialog();
        }

        private void btnGetSerialsList_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ComputeAverageProductPackValueFromAllWeight)
            {
                ShowpnlComputeConvertWeightToProductPackValue();
            }
            else

            {
                string Error = "";
                if (txtProductCode.Text == "")
                {
                    Error += "کد کالا\n";
                }

                if (cmbProductionLine.SelectedIndex == -1)
                {
                    Error += "سالن تولید\n";
                }

                if (cmbProductionShift.SelectedIndex == -1)
                {
                    Error += "شیفت تولید\n";
                }
                if (lblPrintActionId.Text == "0" || lblPrintActionId.Text == "")
                {
                    Error += "کد عملیات\n";
                }
                if (Error == "")
                {
                    pnlGetSerialList.Visible = true;
                    txtFromSerial.Focus(); txtFromSerial.SelectAll();
                }
                else
                {
                    MessageBox.Show("لطفا ابتدا اطلاعات زیر را تکمیل نمایید \n" + Error, "خطا", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnComputeSerialsList_Click(object sender, EventArgs e)
        {
            if (txtFromSerial.Text != "" && txtToSerial.Text != "")
            {
                string DeletedChas = "";
                int FromSerial = 0;
                int ToSerial = 0;
                dgvTempSerialList.Rows.Clear();
                _NotsavedPrintList.Clear();
                try
                {
                    if (txtDeleteCharFrom.Text == "0" && txtDeleteCharTo.Text == "0")
                    {
                        FromSerial = Convert.ToInt32(txtFromSerial.Text.Trim());
                        ToSerial = Convert.ToInt32(txtToSerial.Text.Trim());


                    }
                    else
                    {
                        DeletedChas = txtFromSerial.Text.Substring(Convert.ToInt32((txtDeleteCharFrom.Text)), Convert.ToInt32((txtDeleteCharTo.Text)));
                        FromSerial = Convert.ToInt32(txtFromSerial.Text.Remove(Convert.ToInt32((txtDeleteCharFrom.Text)), Convert.ToInt32((txtDeleteCharTo.Text))).Trim());
                        ToSerial = Convert.ToInt32(txtToSerial.Text.Remove(Convert.ToInt32((txtDeleteCharFrom.Text)), Convert.ToInt32((txtDeleteCharTo.Text))).Trim());

                    }
                    int Count = ToSerial - FromSerial;
                    if (Count >= 0)
                    {
                        for (int i = FromSerial; i < ToSerial; i++)
                        {
                            dgvTempSerialList.Rows.Add(DeletedChas + i.ToString().PadLeft(txtFromSerial.Text.Length - DeletedChas.Length, '0'));
                        }
                    }
                    txtGetSerialListCount.Text = Count.ToString();
                }
                catch
                {

                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dgvTempSerialList.Rows.Clear();
            pnlGetSerialList.Visible = false;
        }

        private void btnGetSerialListSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvTempSerialList.Rows)
            {
                Print _tempPrint = new Print
                {
                    PrintActionId = Convert.ToInt32(lblPrintActionId.Text),
                    ProductCode = txtProductCode.Text,
                    ProductCount = Convert.ToDecimal(txtProductPackValue.Text),
                    ProductProductionLine = cmbProductionLine.SelectedValue.ToString(),
                    ProductProductionShift = cmbProductionShift.SelectedValue.ToString(),
                    ProductSerial = dr.Cells[0].Value.ToString(),
                    ProductOldSerial = dr.Cells[0].Value.ToString()
                };

                _NotsavedPrintList.Add(_tempPrint);
            }
            txtCount.Text = dgvTempSerialList.Rows.Count.ToString();
            btnGetSerialsList.BackColor = Color.Green;
            pnlGetSerialList.Visible = false;
        }

        private void pnlPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintRegisterTags_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AllowShowOnlyPrintFormBeforeSavePrintAction || lblPrintActionStatus.Text == "1")
            {
                if (Properties.Settings.Default.KindRegister.ToString() == "1")
                    new frmPrintRegsiterTags(lblPrintActionId.Text,(!Properties.Settings.Default.MultiProductInOnePrintActionId)? Convert.ToInt32(txtCount.Text):Convert.ToInt32(lblCountMultiProductInOnePrintActionId.Text)).Show();
                else if (Properties.Settings.Default.KindRegister.ToString() == "2" || Properties.Settings.Default.KindRegister.ToString() == "3" || Properties.Settings.Default.KindRegister.ToString() == "4")
                {
                    new frmOnlyPrint(lblPrintActionId.Text).Show();
                }
            }
            else
            {
                MessageBox.Show("لطفا ابتدا عملیات را ثبت نمایید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmStoreRegisterTags_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    Clear(0);
                    Clear(1);
                    break;
                case Keys.F6:
                    btnSave_Click(sender, e);
                    break;
                case Keys.F7:
                    if (lblPrintActionStatus.Text == "1")
                    {
                        if (Properties.Settings.Default.KindRegister.ToString() == "1")
                            new frmPrintRegsiterTags(lblPrintActionId.Text, Convert.ToInt32(txtCount.Text)).Show();
                        else if (Properties.Settings.Default.KindRegister.ToString() == "2" || Properties.Settings.Default.KindRegister.ToString() == "4")
                        {
                            new frmOnlyPrint(lblPrintActionId.Text).Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("لطفا ابتدا عملیات را ثبت نمایید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRepCancelRegisterTag_Click_1(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KindRegister == "2")
            {
                new frmTestRegister().ShowDialog();
            }
            else
            {
                new frmTestRegisterGroup().ShowDialog();

            }
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            new frmCancelRegisterTag().ShowDialog();
        }

        private void btnRepRegisterTag_Click(object sender, EventArgs e)
        {
            new frmRepRegisterTag().ShowDialog();
        }

        private void btnGetExcel_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = @"فایل مورد نظر را انتخاب کنید";
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = @"Excel Document (*.xls , *.xlsx)| *.xls; *.xlsx;";
                dgvTempSerialList.Rows.Clear();
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                System.Data.DataTable dtImportExcel = AvizheExcel.ExcelReader.ReadExcelDataExportInDataTable(openFileDialog1.FileName);
                if (dtImportExcel.Rows.Count > 0)
                {
                    dgvTempSerialList.Rows.Clear();

                    foreach (DataRow dr in dtImportExcel.Rows)
                    {
                        dgvTempSerialList.Rows.Add(dr[0].ToString());
                    }
                    lblExcelFileName.Text = openFileDialog1.SafeFileName;
                }
                else
                {
                    dgvTempSerialList.Rows.Clear();

                    lblExcelFileName.Text = "";
                }
            }
            catch
            {

            }
        }

        private void DynamicField_Leave(object sender, EventArgs e)
        {
            _dynamicFieldDtos.FirstOrDefault(p => p.Id.ToString() == ((Control)sender).Tag.ToString()).Value = ((Control)sender).Text;

        }

        private void btnChangeRegisterDate_Click(object sender, EventArgs e)
        {
            new frmChangeTagRegisterData().Show();
        }

        private void btnCancelMultiProductInOnePrintActionId_Click(object sender, EventArgs e)
        {
            Clear(0);
            Clear(1);
        }

        
        private async void btnConfirmMultiProductInOnePrintActionId_Click(object sender, EventArgs e)
        {
            await SavePrint(lblPrintActionId.Text, "", "", "", "", "", "", "", "", "", "", "", "", cmbProductionLine.SelectedValue.ToString(), cmbProductionShift.SelectedValue.ToString(), "", 0, _NotsavedPrintList, txtDocumentId.Text, cmbStore.SelectedValue.ToString());

            if (MessageBox.Show("ثبت با موفقیت انجام شد ، آیا قصد چاپ لیبل ها را دارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnPrintRegisterTags_Click(sender, e);
            }
        }

        private void btnSearchDoc_Click(object sender, EventArgs e)
        {
            pnlDocs.Visible = true;
            pnlDocs.BringToFront();
            txtSearchDocInlist.Text = "";
            txtSearchDocInlist.ReadOnly = true;
            GetAllPermitedDocs();
            txtSearchDocInlist.ReadOnly = false;

            dgvDocsList.Focus();
        }
        private async Task GetAllPermitedDocs()
        {
            var _docList = await api.GetAggDocsByDocTypeAndStatus("1");
            dgvDocsList.Rows.Clear();
            if (_docList != null)
            {
                foreach (var doc in _docList)
                {
                    dgvDocsList.Rows.Add(doc.DocumentKey, doc.DocumentData, "انتخاب");
                }
            }
        }

        private void dgvDocsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvDocsList.Columns[e.ColumnIndex].Name == "colbtnSelectDoc")
                {
                    txtDocumentId.Text = dgvDocsList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    GetDocumentDataFlag = false;
                    GetDocumentData(txtDocumentId.Text);
                    pnlDocs.Visible = false;

                }
            }
            catch
            {

            }
        }

        private async Task GetDocumentData(string DocumentId)
        {
            try
            {
                if (DocumentId != "")
                {
                    _listOfRemainProductByDocumentId = null;
                    if (!GetDocumentDataFlag)
                    {
                        label19.Text = "اطلاعات و اقلام سند عطف عملیات: " + DocumentId;
                        dgvDocumentHeader.Rows.Clear();
                        dgvDocumentItems.Rows.Clear();
                        _documentItem.Clear();
                        this.Invoke(new System.Action(() => dgvDocumentHeader.Rows.Clear()));
                        this.Invoke(new System.Action(() => dgvDocumentItems.Rows.Clear()));
                        this.Invoke(new System.Action(() => _documentItem.Clear()));

                        var result = await api.GetDocumentData(DocumentId,1);

                        if (result.ToString() == "")
                        {

                            MessageBox.Show("اطلاعاتی برای کد سند : " + DocumentId + " یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            pnlDocumentInfo.Visible = false;
                            return;


                        }
                        
                        dgvDocumentHeader.Rows.Clear();

                        var headerJson = JToken.Parse(result["headerData"].ToString());
                        foreach (JToken item in headerJson)
                        {
                            string[] info = item.ToString().Split(':');
                            var temp_title = info[0].Replace(@"""", "").Replace(@"{", "").Replace(@"}", "").Replace(@"\r\n", "").Replace(@"\", "").Trim();
                            var temp_Value = info[1].Replace(@"""", "").Replace(@"{", "").Replace(@"}", "").Replace(@"\r\n", "").Replace(@"\", "").Trim();

                            dgvDocumentHeader.Rows.Add(temp_title, temp_Value);
                            string TargetControlName = "dynamic_Control" + temp_title.Replace("\r\n", "").Trim();

                            foreach (Control cnt in pnlDynamicFeilds.Controls)
                            {
                                if (cnt.Name.ToString() == TargetControlName)
                                {
                                    if (cnt.Text == "")
                                        cnt.Text = temp_Value.Replace("\r\n", "").Trim();
                                }
                            }

                            foreach (DynamicFieldDto _dto in _dynamicFieldDtos)
                            {
                                if (_dto.Title == temp_title.Replace("\r\n", "").Trim())
                                {
                                    if (_dto.Value.ToString() == "")
                                        _dto.Value = temp_Value.Replace("\r\n", "").Trim();
                                }

                            }


                        }
                        int index = 1;
                        dgvDocumentItems.Rows.Clear();
                        var documentItemsJson = JToken.Parse(result["documentItems"].ToString());
                        foreach (JToken item in documentItemsJson)
                        {

                            if (_documentItem.FirstOrDefault(p => p.ProductCode == item["productCode"].ToString()) == null)
                            {
                                DML.DocumentItem _item = new DML.DocumentItem
                                {
                                    ProductCode = item["productCode"].ToString(),
                                    ProductTitle = item["productTitle"].ToString(),
                                    Count = Convert.ToInt32(item["count"].ToString()),
                                    Remain= Convert.ToInt32(item["count"].ToString()),
                                    StatusDesc = ""

                                };
                                _documentItem.Add(_item);
                            }
                            else
                            {
                                _documentItem.FirstOrDefault(p => p.ProductCode == item["productCode"].ToString()).Count += Convert.ToInt32(item["count"].ToString());
                            }
                            string productCode = item["productCode"].ToString();
                            dgvDocumentItems.Rows.Add(index, item["productCode"].ToString(), item["productTitle"].ToString(), item["count"].ToString(), "");
                            index++;
                        }
                        GetDocumentDataFlag = true;
                        
                    }
                    SGetListOfRemainProductByDocumentId(DocumentId);

                }
                else
                {
                    MessageBox.Show("لطفا ابتدا کد سند را مشخص نمایید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDocumentId.Focus();
                    pnlDocumentInfo.Visible = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                BussinessLogic.Tools.WriteExceptionLogs(ex);
            }
        }

        private async Task SGetListOfRemainProductByDocumentId(string DocumentId)
        {
            _listOfRemainProductByDocumentId = await api.SGetListOfRemainProductByDocumentId(DocumentId);
            foreach (DataGridViewRow dr in dgvMultiProductInOnePrintActionId.Rows)
            {
                if (dr.Cells["dgvMultiProductFlagSave"].Value.ToString() == "0")
                {
                    bool FlagExist = false;
                    foreach (DataRow dtdr in _listOfRemainProductByDocumentId.Rows)
                    {
                        
                        if (dtdr["ProductCode"].ToString() == dr.Cells["dgvMultiProductCode"].Value.ToString() && dr.Cells["dgvMultiDocCode"].Value.ToString()== DocumentId)
                        {
                            dtdr["Count"] = Convert.ToInt32(dtdr["Count"].ToString()) - ((Properties.Settings.Default.CountInPackEqualCount) ? (Convert.ToInt32(dr.Cells["dgvMultiCount"].Value.ToString()) * Convert.ToInt32(dr.Cells["dgvMultiProductCountInPack"].Value.ToString())) : Convert.ToInt32(dr.Cells["dgvMultiProductCount"].Value.ToString()));
                            FlagExist = true;
                            break;
                        }
                    }
                    //if (!FlagExist)
                    //{
                    //    _listOfRemainProductByDocumentId.Rows.Add(dr.Cells["dgvMultiCount"].Value.ToString(), dr.Cells["dgvMultiProductCode"].Value.ToString());
                    //}
                }
            }

            foreach (DataRow dtdr in _listOfRemainProductByDocumentId.Rows)
            {
                if (_documentItem.FirstOrDefault(p => p.ProductCode == dtdr["ProductCode"].ToString()) != null)
                {
                    int mainCount = _documentItem.FirstOrDefault(p => p.ProductCode == dtdr["ProductCode"].ToString()).Count;
                    _documentItem.FirstOrDefault(p => p.ProductCode == dtdr["ProductCode"].ToString()).Remain =   Convert.ToInt32(dtdr["Count"].ToString());
                }
            }
            foreach(DataGridViewRow dr in dgvDocumentItems.Rows)
            {
                dr.Cells["colDocumentItemRemain"].Value=_documentItem.FirstOrDefault(p => p.ProductCode == dr.Cells["colDocumentItemProductCode"].Value.ToString()).Remain;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pnlDocumentInfo.Visible = true;
            pnlDocumentInfo.BringToFront();
            GetDocumentData(txtDocumentId.Text);
        }

        private void btnCancelPnlDocs_Click(object sender, EventArgs e)
        {
            pnlDocs.Visible = false;
        }

        private void btnCancelpnlDocumentInfo_Click(object sender, EventArgs e)
        {
            pnlDocumentInfo.Visible = false;
        }

        private void dgvDocumentItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex == dgvDocumentItems.Columns["colbtnSelectProduct"].Index)
            {
                
                txtProductCode.Text = dgvDocumentItems.Rows[e.RowIndex].Cells["colDocumentItemProductCode"].Value.ToString();
                if (txtProductCode.Text != "")
                {
                    FillProductLableInfo(txtProductCode.Text.Trim(), txtProductRegCode.Text.Trim(), (cmbProductStatus.SelectedValue != null) ? cmbProductStatus.SelectedValue.ToString() : "");
                    pnlDocumentInfo.Visible = false;
                    txtCount.Text = dgvDocumentItems.Rows[e.RowIndex].Cells["colDocumentItemRemain"].Value.ToString();
                    txtCount.Select();
                    txtCount.Focus();
                }
            }
        }

        private void dgvMultiProductInOnePrintActionId_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMultiProductInOnePrintActionId.Columns["dgvMultiProductbtnDelete"].Index)
            {
                if (dgvMultiProductInOnePrintActionId.Rows[e.RowIndex].Cells["dgvMultiProductFlagSave"].Value.ToString()=="1")
                {
                    MessageBox.Show("این ردیف قبلا ثبت شده و شما مجاز به حذف آن نیستید");
                    return;
                }
                else
                {
                    try
                    {
                        if (_listOfRemainProductByDocumentId != null && _listOfRemainProductByDocumentId.Rows.Count > 0)
                        {
                            foreach (DataRow dtdr in _listOfRemainProductByDocumentId.Rows)
                            {
                                if (dtdr["ProductCode"].ToString() == dgvMultiProductInOnePrintActionId.Rows[e.RowIndex].Cells["dgvMultiProductCode"].Value.ToString())
                                {
                                    dtdr["Count"] = Convert.ToInt32(dtdr["Count"].ToString()) - Convert.ToInt32(dgvMultiProductInOnePrintActionId.Rows[e.RowIndex].Cells["dgvMultiCount"].Value.ToString());
                                    break;
                                }
                            }
                        }
                        if (_documentItem.Count > 0)
                            _documentItem.FirstOrDefault(p => p.ProductCode == dgvMultiProductInOnePrintActionId.Rows[e.RowIndex].Cells["dgvMultiProductCode"].Value.ToString()).Remain += Convert.ToInt32(dgvMultiProductInOnePrintActionId.Rows[e.RowIndex].Cells["dgvMultiCount"].Value.ToString());
                        foreach (DataGridViewRow dr in dgvDocumentItems.Rows)
                        {
                            dr.Cells["colDocumentItemRemain"].Value = _documentItem.FirstOrDefault(p => p.ProductCode == dr.Cells["colDocumentItemProductCode"].Value.ToString()).Remain;
                        }
                        dgvMultiProductInOnePrintActionId.Rows.RemoveAt(e.RowIndex);
                    }
                    catch
                    {
                        dgvMultiProductInOnePrintActionId.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lblPrintActionStatus.Text == "1")
            {
                if (Properties.Settings.Default.KindRegister.ToString() == "1")
                    new frmPrintRegsiterTags(lblPrintActionId.Text, (!Properties.Settings.Default.MultiProductInOnePrintActionId) ? Convert.ToInt32(txtCount.Text) : Convert.ToInt32(lblCountMultiProductInOnePrintActionId.Text)).ShowDialog();
                else if (Properties.Settings.Default.KindRegister.ToString() == "2" || Properties.Settings.Default.KindRegister.ToString() == "3" || Properties.Settings.Default.KindRegister.ToString() == "4")
                {
                    new frmOnlyPrint(lblPrintActionId.Text).Show();
                }
            }
            else
            {
                MessageBox.Show("لطفا ابتدا عملیات را ثبت نمایید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchDocInlist.Text!="")
            {
                foreach(DataGridViewRow dr in dgvDocsList.Rows)
                {
                    if (dr.Cells[0].Value.ToString().Contains(txtSearchDocInlist.Text.Trim()))
                    {
                        dr.Visible = true;
                    }
                    else
                    {
                        dr.Visible = false;

                    }
                }
            }
        }

        private void txtDocumentId_TextChanged(object sender, EventArgs e)
        {
            if(txtDocumentId.Text.Trim()=="" || txtDocumentId.Text.Trim()=="0" || txtDocumentId.Text.Trim() == "00")
            {
                _listOfRemainProductByDocumentId = null;
                 GetDocumentDataFlag = false;
                dgvDocumentHeader.Rows.Clear();
                dgvDocumentItems.Rows.Clear();
                _documentItem.Clear();
                
            }
        }

        private void btnCancelpnlComputeConvertWeightToProductPackValue_Click(object sender, EventArgs e)
        {
            pnlComputeConvertWeightToProductPackValue.Visible = false;
        }

        private void ShowpnlComputeConvertWeightToProductPackValue()
        {
            if(txtProductCode.Text!="" && txtCount.Text!="" && txtCount.Text != "0" && txtProductPackValue.Text!="" && txtProductPackValue.Text != "0")
            {
                pnlComputeConvertWeightToProductPackValue.Visible = true;
                label28.Text = txtProductTitle.Text;
                label37.Text = txtCount.Text;
                label36.Text = txtProductPackValue.Text;
                lblAverageWeight.Text = "0";
                txtAllWeightForConvert.Text = "0";
                pnlComputeConvertWeightToProductPackValue.BringToFront();
            }
        }



        private void btnComputepnlComputeConvertWeightToProductPackValue_Click(object sender, EventArgs e)
        {
            try
            {
                var Count = Convert.ToDecimal(txtCount.Text);
                var ProductPackValue= Convert.ToDecimal(txtProductPackValue.Text);
                var allWeight= Convert.ToDecimal(txtAllWeightForConvert.Text);
                lblAverageWeight.Text = Math.Round((allWeight / Count), 2).ToString();

            }
            catch
            {

            }

        }

        private void btnConfirmpnlComputeConvertWeightToProductPackValue_Click(object sender, EventArgs e)
        {
            try
            {
                var Count = Convert.ToDecimal(txtCount.Text);
                var ProductPackValue = Convert.ToDecimal(txtProductPackValue.Text);
                var allWeight = Convert.ToDecimal(txtAllWeightForConvert.Text);
                lblAverageWeight.Text = Math.Round((allWeight / Count), 2).ToString();

                txtProductPackValue.Text = lblAverageWeight.Text;
                pnlComputeConvertWeightToProductPackValue.Visible = false;

            }
            catch
            {

            }
        }

        private void btnSetParrents_Click(object sender, EventArgs e)
        {
            new frmSetParent().ShowDialog();
        }
    }

}

