using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.BussinessLogic
{
    public static class SmsRequest
    {

        public static Boolean SendSmsRequest( string MessageText, int SMSKind)
        {
            string ToMember = "";
            switch(SMSKind)
            { case 1:
                    ToMember = "09368205592 , 09365671561 , 09121468390 ,09121171050,09122565677,09121110035,09195043250,09144441803,09131522262,09124617160"; 
                    break;
                case 2:
                    ToMember = "09368205592 , 09365671561 , 09121468390 ,09121171050,09122565677,09121110035,09195043250,09144441803,09131522262";
                    break;
                case 3:
                    ToMember = "09368205592 , 09365671561 , 09121468390 ,09121171050,09122565677,09121110035,09195043250,09144441803,09131522262";
                    break;
                case 4:
                    ToMember = "09368205592 , 09365671561 , 09121468390 ,09121171050,09122565677,09121110035,09195043250,09144441803,09131522262";
                    break;
            } 
 
            Boolean flag = false;
            string username = "Rokaceram";// Properties.Settings.Default.SmsUserName;
            string password = "Rfid@roka4000";// Properties.Settings.Default.SmsPassword;
            string from = "+983000505";// Properties.Settings.Default.SmsNumber1;
            string PanelType = "IPPanel";//Properties.Settings.Default.PanelType;
            string api_key = "Ehpcmavm1g669k58TDEeOsZjhpkwWFVD1ylvShdorJM=	";// Properties.Settings.Default.api_key;


           

            
                string cmd = "panel_type=" + PanelType + "&username=" + username + "&password=" + password + "&api_key=" + api_key + "&from=" + from + "&to=" + ToMember + "&text= " + MessageText;
            //string cmd = "panel_type=razpayamak&username=raz200133&password=0133&api_key=DAFB389B-08CF-44CB-AAC3-ABBC13A1E48A&from=10002569565478&to=9102197167&text=testavizhe0";

            SendSmsRequestToAvizhePanel(cmd, ToMember, MessageText);
                
             


            


            return flag;
        }

          static Boolean SendSmsRequestToAvizhePanel(string Command, string To, string Text)
        {
            Boolean flagResult = false;

            try
            {
                var request =
                (HttpWebRequest)WebRequest.Create("https://avizhegroup.com/sms/SendSms.php");

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                var byteArray = Encoding.UTF8.GetBytes(Command);

                //textBox1.Text = "Get bytes of request";
                request.ContentLength = byteArray.Length;
                var dataStream = Stream.Null;
                try
                {
                    dataStream = request.GetRequestStream();
                }
                catch
                {
                    dataStream = request.GetRequestStream();
                }
                finally
                {
                    if (dataStream == Stream.Null)
                        dataStream = request.GetRequestStream();
                }
                //textBox1.Text += "request send";
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response;
                try
                {

                    response = request.GetResponse();
                }
                catch
                {
                    response = request.GetResponse();
                }
                //textBox1.Text += "getting response";

                try
                {
                    dataStream = response.GetResponseStream();
                }
                catch
                {
                    dataStream = response.GetResponseStream();
                }

                var streamReader = new StreamReader(dataStream);
                var result = streamReader.ReadToEnd();
                streamReader.Close();
                flagResult = true;

            }
            catch (Exception ex)
            {


            }

            return flagResult;
        }

    }
}
