using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using PdfSharp.Pdf.Content.Objects;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.BussinessLogic.RfidConnectApi;

namespace RfidConnectRegister.UI
{
    public partial class FormSetting : Form
    {
        // 0=> com - 1=> Ethernet - 2=> Usb
        private readonly List<ComboBox> _selectedComsCombo;
        public Dictionary<string, string> DevicePairComsDictionary;

        public FormSetting()
        {
            InitializeComponent();

            _selectedComsCombo = new List<ComboBox>();
            DevicePairComsDictionary = new Dictionary<string, string>();
        }

        private void formSetting_Load(object sender, EventArgs e)
        {
            

            FillComboboxInstalledPrinter();

            if (!Properties.Settings.Default.ServerIP.Equals(string.Empty))
            {
                FillModelComboBox();
            }

            LoadInformations();
            GetReportFiles();
            Text = @"تنظیمات - " + Properties.Settings.Default.PrintPaperType;
        }

        /// <summary>
        /// Get all report files in report folder
        /// </summary>
        private void GetReportFiles()
        {
            try
            {
                var info = new DirectoryInfo(Application.StartupPath + "\\reports");
                var reportFiles = info.GetFiles();
                foreach (var file in reportFiles)
                {
                    dgvShowReportFiles.Rows.Add(Properties.Settings.Default.ReportFileName == file.Name, file.Name, file.Extension);
                }
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
            }
        }

        /// <summary>
        /// set all informations of applicationconfig.txt file in form
        /// </summary>
        private void LoadInformations()
        {
            try
            {
                if (Properties.Settings.Default.ServerIP != "")
                {
                    if (GetSettingDictionary.DicSetting.ContainsKey("BarcodeType"))
                    {
                        switch (Properties.Settings.Default.BarcodeType)
                        {
                            case "Id":
                                rbnBarCodeProductId.Checked = true;
                                break;
                            case "Code":
                                rbnBarCodeProductCode.Checked = true;
                                break;
                            case "Serial":
                                rbnBarCodeProductSerial.Checked = true;
                                break;
                        }
                    }

                    if (GetSettingDictionary.DicSetting.ContainsKey(ConfigKeys.PrinterModel))
                        cmbInstalledPrinter.SelectedIndex = Properties.Settings.Default.PrinterModel != string.Empty ? cmbInstalledPrinter.Items.IndexOf(Properties.Settings.Default.PrinterModel) : -1;

                    if (GetSettingDictionary.DicSetting.ContainsKey(ConfigKeys.PrinterInOperation))
                        chbPrinterInOperation.Checked = 
                                                        Properties.Settings.Default.PrinterInOperation == true;

                    if (GetSettingDictionary.DicSetting.ContainsKey(ConfigKeys.ShowSaveDialog))
                        rbnShowSaveDialog.Checked =   Properties.Settings.Default.ShowSaveDialog == true ;


                    

                    txtReaderPort.Text = Properties.Settings.Default.PortNumber.ToString();
                    txtReaderPower.Text = Properties.Settings.Default.ReaderPower.ToString();
                    txtIgnoreEpcList.Text= Properties.Settings.Default.IgnoreEpcList  ;


                    cmbKindRegister.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.KindRegister);
                    chbMergPrintToPDF.Checked = (Properties.Settings.Default.MergPrintToPDF == "1") ? true : false;
                    chbControlPrintFormatByBrand.Checked = (Properties.Settings.Default.ControlPrintFormatByBrand == "1") ? true : false;
                    chbAutoDetecteShift.Checked = (Properties.Settings.Default.AutoDetecteShift == "1") ? true : false;
                    chbGetListSerial.Checked = (Properties.Settings.Default.GetListSerial == "1") ? true : false;
                    chbAllowShowOnlyPrintFormBeforeSavePrintAction.Checked = Properties.Settings.Default.AllowShowOnlyPrintFormBeforeSavePrintAction;
                    chbRegisterCountEvryTimeIsOne.Checked = Properties.Settings.Default.RegisterCountEvryTimeIsOne;
                    chbPrintPreviewBeforePrint.Checked = Properties.Settings.Default.PrintPreviewBeforePrint;
                    chbActiveRegisterFormByOneSerial.Checked = Properties.Settings.Default.ActiveRegisterFormByOneSerial;
                    chbSetParentForSerials.Checked = Properties.Settings.Default.SetParentForSerials;
                    Properties.Settings.Default.ControlPrintFormatByBrand = (chbControlPrintFormatByBrand.Checked) ? "1" : "0";


                    txtSerialLength.Text = Properties.Settings.Default.SerialLength.ToString();

                    txtBarcodeLength1.Text = Properties.Settings.Default.BarcodeLength1;
                    txtBarcodeLength2.Text = Properties.Settings.Default.BarcodeLength2;
                    txtServerIp.Text = Properties.Settings.Default.ServerIP;
                    cmbDeviceModel.SelectedIndex = Properties.Settings.Default.TableModel != string.Empty
                        ? Convert.ToInt32(Properties.Settings.Default.TableModel.ToString())
                        : -1;
                    txtBarcodeIndex.Text = Properties.Settings.Default.BarcodeIndex.ToString();
                    txtDataSpliter.Text = Properties.Settings.Default.BarcodeSpliter;
                    txtCompanyName.Text = Properties.Settings.Default.CompanyName;
                    var index = 0;
                    foreach (string itemName in cmbKindPrint.Items)
                    {
                        if (itemName == Properties.Settings.Default.PrintPaperType)
                            break;
                        index++;
                    }

                    if (index == cmbKindPrint.Items.Count)
                        index = -1;
                    cmbKindPrint.SelectedIndex = index;

                    chbLogin.Checked = Properties.Settings.Default.HaveLogin ;
                    chbNotifApp.Checked = Properties.Settings.Default.NotifApp ;
                }
                else
                {

                   

                }

                chbZpl.Checked = Properties.Settings.Default.IsZpl;
            }
            catch (Exception e)
            {
               
                Tools.ExceptionLogger.WriteExceptionLogs(e);
            }
        }

