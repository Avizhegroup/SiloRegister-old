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


    public partial class frmTestRegisterGroup : Form
    {
        BllConectToDeskReader _connectToDeskReader;
        private static string _port = string.Empty;
        List<DML.Tag> _detectedTags = new List<DML.Tag>();

        public frmTestRegisterGroup()
        {
            InitializeComponent();

            _port = Properties.Settings.Default.DeskUHFReader_Port;

            _connectToDeskReader = new BllConectToDeskReader();

        }

        private void frmTestRegisterGroup_Load(object sender, EventArgs e)
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
            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc, null, 2);
            if (_connectToDeskReader.StartIndentifyStatus && _connectToDeskReader.ConnectionStatus)
            {
                lblConnectToReaderStatus.BackColor = Color.Yellow;
            }
            else
            {
                lblConnectToReaderStatus.BackColor = Color.Red;

            }
            timer1.Enabled = true;
        }

        private void frmTestRegisterGroup_FormClosing(object sender, FormClosingEventArgs e)
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
        
        private void txtEpc_TextChanged(object sender, EventArgs e)
        {
            if (txtEpc.Text.Length == 24)
            {
                lblConnectToReaderStatus.BackColor = Color.Green;

                if (_detectedTags.FirstOrDefault(p => p.TagEpc == txtEpc.Text) == null)
                {
                    DML.Tag ds = new DML.Tag
                    {
                        TagEpc = txtEpc.Text,
                        TagStatus = -1
                    };
                    _detectedTags.Add(ds);
                    lblAllTagCount.Text = _detectedTags.Count.ToString();

                }
                txtEpc.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Check();
        }

        private async void Check()
        {
            ApiBusiness _api = new ApiBusiness();

            List<string> newTag = new List<string>();
            foreach (var tag in _detectedTags.Where(p => p.TagStatus == -1))
            {
                tag.TagStatus = 0;
                newTag.Add(tag.TagEpc);
            }
            var TagsData = await _api.GetTagsInfo(newTag, "");

            foreach (var tag in newTag)
            {
                var tagData = TagsData.FirstOrDefault(p => p.TagEpc == tag);

                dataGridView1.Rows.Add(tag, (tagData != null) ? tagData.ProductSerial : "رجیستر نشده", (tagData != null) ? tagData.ProductOldSerial : "", (tagData != null) ? tagData.ProductCode : "", (tagData != null) ? tagData.RegCode : "", (tagData != null) ? tagData.ContractStatus.ToString() : "");
            }
            int notregister = 0;

            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[1].Value.ToString()== "رجیستر نشده")
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                    notregister++;
                }
                else
                    dr.DefaultCellStyle.BackColor = Color.LightGreen;

            }
            lblNotRegisterTagCount.Text = notregister.ToString();
            lblAllTagCount.Text = _detectedTags.Count.ToString();
        }

        private void ClearO()
        {
            dataGridView1.Rows.Clear();
            _detectedTags.Clear();
            lblAllTagCount.Text = "0";
            lblNotRegisterTagCount.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            _connectToDeskReader.StartIndentifyTagByDeskReader(txtEpc, null, 2);
            if (_connectToDeskReader.StartIndentifyStatus && _connectToDeskReader.ConnectionStatus)
            {
                lblConnectToReaderStatus.BackColor = Color.Yellow;
            }
            else
            {
                lblConnectToReaderStatus.BackColor = Color.Red;

            }

            ClearO();
        }

        private void lblNotRegisterTagCount_TextChanged(object sender, EventArgs e)
        {
            if (lblNotRegisterTagCount.Text != "0")
            {
                lblNotRegisterTagCount.BackColor = Color.Red;
            }
            else
                lblNotRegisterTagCount.BackColor = Color.White;

        }
    }
    
}
     
