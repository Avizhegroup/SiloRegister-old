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
    public partial class frmRepErrorInRegisterTag : Form
    {
        public frmRepErrorInRegisterTag()
        {
            InitializeComponent();
        }

        private async void frmRepErrorInRegisterTag_Load(object sender, EventArgs e)
        {
              Search();

        }

        private async void Search()
        {


            ApiBusiness _api = new ApiBusiness();


            var _listProduct = await _api.RepRegisterTagByTagStatus0(BussinessLogic.Time.Time.GetUnixPersianTime(-1));

            dgvSearch.Rows.Clear();


            int RowIndex = 1;
            foreach (DataRow dr in _listProduct.Rows)
            {

                dgvSearch.Rows.Add(RowIndex, dr["ProductSerial"].ToString(), dr["ProductCode"].ToString(), dr["RegCode"].ToString(), dr["ProductName"].ToString(), dr["ProductCount"].ToString(), dr["Username"].ToString(), dr["TagRegisterShamsiUnixDate"].ToString() );
                RowIndex++;
            }


            var _listProduct2 = await _api.SRepRegisterTagWithOutEPC();

            dgvSearch2.Rows.Clear();


            int RowIndex2 = 1;
            foreach (DataRow dr in _listProduct2.Rows)
            {

                dgvSearch2.Rows.Add(RowIndex2, dr["ProductSerial"].ToString(), dr["ProductCode"].ToString(), dr["RegCode"].ToString(), dr["ProductName"].ToString(), dr["ProductCount"].ToString(), dr["Username"].ToString(), dr["TagRegisterShamsiUnixDate"].ToString());
                RowIndex2++;
            }
        }
    }
}