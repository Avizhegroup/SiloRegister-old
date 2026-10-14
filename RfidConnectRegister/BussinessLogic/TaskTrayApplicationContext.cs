using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using RfidConnectRegister.UI;

namespace RfidConnectRegister.Business
{
    internal class TaskTrayApplicationContext : ApplicationContext
    {
        private readonly NotifyIcon _notifyIcon = new NotifyIcon();
        private readonly Timer _timerCheckAlerts = new Timer();
         private readonly Dictionary<string, string> _dicSetting = new Dictionary<string, string>();

        public TaskTrayApplicationContext( )
        {

            
            var repTagsMenuItem = new MenuItem("گزارش نوتیف ها ", ShowRepTagsMenuItem);
             var logoutMenuItem = new MenuItem("خروج از حساب کابری", Logout);

            _notifyIcon.ContextMenu = new ContextMenu(new[] {  repTagsMenuItem,    logoutMenuItem });



                _notifyIcon.Icon = Properties.Resources.logo_icon;
            _notifyIcon.Visible = true;
            _notifyIcon.Text = @"گزارشات RFID";

          
        }

        private static void Logout(object sender, EventArgs eventArgs)
        {
            Application.Exit();
        }

        private static void defineProduct(object sender, EventArgs eventArgs)
        {
            new UI.StoreProduct.frmDefineProducts().Show();
        }

        private static void defineProductType(object sender, EventArgs eventArgs)
        {
            new UI.StoreProduct.frmDefineProductType().Show();
        }

        
 
        private static void repCancelRegister(object sender, EventArgs eventArgs)
        {
            new UI.StoreProduct.frmRepCancelRegister().Show();
        }

       

        private static void ShowRepRegisterError(object sender, EventArgs eventArgs)
        {
            new UI.StoreProduct.frmRepErrorInRegisterTag().Show();
        }
       
        private static void ShowRepTagsMenuItem(object sender, EventArgs eventArgs)
        {
            new UI.StoreProduct.frmRepRegisterTag().Show();
        }
        

       
       
       

    }
}