        /// <summary>
        /// get all active printer devices and fill combo box 
        /// </summary>
        private void FillComboboxInstalledPrinter()
        {
            try
            {
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    cmbInstalledPrinter.Items.Add(printer);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Tools.ExceptionLogger.WriteExceptionLogs(e);
            }
        }


        /// <summary>
        /// get all setted informations from form and change to text and save in applicationconfig.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.IgnoreEpcList = txtIgnoreEpcList.Text;

                
                Properties.Settings.Default.SerialLength = Convert.ToInt32(txtSerialLength.Text);
                Properties.Settings.Default.SerialLength = (txtSerialLength.Text != "") ? Convert.ToInt32(txtSerialLength.Text) : 5;
               
                Properties.Settings.Default.KindRegister = cmbKindRegister.SelectedIndex.ToString();
                Properties.Settings.Default.KindRegister = cmbKindRegister.SelectedIndex.ToString();


                Properties.Settings.Default.MergPrintToPDF =(chbMergPrintToPDF.Checked) ? "1" : "0";
                Properties.Settings.Default.MergPrintToPDF = (chbMergPrintToPDF.Checked) ? "1" : "0";


                Properties.Settings.Default.ControlPrintFormatByBrand = (chbControlPrintFormatByBrand.Checked) ? "1" : "0";
                Properties.Settings.Default.ControlPrintFormatByBrand = (chbControlPrintFormatByBrand.Checked) ? "1" : "0";

                Properties.Settings.Default.AutoDetecteShift = (chbAutoDetecteShift.Checked) ? "1" : "0";
                Properties.Settings.Default.AutoDetecteShift = (chbAutoDetecteShift.Checked) ? "1" : "0";


