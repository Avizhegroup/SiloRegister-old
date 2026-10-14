using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using RfidConnectRegister.DML;
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
    public partial class frmSearchProducts : Form
    {
        private List<DML.Product> _listProduct = new List<DML.Product>();
        private List<DML.Product> _filteredlistProduct = new List<DML.Product>();
        private List<DML.ProductStatus> _listProductStatus = new List<DML.ProductStatus>();
         private List<DML.ProductSize> _listProductSize = new List<DML.ProductSize>();
        private List<DML.ProductBrand> _listProductBrand = new List<DML.ProductBrand>();
        private List<DML.ProductGroup> _listProductGroup = new List<DML.ProductGroup>();
        private List<DML.ProductType> _listProductType = new List<DML.ProductType>();
        private List<string> _listProductTechnicalCode = new List<string>();
        private ApiBusiness api = new ApiBusiness();
        MaskedTextBox selectedCode  ;
        Boolean FlagChange = false;
        public frmSearchProducts(MaskedTextBox _selectedProductCode, List<DML.Product> ListProduct)
        {
            InitializeComponent();
            selectedCode = _selectedProductCode;
            _listProduct = ListProduct;


        }

      

        private async  Task  GetListData(List<DML.Product> _listAllprodudt)
        {



           _listProductStatus = new List<DML.ProductStatus>();
         _listProductSize = new List<DML.ProductSize>();
        _listProductBrand = new List<DML.ProductBrand>();
         _listProductGroup = new List<DML.ProductGroup>();
     _listProductType = new List<DML.ProductType>();
         _listProductTechnicalCode = new List<string>();

             foreach (DML.Product pr in _listAllprodudt)
            {
                if(_listProductSize.FirstOrDefault(p=> p.ProductSizeCode==pr.ProductSize)==null && pr.ProductSizeTitle!="" && pr.ProductSize!="")
                {

                    _listProductSize.Add(  new DML.ProductSize { ProductSizeCode = pr.ProductSize, ProductSizeTitle = pr.ProductSizeTitle });
                 }

                if (_listProductTechnicalCode.FirstOrDefault(p => p.ToString() == pr.ProductTechnicalCode) == null && pr.ProductTechnicalCode != "" && pr.ProductTechnicalCode != "")
                {

                    _listProductTechnicalCode.Add(pr.ProductTechnicalCode);
                }

                


                if (_listProductType.FirstOrDefault(p => p.ProductTypeCode == pr.ProductType) == null && pr.ProductTypeTitle!="" && pr.ProductType!="")
                {
                    _listProductType.Add(new DML.ProductType { ProductTypeCode = pr.ProductType, ProductTypeTitle = pr.ProductTypeTitle });
                }


                

                if (_listProductBrand.FirstOrDefault(p => p.ProductBrandCode == pr.ProductBrand) == null && pr.ProductBrandTitle!="" && pr.ProductBrand!="")
                {

                    _listProductBrand.Add(new DML.ProductBrand { ProductBrandCode = pr.ProductBrand, ProductBrandTitle = pr.ProductBrandTitle });
                }

                if (_listProductGroup.FirstOrDefault(p => p.ProductGroupCode == pr.ProductGroup) == null && pr.ProductGroupTitle!="" && pr.ProductGroup!="")
                {

                    _listProductGroup.Add(new DML.ProductGroup { ProductGroupCode = pr.ProductGroup, ProductGroupTitle = pr.ProductGroupTitle });
                }
                if (_listProductStatus.FirstOrDefault(p => p.ProductStatusCode == pr.ProductStatus) == null && pr.ProductStatusTitle!="" && pr.ProductStatus!="")
                {

                    _listProductStatus.Add(new DML.ProductStatus { ProductStatusCode = pr.ProductStatus, ProductStatusTitle = pr.ProductStatusTitle });
                }

                 
            }

            var _tempSelectedProductBrand =(cmbProductBrand.SelectedIndex!=-1)? cmbProductBrand.SelectedValue.ToString():"";
            cmbProductBrand.DataSource = _listProductBrand;
            cmbProductBrand.DisplayMember = "ProductBrandTitle";
            cmbProductBrand.ValueMember = "ProductBrandCode";
            if (_tempSelectedProductBrand == "")
                cmbProductBrand.SelectedIndex = -1;
            else
                cmbProductBrand.SelectedValue = _tempSelectedProductBrand;


            var _tempSelectedProductStatus = (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "";
            cmbProductStatus.DataSource = _listProductStatus;
            cmbProductStatus.DisplayMember = "ProductStatusTitle";
            cmbProductStatus.ValueMember = "ProductStatusCode";
            if (_tempSelectedProductStatus == "")
                cmbProductStatus.SelectedIndex = -1;
            else
                cmbProductStatus.SelectedValue = _tempSelectedProductStatus;


            var _tempSelectedProductGroup = (cmbProductGroup.SelectedIndex != -1) ? cmbProductGroup.SelectedValue.ToString() : "";
            cmbProductGroup.DataSource = _listProductGroup;
            cmbProductGroup.DisplayMember = "ProductGroupTitle";
            cmbProductGroup.ValueMember = "ProductGroupCode";
            if (_tempSelectedProductGroup == "")
                cmbProductGroup.SelectedIndex = -1;
            else
                cmbProductGroup.SelectedValue = _tempSelectedProductGroup;


            var _tempSelectedProductSize = (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "";
            cmbProductSize.DataSource = _listProductSize;
            cmbProductSize.DisplayMember = "ProductSizeTitle";
            cmbProductSize.ValueMember = "ProductSizeCode";
            if (_tempSelectedProductSize == "")
                cmbProductSize.SelectedIndex = -1;
            else
                cmbProductSize.SelectedValue = _tempSelectedProductSize;

            var _tempSelectedProductType = (cmbProductType.SelectedIndex != -1) ? cmbProductType.SelectedValue.ToString() : "";
            cmbProductType.DataSource = _listProductType;
            cmbProductType.DisplayMember = "ProductTypeTitle";
            cmbProductType.ValueMember = "ProductTypeCode";
            if (_tempSelectedProductType == "")
                cmbProductType.SelectedIndex = -1;
            else
                cmbProductType.SelectedValue = _tempSelectedProductType;


            txtProductRegCode.Items.Clear();
            var _tempSelectedProductTechnicalCode = (txtProductRegCode.SelectedIndex != -1) ? txtProductRegCode.Text.ToString() : "";
            foreach(string itemProductRegCode in _listProductTechnicalCode)
            { txtProductRegCode.Items.Add(itemProductRegCode); }
             if (_tempSelectedProductType == "")
                cmbProductType.Text = "";
            else
                cmbProductType.Text = _tempSelectedProductType;

        }


        private async void frmSearchProducts_Load(object sender, EventArgs e)
        {
           

           


                GetListData(_listProduct);
 

            FlagChange = false;
             FlagChange = false;
            cmbProductBrand.SelectedIndex = -1;
            cmbProductSize.SelectedIndex = -1;
            cmbProductGroup.SelectedIndex = -1;
            cmbProductStatus.SelectedIndex = -1;
            FlagChange = false;
            Clear();




        }


        private  void Search(string ProductCode,string ProductTitle,string ProductSize,string ProductStatus,string ProductRegCode)
        {



            if (FlagChange)
            {
                string ProductType = (cmbProductType.SelectedIndex != -1) ? cmbProductType.SelectedValue.ToString() : "";
                string ProductGroup = (cmbProductGroup.SelectedIndex != -1) ? cmbProductGroup.SelectedValue.ToString() : "";
                string ProductBrand = (cmbProductBrand.SelectedIndex != -1) ? cmbProductBrand.SelectedValue.ToString() : "";
                string RegDocument = txtRegDocument.Text;


                dgvSearch.Rows.Clear();
                List<DML.Product> _listProductTemp = new List<DML.Product>();
                _listProductTemp = _listProduct;
                if (ProductCode != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductCode == ProductCode).ToList();
                if (ProductTitle != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductTitle.ToLower().Contains(ProductTitle.ToLower())).ToList();
                if (ProductSize != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductSize == ProductSize).ToList();
                if (ProductStatus != "" && ProductStatus != "RfidConnectRegister.DML.ProductStatus")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductStatus == ProductStatus).ToList();
                if (ProductRegCode != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductTechnicalCode == ProductRegCode).ToList();
                if(ProductGroup!="")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductGroup == ProductGroup).ToList();
                if (ProductBrand != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductBrand == ProductBrand).ToList();

                if (ProductType != "")
                    _listProductTemp = _listProductTemp.Where(p => p.ProductType == ProductType).ToList();

                _filteredlistProduct = _listProductTemp;
                foreach (DML.Product pr in _listProductTemp)
                {
                    string[] Rows = { "انتخاب", pr.ProductCode, pr.ProductTitle, pr.ProductSizeTitle, pr.ProductTechnicalCode, pr.ProductStatusTitle,pr.ProductBrandTitle, pr.ProductGroupTitle, pr.ProductTypeTitle };
                    dgvSearch.Rows.Add(Rows);
                }

                FlagChange = false;

                GetListData(_filteredlistProduct);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FlagChange = true;
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);
        }

        private void dgvSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
                selectedCode.Text = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close() ;
            }
        }

        private void Clear()
        {
            dgvSearch.Rows.Clear();
            txtProductCode.Text = txtProductRegCode.Text = txtProductTitle.Text = "";
            cmbProductBrand.SelectedIndex = -1;
            cmbProductSize.SelectedIndex = -1;
            txtProductRegCode.SelectedIndex = -1;
            cmbProductGroup.SelectedIndex = -1;
            cmbProductStatus.SelectedIndex = -1;
            cmbProductType.SelectedIndex = -1;
            txtProductCode.Focus();
            chbRegDocumrnt.Checked = false;
            txtRegDocument.Text = "";
            GetListData(_listProduct);
            FlagChange = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                selectedCode.Text = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void txtProductTitle_TextChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void txtProductRegCode_TextChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void cmbProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void cmbProductStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void txtProductCode_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void txtProductTitle_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void txtProductRegCode_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void cmbProductSize_Enter(object sender, EventArgs e)
        {
            FlagChange = true;

        }

        private void cmbProductStatus_Enter(object sender, EventArgs e)
        {
            FlagChange = true;

        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void txtProductTitle_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void txtProductRegCode_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void cmbProductSize_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void cmbProductStatus_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProductBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.SelectedValue.ToString() : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void cmbProductBrand_Enter(object sender, EventArgs e)
        {
            FlagChange = true;
        }

        private void cmbProductBrand_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void cmbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void cmbProductGroup_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void cmbProductGroup_Enter(object sender, EventArgs e)
        {
            FlagChange = true;

        }

        private void chbRegDocumrnt_CheckedChanged(object sender, EventArgs e)
        {
            txtRegDocument.Enabled = chbRegDocumrnt.Checked;
        }

        private void cmbProductType_Leave(object sender, EventArgs e)
        {
            FlagChange = false;

        }

        private void cmbProductType_Enter(object sender, EventArgs e)
        {
            FlagChange = true;

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

        }

        private void cmbProductType_TextChanged(object sender, EventArgs e)
        {
            if(cmbProductType.Text=="")
            {
                 Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

            }
        }

        private void cmbProductSize_TextChanged(object sender, EventArgs e)
        {
            if (cmbProductSize.Text == "")
            {
                 Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

            }
        }

        private void cmbProductStatus_TextChanged(object sender, EventArgs e)
        {
            if (cmbProductStatus.Text == "")
            {
                 Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

            }

        }

        private void cmbProductBrand_TextChanged(object sender, EventArgs e)
        {
            if (cmbProductBrand.Text == "")
            {
                 Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

            }

        }

        private void cmbProductGroup_TextChanged(object sender, EventArgs e)
        {
            if (cmbProductGroup.Text == "")
            {
                 Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);

            }
        }

        private void txtProductRegCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(txtProductCode.Text, txtProductTitle.Text, (cmbProductSize.SelectedIndex != -1) ? cmbProductSize.Text : "", (cmbProductStatus.SelectedIndex != -1) ? cmbProductStatus.SelectedValue.ToString() : "", txtProductRegCode.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetAllProduct();

        }

        private async Task GetAllProduct()
        {
            _listProduct = await api.GetAllProduct();



          

            GetListData(_listProduct);


            FlagChange = false;
            FlagChange = false;
            cmbProductBrand.SelectedIndex = -1;
            cmbProductSize.SelectedIndex = -1;
            cmbProductGroup.SelectedIndex = -1;
            cmbProductStatus.SelectedIndex = -1;
            FlagChange = false;
            Clear();

        }
    }
}
