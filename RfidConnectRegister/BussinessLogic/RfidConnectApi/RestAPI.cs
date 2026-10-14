 using System.IO;
using System.Net;
using System.Text;
 using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RfidConnectRegister.BussinessLogic.RfidConnectApi
{
    public class RestApi
    {
        private static string _urlString = string.Empty;

        private const int BufferSize = 4096;
        public static string Ip = string.Empty;

        public RestApi()
        {
            _urlString = string.Format("http://{0}/RfidConnectApi/RfidConnectApiHandler.ashx", Ip);
        }

        private static string Load(string contents)
        {
            _urlString = "http://" + Ip + "/RfidConnectApi/RfidConnectApiHandler.ashx";
            var req = (HttpWebRequest) WebRequest.Create(_urlString);
            req.AllowWriteStreamBuffering = true;
            req.Method = "POST";
            req.Timeout = 60000;
            var outStream = req.GetRequestStream();
            var outStreamWriter = new StreamWriter(outStream);
            outStreamWriter.Write(contents);
            outStreamWriter.Flush();
            outStream.Close();
            var res = req.GetResponse();
            var httpStream = res.GetResponseStream();
            var memoryStream = new MemoryStream();
            try
            {
                var buff = new byte[BufferSize];
                if (httpStream != null)
                {
                    var readedBytes = httpStream.Read(buff, 0, buff.Length);
                    while (readedBytes > 0)
                    {
                        memoryStream.Write(buff, 0, readedBytes);
                        readedBytes = httpStream.Read(buff, 0, buff.Length);
                    }
                }
            }
            finally
            {
                if (httpStream != null)
                {
                    httpStream.Close();
                }

                if (memoryStream != null)
                {
                    memoryStream.Close();
                }
            }

            var data = memoryStream.ToArray();
            var result = Encoding.UTF8.GetString(data, 0, data.Length);
            return result;
        }

        public JObject Receipt(string receiptId, string username)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "Receipt";
            p["receiptId"] = JToken.FromObject(receiptId);
            p["username"] = JToken.FromObject(username);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject PrintDelete(string productSerial)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "PrintDelete";
            p["productSerial"] = JToken.FromObject(productSerial);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject PrintSelectData(string commandText)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "PrintSelectData";
            p["commandText"] = JToken.FromObject(commandText);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject PrintUpdatePrintStatus(string productSerial)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "PrintUpdatePrintStatus";
            p["productSerial"] = JToken.FromObject(productSerial);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject PrintInsertUpdate(string productDescription, string productCode, string productSerial, string productCount, string projectCode, string inputFileName)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "PrintInsertUpdate";
            p["productDescription"] = JToken.FromObject(productDescription);
            p["productCode"] = JToken.FromObject(productCode);
            p["productSerial"] = JToken.FromObject(productSerial);
            p["productCount"] = JToken.FromObject(productCount);
            p["projectCode"] = JToken.FromObject(projectCode);
            p["inputFileName"] = JToken.FromObject(inputFileName);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject GetModelDevices(string modelName)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "GetModelDevices";
            p["modelName"] = JToken.FromObject(modelName);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject GetModelNames()
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "GetModelNames";
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject Login(string username, string password, string deviceIp, string deviceId)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "Login";
            p["username"] = JToken.FromObject(username);
            p["password"] = JToken.FromObject(password);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            p["deviceId"] = JToken.FromObject(deviceId);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject GetProductInfo(string tagEpc)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "GetProductInfo";
            p["tagEpc"] = JToken.FromObject(tagEpc);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject ReadedTags(int gateNumber, string fromDateTime, bool selected, bool lastTag)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "ReadedTags";
            p["gateNumber"] = JToken.FromObject(gateNumber);
            p["fromDateTime"] = JToken.FromObject(fromDateTime);
            p["selected"] = JToken.FromObject(selected);
            p["lastTag"] = JToken.FromObject(lastTag);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject Receipt(string receiptId, string storeHouseCode, object dtProducts)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "Receipt";
            p["receiptId"] = JToken.FromObject(receiptId);
            p["storeHouseCode"] = JToken.FromObject(storeHouseCode);
            p["dtProducts"] = JToken.FromObject(dtProducts);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject GetShamsiUnixDateTime()
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "GetShamsiUnixDateTime";
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject SaveReadedTag(string tagEpc, string readerIp, string readerGate)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "SaveReadedTag";
            p["tagEpc"] = JToken.FromObject(tagEpc);
            p["readerIp"] = JToken.FromObject(readerIp);
            p["readerGate"] = JToken.FromObject(readerGate);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject ASsignPipeToCoupling(string pipeSerial, string pipeEpc, string couplingSerial,
            string couplingEpc, string userReister, string deviceId, string deviceIp)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "ASsignPipeToCoupling";
            p["pipeSerial"] = JToken.FromObject(pipeSerial);
            p["pipeEpc"] = JToken.FromObject(pipeEpc);
            p["couplingSerial"] = JToken.FromObject(couplingSerial);
            p["couplingEpc"] = JToken.FromObject(couplingEpc);
            p["userReister"] = JToken.FromObject(userReister);
            p["deviceId"] = JToken.FromObject(deviceId);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject Reka(string couplingSerial, string status, string pressure, string user, string deviceId,
            string deviceIp)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "Reka";
            p["couplingSerial"] = JToken.FromObject(couplingSerial);
            p["status"] = JToken.FromObject(status);
            p["pressure"] = JToken.FromObject(pressure);
            p["user"] = JToken.FromObject(user);
            p["deviceId"] = JToken.FromObject(deviceId);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject CheckingPipe(string pipeSerial, string status, string meter, string externalDiameter,
            string innerDiameter, string od, string thickness, string user, string deviceId, string deviceIp)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "CheckingPipe";
            p["pipeSerial"] = JToken.FromObject(pipeSerial);
            p["status"] = JToken.FromObject(status);
            p["meter"] = JToken.FromObject(meter);
            p["externalDiameter"] = JToken.FromObject(externalDiameter);
            p["innerDiameter"] = JToken.FromObject(innerDiameter);
            p["od"] = JToken.FromObject(od);
            p["thickness"] = JToken.FromObject(thickness);
            p["user"] = JToken.FromObject(user);
            p["deviceId"] = JToken.FromObject(deviceId);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject CheckingPipeWithCoupling(string pipeSerial, string couplingSerial, string status, string meter,
            string externalDiameter, string innerDiameter, string od, string thickness, string user, string deviceId,
            string deviceIp)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "CheckingPipeWithCoupling";
            p["pipeSerial"] = JToken.FromObject(pipeSerial);
            p["couplingSerial"] = JToken.FromObject(couplingSerial);
            p["status"] = JToken.FromObject(status);
            p["meter"] = JToken.FromObject(meter);
            p["externalDiameter"] = JToken.FromObject(externalDiameter);
            p["innerDiameter"] = JToken.FromObject(innerDiameter);
            p["od"] = JToken.FromObject(od);
            p["thickness"] = JToken.FromObject(thickness);
            p["user"] = JToken.FromObject(user);
            p["deviceId"] = JToken.FromObject(deviceId);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject AssignRfidTagToProduct(int printId, int barcodeType, string productSerial, string tagEpc, string username, string deviceIp, string deviceId)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "AssignRfidTagToProduct";
            p["printId"] = JToken.FromObject(printId);
            p["barcodeType"] = JToken.FromObject(barcodeType);
            p["productSerial"] = JToken.FromObject(productSerial);
            p["tagEpc"] = JToken.FromObject(tagEpc);
            p["username"] = JToken.FromObject(username);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            p["deviceId"] = JToken.FromObject(deviceId);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject IsBarCodeExist(string barCode, string username, string deviceIp, string deviceId)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "IsBarCodeExist";
            p["barCode"] = JToken.FromObject(barCode);
            p["username"] = JToken.FromObject(username);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            p["deviceId"] = JToken.FromObject(deviceId);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject IsTagEpcExist(string tagEpc, string username, string deviceIp, string deviceId)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "IsTagEpcExist";
            p["tagEpc"] = JToken.FromObject(tagEpc);
            p["username"] = JToken.FromObject(username);
            p["deviceIp"] = JToken.FromObject(deviceIp);
            p["deviceId"] = JToken.FromObject(deviceId);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject HasOnlinePrintData()
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "HasOnlinePrintData";
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject SaveServiceLog(string printUser, string productSerial, int errorType, string errorDesc)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "SaveServiceLog";
            p["printUser"] = JToken.FromObject(printUser);
            p["productSerial"] = JToken.FromObject(productSerial);
            p["errorType"] = JToken.FromObject(errorType);
            p["errorDesc"] = JToken.FromObject(errorDesc);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject PrintCancel(int id)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "PrintCancel";
            p["id"] = JToken.FromObject(id);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject IsTagAssignedToProductSerial(string epc, string productSerial)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "IsTagAssignedToProductSerial";
            p["epc"] = JToken.FromObject(epc);
            p["productSerial"] = JToken.FromObject(productSerial);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject UpdateEpcByProductSerialAndGetProductInfo(int barcodeType, string epc, string productSerial)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "UpdateEpcByProductSerialAndGetProductInfo";
            p["barcodeType"] = JToken.FromObject(barcodeType);
            p["epc"] = JToken.FromObject(epc);
            p["productSerial"] = JToken.FromObject(productSerial);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

        public JObject ReregisterRequest(string id, string username)
        {
            var o = new JObject();
            var p = new JObject();
            o["interface"] = "RestAPI";
            o["method"] = "ReregisterRequest";
            p["id"] = JToken.FromObject(id);
            p["username"] = JToken.FromObject(username);
            o["parameters"] = p;
            var s = JsonConvert.SerializeObject(o);
            var r = Load(s);
            var result = JObject.Parse(r);
            return result;
        }

    }
}
