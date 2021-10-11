using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BJCBCPOS.Services.Helpers {
    public sealed class StringExt {
        public static string StringFromLeft(string strTmp,int strLength) {
            if((strLength > 0 && strTmp.Length >= strLength)) {
                return strTmp.Substring(0,strLength);
            } else {
                return strTmp;
            }
        }

        public static string StringFromRight(string strTmp,int strLength) {
            if((strLength > 0 && strTmp.Length >= strLength)) {
                return strTmp.Substring(strTmp.Length - strLength,strLength);
            } else {
                return strTmp;
            }
        }
    }
}
