using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    public class ShamsiCalendar
    {
        PersianCalendar pc = new PersianCalendar();

        public string MiladiToShamsi(DateTime date)
        {
            try
            {
                var firstDate = pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" +
                                pc.GetDayOfMonth(date);
                var array = firstDate.Split('/');
                var returnVal = "";
                if (array[1].Length == 1)
                {
                    array[1] = "0" + array[1];
                }
                if (array[2].Length == 1)
                {
                    array[2] = "0" + array[2];
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0 | i == 1)
                    {
                        returnVal += array[i] + "/";
                    }
                    else
                    {
                        returnVal += array[i];
                    }
                }

                return returnVal;
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                return "";
            }
        }

        public string MiladiToShamsiWithManualSeprator(DateTime date, string seprator)
        {
            try
            {
                var firstDate = pc.GetYear(date) + "/" + pc.GetMonth(date) + "/" +
                                pc.GetDayOfMonth(date);
                var array = firstDate.Split('/');
                var returnVal = "";
                if (array[1].Length == 1)
                {
                    array[1] = "0" + array[1];
                }
                if (array[2].Length == 1)
                {
                    array[2] = "0" + array[2];
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (i == 0 | i == 1)
                    {
                        returnVal += array[i] + seprator;
                    }
                    else
                    {
                        returnVal += array[i];
                    }
                }

                return returnVal;
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                return "";
            }
        }

        public string DayName(DateTime date)
        {
            DayOfWeek dayOfWeek = pc.GetDayOfWeek(date);
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    return "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    return "پنجشنبه";
                    break;
                case DayOfWeek.Friday:
                    return "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    return "شنبه";
                    break;
                default:
                    return "روز هفته";
                    break;
            }

        }

        public int OddAndEvenDay(DateTime date)
        {
            var number = 0;
            DayOfWeek dayOfWeek = pc.GetDayOfWeek(date);
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    number += 1;
                    break;
                case DayOfWeek.Monday:
                    number += 0;
                    break;
                case DayOfWeek.Tuesday:
                    number += 1;
                    break;
                case DayOfWeek.Wednesday:
                    number += 0;
                    break;
                case DayOfWeek.Thursday:
                    number += 1;
                    break;
                case DayOfWeek.Friday:
                    number += 2;
                    break;
                case DayOfWeek.Saturday:
                    number += 0;
                    break;
            }

            return number;

        }

        public DateTime PersianToMiladi(string date)
        {
            try
            {
                if (!CheckDateEmptiness(date))
                {
                    if (CheckDateValidation(date))
                    {
                        string[] array = date.Split('/');
                        return new DateTime(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]),
                            new PersianCalendar());
                    }
                    else
                    {
                        // throw new Exception("Time is not in valid format");
                        return DateTime.Parse("1900/01/01");
                    }
                }
                else
                {
                    //  throw new Exception("Time string is empty");
                    return DateTime.Parse("1900/01/01");
                }
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                return DateTime.Parse("1900/01/01");
            }
        }

        public DateTime PersianToMiladiWithTime(string date, string time)
        {
            try
            {
                if (!CheckDateEmptiness(date) && !CheckTimeEmptiness(time))
                {
                    if (CheckDateValidation(date) && CheckTimeValidation(time))
                    {
                        var dateArray = date.Split('/');
                        var timeArray = time.Split(':');
                        var reDate = new DateTime(int.Parse(dateArray[0]), int.Parse(dateArray[1]),
                            int.Parse(dateArray[2]), new PersianCalendar());
                        reDate = reDate.AddHours(double.Parse(timeArray[0])).AddMinutes(double.Parse(timeArray[1]));
                        return reDate;
                    }
                    else
                    {
                        // throw new Exception("Time is not in valid format");
                        return DateTime.Parse("1900/01/01");
                    }
                }
                else
                {
                    //  throw new Exception("Time string is empty");
                    return DateTime.Parse("1900/01/01");
                }
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                return DateTime.Parse("1900/01/01");
            }
        }




        //public bool CheckTime(string time)
        //{
        //    bool flag = true;
        //    try
        //    {
        //        string[] array = time.Split(':');
        //        if (int.Parse(array[0]) > 24 | int.Parse(array[0]) < 0)
        //            flag = false;
        //        if (int.Parse(array[1]) > 59 | int.Parse(array[1]) < 0)
        //            flag = false;

        //    }
        //    catch (Exception e)
        //    {
        //        flag = false;
        //        Tools.ExceptionLogger.WriteExceptionLogs(e);
        //    }

        //    return flag;
        //}

        public bool CheckTimeValidation(string time)
        {
            var flag = true;
            //  if (CheckTimeEmptiness(time))
            //  {
            try
            {
                string[] array = time.Split(':');
                if (int.Parse(array[0]) > 24 | int.Parse(array[0]) < 0)
                    flag = false;
                if (int.Parse(array[1]) > 59 | int.Parse(array[1]) < 0)
                    flag = false;
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                flag = false;
            }
            //   }
            //  else
            //  {
            //    flag = false;
            //    }
            return flag;
        }

        public bool CheckTimeEmptiness(string time)
        {
            var flag = false;
            try
            {
                if (time.Split(':')[0] == "  " | time.Split(':')[1] == "")
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                flag = false;
            }
            return flag;
        }



        public bool CheckDateValidation(string date)
        {
            var flag = true;
            //  if (CheckDateEmptiness(date))
            //  {
            try
            {
                if (date != String.Empty)
                {
                    if (int.Parse(date.Split('/')[0]) > 1500 | int.Parse(date.Split('/')[0]) < 1300)
                    {
                        flag = false;
                    }

                    if (int.Parse(date.Split('/')[1]) > 12 | int.Parse(date.Split('/')[1]) <= 0)
                    {
                        flag = false;
                    }

                    if (int.Parse(date.Split('/')[2]) > 31 | int.Parse(date.Split('/')[2]) <= 0)
                    {
                        flag = false;
                    }
                }
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                flag = false;
            }
            //    }
            //    else
            //    {
            //    flag = false;
            //    }
            return flag;
        }

        public bool CheckDateEmptiness(string date)
        {
            var flag = false;
            try
            {
                if (date.Split('/')[0] == "13  " | date.Split('/')[1] == "  " |
                    date.Split('/')[2] == "")
                {
                    flag = true;
                }
            }
            catch (Exception e)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(e);
                flag = true;
            }
            return flag;
        }

        //public bool CheckMonthAndDayValidation(string date)
        //{

        //}

    }
}
