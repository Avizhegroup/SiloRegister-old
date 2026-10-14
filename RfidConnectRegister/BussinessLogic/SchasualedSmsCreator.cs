using RfidConnectRegister.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace RfidConnectRegister.BussinessLogic
{
   public static class SchasualedNotifCreator
    {

        static bool schasualedNotifCreatorStatus = false;
    //    static System.Windows.Forms.Timer HourTimer = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer MinTimer = new System.Windows.Forms.Timer();
        static DateTime LastCheck = DateTime.Now;
        static SchasualedNotifCreator()
        {
            //   HourTimer.Interval = 3600000;
           // HourTimer.Interval = 60000;
            MinTimer.Interval = 30000;

         //   HourTimer.Tick += new System.EventHandler(HourTimer_Tick);
            MinTimer.Tick += new System.EventHandler(MinTimer_Tick);
        }
        public static void StartschasualedNotifCreator()
        {
   
          //  HourTimer.Enabled = true;
            MinTimer.Enabled = true;
        }
        public static void StoptschasualedNotifCreator()
        {
          
   //         HourTimer.Enabled = false;
            MinTimer.Enabled = false;
        }

        private async static void MinTimer_Tick(object sender, EventArgs e)
        {
            //check barname
            //مقصد  / تعداد کل/ متراژ کل/ متراژ و میانگین سنی روی گروه بندی کالا / 
            RfidConnectApi.ApiBusiness _api = new RfidConnectApi.ApiBusiness();
            var result = await _api.SGetNotif_WinFormService(LastCheck);
            if (result != "")
            {
                ShowNotif(result);
            }
            LastCheck = DateTime.Now;
        }

        private static void ShowNotif(string NotifMessage)
        {
            new frmShowAlert(NotifMessage).Show();
         }
        //public async static void HourTimer_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (DateTime.Now.Hour == 7)
        //        {
        //            string FromDate = Time.Time.ConvertMiladi2ShamsiDate(DateTime.Now.AddDays(-1));

        //            string ToDate = Time.Time.ConvertMiladi2ShamsiDate(DateTime.Now);
 

        //             RfidConnectApi.ApiBusiness _api = new RfidConnectApi.ApiBusiness();
        //            var result = await _api.NotifGetTolidData(FromDate, ToDate);
        //            if (result != "")
        //            {
        //                NotifRequest.SendNotifRequest(result, 2);
        //            }
        //        }
        //        else if (DateTime.Now.Hour == 16)
        //        {
        //            string DateTemp = Time.Time.ConvertMiladi2ShamsiDate(DateTime.Now.AddDays(-1));
        //            DateTemp = DateTemp.Substring(0, 4) + DateTemp.Substring(5, 2) + DateTemp.Substring(8, 2) + "060101";
        //            string FromDate = DateTemp;

        //            DateTemp = Time.Time.ConvertMiladi2ShamsiDate(DateTime.Now);
        //            DateTemp = DateTemp.Substring(0, 4) + DateTemp.Substring(5, 2) + DateTemp.Substring(8, 2) + "060101";


        //            string ToDate = DateTemp;
        //            RfidConnectApi.ApiBusiness _api = new RfidConnectApi.ApiBusiness();


        //            DateTime From = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 5, 1, 1);
        //            var result2 = await _api.NotifGetForoshData(From.ToString(), DateTime.Now.ToString());

        //            if (result2 != "")
        //            {

        //                NotifRequest.SendNotifRequest(result2, 3);
        //            }

        //            var result3 = await _api.NotifGetMojodiData();
        //            if (result3 != "")
        //            {

        //                NotifRequest.SendNotifRequest(result3, 4);
        //            }

        //            //پیامک پایان شیفت اداری شامل اطلاعات  گزارش تجمعی از تولید ، فروش آن روز و 
        //            // همچنین موجودی جدید انبار

        //            //گزارش تولید روز 
        //            //تعداد و متراژ تولید
        //            //تعداد خطوط فعال
        //            // فاصله  تولید از توان میانگین
        //            //فاصله تولید از توان حداکثر 
        //            //تنوع طرح
        //            //تنوع سایز
        //            //متراژ درجه D و CG


        //            //SELECT COUNT(tbl_Tags.ProductSerial) AS CountProductSerial, SUM(tbl_Tags.ProductCount) AS SumProductCount, COUNT(DISTINCT tbl_Tags.fld_ProductPropertyAId) AS CountPropertyAId, COUNT(DISTINCT tbl_Tags.ProductType) 
        //            //                         AS CountProductType, COUNT(DISTINCT tbl_Products.ProductSize) AS CountProudctSize,
        //            //                             (SELECT        SUM(ProductCount) AS Expr1
        //            //                               FROM            tbl_Tags AS tbl_Tags_1
        //            //                               WHERE(TagRegisterShamsiUnixDate > 14000627150101) AND(ProductStatus IN('D', 'CG'))) AS SumProductCountProductStatusDCG
        //            //FROM tbl_Tags LEFT OUTER JOIN
        //            //              tbl_Products ON tbl_Tags.ProductCode = tbl_Products.ProductCode
        //            //WHERE(tbl_Tags.TagRegisterShamsiUnixDate > 14000627150101)
        //            //                CountProductSerial SumProductCount CountPropertyAId CountProductType    CountProudctSize SumProductCountProductStatusDCG
        //            //114 9853.92 3   1   2   8019.36


        //            //SELECT TOP(1) SUM(ProductCount) AS Expr2
        //            //FROM tbl_Tags
        //            //WHERE(fld_ProductPropertyAId > 0)
        //            //GROUP BY SUBSTRING(TagRegisterShamsiUnixDate, 0, 9)
        //            //ORDER BY Expr2 DESC
        //            //تولید حداکثر


        //            //                SELECT CAST(SUM(ProductCount) / COUNT(DISTINCT SUBSTRING(TagRegisterShamsiUnixDate, 0, 9)) AS decimal(18, 2)) AS Expr1
        //            //FROM tbl_Tags
        //            //WHERE(fld_ProductPropertyAId > 0) AND(fld_ProductPropertyBId > 0)
        //            // تولید میانگین






        //            //گزارش فروش روز
        //            //تعداد ماشین
        //            //متراژ
        //            //مقصد - لیست تنوع - سایز - متراژ

        //            //SELECT tbl_Products.ProductType, tbl_Products.ProductSize, SUM(tbl_TagsMovement.ProductCount) AS SumProductCount, COUNT(tbl_TagsMovement.ProductSerial) AS CountProductSerial, tbl_MovementActions.MovementActionData, 
        //            //                         tbl_MovementActions.MovementActionId
        //            //FROM            tbl_Products RIGHT OUTER JOIN
        //            //                         tbl_TagsMovement ON tbl_Products.ProductCode = tbl_TagsMovement.ProductCode RIGHT OUTER JOIN
        //            //                         tbl_MovementActions ON tbl_TagsMovement.HMovementActionId = tbl_MovementActions.MovementActionId
        //            //WHERE(tbl_MovementActions.MovementActionTp = 2) AND(tbl_MovementActions.MovementActionData NOT LIKE N'%برگشت کالا%') AND(tbl_MovementActions.MovementActionTime <= '')
        //            //GROUP BY tbl_Products.ProductType, tbl_Products.ProductSize, tbl_MovementActions.MovementActionDate, tbl_MovementActions.MovementActionTime, tbl_MovementActions.MovementActionDriverName, 
        //            //                         tbl_MovementActions.MovementActionDriverMobile, tbl_MovementActions.MovementActionData, tbl_MovementActions.MovementActionId
        //            //                ProductType ProductSize SumProductCount CountProductSerial  MovementActionData MovementActionId
        //            //9   GRIT    60 * 60 1140.48 11   { "MovementActionDesc":"","DocumentID":"113949","DetinationType":"1","Destination":""}
        //            //                1847
        //            //10  GRIT    60 * 60 1244.16 12   { "MovementActionDesc":"","DocumentID":"113985","DetinationType":"1","Destination":""}
        //            //                1857



        //            // فاصله  فروش از فروش میانگین
        //            //SELECT TOP(1) SUM(tbl_TagsMovement.ProductCount) / COUNT(DISTINCT tbl_TagsMovement.HTagsMovementDate) AS Expr1
        //            //FROM tbl_TagsMovement INNER JOIN
        //            //                         tbl_MovementActions ON tbl_TagsMovement.HMovementActionId = tbl_MovementActions.MovementActionId
        //            //WHERE(tbl_MovementActions.MovementActionTp = 2) AND(tbl_MovementActions.MovementActionData NOT LIKE N'%برگشت کالا%')
        //            //فاصله فروش از فروش حداکثر 
        //            //SELECT TOP(1) SUM(tbl_TagsMovement.ProductCount) AS SumProductCount
        //            //FROM tbl_TagsMovement INNER JOIN
        //            //                         tbl_MovementActions ON tbl_TagsMovement.HMovementActionId = tbl_MovementActions.MovementActionId
        //            //GROUP BY tbl_TagsMovement.HTagsMovementDate, tbl_MovementActions.MovementActionTp, tbl_MovementActions.MovementActionData
        //            //HAVING(tbl_MovementActions.MovementActionTp = 2) AND(tbl_MovementActions.MovementActionData NOT LIKE N'%برگشت کالا%')
        //            //ORDER BY SumProductCount DESC




        //            //میانگین سنی کالا



        //            //تعداد پالت
        //            //متراژ                  
        //            //میانگین سنی کالا
        //            //SELECT COUNT(ProductSerial) AS Expr1, CAST( SUM(ProductCount) as bigint) AS Expr2, dbo.GeorgianDateToJalaliDate(cast(avg(CAST(CAST((dbo.JalaliDateToGeorgianDate(SUBSTRING(TagRegisterShamsiUnixDate, 0, 5) + '/' + SUBSTRING(TagRegisterShamsiUnixDate, 5, 2)
        //            //           + '/' + SUBSTRING(TagRegisterShamsiUnixDate, 7, 2), SUBSTRING(TagRegisterShamsiUnixDate, 9, 2) + ':' + SUBSTRING(TagRegisterShamsiUnixDate, 11, 2))) as datetime) as float)) as datetime))
        //            //FROM tbl_Tags
        //            //WHERE(TagStatus = N'1')

        //            // لیفتراک فعال
        //            //SELECT COUNT(DISTINCT fld_PPMWMCode) AS Expr1
        //            //FROM tbl_ProductPlacementMissions
        //            //WHERE(fld_PPMStatus = 2) AND(fld_PPMRegDateTime >= '2021-09-23 06:01:59.000')
        //            //تعداد لاین خالی

        //            //SELECT COUNT(DISTINCT tbl_Zones.ZoneCode) AS Expr1
        //            //FROM tbl_Zones LEFT OUTER JOIN
        //            //              tbl_Tags ON tbl_Zones.ZoneCode = tbl_Tags.TagZone
        //            //WHERE(tbl_Zones.ZoneParentCode <> N'-1') AND(tbl_Zones.ZoneCode NOT LIKE '%R%') AND(tbl_Zones.ZoneCode NOT LIKE '%MR%') AND(tbl_Tags.TagZone IS NULL)
        //            // ظرفیت انبار
        //            //SELECT SUM(ZoneCapacity) AS Expr1
        //            //FROM tbl_Zones
        //            //WHERE(ZoneParentCode <> N'-1') AND(ZoneCode NOT LIKE '%R%') AND(ZoneCode NOT LIKE '%MR%')


        //        }
        //        else if (DateTime.Now.Hour == 6)
        //        {
        //            // 3 پایان شیفت تولیدی
        //            //محتوای پیامک
        //            // تولید انجام شده در این شیفت 
        //            //تعداد خطوط فعال
        //            // فاصله از توان میانگین
        //            //فاصله از توان حداکثر 
        //            //تنوع کالا 
        //        }
        //        else if (DateTime.Now.Hour == 14)
        //        {
        //            // 1 پایان شیفت تولیدی
        //            //محتوای پیامک
        //            // تولید انجام شده در این شیفت 
        //            //تعداد خطوط فعال
        //            // فاصله از توان میانگین
        //            //فاصله از توان حداکثر 
        //            //تنوع کالا 

        //        }
        //        else if (DateTime.Now.Hour == 22)
        //        {
        //            // 2 پایان شیفت تولیدی
        //            //محتوای پیامک
        //            // تولید انجام شده در این شیفت 
        //            //تعداد خطوط فعال
        //            // فاصله از توان میانگین
        //            //فاصله از توان حداکثر 
        //            //تنوع کالا 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        RfidConnectRegister.BussinessLogic.Classes.Tools.ExceptionLogger.WriteExceptionLogs(ex);

        //    }
        //}
        
    }
}