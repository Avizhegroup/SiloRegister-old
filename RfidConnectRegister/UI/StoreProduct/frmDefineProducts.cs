using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidConnectRegister.UI.StoreProduct
{
    public partial class frmDefineProducts : Form
    {
        private List<DML.Product> _list = new List<DML.Product>();
        private List<DML.Product> _CusWMSList = new List<DML.Product>();
        private bool _flagSelectionChange = false;
        private bool FlagChange = false;
        public DML.Product _ChoosedProduct;
        public frmDefineProducts()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private bool CheckBeforeSave()
        {
            var flag = true;
            if (txtProductCode.Text == string.Empty)
            {
                errorProvider.SetError(txtProductCode, "فیلد نمی تواند خالی بماند");
                flag = false;
            }
            if (txtProductTitle.Text == string.Empty)
            {
                errorProvider.SetError(txtProductTitle, "فیلد نمی تواند خالی بماند");
                flag = false;
            }
            if (txtProductPackValue.Text == string.Empty)
            {
                errorProvider.SetError(txtProductPackValue, "فیلد نمی تواند خالی بماند");
                flag = false;
            }

            if (txtProductSize.SelectedIndex==-1)
            {
                errorProvider.SetError(txtProductSize, "فیلد نمی تواند خالی بماند");
                flag = false;
            }
            if (cmbProductType.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbProductType, "فیلد نمی تواند خالی بماند");
                flag = false;
            }
            if (cmbProductStatus.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbProductStatus, "فیلد نمی تواند خالی بماند");
                flag = false;
            }
            if (!flag)
                timerErrorClear.Enabled = true;

            return flag;
        }

        private void timerErrorClear_Tick(object sender, EventArgs e)
        {

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            var apiBusiness = new ApiBusiness();

            /// قرار میدهد <see cref="Berlian"/>مقادیر موجود در تکس باکس ها را در متغییر های لیست
            var newProduct = new DML.Product()
            {
                ProductCode = txtProductCode.Text,
                ProductCountInPack = txtProductCountInPack.Text,
                ProductENTitle = txtProductENTitle.Text,
                ProductPackValue = txtProductPackValue.Text,
                ProductPackVolume = txtProductPackVolume.Text,
                ProductPackWeight = txtProductPackWeight.Text,
                ProductSize = (txtProductSize.SelectedValue != null) ? txtProductSize.SelectedValue.ToString() : "-1",
                ProductStatus = (cmbProductStatus.SelectedValue != null) ? cmbProductStatus.SelectedValue.ToString() : "-1",
                ProductTechnicalCode = txtProductTechnicalCode.Text,
                ProductTitle = txtProductTitle.Text,
                ProductUnit = txtProductUnit.Text,
                ProductValue = txtProductValue.Text,
                ProductType = (cmbProductType.SelectedValue != null) ? cmbProductType.SelectedValue.ToString() : "-1"
                , ProductRegUser = DataAccess.Items.OnlineUserCode.ToString()
            };

            var result = await apiBusiness.SaveProduct(newProduct);
            if (result)
            {
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _ChoosedProduct = newProduct;
            }
            else
            {
                MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "توجه", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                _ChoosedProduct = null;
            }

            GetAndFill();
        //    GetSizeList(_list);
            ClearItems();
        }

        private async void Delete()
        {
            if (txtProductCode.Text.Trim()=="")
                return;
            var apiBusiness = new ApiBusiness();

            /// قرار میدهد <see cref="Berlian"/>مقادیر موجود در تکس باکس ها را در متغییر های لیست
 
            var result = await apiBusiness.DeleteProduct(txtProductCode.Text.Trim());
            if (result)
            {
                MessageBox.Show("اطلاعات با موفقیت حذف شد", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
             }
            else
            {
                MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "توجه", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
             }

            GetAndFill();
             ClearItems();
        }

        private void ClearItems()
        {
            cmbProductStatus.SelectedIndex = -1;
            txtProductPackWeight.Text=  txtProductTitle.Text=  txtProductTechnicalCode.Text= txtProductUnit.Text= txtProductValue.Text= txtProductSize.Text= txtProductCode.Text = txtProductCountInPack.Text = txtProductENTitle.Text = txtProductPackValue.Text = txtProductPackVolume.Text = txtProductCountInPack.Text= "";
            txtProductUnit.Text = "متر مربع";
            txtProductSize.SelectedIndex = -1;
            txtProductCode.Focus();
            FlagChange = false;
        }
        private async void GetAndFill()
        {
            dgvPrintQueue.Rows.Clear();
            var api = new ApiBusiness();
            _list = await api.GetAllProduct();
             cmbProductStatus.DataSource = await api.GetAllProductStatus();
            cmbProductStatus.DisplayMember = "ProductStatusTitle";
            cmbProductStatus.ValueMember = "ProductStatusCode";
            cmbProductStatus.SelectedIndex = -1;


            cmbProductType.DataSource = await api.GetAllProductType();
            cmbProductType.DisplayMember = "ProductTypeTitle";
            cmbProductType.ValueMember = "ProductTypeCode";
            cmbProductType.SelectedIndex = -1;



            txtProductSize.DataSource = await api.GetAllProductPropertyC();
            txtProductSize.DisplayMember = "ProductPropertyC_Title";
            txtProductSize.ValueMember = "ProductPropertyC_Id";
            txtProductSize.SelectedIndex = -1;

            ///متد زیر را اجرا میکند
            var counter = 1;
            foreach (DML.Product item in _list)
            {
                dgvPrintQueue.Rows.Add(item.ProductCode, item.ProductTitle);
                counter++;
            }


           // GetSizeList(_list); 
        }



        private void frmDefineProducts_Load(object sender, EventArgs e)
        {
            GetAndFill();
            ClearItems();
           
        }

        private void dgvPrintQueue_Enter(object sender, EventArgs e)
        {
            _flagSelectionChange = true;
        }

        private void dgvPrintQueue_Leave(object sender, EventArgs e)
        {
            _flagSelectionChange = false;
        }

        private void PanelWaitingShow(Action passedAction)
        {
            pnlWaiting.Visible = true;
            this.Enabled = !true;
            this.Invoke(passedAction);
            pnlWaiting.Visible = !true;
            this.Enabled = true;
        }


        private void dgvPrintQueue_SelectionChanged(object sender, EventArgs e)
        {
            if (!_flagSelectionChange)
                return;
            if (dgvPrintQueue.Rows.Count == 0)
                return;
            if (dgvPrintQueue.SelectedRows.Count == 0)
                return;
            if (dgvPrintQueue.SelectedRows[0].Index == -1)
                return;
            ClearItems();
            PanelWaitingShow(new Action(() =>
            {
                var id = dgvPrintQueue.SelectedRows[0].Cells[0].Value.ToString();
                var choosedInstance = _list.FirstOrDefault(p =>
                    p.ProductCode == id);
                FillData(choosedInstance);
            }
            ));
            
        }


        private void FillData(DML.Product data)
        {
            txtProductCode.Text = data.ProductCode;
            txtProductCountInPack.Text = data.ProductCountInPack;
            txtProductENTitle.Text = data.ProductENTitle;
            txtProductPackValue.Text = data.ProductPackValue;
            txtProductPackVolume.Text = data.ProductPackVolume;
            txtProductPackWeight.Text = data.ProductPackWeight;
            txtProductSize.SelectedValue = data.ProductSize;
            cmbProductStatus.SelectedValue = data.ProductStatus;
            txtProductTechnicalCode.Text = data.ProductTechnicalCode;
            txtProductTitle.Text = data.ProductTitle;
            txtProductUnit.Text = data.ProductUnit;
            txtProductValue.Text = data.ProductValue;
            cmbProductType.SelectedValue = data.ProductType;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pnlSerachInWMS.Visible = true;
             
            var api = new ApiBusiness();
            _CusWMSList = await api.GetAllWMSProduct();

            dgvCusWMS.Rows.Clear();
            foreach (DML.Product item in _CusWMSList)
            {
                dgvCusWMS.Rows.Add("انتخاب", item.ProductCode, item.ProductTitle);
            }
        }

        private void dgvCusWMS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex>=0 && e.ColumnIndex>=0)
            //{
            //    txtProductCode.Text = dgvCusWMS.Rows[e.RowIndex].Cells["dgvCodekala"].Value.ToString();
            //    txtProductTitle.Text = dgvCusWMS.Rows[e.RowIndex].Cells["dgvTitleKala"].Value.ToString();
            //}
            //pnlSerachInWMS.Visible = false;


        }

        private void SearchIndgvCusWMS(string Code,string title)
        {
            if (FlagChange)
            {
                dgvCusWMS.Rows.Clear();
                List<DML.Product> _listProductTemp = new List<DML.Product>();
                _listProductTemp = _CusWMSList;
                if (Code != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductCode.ToLower().Contains(Code.ToLower())).ToList();
                if (title != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductTitle.ToLower().Contains(title.ToLower())).ToList();
 
                foreach (DML.Product pr in _listProductTemp)
                {
                    string[] Rows = { "انتخاب", pr.ProductCode, pr.ProductTitle};
                    dgvCusWMS.Rows.Add(Rows);
                }

                //FlagChange = false;
            }
        }

        private void dgvCusWMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                txtProductCode.Text = dgvCusWMS.Rows[e.RowIndex].Cells["dgvCodekala"].Value.ToString();
                txtProductTitle.Text = dgvCusWMS.Rows[e.RowIndex].Cells["dgvTitleKala"].Value.ToString();
                txtProductENTitle.Text = dgvCusWMS.Rows[e.RowIndex].Cells["dgvTitleKala"].Value.ToString();
            }
            pnlSerachInWMS.Visible = false;

        }

        private void txtSearchCode_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void txtSearchCode_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void txtSearchTitle_Enter(object sender, EventArgs e)
        {
            FlagChange = true;

        }

        private void txtSearchTitle_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            SearchIndgvCusWMS(txtSearchCode.Text, txtSearchTitle.Text);
        }

        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
        {
            SearchIndgvCusWMS(txtSearchCode.Text, txtSearchTitle.Text);

        }

        private void btnCancelppnlWMS_Click(object sender, EventArgs e)
        {
            pnlSerachInWMS.Visible = false;
        }


        private async Task<List<string>> GetSizeList(List<DML.Product> _listAllprodudt)
        {

            List<string> _listSize = new List<string>();

            foreach (DML.Product pr in _listAllprodudt)
            {
                if (_listSize.FirstOrDefault(p => p.Contains(pr.ProductSize)) == null)
                {
                    _listSize.Add(pr.ProductSize);
                    txtProductSize.Items.Add(pr.ProductSize);
                }
            }

            return _listSize;
        }

        private void txtProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtProductSize.SelectedIndex!=-1)
            {
                switch(txtProductSize.SelectedValue.ToString())
                {
                    case "75*75":
                        txtProductValue.Text = "1.69";
                        txtProductCountInPack.Text = "40";
                        txtProductPackValue.Text = "67.6";
                        txtProductPackWeight.Text = "0";
                        txtProductPackVolume.Text = "0";
                        break;
                    case "60*60":
                        txtProductValue.Text = "1.44";
                        txtProductCountInPack.Text = "72";
                        txtProductPackValue.Text = "103.68";
                        txtProductPackWeight.Text = "0";
                        txtProductPackVolume.Text = "0";
                        break;
                    case "60*120":                        
                        txtProductValue.Text = "1.44";
                        txtProductCountInPack.Text = "60";
                        txtProductPackValue.Text = "86.4";
                        txtProductPackWeight.Text = "0";
                        txtProductPackVolume.Text = "0";
                        break;
                         
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
