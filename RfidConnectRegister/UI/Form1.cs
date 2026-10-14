using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PrintLabelWithCutter();
            //return;

            LabelPrinter.ZMPrinter thiszmprinter = new LabelPrinter.ZMPrinter();//Printer Object
            LabelPrinter.ZMLabel thiszmlabel = new LabelPrinter.ZMLabel();//label object
            List<LabelPrinter.LabelObject> prints = new List<LabelPrinter.LabelObject>();//List of objects within the label

            #region Define printer
            thiszmprinter.printerinterface = LabelPrinter.PrinterStyle.RFID_USB;
            //thiszmprinter.printername = "RFID Printer";//Printer driver name, valid only when interface type is DRIVER or RFID_DRIVER
            //thiszmprinter.printernetip = "192.168.1.180";//The IP address of the printer, valid only when interface type is NET or RFID_NET
            thiszmprinter.printerdpi = 300;//Printer resolution
            thiszmprinter.printSpeed = 4;//Printing speed in IPS
            thiszmprinter.printDarkness = 10;//Print darkness, value range: 0-20
            thiszmprinter.labelhavegap = true;//Are there gaps, black markings, or holes in the labels.
            #endregion

            #region Define label
            thiszmlabel.labelwidth = 78;//The width of the label, in millimeters
            thiszmlabel.labelheight = 48;//The height of the label, in millimeters
            thiszmlabel.labelrowgap = 2;//The row gap of the label, in millimeters
            #endregion

            #region Define objects in label
            LabelPrinter.LabelObject textobject01 = new LabelPrinter.LabelObject();
            textobject01.ObjectName = "text-01";// Declare that the object is text.
            textobject01.objectdata = " This is paragraph text, containing some characters. ";// Content of text
            textobject01.Xposition = 25.1f;// X coordinate of the starting point of the text, in mm
            textobject01.Yposition = 35.5f;// Y coordinate of the starting point of the text, in mm
            textobject01.texttextalign = 0;// 0 is left aligned, 1 is centered, and 2 is right aligned
            textobject01.texttextvalign = 0;// 0 for top edge alignment, 1 for vertical center, and 2 for bottom edge alignment
            textobject01.texttype = 1; //Text type, 0 is single line text, 1 is paragraph text, and 2 is circular wrapped text
            textobject01.textwidth = 50f;// The width of the paragraph text, in millimeters
            textobject01.textwidthbeyound = 0;// After exceeding the width of the paragraph text, 0 is for automatic line wrapping, 1 is for automatic flattening of the font, and 2 is for automatic font reduction
            textobject01.textfont = "Arial";// Font of text
            textobject01.fontstyle = 1;// 0 regular, 1 bold
            textobject01.fontsize = 8;// Font size
            prints.Add(textobject01);// Add a text object to the object list

            LabelPrinter.LabelObject textobject02 = new LabelPrinter.LabelObject();
            textobject02.ObjectName = "text-02";// Declare that the object is text.
            textobject02.objectdata = " This is a single line text. ";//文字
            textobject02.Xposition = 5;// X coordinate of the starting point of the text, in mm
            textobject02.Yposition = 6;// Y coordinate of the starting point of the text, in mm
            textobject02.textfont = " Arial ";// Font of text
            textobject02.fontstyle = 0;// 0 regular, 1 bold
            textobject02.fontsize = 10;// Font size
            prints.Add(textobject02);// Add a text object to the object list

            LabelPrinter.LabelObject shape01 = new LabelPrinter.LabelObject();
            shape01.ObjectName = "rectangle-01";// Declare that the object is a rectangle.
            shape01.objectclass = 2;// The category of objects, 1 is a straight line and 2 is a rectangle
            shape01.startXposition = 24f;// The X-coordinate of the starting point, in millimeters
            shape01.startYposition = 25f;// The Y-coordinate of the starting point, in millimeters
            shape01.endXposition = 76f;// The X-coordinate of the termination point, in millimeters
            shape01.endYposition = 45f;// The Y-coordinate of the termination point, in millimeters
            shape01.lineWidth = 0.4f;// The width of the line, in millimeters
            prints.Add(shape01); // Add a rectangle object to the object list

            LabelPrinter.LabelObject barcodeobject01 = new LabelPrinter.LabelObject();
            barcodeobject01.ObjectName = "barcode-01";// The object is a barcode
            barcodeobject01.objectdata = "12345678";// Content of barcode
            barcodeobject01.Xposition = 25;// X coordinate of the starting point of the text, in mm
            barcodeobject01.Yposition = 12;// Y coordinate of the starting point of the text, in mm
            barcodeobject01.barcodekind = "Code 128 Auto";// Type of barcode: Code 128 Auto,Code 128 A,Code 128 B,Code 128 C,EAN-13,QR Code(2D),PDF 417(2D),Code 39,Data Matrix(2D)
            barcodeobject01.barcodescale = 3;// Horizontal scaling coefficient of barcode, value range: 1-99, the larger the number, the wider the barcode
            barcodeobject01.barcodeheight = 5;// Barcode height in mm
            prints.Add(barcodeobject01);// Add barcode objects to the object list

            LabelPrinter.LabelObject rfidobject01 = new LabelPrinter.LabelObject();
            rfidobject01.ObjectName = "rfiduhf-01";// The object is written using RFID
            rfidobject01.objectdata = "12345678";// The content that needs to be written in RFID is recommended to be a multiple of 8 in length.
            rfidobject01.RFIDDatablock = 0;// Write area, 0 is EPC, 1 is USER
            rfidobject01.RFIDDatatype = 1;// Data type: 0 is text, 1 is hexadecimal
            rfidobject01.RFIDerrortimes = 1;// Error retry count
            prints.Add(rfidobject01);// Add RFID object to object list
            #endregion

            #region Label preview
            Bitmap previewimage = new LabelPrinter.PrintUtility().GetLabelImage(thiszmprinter, thiszmlabel, prints, 0);//Generate preview image
            //previewimage.Save("c:\\test.png", System.Drawing.Imaging.ImageFormat.Png);
            if (previewimage != null)
                pictureBox1.Image = previewimage;
            #endregion

            #region print label
            string returnmsg = new LabelPrinter.PrintUtility().PrintLabel(thiszmprinter, thiszmlabel, prints, true, true);
            if (returnmsg.StartsWith("Error:"))
                MessageBox.Show(returnmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion
        }

      

        /// <summary>
        /// Check printer status including cutter detection
        /// </summary>
        private int GetPrinterStatus(LabelPrinter.ZMPrinter thiszmprinter)
        {
            string errormsg = "";
            int printerstatuscode = new LabelPrinter.PrintUtility().getPrinterStatusCode(thiszmprinter);

            if (printerstatuscode != 0)
            {
                if (printerstatuscode == 86)
                {
                    errormsg = "The printer's cutter detection error has occurred. Please check if the cutter function is enabled.";
                }
                else if (printerstatuscode == 96)
                {
                    errormsg = "The paper stripper is waiting to remove the label.";
                }
                else if (printerstatuscode == 88)
                {
                    errormsg = "The printer is currently in a paused state. Pressing the \"Pause\" button on the printer will restart printing.";
                }
                else if (printerstatuscode == 81)
                {
                    errormsg = "Motherboard hardware malfunction, please contact after-sales service for repair.";
                }
                else if (printerstatuscode == 82)
                {
                    errormsg = "The printer's carbon belt detection error has occurred. Please check if the carbon belt is installed properly.";
                }
                else if (printerstatuscode == 83)
                {
                    errormsg = "The label detection error of the printer has occurred. Please check if the label is installed properly. It is recommended to perform a paper calibration operation.";
                }
                else if (printerstatuscode == 89)
                {
                    errormsg = "We have run out of label paper. Please install a new label.";
                }
                else if (printerstatuscode == 90)
                {
                    errormsg = "RFID tag read or write error.";
                }
                else if (printerstatuscode == 91 || printerstatuscode == 92)
                {
                    errormsg = "RFID tag signal calibration failed.";
                }
                else if (printerstatuscode == 99 || printerstatuscode == 120)
                {
                    errormsg = "The printer has completed the upgrade. Please follow the upgrade tool prompts.";
                }
                else if (printerstatuscode == 1)
                {
                    errormsg = "The printer has received incorrect instructions. Please check the format of the sent instructions and restart the printer.";
                }
                else
                {
                    errormsg = "Printer error, error code:" + printerstatuscode.ToString();
                }

                MessageBox.Show(errormsg, "Printer Status Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return printerstatuscode;
        }

    }
}
