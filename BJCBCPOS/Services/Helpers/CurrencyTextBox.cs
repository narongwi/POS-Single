using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BJCBCPOS.Services.Helpers {
    class CurrencyTextBox {
        public static bool CurrencyOnly(TextBox TargetTextBox,char CurrentChar) {
            if((int)CurrentChar >= 48 && (int)CurrentChar <= 57) {
                return false;
            }

            if(Convert.ToString(CurrentChar) == "." && TargetTextBox.Text.IndexOf(".") == -1) {
                return false;
            }

            if(CurrentChar == Convert.ToChar(Keys.Back)) {
                return false;
            }

            return true;
        }
    }
}
//Using
//private void txtCash_KeyPress(object sender,KeyPressEventArgs e) {
//    e.Handled = CurrencyTextBox.CurrencyOnly(txtCash,e.KeyChar);
//}
