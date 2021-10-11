using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BJCBCPOS.Services.Forms {
    public partial class frmBillPayment : Form {
        public frmBillPayment() {
            InitializeComponent();
        }

        private void frmBillPayment_Load(object sender,EventArgs e) {
            dgvBillEditor.Rows.Add("Ref 1","01060523903","STR","");
            dgvBillEditor.Rows.Add("Ref 2","01","STR","");
            dgvBillEditor.Rows.Add("จำนวนเงินที่รับชำระ","7000.00","NUM","");
            dgvBillEditor.Rows.Add("เบอร์ติดต่อ","0847551420","text","^[0-9]{1,10}$");
            dgvBillEditor.Rows.Add("เลขบัตรประชาชนผู้ชำระ","1311400011452","STR","^[0-9]{13,13}$");

            dgvDetail.Rows.Add("บริษัท แบทเตอร์เวย์","Mpower","01060523903","681.00","5.00","กำลังทำรายการ");
            dgvDetail.Rows[0].HeaderCell.Value = "1";
            for(int i = 2 ; i < 11 ; i++) {
                dgvDetail.Rows.Add();
                dgvDetail.Rows[i-1].HeaderCell.Value = i.ToString();
            }
            lblTotalAmt.Text = "681.00";
            lblTotalFee.Text = "5.00";

        }
    }
}
