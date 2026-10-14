using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    public class DotNetVersionChecker
    {
        private static int Get45or451FromRegistry()
        {
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
            {
                return Convert.ToInt32(ndpKey.GetValue("Release"));
               // CheckFor45DotVersion(releaseKey);
            }
        }

        public static bool CheckFor45DotVersion(/*int releaseKey*/)
        {
            //if (releaseKey >= 393273)
            //{
            //    return "4.6 RC or later";
            //}
            //if ((releaseKey >= 379893))
            //{
            //    return "4.5.2 or later";
            //}
            //if ((releaseKey >= 378675))
            //{
            //    return "4.5.1 or later";
            //}
            var releaseKey = Get45or451FromRegistry();
            if ((releaseKey >= 378389))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
