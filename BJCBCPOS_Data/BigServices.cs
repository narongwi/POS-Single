using BJCBCPOS_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BJCBCPOS_Data {
    public class BigServices : SqlCommand {
        private DBConnect db = null;
        public BigServices(string connectionString) : base(connectionString) {
            try {
                db = new DBConnect(connectionString);
            } catch(NetworkConnectionException ex) {
                AppLog.writeLog(ex);
                throw ex;
            }
        }
        /// <summary>
        ///  Call Web Api With XML Format
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="reqBody"></param>
        /// <returns></returns>
        public string BPS_WebService(string serviceName,string reqBody) {
            try {
                db.SetCommandStoredProcedure("[dbo].[BPS_CallService]");
                db.AddInputParameter("serviceName",SqlDbType.VarChar,serviceName);
                db.AddInputParameter("reqBody",SqlDbType.NVarChar,reqBody);
                var dt = db.ExecuteToDataTable();
                if(dt.Rows.Count == 0)
                    throw new Exception("Service Group Notfound");

                return dt.Rows[0][0].ToString();
            } catch(NetworkConnectionException ex) {
                AppLog.writeLog(ex);
                throw ex;
            } 
        }

        private bool disposedValue;

        protected virtual void Dispose(bool disposing) {
            if(!disposedValue) {
                if(disposing) {
                    // TODO: dispose managed state (managed objects)
                    db = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~PaymentCommand()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose() {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
