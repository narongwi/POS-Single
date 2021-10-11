using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
namespace BJCBCPOS.Services.Helpers {
    public static class Conversion {
        public static int toInt(this object Value) {
            try {
                if(Value == DBNull.Value)
                    return 0;
                if(Value == null)
                    return 0;

                int OutVal;
                int.TryParse(Value.ToString(),out OutVal);
                return OutVal;
            } catch(Exception) {
                return 0;
            }

        }
        public static decimal toDecimal(this object Value) {
            try {
                if(Value == DBNull.Value)
                    return 0;
                if(Value == null)
                    return 0;
                decimal OutVal;
                decimal.TryParse(Value.ToString(),out OutVal);
                return OutVal;
            } catch(Exception) {
                return 0;
            }
        }
        public static double toDouble(this object Value) {
            try {
                if(Value == DBNull.Value)
                    return 0;

                double OutVal;
                double.TryParse(Value.ToString(),out OutVal);
                return OutVal;
            } catch(Exception) {
                return 0;
            }
        }
        public static string SetDecimal(this double doubleNumber,int decimalPoint) {
            string format = string.Format("F{0}",decimalPoint);
            return doubleNumber.ToString(format,System.Globalization.CultureInfo.InvariantCulture);
        }
        public static string LimitString(this string Value,int limitLength) {
            if(string.IsNullOrEmpty(Value)) {
                return "";
            } else {
                if(Value.Length > limitLength)
                    return Value.Substring(0,limitLength).Replace("'","").Replace("&","");

                return Value.Replace("'","").Replace("&","");
            }
        }
        public static int GetDecimalPlace(object decimal_number) {
            try {
                string decimal_places = "";
                string input_decimal_number = decimal_number.ToString();
                var regex = new System.Text.RegularExpressions.Regex("(?<=[\\.])[0-9]+");
                if(regex.IsMatch(input_decimal_number))
                    decimal_places = regex.Match(input_decimal_number).Value;
                return toInt(decimal_places);
            } catch(Exception) {
                throw;
            }

        }
        /// <summary>
        /// Convert String to Datetime and Set format
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime toDate(this string dateTime,string format) {
            DateTime outDate;
            DateTime.TryParseExact(dateTime,format,CultureInfo.InvariantCulture,DateTimeStyles.None,out outDate);
            return outDate;
        }
        // function that creates a list of an object from the given data table
        public static T toObj<T>(this DataTable dt) where T : new() {
            return getFromRow<T>(dt.Rows[0]);
        }
        // function that creates a list of an object from the given data table
        public static List<T> toList<T>(this DataTable dt) where T : new() {
            // define return list
            List<T> lst = new List<T>();

            // go through each row
            foreach(DataRow r in dt.Rows) {
                // add to the list
                lst.Add(getFromRow<T>(r));
            }

            // return the list
            return lst;
        }
        // function that creates an object from the given data row
        public static T getFromRow<T>(DataRow row) where T : new() {
            // create a new object
            T item = new T();

            // set the item
            setFromRow(item,row);

            // return 
            return item;
        }

        public static void setFromRow<T>(T item,DataRow row) where T : new() {
            // go through each column
            foreach(DataColumn c in row.Table.Columns) {
                // find the property for the column
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // if exists, set the value
                if(p != null && row[c] != DBNull.Value) {
                    p.SetValue(item,row[c],null);
                }
            }
        }
    }
}
