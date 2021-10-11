using BJCBCPOS_Data;
using BJCBCPOS_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJCBCPOS_Process {
    public class BigServiceProcess {
        public BigServices command = new BigServices(ProgramConfig.connectionString);
        public string BPS_WebService(string serviceName,string reqBody) {
            try {
                return command.BPS_WebService(serviceName,reqBody);
            } catch(NetworkConnectionException nx) {
                AppLog.writeLog("connection to server lost at BillPaymentProcess.BPS_WebService");
                throw nx;
            } catch(Exception ex) {
                AppLog.writeLog(ex);
                throw ex;
            }
        }
    }
}
