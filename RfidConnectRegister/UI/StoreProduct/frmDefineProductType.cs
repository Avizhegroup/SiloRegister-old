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
    public partial class frmDefineProductType : Form
    {
        private List<DML.ProductType> _list = new List<DML.ProductType>();
         private bool _flagSelectionChange = false;
        private bool FlagChange = false;
        public DML.Product _ChoosedProduct;
        public frmDefineProductType()
        {
            InitializeComponent();
        }

        private void frmDefineProductType_Load(object sender, EventArgs e)
        {
            GetAndFill();
            ClearItems();
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
             if (!flag)
                timerErrorClear.Enabled = true;

            return flag;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckBeforeSave())
                return;
            var apiBusiness = new ApiBusiness();

            /// قرار میدهد <see cref="Berlian"/>مقادیر موجود در تکس باکس ها را در متغییر های لیست
            

            var result = await apiBusiness.SaveProductType(txtProductTitle.Text,"1","",txtProductCode.Text,DataAccess.Items.OnlineUserCode.ToString());
            if (result)
            {
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                 
            }
            else
            {
                MessageBox.Show("در انجام عملیات مشکلی بوجود آمده است", "توجه", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                
            }

            GetAndFill();
            //    GetSizeList(_list);
            ClearItems();
        }

        private void ClearItems()
        {
                      txtProductTitle.Text =  txtProductCode.Text= "";
             txtProductCode.Focus();
            FlagChange = false;
        }
        private async void GetAndFill()
        {
            dgvPrintQueue.Rows.Clear();
            var api = new ApiBusiness();
            _list = await api.GetAllProductType();
 
            ///متد زیر را اجرا میکند
            var counter = 1;
            foreach (DML.ProductType item in _list)
            {
                dgvPrintQueue.Rows.Add(item.ProductTypeCode, item.ProductTypeTitle);
                counter++;
            }


            // GetSizeList(_list); 
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
                    p.ProductTypeCode == id);
                FillData(choosedInstance);
            }
            ));

        }


        private void FillData(DML.ProductType data)
        {
            txtProductCode.Text = data.ProductTypeCode;
            txtProductTitle.Text = data.ProductTypeTitle;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            ClearItems();
        }
    }
}
