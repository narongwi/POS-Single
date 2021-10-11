using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BJCBCPOS.Services.Helpers {
    public class SqlParams : IDisposable {
        public string name { get; set; }
        public object value { get; set; }
        private bool disposedValue;

        private List<SqlParams> _params { get; set; }

        public SqlParams[] Values {
            get { return _params.ToArray(); }
        }
        public SqlParams() {
            _params = new List<SqlParams>();
        }
        public SqlParams(string name_,object value_) {
            name = name_; value = value_;
            _params = new List<SqlParams>();
        }
        public void add(string name_,object value_) {
            if(_params.Any(x => x.name == name_)) _params.Remove(_params.Find(x => x.name.Equals(name_)));
            if(value_.GetType() == typeof(string)) { value_ = string.IsNullOrEmpty(value_.ToString()) ? null : value_; }
            if(value_ == null) value_ = DBNull.Value;
            _params.Add(new SqlParams(name_,value_));
        }
        public void map(object value_,string name_) {
            if(value_ == null) value_ = DBNull.Value;
            if(_params.Any(x => x.name == name_)) _params.Remove(_params.Find(x => x.name.Equals(name_)));
            if(value_.GetType() == typeof(string)) { value_ = string.IsNullOrEmpty(value_.ToString()) ? null : value_; }
            if(value_ == null) value_ = DBNull.Value;
            _params.Add(new SqlParams(name_,value_));
        }
        protected virtual void Dispose(bool disposing) {
            if(!disposedValue) {
                if(disposing) {
                    _params.Clear();
                    _params = null;
                }
                disposedValue = true;
            }
        }
        public void Dispose() {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
