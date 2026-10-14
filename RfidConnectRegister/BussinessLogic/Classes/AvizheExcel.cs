using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    public class AvizheExcel
    {
        public DataSet GetDataFroExcel(string filePath, string sheetName)
        {
            try
            {
                var connectionString =
                    string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;",
                        filePath);
                var adapter = new OleDbDataAdapter("SELECT * FROM [" + sheetName + "$]", connectionString);
                var ds = new DataSet();
                adapter.Fill(ds, sheetName);
                return ds;
            }
            catch (OleDbException ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"فایل مورد نظر در فرمت درست نیست", @"خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"در انجام عملیات مشکلی بوجود آمده است", @"خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