                Properties.Settings.Default.SetParentForSerials = chbSetParentForSerials.Checked;
                Properties.Settings.Default.GetListSerial = (chbGetListSerial.Checked) ? "1" : "0";
                Properties.Settings.Default.AllowShowOnlyPrintFormBeforeSavePrintAction = chbAllowShowOnlyPrintFormBeforeSavePrintAction.Checked;
                Properties.Settings.Default.RegisterCountEvryTimeIsOne = chbRegisterCountEvryTimeIsOne.Checked;
                Properties.Settings.Default.PrintPreviewBeforePrint = chbPrintPreviewBeforePrint.Checked;
                Properties.Settings.Default.ActiveRegisterFormByOneSerial = chbActiveRegisterFormByOneSerial.Checked;

                

                Properties.Settings.Default.DeskUHFReader_Port = txtReaderPort.Text;
                Properties.Settings.Default.PortNumber = txtReaderPort.Text;
 
                Properties.Settings.Default.ReaderPower = (txtReaderPower.Text != "") ? Convert.ToInt32(txtReaderPower.Text) : 10;


                Properties.Settings.Default.TableModel =   cmbDeviceModel.SelectedIndex.ToString();
                Properties.Settings.Default.DeskReaderType = cmbDeviceModel.SelectedIndex;


