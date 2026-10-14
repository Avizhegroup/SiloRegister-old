using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    public class GetComPort
    {
        

        public GetComPort()
        {
        }

        public List<Com> GetComPortsInfo()
        {
            List<Com> comPortInfoList = new List<Com>();

            ConnectionOptions options = ProcessConnection.ProcessConnectionOptions();
            ManagementScope connectionScope = ProcessConnection.ConnectionScope(Environment.MachineName, options, @"\root\CIMV2");

            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
            ManagementObjectSearcher comPortSearcher = new ManagementObjectSearcher(connectionScope, objectQuery);

            using (comPortSearcher)
            {
                string caption = null;
                foreach (ManagementObject obj in comPortSearcher.Get())
                {
                    if (obj != null)
                    {
                        object captionObj = obj["Caption"];
                        if (captionObj != null)
                        {
                            caption = captionObj.ToString();
                            if (caption.Contains("(COM"))
                            {
                                if (caption.Contains("WBT") || caption.Contains("CP210x"))
                                {
                                    RfidConnectRegister.Properties.Settings.Default.PortNumber = caption.Substring(caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty);
                                }
                                var comPortInfo = new Com
                                {
                                    Name = caption.Substring(caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty),
                                    Description = caption
                                };
                                comPortInfoList.Add(comPortInfo);
                            }
                        }
                    }
                }
            }
            return comPortInfoList;
        }
    }
    internal class ProcessConnection
    {
        public static ConnectionOptions ProcessConnectionOptions()
        {
            try
            {
                var options = new ConnectionOptions
                {
                    Impersonation = ImpersonationLevel.Impersonate,
                    Authentication = AuthenticationLevel.Default,
                    EnablePrivileges = true
                };
                return options;
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                Debug.WriteLine(e.Message);
                return null;
            }

        }
        public static ManagementScope ConnectionScope(string machineName, ConnectionOptions options, string path)
        {
            try
            {
                var connectScope = new ManagementScope
                {
                    Path = new ManagementPath(string.Format(@"\\{0}{1}", machineName, path)),
                    Options = options
                };
                connectScope.Connect();
                return connectScope;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
                return null;
            }
        }
    }
    public class Com
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
