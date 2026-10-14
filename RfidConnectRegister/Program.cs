using System;
using System.Windows.Forms;
using Microsoft.Win32;
using RfidConnectRegister.BussinessLogic.AppRegister;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;

namespace RfidConnectRegister
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {//کد تولید >>> کد تولید
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show(args.Exception.ToString());
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                MessageBox.Show(args.ExceptionObject.ToString());
            };
            GetSettingDictionary.GetSetting();
            try
            {
                RestApi.Ip = Properties.Settings.Default.ServerIP;


                 
            }
            catch
            {
                //GetSettingDictionary.DicSetting[ConfigKeys.SerialLength] = Properties.Settings.Default.SerialLength.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.KindRegister] = Properties.Settings.Default.KindRegister.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.MergPrintToPDF] = Properties.Settings.Default.MergPrintToPDF;

                //GetSettingDictionary.DicSetting[ConfigKeys.ControlPrintFormatByBrand] = Properties.Settings.Default.ControlPrintFormatByBrand;

                //GetSettingDictionary.DicSetting[ConfigKeys.AutoDetecteShift] = Properties.Settings.Default.AutoDetecteShift;

                //GetSettingDictionary.DicSetting[ConfigKeys.GetListSerial] = Properties.Settings.Default.GetListSerial;

                //GetSettingDictionary.DicSetting[ConfigKeys.ReaderPort] = Properties.Settings.Default.PortNumber;

                //GetSettingDictionary.DicSetting[ConfigKeys.ReaderPower] = Properties.Settings.Default.ReaderPower.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.TableModel] = Properties.Settings.Default.TableModel;

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeSpliter] = Properties.Settings.Default.BarcodeSpliter;

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeIndex] = Properties.Settings.Default.BarcodeIndex.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.ComPairDevice] = Properties.Settings.Default.PortNumber;

                //GetSettingDictionary.DicSetting[ConfigKeys.ServerIp] = Properties.Settings.Default.ServerIP;

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeLength1] = Properties.Settings.Default.BarcodeLength1.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeLength2] = Properties.Settings.Default.BarcodeLength2.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.ShowSaveDialog] = Properties.Settings.Default.ShowSaveDialog ? "true" : "false";

                //GetSettingDictionary.DicSetting[ConfigKeys.PrinterModel] = Properties.Settings.Default.PrinterModel;

                //GetSettingDictionary.DicSetting[ConfigKeys.PrinterInOperation] = Properties.Settings.Default.PrinterInOperation ? "true" : "false";

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeSpliter] = Properties.Settings.Default.BarcodeSpliter;

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeIndex] = Properties.Settings.Default.BarcodeIndex.ToString();

                //GetSettingDictionary.DicSetting[ConfigKeys.CompanyName] = Properties.Settings.Default.CompanyName;

                //GetSettingDictionary.DicSetting[ConfigKeys.ReportFileName] = Properties.Settings.Default.ReportFileName;

                //GetSettingDictionary.DicSetting[ConfigKeys.BarcodeType] = Properties.Settings.Default.BarcodeType;

                //GetSettingDictionary.DicSetting[ConfigKeys.HaveLogin] = Properties.Settings.Default.HaveLogin ? "true" : "false";

                //GetSettingDictionary.DicSetting[ConfigKeys.NotifApp] = Properties.Settings.Default.NotifApp ? "true" : "false";

                //GetSettingDictionary.DicSetting[ConfigKeys.PrintPaperType] = Properties.Settings.Default.PrintPaperType;
                //GetSettingDictionary.SaveSettingInFile();
            }


            //var rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //if (rkApp != null) rkApp.SetValue("RfidConnectRegister.EXE", Application.ExecutablePath);
            //var checkingRegRes = RegisteryClass.CheckRegistery();

            //     BussinessLogic.SchasualedSmsCreator.StartschasualedSmsCreator();


            Application.Run(new UI.FrmLogin());
            //switch (checkingRegRes)
            //{
            //    case 1:
            //        if (GetSettingDictionary.DicSetting[ConfigKeys.HaveLogin].ToLower() == "true")
            //            Application.Run(new UI.FrmLogin());
            //        else
            //            Application.Run(new UI.FrmParent());
            //        break;
            //    case 3:
            //        Application.Run(new UI.FrmRegister());
            //        break;
            //}
        }

    }
}