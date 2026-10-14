using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace RfidConnectRegister.BussinessLogic.Time
{
    public class Time
    {
        internal static string GetUnixPersianTime(int addDay=0)
        {
            var DateTimeNow = DateTime.Now;
            if (addDay != 0)
            {
                DateTimeNow = DateTimeNow.AddDays(addDay);
            }
            var pc = new PersianCalendar();
            return pc.GetYear(DateTimeNow) +
                   pc.GetMonth(DateTimeNow).ToString().PadLeft(2, '0') +
                   pc.GetDayOfMonth(DateTimeNow).ToString().PadLeft(2, '0') +
                   DateTimeNow.Hour.ToString().PadLeft(2, '0') +
                   DateTimeNow.Minute.ToString().PadLeft(2, '0') +
                   DateTimeNow.Second.ToString().PadLeft(2, '0'); //+
            //                   DateTime.Now.Millisecond.ToString().PadLeft(3, '0');
        }

        public static string ConvertMiladi2ShamsiDate(DateTime Date)
        {
            if (Date.ToString() != "01/01/0001 12:00:00 AM" && Date.ToString() != "01/01/0001 12:00:00 ق.ظ")
            {
                System.Globalization.PersianCalendar shamsi = new System.Globalization.PersianCalendar();
                int ysh = shamsi.GetYear(Date);
                int msh = shamsi.GetMonth(Date);
                int dsh = shamsi.GetDayOfMonth(Date);
                return String.Format("{0}/{1}/{2}", ysh, msh.ToString().PadLeft(2, '0'), dsh.ToString().PadLeft(2, '0'));
            }
            else
            {
                System.Globalization.PersianCalendar shamsi = new System.Globalization.PersianCalendar();
                int ysh = shamsi.GetYear(DateTime.Now);
                int msh = shamsi.GetMonth(DateTime.Now);
                int dsh = shamsi.GetDayOfMonth(DateTime.Now);
                return String.Format("{0}/{1}/{2}", ysh, msh.ToString().PadLeft(2, '0'), dsh.ToString().PadLeft(2, '0'));
            }

        }

        public static DateTime ConvertShamsi2MiladiDate(string date)
        {
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            DateTime Date = p.ToDateTime(year, month, day, 0, 0, 0, 0);
            return Date;
        }

        public static string PersinaNowDate()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime dt = DateTime.Now;
            string year = pc.GetYear(dt).ToString();
            string mounth = pc.GetMonth(dt).ToString();
            string Day = pc.GetDayOfMonth(dt).ToString();
            return year + "/" + mounth.PadLeft(2, '0') + "/" + Day.PadLeft(2, '0');

        }

        public static string ConvertShortTimeToLongTime(string ShortTime)
        {
            //string LongTime = "";
            //string[] Temp = new string[2];
            //string[] TempTime = new string[3];
            //Temp = ShortTime.Split(' ');
            //if (Temp[1] == "PM")
            //{
            //    TempTime = Temp[0].Split(':');
            //    TempTime[0] = (TempTime[0] != "12") ? Convert.ToString(Convert.ToInt32(TempTime[0]) + 12) : "12";
            //    TempTime[1] = TempTime[1].PadLeft(2, '0');
            //    TempTime[2] = TempTime[2].PadLeft(2, '0');
            //}
            //else
            //{
            //    TempTime = Temp[0].Split(':');
            //    TempTime[0] = TempTime[0].PadLeft(2, '0');
            //    TempTime[1] = TempTime[1].PadLeft(2, '0');
            //    TempTime[2] = TempTime[2].PadLeft(2, '0');

            //}
            //LongTime = TempTime[0] + ":" + TempTime[1] + ":" + TempTime[2];
            try
            {
                return ShortTime.Remove(8);
            }
            catch
            {
                try
                {
                    return DateTime.Now.TimeOfDay.ToString().Remove(5);
                }
                catch
                {
                    try
                    {
                        return DateTime.Now.ToShortTimeString().Remove(8);
                    }
                    catch
                    {
                        return DateTime.Now.TimeOfDay.ToString();
                        //  MessageBox.Show("تنظیمات ساعت سیستم شما نادرست است. لطفا طبق راهنما اصلاح نمایید.");
                    }
                }
            }
        }
        public static string GetDayNameFromDateTime(DateTime Dt)
        {
            string DayName = "";
            switch (Dt.DayOfWeek.ToString())
            {
                case "Sunday":
                    DayName = "یکشنبه";
                    break;
                case "Monday":
                    DayName = "دوشنبه";
                    break;
                case "Tuesday":
                    DayName = "سه شنبه";
                    break;
                case "Wednesday":
                    DayName = "چهارشنبه";
                    break;
                case "Thursday":
                    DayName = "پنج شنبه";
                    break;
                case "Friday":
                    DayName = "جمعه";
                    break;
                case "Saturday":
                    DayName = "شنبه";
                    break;
            }
            return DayName;
        }

        public static int ExistMinBetweenToTime(string TimeStart, string TimeEnd)
        {
            //DateTime.Now.TimeOfDay
            string[] TempStart = TimeStart.Split(':');
            string[] TempEnd = TimeEnd.Split(':');

            return Convert.ToInt32((Convert.ToInt32(TempEnd[1]) - Convert.ToInt32(TempStart[1])) + ((Convert.ToInt32(TempEnd[0]) - Convert.ToInt32(TempStart[0])) * 60));
        }
    }




}
