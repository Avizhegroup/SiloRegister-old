using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;
using RfidConnectRegister.DataAccess;
using RfidConnectRegister.Business;
using RfidConnectRegister.UI.StoreProduct;

namespace RfidConnectRegister.UI
{
    public partial class FrmLogin : Form
    {
        private readonly Dictionary<string, string> _dicSetting;

        public FrmLogin()
        {
            InitializeComponent();

            try
            {
                RestApi.Ip = Properties.Settings.Default.ServerIP;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                Application.Exit();
            }
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            var apiBusiness = new ApiBusiness();
            try
            {
                if (!await apiBusiness.Login(txtUserName.Text.TrimEnd(), txtPassword.Text.TrimEnd()))
                    MessageBox.Show("نام کاربری و یا رمز عبور اشتباه است", "توجه", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                else
                {
                    Items.OnlineUserName = txtUserName.Text;
                    //DAL.Items.UserRoles = await apiBusiness.GetUserRoleList(DAL.Items.OnlineUserCode);
                    //_uhfReader.StopIndentifyTagByDeskReader();


                    if(Properties.Settings.Default.NotifApp )
                    {
                        this.Hide();
                        new TaskTrayApplicationContext();
                        BussinessLogic.SchasualedNotifCreator.StartschasualedNotifCreator();
 

                    }
                    else
                    {
                        new StoreProduct.frmStoreRegisterTags().Show();

                    }
                    //if (txtUserName.Text.Trim().ToLower() == "admin")
                    //{
                    //    BussinessLogic.SchasualedSmsCreator.StartschasualedSmsCreator();
                    //    BussinessLogic.SchasualedSmsCreator.HourTimer_Tick(sender, e);
                    //}

                }

            }
            catch (WebException ex)
            {
                MessageBox.Show("اتصال به سرور ممکن نیست", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                pnlIp.Visible = true;
             //.   AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
            }
            catch (AggregateException ex)
            {
           //     AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
                foreach (Exception innerEx in ex.InnerExceptions)
                {
                    if (innerEx is WebException)
                    {
                        pnlIp.Visible = true;
                        MessageBox.Show("اتصال به سرور ممکن نیست", "توجه", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                    }
                }
            }

            try
            {
                //ApiBusiness _api = new ApiBusiness();
                //var backResult = _api.Login(txtUserName.Text, txtPassword.Text, GetLocalIpAddress(),"1");
                //    var boolResult = !backResult["Value"][0]["UserInfo"].ToString().Equals("NotValid");
                //    if (boolResult)
                //    {
                //        GetSettingDictionary.DicSetting[ConfigKeys.User] = txtUserName.Text;
                //        GetSettingDictionary.SaveSettingInFile(true);
                //    Hide();
                //        new StoreProduct.frmStoreRegisterTags().ShowDialog();
                //    }
                //    else
                //        MessageBox.Show(@"اطلاعات وارد شده اشتباه است", @"خطا", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"در ارتباط با سامانه مشکلی بوجود آمده است", @"خطا", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
 

                GetLocalIpAddress();
                txtIp.Text = GetSettingDictionary.DicSetting[ConfigKeys.ServerIp];
            }
            catch (Exception)
            {

            }
        }

        public static string GetLocalIpAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }

                throw new Exception("No network adapters with an IPv4 address in the system!");
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                return string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(ActiveControl, true, true, true, true) ;
        }

        private void btnVisiblePanelIp_Click(object sender, EventArgs e)
        {
            new UI.FormSetting().ShowDialog();

            //pnlIp.Visible = true;
            //btnVisiblePanelIp.Visible = false;
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            var array = new[]
            {
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."
            };
            foreach (var item in txtIp.Text)
            {
                if (!array.Contains(item.ToString()))
                {
                    txtIp.Text = string.Empty;
                    return;
                }
            }
        }

        private void btnSaveIp_Click(object sender, EventArgs e)
        {
            try
            {
                GetSettingDictionary.DicSetting[ConfigKeys.ServerIp] = txtIp.Text;
                GetSettingDictionary.SaveSettingInFile();
                RestApi.Ip = GetSettingDictionary.DicSetting[ConfigKeys.ServerIp];
                pnlIp.Visible = false;
                btnVisiblePanelIp.Visible = true;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"در ثبت آی پی مشکلی بوجود آمده است", @"خطا", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        
    }
}
