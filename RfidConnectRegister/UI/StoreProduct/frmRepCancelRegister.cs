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
    public partial class frmRepCancelRegister : Form
    {
        private List<DML.User> _listUser = new List<DML.User>();

        Boolean FlagChange = false;
        public frmRepCancelRegister()
        {
            InitializeComponent();
        }

        private async void frmRepCancelRegister_Load(object sender, EventArgs e)
        {
            var api = new ApiBusiness();
            _listUser = await api.GetAllUser();
            cmbUsers.DataSource = _listUser;
            cmbUsers.DisplayMember = "UserName";
            cmbUsers.ValueMember = "UserName";
            cmbUsers.SelectedIndex = -1;
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FlagChange = true;
            Search(  txtProductSerial.Text, (txtRegisterDateFrom.Text.Length >= 10) ? txtRegisterDateFrom.Text : "", (txtRegisterDateTo.Text.Length >= 10) ? txtRegisterDateTo.Text : "",   (cmbUsers.SelectedIndex != -1) ? cmbUsers.SelectedValue.ToString() : "" );

        }

        private async void Search( string ProductSerial, string FromDate, string ToDate, string  UserName)
        {
            if (FlagChange)
            {

                ApiBusiness _api = new ApiBusiness();


                var _listProduct = await _api.RepSCancelRegisterTag(ProductSerial, FromDate,
                  ToDate, UserName );

                dgvSearch.Rows.Clear();


                int RowIndex = 1;
                foreach (DataRow dr in _listProduct.Rows)
                {

                    dgvSearch.Rows.Add(RowIndex, dr["ProductSerial"].ToString(), dr["ProductCode"].ToString(), dr["ProductRegCode"].ToString(), dr["ProductName"].ToString(), dr["ProductCount"].ToString(), dr["RegisterUser"].ToString(), dr["RegisterDate"].ToString(), dr["SoftDeleteDate"].ToString(), dr["SoftDeleteUser"].ToString() );
                    RowIndex++;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
             txtProductSerial.Text = txtRegisterDateFrom.Text = txtRegisterDateTo.Text =   "";
            cmbUsers.SelectedIndex =   -1;
            dgvSearch.Rows.Clear();
            txtProductSerial.Focus();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Title = @"فایل مورد نظر را انتخاب کنید";
                saveFileDialog1.Filter = @"Excel Document (*.xls , *.xlsx)| *.xls; *.xlsx;";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtExportExcel = BussinessLogic.Tools.ConvertDatagridViewToDatatable(dgvSearch);

                    AvizheExcel.ExcelExport.ExportDatatable(dtExportExcel, saveFileDialog1.FileName);
                    MessageBox.Show("فایل اکسل مورد نظر در مسیر انتخاب شده ذخیره شد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ذخیره فایل اکسل با خطا مواجه شده است\n" + ex.ToString());

            }
        }
    }
}