                if (txtDataSpliter.Text == string.Empty)
                {
                    MessageBox.Show(@"جداکننده ی بارکد را مشخص کنید", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Properties.Settings.Default.BarcodeSpliter = txtDataSpliter.Text;
                Properties.Settings.Default.BarcodeSpliter = txtDataSpliter.Text;

                Properties.Settings.Default.IsZpl = chbZpl.Checked;

                if (txtBarcodeIndex.Text == string.Empty)
                {
                    MessageBox.Show(@"ایندکس را مشخص کنید", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int temp;
                if (int.TryParse(txtBarcodeIndex.Text, out temp))
                {
                    if (temp <= -1)
                    {
                        MessageBox.Show(@"ایندکس نمی تواند از صفر کوچکتر باشد", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
 
                    Properties.Settings.Default.BarcodeIndex = temp;

                }
                else
                {
                    MessageBox.Show(@"لطفا در ورود ایندکس فقط از اعداد استفاده کنید", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (pnlComsSetting.Controls.Count != 0)
                {
                    var comString = string.Empty;
                    foreach (Control item in pnlComsSetting.Controls)
                    {
                        if (item is ComboBox)
                        {
                            comString += item.Name.Substring(3, item.Name.Length - 3) + ":" + (item as ComboBox).SelectedItem;
                        }
                    }

 
                    Properties.Settings.Default.PortNumber = comString;

                }

                 Properties.Settings.Default.ServerIP = txtServerIp.Text; ;

                // TODO: Change name of int1,2
                int int1;
                int int2;
                if (txtBarcodeLength1.Text != string.Empty | int.TryParse(txtBarcodeLength1.Text, out int1))
                {
                    Properties.Settings.Default.BarcodeLength1 = int1.ToString();
                    Properties.Settings.Default.BarcodeLength1 = int1.ToString();

                }
                else
                {
                    Properties.Settings.Default.BarcodeLength1 = "0";
                    Properties.Settings.Default.BarcodeLength1 = "0";

                }

                if (txtBarcodeLength2.Text != string.Empty | int.TryParse(txtBarcodeLength1.Text, out int2))
                {
                    Properties.Settings.Default.BarcodeLength2 = int2.ToString();
                    Properties.Settings.Default.BarcodeLength2 = int2.ToString();

                }
                else
                {
                    Properties.Settings.Default.BarcodeLength2 = "0";
                    Properties.Settings.Default.BarcodeLength2 =   "0";

                }

 
                Properties.Settings.Default.ShowSaveDialog = rbnShowSaveDialog.Checked ?  true  :  false ;

                Properties.Settings.Default.PrinterModel = cmbInstalledPrinter.SelectedIndex != -1 ? cmbInstalledPrinter.SelectedItem.ToString() : string.Empty;
                Properties.Settings.Default.PrinterModel = cmbInstalledPrinter.SelectedIndex != -1 ? cmbInstalledPrinter.SelectedItem.ToString() : string.Empty;

 
                Properties.Settings.Default.PrinterInOperation = chbPrinterInOperation.Checked ?  true  :  false ;

                Properties.Settings.Default.BarcodeSpliter = txtDataSpliter.Text;
                Properties.Settings.Default.BarcodeSpliter = txtDataSpliter.Text;

 
                Properties.Settings.Default.BarcodeIndex = int.Parse(txtBarcodeIndex.Text) ;

                foreach (Control control in pnlComsSetting.Controls)
                {
                    //if (control is TextBox)
                    //{
                    //    if (int.TryParse((control as TextBox).Text, out temp))
                    //    {
                    //        Properties.Settings.Default.ReaderPower = temp.ToString();
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show(@"ورودی قدرت دستگاه معتبر نیست");
                    //        return;
                    //    }
                    //}
                }

                Properties.Settings.Default.CompanyName = txtCompanyName.Text;
                Properties.Settings.Default.CompanyName = txtCompanyName.Text;

                Properties.Settings.Default.ReportFileName = GetReportFileName();
                Properties.Settings.Default.ReportFileName = GetReportFileName();



                if (rbnBarCodeProductId.Checked)
                    Properties.Settings.Default.BarcodeType = "Id";
                else if (rbnBarCodeProductCode.Checked)
                    Properties.Settings.Default.BarcodeType = "Code";
                else if (rbnBarCodeProductSerial.Checked)
                    Properties.Settings.Default.BarcodeType = "Serial";

                Properties.Settings.Default.BarcodeType = Properties.Settings.Default.BarcodeType;


                var saveStr = string.Empty;
                foreach (var item in GetSettingDictionary.DicSetting.Keys)
                {
                    if (item != string.Empty && GetSettingDictionary.DicSetting[item] != string.Empty)
                        saveStr += item + "=" + GetSettingDictionary.DicSetting[item] + "/";
                }

                Properties.Settings.Default.HaveLogin = chbLogin.Checked ;



                Properties.Settings.Default.NotifApp = chbNotifApp.Checked;


 
                Properties.Settings.Default.PrintPaperType = cmbKindPrint.Text;

                GetSettingDictionary.SaveSettingInFile();
                Properties.Settings.Default.Save();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                MessageBox.Show(@"در انجام عملیات مشکلی بوجود آمده است", @"توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// get name of choosed report file 
        /// </summary>
        /// <returns></returns>
        private string GetReportFileName()
        {
            try
            {
                var file = string.Empty;
                foreach (DataGridViewRow row in dgvShowReportFiles.Rows)
                {
                    if ((bool) row.Cells[0].Value)
                    {
                        file += row.Cells[1].Value.ToString();
                        break;
                    }
                }

                return file;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                return string.Empty;
            }
        }


        /// <summary>
        /// get device models from API and fill combo box           
        /// </summary>
        private void FillModelComboBox()
        {
            try
            {
                //var restApi = new RestApi();
                //var result = restApi.GetModelNames();
                //foreach (var jToken in result["Value")
                //{
                //    var item = (JObject) jToken;
                //    cmbDeviceModel.Items.Add(item["ModelName");
                //}
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void cmbDeviceModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var coms = new GetComPort();
                //var temp = coms.GetComPortsInfo();
                //var restApi = new RestApi();
                //var result = restApi.GetModelDevices(cmbDeviceModel.Items[cmbDeviceModel.SelectedIndex.ToString());
                //var list = result["Value".Cast<JObject>().ToDictionary(item => item["ModelDeviceName".ToString(), item => item["ModelDeviceCount".ToString());
                //if (list.ContainsKey("6061"))
                //{
                //    pnlComsSetting.Controls.Clear();
                //    for (var i = 0; i < list["6061".Length; i++)
                //    {
                //        var labelDeviceModel = new Label
                //        {
                //            Name = "lblDevice" + i,
                //            Text = @"دستگاه" + @"6061",
                //            TextAlign = ContentAlignment.MiddleRight,
                //            Anchor = AnchorStyles.Right,
                //            Font = new Font("IRANSans(FaNum)", 9, FontStyle.Bold),
                //            Width = 100,
                //            BackColor = Color.BurlyWood,
                //            Location = pnlComsSetting.Controls.Count != 0 ? new Point(400, pnlComsSetting.Controls[pnlComsSetting.Controls.Count - 1.Location.Y + pnlComsSetting.Controls[pnlComsSetting.Controls.Count - 1.Height + 10) : new Point(400, 10)
                //        };
                //        pnlComsSetting.Controls.Add(labelDeviceModel);
                //        var combo = new ComboBox
                //        {
                //            Name = "cmbDevice" + i,
                //            Font = new Font("IRANSans(FaNum)", 9, FontStyle.Bold),
                //            Location = i != 0
                //                ? new Point(250, pnlComsSetting.Controls["lblDevice " + i.Location.Y)
                //                : new Point(250, 10)
                //        };

                //        _selectedComsCombo.Add(combo);
                //        temp.ForEach(item => combo.Items.Add(item.Name));
                //        combo.SelectedIndexChanged += ComboBoxSelectChange;
                //        combo.DropDownStyle = ComboBoxStyle.DropDownList;
                //        combo.SelectedIndex = GetIndexOfItem(Properties.Settings.Default.ComPairDevice.Split(':')[1, combo);
                //        pnlComsSetting.Controls.Add(combo);
                //        var textBox = new TextBox
                //        {
                //            Name = "txtDevicePower" + i,
                //            Font = new Font("IRANSans(FaNum)", 9, FontStyle.Bold),
                //            Text = @"قدرت دستگاه",
                //            Location = i != 0
                //                ? new Point(100, pnlComsSetting.Controls["lblDevice" + i.Location.Y)
                //                : new Point(100, 10)
                //        };
                //        textBox.TextChanged += TextBox_TextChange;
                //        textBox.Leave += TextBox_Leave;
                //        textBox.Enter += TextBox_Enter;
                //        textBox.Text = Properties.Settings.Default.ReaderPower;
                //        pnlComsSetting.Controls.Add(textBox);
                //    }
                //}
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        /// <summary>
        /// get index of specified item from specified combo box 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="combo"></param>
        /// <returns></returns>
        private static int GetIndexOfItem(string item, ComboBox combo)
        {
            try
            {
                for (var i = 0; i < combo.Items.Count; i++)
                {
                    if (combo.Items[i].ToString() == item)
                    {
                        return i;
                    }
                }

                return -1;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                return -1;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                var textBox = (TextBox) sender;
                if (textBox.Text == string.Empty)
                {
                    textBox.Text = @"قدرت دستگاه";
                }
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                var textBox = (TextBox) sender;
                if (textBox.Text == @"قدرت دستگاه")
                {
                    textBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void TextBox_TextChange(object sender, EventArgs e)
        {
            try
            {
                var textBox = (TextBox) sender;
                int power;
                if (!int.TryParse(textBox.Text, out power))
                {
                    textBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void ComboBoxSelectChange(object sender, EventArgs e)
        {
            try
            {
                var combo = (ComboBox) sender;
                foreach (ComboBox item in _selectedComsCombo)
                    if (item.Name != combo.Name)
                        if (item.SelectedIndex == combo.SelectedIndex)
                            combo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void dgvShowReportFiles_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;
                if (e.ColumnIndex != 0)
                    return;
                foreach (DataGridViewRow row in dgvShowReportFiles.Rows)
                    row.Cells[0].Value = false;
                dgvShowReportFiles.Rows[e.RowIndex].Cells[0].Value =
                    !(bool) dgvShowReportFiles.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
        }

        private void FormSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString().ToLower() == "s")
                btnSave_Click(sender, e);
        }
    }
}
