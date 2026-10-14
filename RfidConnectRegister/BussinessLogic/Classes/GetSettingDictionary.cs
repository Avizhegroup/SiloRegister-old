using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    public class GetSettingDictionary
    {
        public static Dictionary<string, string> DicSetting = new Dictionary<string, string>();

        internal static void GetSetting()
        {
            try
            {
                var appStringArray = File.ReadAllLines(Application.StartupPath + "\\ApplicationConfig.log")[0].Split('/');
                var dic = new Dictionary<string, string>();
                if (appStringArray.Length != 0)
                {
                    foreach (var item in appStringArray)
                    {
                        var splited = item.Split('=');
                        if (splited.Length == 1)
                            break;
                        var key = item.Split('=')[0];
                        var value = item.Split('=')[1];
                        dic.Add(key, value);
                    }
                }

                DicSetting = dic;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"در ثبت فایل تنظیمات مشکلی بوجود آمده است", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        internal static void SaveSettingInFile(bool isFromLogin = false)
        {
            try
            {
                var saveStr = string.Empty;
                foreach (var key in DicSetting.Keys)
                {
                    saveStr += key + "=" + DicSetting[key] + "/";
                }

                File.WriteAllText(Application.StartupPath + "\\ApplicationConfig.log", "");
                File.WriteAllText(Application.StartupPath + "\\ApplicationConfig.log", saveStr);
                if (!isFromLogin)
                    MessageBox.Show(@"تنظیمات با موفقیت ثبت شد", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"در خواندن فایل تنظیمات مشکلی بوجود آمده است", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}