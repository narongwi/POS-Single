using BJCBCPOS.Services.Classes;
using BJCBCPOS.Services.Controls;
using BJCBCPOS.Services.ServiceXml.ServiceType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BJCBCPOS.Services.Forms {

    public partial class frmBigService : Form {
        private int pageTotal = 0;
        private int pageActive = 0;
        private int pageMaxItem = 3;
        private List<ServiceType> serviceTypes;
        public BigServices bsv = new BigServices();

        public frmBigService() {
            InitializeComponent();
        }

        ImageList imageListM = new ImageList();
        string[] imgfileM = new string[] { };
        string[] menuIDM = new string[] { };
        string[] menuNameM = new string[] { };
        DataTable dt = new DataTable();

        private void ListMenu() {
            var svtype = bsv.listServiceTypes();
            serviceTypes = new List<ServiceType>();
            serviceTypes = svtype.ServiceTypeList.ServiceType;
            pageTotal = serviceTypes.Count <= pageMaxItem ? 1 : (int)Math.Ceiling(serviceTypes.Count / Convert.ToDouble(pageMaxItem));
            pageActive = 1;
            lb_PageNo.Text = "1";
            lb_PageTotal.Text = pageTotal.ToString();
            RanderMenu(1);
        }

        private void RanderMenu(int page) {
            int btnX = 0, btnY = 0;
            int btnWidth = 240, btnHeight = 200;
            int btnMax = 2, btnCnt = 0;
            int curWidth = 0, curHeight = 0;
            int idxStart= (page * pageMaxItem) - pageMaxItem;
            int idxRange = serviceTypes.Count - idxStart;
            int idxEnd = idxRange >= pageMaxItem ? pageMaxItem : idxRange;
            pnlMenus.Controls.Clear();
            foreach(ServiceType item in serviceTypes.GetRange(idxStart,idxEnd)) {
                CustomButton btn = new CustomButton();
                btn.Size = new Size(btnWidth,btnHeight);
                btn.Location = new Point(btnX,btnY);
                btn.BackColor = Color.FromArgb(63,184,105);
                btn.Text = item.Name;
                btn.Tag = item;
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.IconType = Fonts.POSIcons.TagTextOutline;
                btn.IconSize = 50;
                btn.IconColor = Color.White;
                btn.ShowIcon = true;
                btn.Padding = new Padding(0,40,0,40);
                btn.BorderSize = 0;
                btn.BorderRadius = 8;
                btn.Click += Menu_Click;
                pnlMenus.Controls.Add(btn);
                // next button
                curWidth = curWidth + btnWidth + 40;
                btnX = curWidth;
                btnCnt++;

                // next row
                if(btnCnt > btnMax) {
                    btnCnt = 0;
                    curWidth = 0;
                    curHeight = curHeight + btnHeight + 40;
                    btnX = 0;
                    btnY = curHeight;
                }
            }

            //for(int i = 0 ; i < 6 ; i++) {
            //    CustomButton btn = new CustomButton();
            //    btn.Size = new Size(btnWidth,btnHeight);
            //    btn.Location = new Point(btnX,btnY);
            //    btn.BackColor = Color.FromArgb(63,184,105);
            //    btn.Text = $"Button {i}";
            //    btn.ForeColor = Color.White;
            //    btn.TextAlign = ContentAlignment.BottomCenter;
            //    btn.ImageAlign = ContentAlignment.TopCenter;
            //    btn.IconType = Fonts.POSIcons.TagTextOutline;
            //    btn.IconSize = 50;
            //    btn.IconColor = Color.White;
            //    btn.ShowIcon = true;
            //    btn.Padding = new Padding(0,40,0,40);
            //    btn.BorderSize = 0;
            //    btn.BorderRadius = 8;
            //    pnlMenus.Controls.Add(btn);

            //    // next button
            //    curWidth = curWidth + btnWidth + 40;
            //    btnX = curWidth;
            //    btnCnt++;

            //    // next row
            //    if(btnCnt > btnMax) {
            //        btnCnt = 0;
            //        curWidth = 0;
            //        curHeight = curHeight + btnHeight + 40;
            //        btnX = 0;
            //        btnY = curHeight;
            //    }
            //}
        }

        private void Menu_Click(object sender,EventArgs e) {
            var btn = (CustomButton)sender;
            var svt = btn.Tag as ServiceType;
            BigServiceShared.ServiceTypeId = svt.Id;
            BigServiceShared.ServiceTypeName = svt.Name;
            BigServiceShared.ServiceTypeSeq = svt.Seq;
            MessageBox.Show(svt.Name);
        }

        private void BigService_Load(object sender,EventArgs e) {
            ListMenu();
        }
        private void button1_Click(object sender,EventArgs e) {
            MessageBox.Show("Back to Main Menu","Warning"); 
            Environment.Exit(0);
        }

        private void btn_Next_Click(object sender,EventArgs e) {
            if(pageActive < pageTotal) {
                pageActive++;
                RanderMenu(pageActive);
                lb_PageNo.Text = pageActive.ToString();
                if(pageActive == pageTotal) {
                    btn_Next.Enabled = false;
                    btn_Previous.Enabled = true;
                }
            }
        }

        private void btn_Previous_Click(object sender,EventArgs e) {
            if(pageActive > 1) {
                pageActive--;
                RanderMenu(pageActive);
                lb_PageNo.Text = pageActive.ToString();
                if(pageActive == 1) {
                    btn_Previous.Enabled = false;
                    btn_Next.Enabled = true;
                } 
            }
        }
    }
}
