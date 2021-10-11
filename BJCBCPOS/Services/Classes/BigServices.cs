using BJCBCPOS.Services.Enum;
using BJCBCPOS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BJCBCPOS.Services.Helpers;
using BJCBCPOS_Process;

namespace BJCBCPOS.Services.Classes {
    public class BigServices  {
        public ServiceXml.ServiceType.ServiceTypeResp listServiceTypes() {
            var response = new ServiceXml.ServiceType.ServiceTypeResp();
            var request = new ServiceXml.ServiceType.ServiceTypeReq();
            request.StoreCode = ProgramConfig.storeCode;
            request.LocNo = ProgramConfig.tillNo;
            request.CashierId = "300008";
            request.ControlRef = "F00800002";
            var ws = new BigServiceProcess();
            var st = ServiceNames.queryServiceType.ToString();
            var rs = ws.BPS_WebService(st,request.SerializeObject());
            return rs.DeserializeFromString(response);
        }

        public ServiceXml.ServiceGroup.ServiceGroupResp listServiceGroups(string serviceType) {
            var response = new ServiceXml.ServiceGroup.ServiceGroupResp();
            var request = new ServiceXml.ServiceGroup.ServiceGroupReq();
            request.StoreCode = ProgramConfig.storeCode;
            request.LocNo = ProgramConfig.tillNo;
            request.CashierId = "300008";
            request.ControlRef = "F00800002";
            request.ServiceType = serviceType;
            var ws = new BigServiceProcess();
            var st = ServiceNames.queryServiceGroup.ToString();
            var rs = ws.BPS_WebService(st,request.SerializeObject());
            return rs.DeserializeFromString(response);
        }
    }
}
