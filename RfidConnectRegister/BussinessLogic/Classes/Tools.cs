using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    public class Tools
    {
        internal static class ExceptionLogger
        {
            internal static void WriteExceptionLogs(Exception ex)
            {
                var pc = new PersianCalendar();

                var fileName = pc.GetYear(DateTime.Now) + "-"
                                                        + pc.GetMonth(DateTime.Now).ToString().PadLeft(2, '0') + "-"
                                                        + pc.GetDayOfMonth(DateTime.Now).ToString().PadLeft(2, '0');
                if (!Directory.Exists(Application.StartupPath + "\\Exceptions"))
                    Directory.CreateDirectory(Application.StartupPath + "\\Exceptions");
                var filePath = Application.StartupPath + "\\Exceptions\\Exception" + fileName + ".log";

                using (var file = new StreamWriter(filePath, true))
                {
                    file.WriteLine("-------------------Exception Begin----------------------");
                    file.WriteLine("Exception Message: {0}", ex.Message);
                    file.WriteLine("Exception Base: {0}", ex.GetBaseException());
                    file.WriteLine("Exception Raise Time : {0} ",
                        DateTime.Now.ToShortTimeString());
                    file.WriteLine("-------------------Exception End----------------------");
                    file.WriteLine();
                }
            }

           

        }

        internal static void WriteLogs(string method, string log)
        {
            var pc = new PersianCalendar();

            var fileName = pc.GetYear(DateTime.Now) + "-"
                                                       + pc.GetMonth(DateTime.Now).ToString().PadLeft(2, '0') + "-"
                                                       + pc.GetDayOfMonth(DateTime.Now).ToString().PadLeft(2, '0');
            if (!Directory.Exists(Application.StartupPath + "\\Log"))
                Directory.CreateDirectory(Application.StartupPath + "\\Log");
            var filePath = Application.StartupPath + "\\Log\\Log" + fileName + ".log";

            using (var file = new StreamWriter(filePath, true))
            {
                file.WriteLine("-------------------Log Begin----------------------");
                file.WriteLine("Log from: {0}", method);
                file.WriteLine("Log Content: {0}", log);
                file.WriteLine("Log Raise Time : {0} ", DateTime.Now.ToShortTimeString());
                file.WriteLine("-------------------Log End------------------------");
                file.WriteLine();
            }
        }
    }
}
 