using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RfidConnectRegister.BussinessLogic
{
    internal static class Tools
    {
        internal static DataTable ConvertDatagridViewToDatatable(DataGridView dgv)
        {
            DataTable dtResult = new DataTable();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dtResult.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dtResult.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dtResult.Rows.Add(dRow);
            }
            return dtResult;
        }
        internal static void WriteExceptionLogs(Exception ex, SqlCommand command = null)
        {
            var pc = new PersianCalendar();

            var fileName = pc.GetYear(DateTime.Now) + "-"
                                                    + pc.GetMonth(DateTime.Now).ToString().PadLeft(2, '0') + "-"
                                                    + pc.GetDayOfMonth(DateTime.Now).ToString().PadLeft(2, '0');
            if (!Directory.Exists(Application.StartupPath + "\\Exception"))
                Directory.CreateDirectory(Application.StartupPath + "\\Exception");
            var filePath = Application.StartupPath + "\\Exception\\Exception" + fileName + ".log";
            using (var file = new StreamWriter(filePath, true))
            {
                file.WriteLine("-------------------Exception Begin----------------------");
                file.WriteLine("Exception Message: {0}", ex.Message);
                file.WriteLine("Exception Base: {0}", ex.GetBaseException());
                if (command != null)
                {
                    file.WriteLine("Query => Text:{0}", command.CommandText);
                    foreach (SqlParameter commandParameter in command.Parameters)
                        file.WriteLine("Query => Parameter:{0}-{1}", commandParameter.ParameterName, commandParameter.Value);
                }
                file.WriteLine("Exception Raise Time : {0} ",
                    DateTime.Now.ToShortTimeString());
                file.WriteLine("-------------------Exception End----------------------");
                file.WriteLine();
            }
        }



        internal static DataTable ConvertJSONToDataTable(JToken JSONData)
        {
             DataTable dtEmpShiftData = new DataTable();
            try
            {
                foreach(JToken jt in JSONData)
                {
                     

                }


              //  dtEmpShiftData = (DataTable)JsonConvert.DeserializeObject(JSONData, (typeof(DataTable)));

                return dtEmpShiftData;
            }
            catch (Exception ex)
            {
                //logger.Error(ex);
                return dtEmpShiftData;
            }
        }

        internal static string ReplaceAllEnglishAlphbet(string serial, string replace)
        {
            serial = serial.ToUpper().Replace("B", replace);
            serial = serial.ToUpper().Replace("A", replace);
            serial = serial.ToUpper().Replace("C", replace);
            serial = serial.ToUpper().Replace("D", replace);
            serial = serial.ToUpper().Replace("E", replace);
            serial = serial.ToUpper().Replace("F", replace);
            serial = serial.ToUpper().Replace("G", replace);
            serial = serial.ToUpper().Replace("H", replace);
            serial = serial.ToUpper().Replace("I", replace);
            serial = serial.ToUpper().Replace("J", replace);
            serial = serial.ToUpper().Replace("K", replace);
            serial = serial.ToUpper().Replace("L", replace);
            serial = serial.ToUpper().Replace("M", replace);
            serial = serial.ToUpper().Replace("N", replace);
            serial = serial.ToUpper().Replace("O", replace);
            serial = serial.ToUpper().Replace("A", replace);
            serial = serial.ToUpper().Replace("P", replace);
            serial = serial.ToUpper().Replace("Q", replace);
            serial = serial.ToUpper().Replace("R", replace);
            serial = serial.ToUpper().Replace("S", replace);
            serial = serial.ToUpper().Replace("T", replace);
            serial = serial.ToUpper().Replace("U", replace);
            serial = serial.ToUpper().Replace("V", replace);
            serial = serial.ToUpper().Replace("W", replace);
            serial = serial.ToUpper().Replace("X", replace);
            serial = serial.ToUpper().Replace("Y", replace);
            serial = serial.ToUpper().Replace("Z", replace);
            serial = serial.ToUpper().Replace(" ", replace);
            serial = serial.ToUpper().Replace(":", replace);
            serial = serial.ToUpper().Replace("-", replace);
            serial = serial.ToUpper().Replace("-", replace);
            serial = serial.ToUpper().Replace("/", replace);
            serial = serial.ToUpper().Replace(",", replace);

            return serial;
        }



        public static DataTable  JsonToObjects(JToken token)
        {
            DataTable Dt = new DataTable();

            int index = 0;
            List<object> rtn = new List<object>();

            foreach (JObject item in token)
            {
                if (index == 0)
                {

                    foreach (JProperty prop in item.Properties())
                {
                        string ColumnName = "";
                    switch( prop.Name)
                        {
                            case "fld_ProductPropertyATitle":
                                ColumnName = "خط تولید";
                                break;
                            case "RegCode":
                                ColumnName = "کد طرح";
                                break;
                            case "ProductName":
                                ColumnName = "عنوان کالا";
                                break;
                            case "fld_ProductPropertyCTitle":
                                ColumnName = "سایز";
                                break;
                            case "ProductType":
                                ColumnName = "عنوان طرح";
                                break;
                            default:
                                ColumnName = prop.Name;
                                break;

                        }
                        Dt.Columns.Add(ColumnName);
                    

 
                }

                }
                else
                {
                    break;
                }
                index++;
                
            }

             foreach (JObject item in token)
            {
                int index2 = 0;
                string[] Rows = new string[Dt.Columns.Count];
                foreach (JProperty prop in item.Properties())
                {
                    
                        Rows[index2] = (prop.Value.ToString() != "{}") ? prop.Value.ToString() : "0";
                    index2++;



                }
                Dt.Rows.Add(Rows);
            }

            return Dt;
        }
    }
}
