using DocumentFormat.OpenXml.Bibliography;
using FastReport.Cloud.OAuth;
 using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RfidConnectRegister.BussinessLogic.Classes;
using RfidConnectRegister.DML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Tag = RfidConnectRegister.DML.Tag;

namespace RfidConnectRegister.BussinessLogic.RfidConnectApi
{
    public class ApiBusiness
    {
        private string StringKey_Url = "http://" + Properties.Settings.Default.ServerIP +"/RfidCore/v1/Wms/PostObject";

        internal async Task<bool> Login(string username, string password)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("TSLogin", StringKey_Url,
              new KeyValuePair<string, object>("username", username),
              new KeyValuePair<string, object>("password", password));
            if ((bool)result["successful"] && result["value"].ToString() != "0") 
            {
                DataAccess.Items.OnlineUserCode = result["value"].ToString();
                DataAccess.Items.OnlineUserName = username;
                DataAccess.Items.OnlineUserRealName = await TSLoginReturnName(DataAccess.Items.OnlineUserCode);

                return true;
            }
            else
                return false;
        }



        internal async Task<List<DML.GetAllAggDocDto>> GetAggDocsByDocTypeAndStatus(string documentType)
        {
            try
            {
                var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetDocumentsByDocType", StringKey_Url,
                   new KeyValuePair<string, object>("documentType", documentType));
                if ((bool)result["successful"])
                {

                    if (result["value"].ToString() != "")
                    {
                        List<DML.GetAllAggDocDto> _listAllAggDocDto = new List<DML.GetAllAggDocDto>();
                        foreach (JToken item in result["value"])
                        {


                            _listAllAggDocDto.Add(new DML.GetAllAggDocDto()
                            {
                                DocumentData = item["headerData"].ToString(),
                                DocumentKey = item["key"].ToString()

                            });

                        }
                        return _listAllAggDocDto;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                Tools.WriteExceptionLogs(ex);
                return null;

            }
            return null;
        }


        internal async Task<JToken> GetDocumentData(string documentKey, int documentType)
        {
            try
            {
                var result = await WorkingWithApiConnector.LoadUnDirectAsync(methodName: "SGetDocumentData", url: StringKey_Url,
     new KeyValuePair<string, object>("documentKey", documentKey),
      new KeyValuePair<string, object>("documentType", documentType)
                );


                if ((bool)result["successful"])
                {
                    return result["value"];

                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Tools.WriteExceptionLogs(ex);
                return null;

            }
        }



        internal async Task<string> TSLoginReturnName(string UserId)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("TSLoginReturnName", StringKey_Url,
              new KeyValuePair<string, object>("UserId", UserId));
            if ((bool)result["successful"] && result["value"].ToString() != "")
            {
                return result["value"].ToString();
            }
            else
                return "";
        }



        internal async Task<List<DynamicFieldDto>> GetDynamicFieldsByActionTypeId(string actionTypeId)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetDynamicFieldsByActionTypeId", StringKey_Url,
                new KeyValuePair<string, object>("actionTypeId",Convert.ToInt32( actionTypeId)));
            if ((bool)result["successful"])
            {
                var list = new List<DynamicFieldDto>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new DynamicFieldDto()
                    {
                        Title = items["title"].ToString(),
                        Id = Convert.ToInt32(items["id"].ToString()),
                        RelatedTitle1 = items["relatedTitle1"].ToString(),
                        Value = ""
                    }) ;
                }
                return list;
            }
            else
                return null;
        }





        internal async Task<string> GetAllProductByTechnicalData(string ProductCode)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SPSearchProductWeb", StringKey_Url,
                new KeyValuePair<string, object>("search", new { MProductTitle ="-1", MProductCode = ProductCode, MTechCode ="-1", MSize ="-1", MQuality ="-1"}));
            if ((bool)result["successful"])
            {
                 return result["value"][0]["ProductTechnicalData"].ToString();
                //foreach (JToken items in result["value"])
                //{




                //    var tt = JToken.Parse(items["ProductTechnicalData"].ToString());
                //    foreach (JProperty jj in tt)
                //    {
                //        string name = jj.Name;
                //        string value = jj.Value.ToString();
                //    }
                //}
            }
            else
                return null;
        }


        internal async Task<List<Product>> GetAllProduct()
        { 
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetAllProductsDefined", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {
                var list = new List<Product>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new Product()
                    {
                        ProductCode = items["ProductCode"].ToString(),
                        ProductCountInPack =(items["ProductCountInPack"]!=null)? items["ProductCountInPack"].ToString():"0",
                        ProductENTitle= (items["ProductENTitle"] != null) ? items["ProductENTitle"].ToString() : "",
                        ProductPackValue = (items["ProductPackValue"] != null) ? items["ProductPackValue"].ToString() : "0",
                        ProductPackVolume = (items["ProductPackVolume"] != null) ? items["ProductPackVolume"].ToString() : "0",
                        ProductPackWeight = (items["ProductPackWeight"] != null) ? items["ProductPackWeight"].ToString() : "0",
                        ProductProperties = (items["ProductProperties"] != null) ? items["ProductProperties"].ToString() : "",
                        ProductSize = (items["ProductSize"] != null) ? items["ProductSize"].ToString() : " ",
                        ProductStatus = (items["ProductStatus"] != null) ? items["ProductStatus"].ToString() : "0",
                        ProductTechnicalCode = (items["ProductTechnicalCode"] != null) ? items["ProductTechnicalCode"].ToString() : "0",
                        ProductTitle = (items["ProductTitle"] != null) ? items["ProductTitle"].ToString() : " ",
                        ProductType = (items["ProductType"] != null) ? items["ProductType"].ToString() : "0",
                        ProductUnit = (items["ProductUnit"] != null) ? items["ProductUnit"].ToString() : "",
                        ProductValue = (items["ProductValue"] != null) ? items["ProductValue"].ToString() : "0",
                        ProductBrand= (items["ProductBrand"] != null) ? items["ProductBrand"].ToString() : "0",
                        ProductGroup= (items["ProductGroup"] != null) ? items["ProductGroup"].ToString() : "0",
                        ProductTechnicalData= (items["ProductTechnicalData"] != null) ? items["ProductTechnicalData"].ToString() : "0",
                        ProductBrandTitle = (items["ProductBrandTitle"] != null) ? items["ProductBrandTitle"].ToString() : "",
                        ProductGroupTitle = (items["ProductGroupTitle"] != null) ? items["ProductGroupTitle"].ToString() : "",
                        ProductStatusTitle = (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : "",
                        ProductTypeTitle = (items["ProductTypeTitle"] != null) ? items["ProductTypeTitle"].ToString() : "",
                        ProductSizeTitle= (items["ProductSizeTitle"] != null) ? items["ProductSizeTitle"].ToString() : ""

                    });
                }
                return list;
            }
            else
                return null;
        }



        internal async Task<List<DynamicFieldDto>> GetDynamicField(string sourceWarehouseCode, string destinationWarehouseCode)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetDynamicFieldsBySourceAndDestination", StringKey_Url,
                new KeyValuePair<string, object>("sourceWarehouseCode", sourceWarehouseCode),
                 new KeyValuePair<string, object>("destinationWarehouseCode", destinationWarehouseCode));
            if ((bool)result["successful"])
            {
                var list = new List<DynamicFieldDto>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new DynamicFieldDto()
                    {

                        ActionType = (items["ActionType"] != null) ? Convert.ToInt32(items["ActionType"].ToString()) : 0,
                        FieldType = (items["FieldType"] != null) ? (DynamicFieldType)Convert.ToInt32(items["FieldType"].ToString()) : DynamicFieldType.HeaderData,
                        Title = (items["Title"] != null) ? items["Title"].ToString() : "",
                        

                    });
                }
                return list;
            }
            else
                return null;
        }





            internal async Task<bool> ChangeRegisterDate(string ProductSerial,string NewDate,string NewTime)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SChangeRegisterDate", StringKey_Url,
              new KeyValuePair<string, object>("ProductSerial", ProductSerial)
              , new KeyValuePair<string, object>("NewDate", NewDate)
              , new KeyValuePair<string, object>("NewTime", NewTime));
            if ((bool)result["successful"] && (bool)result["value"])
            {
                return true;
            }
            else
                return false;
        }

        internal async Task<bool> CheckProductSerial(string ProductSerial)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SCheckProductSerial", StringKey_Url,
              new KeyValuePair<string, object>("ProductSerial", ProductSerial));
            if ((bool)result["successful"] && (bool)result["value"])
            {
                return true;
            }
            else
                return false;
        }

        internal async Task<string> CheckTagEPC(string TagEpc)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SCheckTagEPCReturnProductSerial", StringKey_Url,
              new KeyValuePair<string, object>("TagEpc", TagEpc));
            if ((bool)result["successful"]  )
            {
                return result["value"].ToString();
            }
            else
                return "";
        }



        internal async Task<int> IsProductSerialExist(string ProductSerial)
        {

            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SIsProductSerialExist", StringKey_Url,
               new KeyValuePair<string, object>("ProductSerial", ProductSerial),
               new KeyValuePair<string, object>("username", ""),
               new KeyValuePair<string, object>("deviceIp", ""),
               new KeyValuePair<string, object>("deviceId", ""));
            if ((bool)result["successful"])
            {

                return Convert.ToInt32(result["value"].ToString());
            }
            else

                return 0;

        }


        internal async Task<List<WarehouseDto>> GetAllWarehouses()
        {

 

            var result = await WorkingWithApiConnector.LoadUnDirectAsync(methodName: "SGetAllWarehouses",StringKey_Url);
            if ((bool)result["successful"])
            {
                var list = new List<WarehouseDto>();
                foreach (JToken items in result["value"])
                {
                    var dict = (items["epc"] != null && items["epc"].ToString() != "") ? JsonConvert.DeserializeObject<Dictionary<string, string>>(items["epc"].ToString()) : null;
                    
                    
        
                    list.Add(new WarehouseDto()
                    {
                        DestinationCode = items["destinationCode"].ToString(),
                        DestinationTitle = items["destinationTitle"].ToString(),
                        OperationalType = (DestinationOperationalType)Convert.ToInt32(items["operationalType"].ToString()),
                        InventoryType =  (DestinationInventoryType)Convert.ToInt32(items["inventoryType"].ToString()),
                        IsDefault = Convert.ToBoolean(items["isDefault"].ToString()),
                        IsActive = Convert.ToBoolean(items["isActive"].ToString()) ,
                        Id = Convert.ToInt32(items["id"].ToString()),
                        Epc= (items["Epc"]!=null)? items["Epc"].ToString():"",
                        allowCancel =(dict!=null && dict["AllowCancelTag"]!=null && dict["AllowCancelTag"].ToString()!="")? bool.Parse(dict["AllowCancelTag"]):false,
                        allowRePrint= (dict != null &&  dict["AllowRePrintTag"] != null && dict["AllowRePrintTag"].ToString() != "") ? bool.Parse(dict["AllowRePrintTag"]) : false 
                    });
                }
                return list;
            }
            else
                return null;
        }


        internal async Task<List<Product>> GetAllWMSProduct()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetCusProducts", StringKey_Url);
            if ((bool)result["successful"])
            {
                var list = new List<Product>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new Product()
                    {
                        ProductCode = items["mat_Code"].ToString(),
                         ProductTitle = (items["mat_Name"] != null) ? items["mat_Name"].ToString() : " "
 
                    });
                }
                return list;
            }
            else
                return null;
        }


         


            internal async Task<List<Tag>> GetTagsInfo(List<string> epcList, string userToken)
            {
                try
                {
                    var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetProductsByEpcs", StringKey_Url,
                        new KeyValuePair<string, object>("epcList", epcList),
                        new KeyValuePair<string, object>("userToken", userToken));
                    if ((bool)result["successful"])
                    {
                        var list = new List<Tag>();
                        foreach (JToken items in result["value"])
                        {
                            list.Add(new Tag()
                            {
                                TagEpc = items["TagEpc"].ToString(),
                                ProductCode = items["ProductCode"].ToString(),
                                ProductSerial = items["ProductSerial"].ToString(),
                                ProductCount = (items["ProductCount"] != null) ? Convert.ToDecimal(items["ProductCount"].ToString()) : 0,
                                ProductName = (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                                ProductOldSerial = (items["DeviceIp"] != null) ? items["DeviceIp"].ToString() : "",
                                ContractStatus= (items["ContractStatus"] != null) ? items["ContractStatus"].ToString() : "",
                                RegCode= (items["RegCode"] != null) ? items["RegCode"].ToString() : ""
                            });



                        }
                        return list;
                    }
                    else
                        return null;
                }
                catch
                {
                    return null;
                }
            }



            internal async Task<List<Tag>> GetTagInfo(string EPC)
        {
            try
            {
                var result = await WorkingWithApiConnector.LoadUnDirectAsync("SPGetProductInfo", StringKey_Url,
                    new KeyValuePair<string, object>("tagEpc", EPC));
                if ((bool)result["successful"])
                {
                    var list = new List<Tag>();
                    foreach (JToken items in result["value"])
                    {
                        list.Add(new Tag()
                        {
                            TagEpc = items["TagEpc"].ToString(),
                            ProductCode = items["ProductCode"].ToString(),
                            ProductSerial =  items["ProductSerial"].ToString(),
                            ProductCount = (items["ProductCount"] != null) ? Convert.ToDecimal(items["ProductCount"].ToString()) : 0,
                            ProductName = (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                            ProductTypeTitle = (items["ProductTypeTitle"] != null) ? items["ProductTypeTitle"].ToString() : "0",
                            ProductStatusTitle= (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : "0",
                            TagStatus = (items["TagStatus"] != null) ? Convert.ToInt32(items["TagStatus"].ToString()) : 0,
                            ProductProperties = (items["ProductProperties"] != null) ? items["ProductProperties"].ToString() : "",
                            ProductSize = (items["ProductSize"] != null) ? items["ProductSize"].ToString() : " ",
                            RegCode = (items["RegCode"] != null) ? items["RegCode"].ToString() : "0",
                            fld_ProductPropertyATitle= (items["fld_ProductPropertyATitle"] != null) ? items["fld_ProductPropertyATitle"].ToString() : "",
                            fld_ProductPropertyBTitle = (items["fld_ProductPropertyBTitle"] != null) ? items["fld_ProductPropertyBTitle"].ToString() : "",
                            ProductPackWeight = (items["ProductPackWeight"] != null) ? items["ProductPackWeight"].ToString() : "",
                            ProductPackVolume= (items["ProductPackVolume"] != null) ? items["ProductPackVolume"].ToString() : "",
                            ProductCountInPack = (items["ProductCountInPack"] != null) ? items["ProductCountInPack"].ToString() : "",
                            ProductValue = (items["ProductValue"] != null) ? items["ProductValue"].ToString() : "",
                            ProductUnit = (items["ProductUnit"] != null) ? items["ProductUnit"].ToString() : "",
                            fld_ProductPropertyAId = (items["fld_ProductPropertyAId"] != null) ? items["fld_ProductPropertyAId"].ToString() : "",
                            fld_ProductPropertyBId = (items["fld_ProductPropertyBId"] != null) ? items["fld_ProductPropertyBId"].ToString() : "",
                            TagZone =  (items["TagZone"] != null) ? items["TagZone"].ToString() : "",
                            TagStatusTitle = (items["TagStatusTitle"] != null) ? items["TagStatusTitle"].ToString() : "",
                            TagRegisterUser= (items["Username"] != null) ? items["Username"].ToString() : "",
                            TagRegisterShamsiUnixDate= (items["TagRegisterShamsiUnixDate"] != null) ? items["TagRegisterShamsiUnixDate"].ToString() : "",
                            FreezeStatusTitle=(items["FreezeStatusTitle"] != null) ? items["FreezeStatusTitle"].ToString() : "",
                            InspectStatusTitle = (items["InspectStatusTitle"] != null) ? items["InspectStatusTitle"].ToString() : "",
                            TagInDestinationId = (items["TagInDestinationId"] != null) ? items["TagInDestinationId"].ToString() : "",
                            TagTreeParentsEpc = (items["TagTreeParentsEpc"] != null) ? items["TagTreeParentsEpc"].ToString() : "",
                            TagTreeParentSerial = (items["TagTreeParentSerial"] != null) ? items["TagTreeParentSerial"].ToString() : ""

                        });



                    }
                    return list;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }


        internal async Task<List<Tag>> GetTagListByParentCode(string ParentSerial,string ParentEpc)
        {
            try
            {
                var result = await WorkingWithApiConnector.LoadUnDirectAsync("SPGetProductListByParentSerial", StringKey_Url,
                    new KeyValuePair<string, object>("parentSerial", ParentSerial),
                    new KeyValuePair<string, object>("parentEpc", ParentEpc));
                if ((bool)result["successful"])
                {
                    var list = new List<Tag>();
                    foreach (JToken items in result["value"])
                    {
                        list.Add(new Tag()
                        {
                            TagEpc = items["TagEpc"].ToString(),
                            ProductCode = items["ProductCode"].ToString(),
                            ProductSerial = items["ProductSerial"].ToString(),
                            ProductCount = (items["ProductCount"] != null) ? Convert.ToDecimal(items["ProductCount"].ToString()) : 0,
                            ProductName = (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                            ProductTypeTitle = (items["ProductTypeTitle"] != null) ? items["ProductTypeTitle"].ToString() : "0",
                            ProductStatusTitle = (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : "0",
                            TagStatus = (items["TagStatus"] != null) ? Convert.ToInt32(items["TagStatus"].ToString()) : 0,
                            ProductProperties = (items["ProductProperties"] != null) ? items["ProductProperties"].ToString() : "",
                            ProductSize = (items["ProductSize"] != null) ? items["ProductSize"].ToString() : " ",
                            RegCode = (items["RegCode"] != null) ? items["RegCode"].ToString() : "0",
                            fld_ProductPropertyATitle = (items["fld_ProductPropertyATitle"] != null) ? items["fld_ProductPropertyATitle"].ToString() : "",
                            fld_ProductPropertyBTitle = (items["fld_ProductPropertyBTitle"] != null) ? items["fld_ProductPropertyBTitle"].ToString() : "",
                            ProductPackWeight = (items["ProductPackWeight"] != null) ? items["ProductPackWeight"].ToString() : "",
                            ProductPackVolume = (items["ProductPackVolume"] != null) ? items["ProductPackVolume"].ToString() : "",
                            ProductCountInPack = (items["ProductCountInPack"] != null) ? items["ProductCountInPack"].ToString() : "",
                            ProductValue = (items["ProductValue"] != null) ? items["ProductValue"].ToString() : "",
                            ProductUnit = (items["ProductUnit"] != null) ? items["ProductUnit"].ToString() : "",
                            fld_ProductPropertyAId = (items["fld_ProductPropertyAId"] != null) ? items["fld_ProductPropertyAId"].ToString() : "",
                            fld_ProductPropertyBId = (items["fld_ProductPropertyBId"] != null) ? items["fld_ProductPropertyBId"].ToString() : "",
                            TagZone = (items["TagZone"] != null) ? items["TagZone"].ToString() : "",
                            TagStatusTitle = (items["TagStatusTitle"] != null) ? items["TagStatusTitle"].ToString() : "",
                            TagRegisterUser = (items["Username"] != null) ? items["Username"].ToString() : "",
                            TagRegisterShamsiUnixDate = (items["TagRegisterShamsiUnixDate"] != null) ? items["TagRegisterShamsiUnixDate"].ToString() : "",
                            FreezeStatusTitle = (items["FreezeStatusTitle"] != null) ? items["FreezeStatusTitle"].ToString() : "",
                            InspectStatusTitle = (items["InspectStatusTitle"] != null) ? items["InspectStatusTitle"].ToString() : "",
                            TagInDestinationId = (items["TagInDestinationId"] != null) ? items["TagInDestinationId"].ToString() : "",
                            TagTreeParentsEpc= (items["TagTreeParentsEpc"] != null) ? items["TagTreeParentsEpc"].ToString() : "",
                            TagTreeParentSerial = (items["TagTreeParentSerial"] != null) ? items["TagTreeParentSerial"].ToString() : ""
                        });



                    }
                    return list;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }



        internal async Task<List<Tag>> GetPrintInfo(string ProductSerial, string userToken)
        {
            string[] _productSerial = { ProductSerial };
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("GetPrintData", StringKey_Url,
                new KeyValuePair<string, object>("serials", _productSerial),
                new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {
                var list = new List<Tag>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new Tag()
                    {
                        ProductCode = items["ProductCode"].ToString(),
                        ProductSerial = items["ProductSerial"].ToString(),
                        ProductCount = (items["ProductCount"] != null) ? Convert.ToDecimal(items["ProductCount"].ToString()) : 0,
                        ProductName = (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                        ProductStatusTitle = (items["ProductStatus"] != null) ? items["ProductStatus"].ToString() : "0"

                    });
                }
                return list;
            }
            else
                return null;
        }


        internal async Task<List<Tag>> RepRegisterTag(GetRegisterRequestFilter rep)
        {

            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRepRegisterTagDetailsForWinApp", StringKey_Url,
                new KeyValuePair<string, object>("filter", rep));
            if ((bool)result["successful"])
            {
                var list = new List<Tag>();
                foreach (JToken items in result["value"])
                {
                   




                    list.Add(new Tag()
                    {
                         ProductCode = items["ProductCode"].ToString(),
                        ProductSerial = items["ProductSerial"].ToString(),
                        ProductCount = (items["Count"] != null) ? Convert.ToDecimal(items["Count"].ToString()) : 0,
                        ProductName = (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                        ProductStatusTitle = (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : "0",
                        RegCode = (items["RegCode"] != null) ? items["RegCode"].ToString() : "0",
                        TagRegisterShamsiUnixDate = (items["DateTime"] != null) ? items["DateTime"].ToString() : "0",
                        TagRegisterUser = (items["Username"] != null) ? items["Username"].ToString() : "0",
                       fld_ProductPropertyATitle  = (items["Line"] != null) ? items["Line"].ToString() : "",
                        fld_ProductPropertyBTitle = (items["Shift"] != null) ? items["Shift"].ToString() : "",
                        TagEpc =   "",
                        TagZone =   "",
                        ProductTypeTitle =  "",
                        ProductSize= (items["Size"] != null) ? items["Size"].ToString() : "0",
                        ProductProperties= (items["DateTimeEnter"] != null) ? items["DateTimeEnter"].ToString() : "-",
                        TagStatusTitle = (items["Status"] != null) ? items["Status"].ToString() : "-"

                    });
                }
                return list;
            }
            else
                return null;
        }


       
        internal async Task<DataTable> RepSCancelRegisterTag(string ProductSerial, string FromDate,
     string ToDate, string User )
        {

        

            DataTable _dtResult = new DataTable();
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRepSCancelRegisterTag", StringKey_Url,
                new KeyValuePair<string, object>("ProductSerial", ProductSerial),
                new KeyValuePair<string, object>("FromDate", FromDate),
                new KeyValuePair<string, object>("ToDate", ToDate),
                new KeyValuePair<string, object>("User", User));

            _dtResult.Columns.Add("ProductSerial", typeof(string));
            _dtResult.Columns.Add("ProductCode", typeof(string));
            _dtResult.Columns.Add("ProductName", typeof(string));
            _dtResult.Columns.Add("ProductRegCode", typeof(string));
            _dtResult.Columns.Add("ProductCount", typeof(string));
            _dtResult.Columns.Add("SoftDeleteUser", typeof(string));
            _dtResult.Columns.Add("SoftDeleteDate", typeof(string));
            _dtResult.Columns.Add("RegisterUser", typeof(string));
            _dtResult.Columns.Add("RegisterDate", typeof(string));
            if ((bool)result["successful"])
            {

                foreach (JToken items in result["value"])
                {
                    _dtResult.Rows.Add((items["ProductSerial"] != null) ? items["ProductSerial"].ToString() : "",
                        (items["ProductCode"] != null) ? items["ProductCode"].ToString() : "",
                        (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                        (items["ProductRegCode"] != null) ? items["ProductRegCode"].ToString() : "",
                        (items["ProductCount"] != null) ? items["ProductCount"].ToString() : "",
                        (items["SoftDeleteUser"] != null) ? items["SoftDeleteUser"].ToString() : "",
                        (items["SoftDeleteDate"] != null) ? items["SoftDeleteDate"].ToString() : "",
                        (items["RegisterUser"] != null) ? items["RegisterUser"].ToString() : "",
                        (items["RegisterDate"] != null) ? items["RegisterDate"].ToString() : ""
                        

                      );
                }
                return _dtResult;
            }
            else
                return null;
        }


        internal async Task<DataTable> RepSGetNotRegisteredPrints()
        {
            

            DataTable _dtResult = new DataTable();
           

            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetRegisteredPrints", StringKey_Url , new List<KeyValuePair<string,object>>().ToArray());

            _dtResult.Columns.Add("ProductSerial", typeof(string));
            _dtResult.Columns.Add("ProductCode", typeof(string));
            _dtResult.Columns.Add("ProductName", typeof(string));
            _dtResult.Columns.Add("ProductCount", typeof(string));
            _dtResult.Columns.Add("TagEpc", typeof(string));
            _dtResult.Columns.Add("RegisterFlag", typeof(string));
             
            if ((bool)result["successful"])
            {

                foreach (JToken items in result["value"])
                {
                    _dtResult.Rows.Add((items["ProductSerial"] != null) ? items["ProductSerial"].ToString() : "",
                        (items["ProductCode"] != null) ? items["ProductCode"].ToString() : "",
                        (items["ProductName"] != null) ? items["ProductName"].ToString() : "", 
                        (items["ProductCount"] != null) ? items["ProductCount"].ToString() : "",
                        (items["TagEpc"] != null) ? items["TagEpc"].ToString() : "",
                        (items["RegisterFlag"] != null) ? items["RegisterFlag"].ToString() : "" 


                      );
                }
                return _dtResult;
            }
            else
                return null;
        }


        internal async Task<DataTable>  RepRegisterTagByTagStatus0(string FromRegisterShamsiUnixDate)
        {



            DataTable _dtResult = new DataTable();
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRepRegisterTagByTagStatus0", StringKey_Url,
                new KeyValuePair<string, object>("FromRegisterShamsiUnixDate", FromRegisterShamsiUnixDate) );

            _dtResult.Columns.Add("ProductSerial", typeof(string));
            _dtResult.Columns.Add("ProductCode", typeof(string));
            _dtResult.Columns.Add("ProductName", typeof(string));
            _dtResult.Columns.Add("RegCode", typeof(string));
            _dtResult.Columns.Add("ProductCount", typeof(string));
             _dtResult.Columns.Add("Username", typeof(string));
            _dtResult.Columns.Add("TagRegisterShamsiUnixDate", typeof(string));
            if ((bool)result["successful"])
            {

                foreach (JToken items in result["value"])
                {
                    _dtResult.Rows.Add((items["ProductSerial"] != null) ? items["ProductSerial"].ToString() : "",
                        (items["ProductCode"] != null) ? items["ProductCode"].ToString() : "",
                        (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                        (items["RegCode"] != null) ? items["RegCode"].ToString() : "",
                        (items["ProductCount"] != null) ? items["ProductCount"].ToString() : "",
                         (items["Username"] != null) ? items["Username"].ToString() : "",
                        (items["TagRegisterShamsiUnixDate"] != null) ? items["TagRegisterShamsiUnixDate"].ToString() : ""


                      );
                }
                return _dtResult;
            }
            else
                return null;
        }



        internal async Task<DataTable> SGetListOfRemainProductByDocumentId(string DocumentId)
        {



            DataTable _dtResult = new DataTable();
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetRemainRegisterByDoc", StringKey_Url,
                new KeyValuePair<string, object>("DocumentId", DocumentId));

            _dtResult.Columns.Add("Count", typeof(string));
            _dtResult.Columns.Add("ProductCode", typeof(string));
              
            if ((bool)result["successful"])
            {

                foreach (JToken items in result["value"])
                {
                    _dtResult.Rows.Add((items["Count"] != null) ? items["Count"].ToString() : "0",
                        (items["ProductCode"] != null) ? items["ProductCode"].ToString() : "" );
                }
                return _dtResult;
            }
            else
                return null;
        }

        internal async Task<DataTable> SRepRegisterTagWithOutEPC()
        {



            DataTable _dtResult = new DataTable();
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRepRegisterTagWithOutEPC", StringKey_Url );

            _dtResult.Columns.Add("ProductSerial", typeof(string));
            _dtResult.Columns.Add("ProductCode", typeof(string));
            _dtResult.Columns.Add("ProductName", typeof(string));
            _dtResult.Columns.Add("RegCode", typeof(string));
            _dtResult.Columns.Add("ProductCount", typeof(string));
            _dtResult.Columns.Add("Username", typeof(string));
            _dtResult.Columns.Add("TagRegisterShamsiUnixDate", typeof(string));
            if ((bool)result["successful"])
            {

                foreach (JToken items in result["value"])
                {
                    _dtResult.Rows.Add((items["ProductSerial"] != null) ? items["ProductSerial"].ToString() : "",
                        (items["ProductCode"] != null) ? items["ProductCode"].ToString() : "",
                        (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                        (items["RegCode"] != null) ? items["RegCode"].ToString() : "",
                        (items["ProductCount"] != null) ? items["ProductCount"].ToString() : "",
                         (items["Username"] != null) ? items["Username"].ToString() : "",
                        (items["TagRegisterShamsiUnixDate"] != null) ? items["TagRegisterShamsiUnixDate"].ToString() : ""


                      );
                }
                return _dtResult;
            }
            else
                return null;
        }
  
        internal async Task<List<Tag>> RepRegisterTagTajamoeeProductCode(GetRegisterRequestFilter filters)
        {

            

            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRepRegisterTagSummaryForRegisterWinApp", StringKey_Url,
                new KeyValuePair<string, object>("filter", filters));
            if ((bool)result["successful"])
            {
                var list = new List<Tag>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new Tag()
                    {                        
                    ProductCode = items["ProductCode"].ToString(),
                    ProductName = (items["ProductName"] != null) ? items["ProductName"].ToString() : "",
                    RegCode = (items["RegCode"] != null) ? items["RegCode"].ToString() : "0",
                    ProductStatusTitle = (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : "0",
                    ProductSerial  = (items["Count"] != null) ?  items["Count"].ToString() : "0",
                    ProductCount = (items["SumCount"] != null) ? Convert.ToDecimal(items["SumCount"].ToString()) : 0,
                    ProductSize = (items["Size"] != null) ? items["Size"].ToString() : "0",
                    NotEnterCount=(items["NotEnterCount"] != null) ? items["NotEnterCount"].ToString() : "0",
                    fld_ProductPropertyATitle= (items["LineTitle"] != null) ? items["LineTitle"].ToString() : "-"
                    });
                }
                return list;
            }
            else
                return null;
        }


        internal async Task<string> SGetNotif_WinFormService(DateTime DateTimeLastCheck)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetNotif_WinFormService", StringKey_Url,
                new KeyValuePair<string, object>("DateTimeLastCheck", DateTimeLastCheck.ToString()),
                 new KeyValuePair<string, object>("User", DataAccess.Items.OnlineUserRealName));
            if ((bool)result["successful"])
            {
                return result["value"].ToString();
            }
            else
                return "";
        }

        internal async Task<DataTable> RepRegisterTagSummaryGroupBySizeANDRegCode(GetRegisterRequestFilter rep)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRepRegisterTagSummaryGroupBySizeANDRegCode", StringKey_Url,
                new KeyValuePair<string, object>("filter", rep));
            if ((bool)result["successful"])
            {

                

                var dt = Tools.JsonToObjects(JToken.Parse(result["value"].ToString()));
                return dt;
            }
            else
                return null;
        }



        


        internal async Task<string> CreateEpc(string serial, string productCode, string refCode)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SCreateEpc", StringKey_Url,
                new KeyValuePair<string, object>("serial", serial),
                 new KeyValuePair<string, object>("productCode", productCode),
                  new KeyValuePair<string, object>("refCode", refCode),
                   new KeyValuePair<string, object>("epc", ""),
                   new KeyValuePair<string, object>("type", "1"));
            if ((bool)result["successful"])
            {


                return result["value"].ToString();
            }
            else
                return null;
        }





        //internal async Task<bool> SavePrint(Print  _Print,string ProductProductionLine,string ProductProductionShift,string PrintCount)        
        //{
        //    var result = await WorkingWithApiConnector.LoadUnDirectAsync("SSavePrint", StringKey_Url,
        //         new KeyValuePair<string, object>("ProductCode", _Print.ProductCode),
        //         new KeyValuePair<string, object>("ProductRegCode", (_Print.ProductRegCode.ToString() != "") ? _Print.ProductRegCode : "0"),
        //         new KeyValuePair<string, object>("ProductTitle", (_Print.ProductTitle.ToString() != "") ? _Print.ProductTitle.ToString() : ""),
        //         new KeyValuePair<string, object>("ProductENTitle", (_Print.ProductENTitle != "") ? _Print.ProductENTitle : ""),
        //         new KeyValuePair<string, object>("ProductSize", (_Print.ProductSize != "") ? _Print.ProductSize : "0"),
        //         new KeyValuePair<string, object>("ProductItemCount", (_Print.ProductItemCount.ToString() != "") ? _Print.ProductItemCount.ToString() : "0"),
        //         new KeyValuePair<string, object>("ProductUnit", _Print.ProductUnit),
        //         new KeyValuePair<string, object>("ProductCountInPack", (_Print.ProductCountInPack.ToString() != "") ? _Print.ProductCountInPack.ToString() : "0"),
        //         new KeyValuePair<string, object>("ProductCount", (_Print.ProductCount != null) ? _Print.ProductCount.ToString() : "0"),
        //         new KeyValuePair<string, object>("ProductVolume", (_Print.ProductVolume != null) ? _Print.ProductVolume.ToString() : "0"),
        //         new KeyValuePair<string, object>("ProductWeight", (_Print.ProductWeight != null) ? _Print.ProductWeight.ToString() : "0"),
        //         new KeyValuePair<string, object>("ProductStatus", (_Print.ProductStatus != null) ? _Print.ProductStatus.ToString() : "0"),
        //         new KeyValuePair<string, object>("PrintActionId", _Print.PrintActionId),
        //         new KeyValuePair<string, object>("ProductProductionLine", (_Print.ProductProductionLine != null) ? _Print.ProductProductionLine : "0"),
        //         new KeyValuePair<string, object>("ProductProductionShift", (_Print.ProductProductionShift != null) ? _Print.ProductProductionShift : "0"),
        //         new KeyValuePair<string, object>("PrintCount", PrintCount),
        //         new KeyValuePair<string, object>("ProductType", _Print.ProductType),
        //          new KeyValuePair<string, object>("ProductContractType", _Print.ProductContractType));
        //    if ((bool)result["successful"])
        //    {

        //        return (bool)result["value"];
        //    }
        //    else
        //        return false;
        //}


        internal async Task<bool> SavePrintBySerial(Print _Print, string PrintCount, JToken ProductProperties)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SSavePrintBySerial", StringKey_Url,
                 new KeyValuePair<string, object>("ProductSerial", _Print.ProductSerial),
                 new KeyValuePair<string, object>("ProductCode", _Print.ProductCode),
                  new KeyValuePair<string, object>("ProductCount", (_Print.ProductCount != null) ? _Print.ProductCount.ToString() : "0"),
                 new KeyValuePair<string, object>("PrintActionId", _Print.PrintActionId),
                 new KeyValuePair<string, object>("ProductProductionLine", (_Print.ProductProductionLine != null) ? _Print.ProductProductionLine : "0"),
                 new KeyValuePair<string, object>("ProductProductionShift", (_Print.ProductProductionShift != null) ? _Print.ProductProductionShift : "0"),
                 new KeyValuePair<string, object>("PrintCount", PrintCount),
                  new KeyValuePair<string, object>("ProductContractType", _Print.ProductContractType),
                  new KeyValuePair<string, object>("ProductOldSerial", _Print.ProductOldSerial),
                   new KeyValuePair<string, object>("Location", "0"),
                    new KeyValuePair<string, object>("DocumentId", _Print.DocumentId),
                      new KeyValuePair<string, object>("PrintUser", _Print.PrintUser),
                      new KeyValuePair<string, object>("WareHouseCode", _Print.WareHouseCode),

                      new KeyValuePair<string, object>("ProductProperties", (JToken)ProductProperties)
                      );


             if ((bool)result["successful"])
            {
                return  (result["value"].ToString()=="")?false:true;
            }
            else
                return false;
        }
 
        internal async Task<string> GetNewPrintActionId()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetNewPrintActionId", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {

                return result["value"].ToString();
            }
            else
                return "0";
        }
 
        internal async Task<string> GetLatestNextlevelProductUnitbyEpc(string EpcCode)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("GetLatestNextlevelProductUnitbyEpc", StringKey_Url,
                new KeyValuePair<string, object>("EpcCode", EpcCode));
            if ((bool)result["successful"])
            {

                return result["value"].ToString();
            }
            else
                return "0";
        }


        internal async Task<bool> SaveProduct(Product ProductData)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SaveProduct", StringKey_Url,
                new KeyValuePair<string, object>("ProductCode", ProductData.ProductCode),
                new KeyValuePair<string, object>("ProductTitle", ProductData.ProductTitle),
                new KeyValuePair<string, object>("ProductENTitle", ProductData.ProductENTitle),
                new KeyValuePair<string, object>("ProductPackValue", (ProductData.ProductPackValue.ToString() != "") ? ProductData.ProductPackValue.ToString() : "0"),
                new KeyValuePair<string, object>("ProductPackWeight", (ProductData.ProductPackWeight != "") ? ProductData.ProductPackWeight : "0"),
                new KeyValuePair<string, object>("ProductPackVolume", (ProductData.ProductPackVolume != "") ? ProductData.ProductPackVolume : "0"),
                new KeyValuePair<string, object>("ProductCountInPack", (ProductData.ProductCountInPack != "") ? ProductData.ProductCountInPack : "0"),
                new KeyValuePair<string, object>("ProductValue", ProductData.ProductValue),
                new KeyValuePair<string, object>("ProductTechnicalCode", ProductData.ProductTechnicalCode),
                new KeyValuePair<string, object>("ProductProperties", (ProductData.ProductProperties != null) ? ProductData.ProductProperties : ""),
                new KeyValuePair<string, object>("ProductType", (ProductData.ProductType != null) ? ProductData.ProductType : ""),
                new KeyValuePair<string, object>("ProductStatus", ProductData.ProductStatus),
                new KeyValuePair<string, object>("ProductSize", ProductData.ProductSize),
                new KeyValuePair<string, object>("ProductUnit", ProductData.ProductUnit),
                new KeyValuePair<string, object>("ProductRegUser", ProductData.ProductRegUser));
            if ((bool)result["successful"])
            {

                return (bool)result["value"];
            }
            else
                return false;
        }

         

              internal async Task<bool> SRegisterNextlevelProductUnit(string productUnitEpc, List<string> listEpc,string userToken)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRegisterNextlevelProductUnit", StringKey_Url,
                new KeyValuePair<string, object>("productUnitEpc", productUnitEpc),
                  new KeyValuePair<string, object>("listEpc", listEpc),
                     new KeyValuePair<string, object>("userToken", userToken)
                  );
            if ((bool)result["successful"])
            {

                return (bool)result["value"];
            }
            else
                return false;
        }

        internal async Task<bool> SDeletePrintByPrintId(string PrintId)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SDeletePrintByPrintId", StringKey_Url,
                new KeyValuePair<string, object>("PrintId", PrintId));
            if ((bool)result["successful"])
            {

                return (bool)result["value"];
            }
            else
                return false;
        }

        internal async Task<bool> DeleteProduct(string ProductData)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SDeleteProduct", StringKey_Url,
                new KeyValuePair<string, object>("ProductCode", ProductData) );
            if ((bool)result["successful"])
            {

                return (bool)result["value"];
            }
            else
                return false;
        }


        internal async Task<bool>  SaveProductType(string ProductTypeTitle, string ProductTypeParentId, string ProductTypeParentsId, string ProductTypeCode, string userToken)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SSaveProductType", StringKey_Url,
                new KeyValuePair<string, object>("ProductTypeTitle", ProductTypeTitle),
                new KeyValuePair<string, object>("ProductTypeParentId", ProductTypeParentId),
                new KeyValuePair<string, object>("ProductTypeParentsId", ProductTypeParentsId),
                new KeyValuePair<string, object>("ProductTypeCode", ProductTypeCode),
                new KeyValuePair<string, object>("userToken", userToken) );
            if ((bool)result["successful"])
            {

                return (bool)result["value"];
            }
            else
                return false;
        }
 
        internal async Task<bool> SaveRegisterTag(string productSerial,string productCode,string productCount,string[] epcList,string username)
        {
            try
            {
                var result = await WorkingWithApiConnector.LoadUnDirectAsync("SRegisterTag", StringKey_Url,
                   new KeyValuePair<string, object>("productSerial", productSerial),
                   new KeyValuePair<string, object>("productCode", productCode),
                   new KeyValuePair<string, object>("productCount", productCount),
                   new KeyValuePair<string, object>("epcList", epcList),
                   new KeyValuePair<string, object>("username", username),
                    new KeyValuePair<string, object>("deviceIp", "0"),
                   new KeyValuePair<string, object>("deviceId", "0"),
                   new KeyValuePair<string, object>("RegisterProperties", ""));


                if (result == null || !result.Contains("successful"))
                    return false;


                if ((bool)result["successful"])
                {
                    return result.Contains("value") && (bool)result["value"];
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
                return false;
            }
        }



 

        internal async Task<List<ProductStatus>> GetAllProductStatus()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetAllProductStatus_winapp", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""),
                new KeyValuePair<string, object>("haveNotSelect", false));
            if ((bool)result["successful"])
            {
                var list = new List<ProductStatus>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new ProductStatus()
                    {
                        ProductStatusCode = items["Code"].ToString(),
                        ProductStatusTitle = (items["Title"] != null) ? items["Title"].ToString() : " "

                    });
                }
                return list;
            }
            else
                return null;
        }
        internal async Task<List<ProductType>>  GetAllProductType()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetAllProductType", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""),
                new KeyValuePair<string, object>("haveNotSelect", false));
            if ((bool)result["successful"])
            {
                var list = new List<ProductType>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new ProductType()
                    {
                        ProductTypeCode = items["Code"].ToString(),
                        ProductTypeTitle = (items["Title"] != null) ? items["Title"].ToString() : " "

                    });
                }
                return list;
            }
            else
                return null;
        }
        internal async Task<List<ProductPropertyC>>  GetAllProductPropertyC()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetAllProductPropertyC", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""),
                new KeyValuePair<string, object>("haveNotSelect", false));
            if ((bool)result["successful"])
            {
                var list = new List<ProductPropertyC>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new ProductPropertyC()
                    {
                        ProductPropertyC_Id = items["Code"].ToString(),
                        ProductPropertyC_Title = (items["Title"] != null) ? items["Title"].ToString() : " "

                    });
                }
                return list;
            }
            else
                return null;
        }



        internal async Task<List<Print>> GetPrintDataByByProductSerial(string ProductSerial)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetPrintDataByProductSerial", StringKey_Url,
                new KeyValuePair<string, object>("ProductSerial", ProductSerial), new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {
                var list = new List<Print>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new DML.Print()
                    {

                        Id = Convert.ToInt32(items["Id"].ToString()),
                        ProductSerial = (items["ProductSerial"] != null) ? items["ProductSerial"].ToString() : " ",
                        ProductCode = (items["ProductCode"] != null) ? items["ProductCode"].ToString() : " ",
                        ProductTitle = (items["ProductName"] != null) ? items["ProductName"].ToString() : " ",
                        ProductENTitle = (items["ProductENTitle"] != null) ? items["ProductENTitle"].ToString() : " ",
                        ProductDescription = (items["ProductDescription"] != null) ? items["ProductDescription"].ToString() : " ",
                        ProductTypeTitle = (items["ProductTypeTitle"] != null) ? items["ProductTypeTitle"].ToString() : " ",
                        ProductCount = (items["ProductCount"] != null) ? Convert.ToDecimal(items["ProductCount"].ToString()) : 0,
                        ProductItemCount = (items["ProductItemCount"] != null) ? Convert.ToDecimal(items["ProductItemCount"].ToString()) : 0,
                        ProductCountInPack = (items["ProductCountInPack"] != null) ? Convert.ToDecimal(items["ProductCountInPack"].ToString()) : 0,
                        ProductUnit = (items["ProductUnit"] != null) ? items["ProductUnit"].ToString() : " ",
                        ProductSize = (items["ProductSize"] != null) ? items["ProductSize"].ToString() : " ",
                        ProductRegCode = (items["ProductRegCode"] != null) ? items["ProductRegCode"].ToString() : " ",
                        ProductStatusTitle = (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : " ",
                        ProductWeight = (items["ProductWeight"] != null) ? Convert.ToDecimal(items["ProductWeight"].ToString()) : 0,
                        ProductVolume = (items["ProductVolume"] != null) ? Convert.ToDecimal(items["ProductVolume"].ToString()) : 0,
                        ProjectCode = (items["ProjectCode"] != null) ? items["ProjectCode"].ToString() : " ",
                        ProductProductionLineTitle = (items["fld_ProductPropertyATitle"] != null) ? items["fld_ProductPropertyATitle"].ToString() : " ",
                        ProductProductionShiftTitle = (items["fld_ProductPropertyBTitle"] != null) ? items["fld_ProductPropertyBTitle"].ToString() : " ",
                        PrintType = (items["PrintType"] != null) ? items["PrintType"].ToString() : " ",
                        PrintUser = (items["PrintUser"] != null) ? items["PrintUser"].ToString() : " ",
                        PrintFlag = (items["PrintFlag"] != null) ? Convert.ToInt32(items["PrintFlag"].ToString()) : 0,
                        RegisterFlag = (items["RegisterFlag"] != null) ? ((Convert.ToBoolean(items["RegisterFlag"])==true)?1:0) : 0,
                        InputFileName = (items["InputFileName"] != null) ? items["InputFileName"].ToString() : " ",
                        PrintActionDateTime = (items["PrintActionDateTime"] != null) ? Convert.ToDateTime(items["PrintActionDateTime"].ToString()) : DateTime.Now,
                        ProductContractType = (items["ProductContractType"] != null) ? items["ProductContractType"].ToString() : "0",
                        ProductOldSerial = (items["ProductOldSerial"] != null) ? items["ProductOldSerial"].ToString() : "0",
                        DocumentId = (items["DocumentId"] != null) ? items["DocumentId"].ToString() : "0",
                        ProductTechnicalData = (items["ProductTechnicalData"] != null) ? items["ProductTechnicalData"].ToString() : ""
                        ,
                        TagEpc = (items["TagEpc"] != null) ? items["TagEpc"].ToString() : "",
                        ProductGroup = (items["ProductGroup"] != null) ? items["ProductGroup"].ToString() : "",
                        ProductBrand = (items["ProductBrand"] != null) ? items["ProductBrand"].ToString() : "",
                        ProductBrandTitle = (items["ProductBrandTitle"] != null) ? items["ProductBrandTitle"].ToString() : "",
                        ProductGroupTitle = (items["ProductGroupTitle"] != null) ? items["ProductGroupTitle"].ToString() : "",
                        ProductSizeTitle = (items["ProductSizeTitle"] != null) ? items["ProductSizeTitle"].ToString() : "",
                        ProductProperties = (items["ProductProperties"] != null) ? items["ProductProperties"].ToString() : "",
                        ProductProductionLine = (items["ProductProductionLine"] != null) ? items["ProductProductionLine"].ToString() : "",
                        ProductProductionShift = (items["ProductProductionShift"] != null) ? items["ProductProductionShift"].ToString() : ""


                    });
                }
                return list;
            }
            else
                return null;
        }



        internal async Task<List<Print>> GetPrintListByPrintActionId(string PrintActionId)
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SGetPrintListByPrintActionId", StringKey_Url,
                new KeyValuePair<string, object>("PrintActionId", PrintActionId), new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {
                var list = new List<DML.Print>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new DML.Print()
                    {

                        Id = Convert.ToInt32(items["Id"].ToString()),
                        ProductSerial = (items["ProductSerial"] != null) ? items["ProductSerial"].ToString() : " ",
                        ProductCode = (items["ProductCode"] != null) ? items["ProductCode"].ToString() : " ",
                        ProductTitle = (items["ProductName"] != null) ? items["ProductName"].ToString() : " ",
                        ProductENTitle= (items["ProductENTitle"] != null) ? items["ProductENTitle"].ToString() : " ",
                        ProductDescription = (items["ProductDescription"] != null) ? items["ProductDescription"].ToString() : " ",
                        ProductTypeTitle = (items["ProductTypeTitle"] != null) ? items["ProductTypeTitle"].ToString() : " ",
                        ProductCount = (items["ProductCount"] != null) ? Convert.ToDecimal(items["ProductCount"].ToString()) : 0,
                        ProductItemCount = (items["ProductItemCount"] != null) ? Convert.ToDecimal(items["ProductItemCount"].ToString()) : 0,
                        ProductCountInPack = (items["ProductCountInPack"] != null) ? Convert.ToDecimal(items["ProductCountInPack"].ToString()) : 0,
                        ProductUnit = (items["ProductUnit"] != null) ? items["ProductUnit"].ToString() : " ",
                        ProductSize = (items["ProductSize"] != null) ? items["ProductSize"].ToString() : " ",
                        ProductRegCode = (items["ProductRegCode"] != null) ? items["ProductRegCode"].ToString() : " ",
                        ProductStatusTitle = (items["ProductStatusTitle"] != null) ? items["ProductStatusTitle"].ToString() : " ",
                        ProductWeight = (items["ProductWeight"] != null) ? Convert.ToDecimal(items["ProductWeight"].ToString()) : 0,
                        ProductVolume = (items["ProductVolume"] != null) ? Convert.ToDecimal(items["ProductVolume"].ToString()) : 0,
                        ProjectCode = (items["ProjectCode"] != null) ? items["ProjectCode"].ToString() : " ",

                        ProductProductionLineTitle = (items["fld_ProductPropertyATitle"] != null) ? items["fld_ProductPropertyATitle"].ToString() : " ",
                        ProductProductionShiftTitle = (items["fld_ProductPropertyBTitle"] != null) ? items["fld_ProductPropertyBTitle"].ToString() : " ",
                        PrintType = (items["PrintType"] != null) ? items["PrintType"].ToString() : " ",
                        PrintUser = (items["PrintUser"] != null) ? items["PrintUser"].ToString() : " ",
                        PrintFlag = (items["PrintFlag"] != null) ? Convert.ToInt32(items["PrintFlag"].ToString()) : 0,
                        RegisterFlag = (items["RegisterFlag"] != null) ? ((Convert.ToBoolean( items["RegisterFlag"].ToString())==true)?1:0) : 0,
                        InputFileName = (items["InputFileName"] != null) ? items["InputFileName"].ToString() : " ",
                        PrintActionDateTime = (items["PrintActionDateTime"] != null) ? Convert.ToDateTime(items["PrintActionDateTime"].ToString()) : DateTime.Now,
                        ProductContractType=(items["ProductContractType"] != null) ? items["ProductContractType"].ToString() : "0",
                        ProductOldSerial=(items["ProductOldSerial"] != null) ? items["ProductOldSerial"].ToString() : "0",
                        DocumentId=(items["DocumentId"] != null) ? items["DocumentId"].ToString() : "0",
                        ProductTechnicalData=(items["ProductTechnicalData"] != null) ? items["ProductTechnicalData"].ToString() : ""
                        ,TagEpc=(items["TagEpc"] != null) ? items["TagEpc"].ToString() : "",
                        ProductGroup = (items["ProductGroup"] != null) ? items["ProductGroup"].ToString() : "",
                        ProductBrand = (items["ProductBrand"] != null) ? items["ProductBrand"].ToString() : "",
                        ProductBrandTitle= (items["ProductBrandTitle"] != null) ? items["ProductBrandTitle"].ToString() : "",
                        ProductGroupTitle=(items["ProductGroupTitle"] != null) ? items["ProductGroupTitle"].ToString() : "",
                        ProductSizeTitle = (items["ProductSizeTitle"] != null) ? items["ProductSizeTitle"].ToString() : "",
                        ProductProperties = (items["ProductProperties"] != null) ? items["ProductProperties"].ToString() : "",
                        ProductProductionLine= (items["ProductProductionLine"] != null) ? items["ProductProductionLine"].ToString() : "",
                        ProductProductionShift = (items["ProductProductionShift"] != null) ? items["ProductProductionShift"].ToString() : ""
 
                    });
                }
                return list;
            }
            else
                return null;
        }

        internal async Task<bool> PrintUpdatePrintStatus( string productSerial)
        {
            var result =    await WorkingWithApiConnector.LoadUnDirectAsync("PrintUpdatePrintStatus", StringKey_Url,
                new KeyValuePair<string, object>("productSerial", productSerial ));



            if ((bool)result["successful"])
                return (bool)result["value"];
            else
                return false;
        }

        internal async Task<bool> CancelRegisterTag(string TagEpc,string username )
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("SCancelRegisterTag", StringKey_Url,
                new KeyValuePair<string, object>("TagEpc", TagEpc),
                 new KeyValuePair<string, object>("username", username),
                  new KeyValuePair<string, object>("deviceId", "0"),
                   new KeyValuePair<string, object>("deviceIp", "0"));

            if ((bool)result["successful"])
                return (bool)result["value"];
            else
                return false;
        }

        internal async Task<List<ProductionLine>> GetAllProductionLine()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("GetAllProductPropertyAData", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {
                var list = new List<ProductionLine>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new ProductionLine()
                    {
                        ProductionLineCode= items["fld_ProductPropertyAId"].ToString(),
                        ProductionLineTitle = (items["fld_ProductPropertyATitle"] != null) ? items["fld_ProductPropertyATitle"].ToString() : " "

                    });
                }
                return list;
            }
            else
                return null;
        }

        internal async Task<List<ProductionShift>> GetAllProductionShift()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("GetAllProductPropertyBData", StringKey_Url,
                new KeyValuePair<string, object>("userToken", ""));
            if ((bool)result["successful"])
            {
                var list = new List<ProductionShift>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new ProductionShift()
                    {
                        ProductionShiftCode = items["fld_ProductPropertyBId"].ToString(),
                        ProductionShiftTitle = (items["fld_ProductPropertyBTitle"] != null) ? items["fld_ProductPropertyBTitle"].ToString() : " "

                    });
                }
                return list;
            }
            else
                return null;
        }
        internal async Task<List<User>> GetAllUser()
        {
            var result = await WorkingWithApiConnector.LoadUnDirectAsync("GetAllUser", StringKey_Url,
                new KeyValuePair<string, object>("userToken", DataAccess.Items.OnlineUserCode));
            if ((bool)result["successful"])
            {
                var list = new List<User>();
                foreach (JToken items in result["value"])
                {
                    list.Add(new User()
                    {
                        UserId = items["Id"].ToString(),
                        UserName = (items["Username"] != null) ? items["Username"].ToString() : " ",
                        UserType = "1"

                    });
                }
                return list;
            }
            else
                return null;
        }
 
    }
}
