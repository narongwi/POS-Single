namespace BJCBCPOS.Services.Forms
{
    partial class frmParcelSubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParcelSubMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucHeader1 = new BJCBCPOS.UCHeader();
            this.ucFooter1 = new BJCBCPOS.UCFooter();
            this.label27 = new System.Windows.Forms.Label();
            this.lb_PageTotal = new System.Windows.Forms.Label();
            this.lb_PageNo = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ucButtonPayment2 = new BJCBCPOS.UCButtonPayment();
            this.ucButtonPayment4 = new BJCBCPOS.UCButtonPayment();
            this.ucButtonPayment3 = new BJCBCPOS.UCButtonPayment();
            this.ucButtonPayment1 = new BJCBCPOS.UCButtonPayment();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbProductAndServices = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.ucButtonPayment2);
            this.panel2.Controls.Add(this.ucButtonPayment4);
            this.panel2.Controls.Add(this.ucButtonPayment3);
            this.panel2.Controls.Add(this.ucButtonPayment1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(62, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 540);
            this.panel2.TabIndex = 9;
            // 
            // ucHeader1
            // 
            this.ucHeader1.alertEnabled = true;
            this.ucHeader1.alertFunctionID = null;
            this.ucHeader1.alertStatus = false;
            this.ucHeader1.BackColor = System.Drawing.Color.Transparent;
            this.ucHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHeader1.currentMenuTitle1 = "เมนูหลัก";
            this.ucHeader1.currentMenuTitle2 = "รับ - ส่งพัสดุ";
            this.ucHeader1.currentMenuTitle3 = "เคอรี่ เอ็กซ์เพลส";
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucHeader1.logoutText = "ออกจากระบบ";
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.nameText = "ชื่อสมาชิก";
            this.ucHeader1.nameVisible = false;
            this.ucHeader1.showAlert = true;
            this.ucHeader1.showCalculator = true;
            this.ucHeader1.showCurrentMenuText = true;
            this.ucHeader1.showHamberGetItm = true;
            this.ucHeader1.showLanguage = true;
            this.ucHeader1.showLine = true;
            this.ucHeader1.showLockScreen = true;
            this.ucHeader1.showLogout = false;
            this.ucHeader1.showMainMenu = true;
            this.ucHeader1.showMember = true;
            this.ucHeader1.showMember_ButtonBack = false;
            this.ucHeader1.showMember_IsSaveMember = true;
            this.ucHeader1.showScanner = true;
            this.ucHeader1.Size = new System.Drawing.Size(1024, 43);
            this.ucHeader1.TabIndex = 10;
            // 
            // ucFooter1
            // 
            this.ucFooter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(53)))));
            this.ucFooter1.Location = new System.Drawing.Point(0, 726);
            this.ucFooter1.Name = "ucFooter1";
            this.ucFooter1.Size = new System.Drawing.Size(1024, 40);
            this.ucFooter1.TabIndex = 121;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label27.ForeColor = System.Drawing.Color.Gray;
            this.label27.Location = new System.Drawing.Point(565, 677);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 29);
            this.label27.TabIndex = 133;
            this.label27.Text = "/";
            // 
            // lb_PageTotal
            // 
            this.lb_PageTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_PageTotal.ForeColor = System.Drawing.Color.Gray;
            this.lb_PageTotal.Location = new System.Drawing.Point(587, 677);
            this.lb_PageTotal.Name = "lb_PageTotal";
            this.lb_PageTotal.Size = new System.Drawing.Size(40, 29);
            this.lb_PageTotal.TabIndex = 134;
            this.lb_PageTotal.Text = "1";
            this.lb_PageTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PageNo
            // 
            this.lb_PageNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_PageNo.ForeColor = System.Drawing.Color.Gray;
            this.lb_PageNo.Location = new System.Drawing.Point(521, 677);
            this.lb_PageNo.Name = "lb_PageNo";
            this.lb_PageNo.Size = new System.Drawing.Size(40, 29);
            this.lb_PageNo.TabIndex = 132;
            this.lb_PageNo.Text = "1";
            this.lb_PageNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label28.ForeColor = System.Drawing.Color.Gray;
            this.label28.Location = new System.Drawing.Point(399, 677);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(114, 29);
            this.label28.TabIndex = 131;
            this.label28.Text = "Page No.";
            // 
            // btn_Next
            // 
            this.btn_Next.BackgroundImage = global::BJCBCPOS.Properties.Resources.btn_next;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Location = new System.Drawing.Point(897, 659);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(49, 58);
            this.btn_Next.TabIndex = 130;
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackgroundImage = global::BJCBCPOS.Properties.Resources.btn_previous;
            this.btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Previous.FlatAppearance.BorderSize = 0;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Location = new System.Drawing.Point(95, 661);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(49, 56);
            this.btn_Previous.TabIndex = 129;
            this.btn_Previous.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BJCBCPOS.Properties.Resources.KerrySCL;
            this.pictureBox4.Location = new System.Drawing.Point(629, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(230, 127);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BJCBCPOS.Properties.Resources.KerryCOD;
            this.pictureBox2.Location = new System.Drawing.Point(335, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BJCBCPOS.Properties.Resources.KerryExpress1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BJCBCPOS.Properties.Resources.KerryDropOff;
            this.pictureBox7.Location = new System.Drawing.Point(42, 334);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(230, 127);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // ucButtonPayment2
            // 
            this.ucButtonPayment2.BackColor = System.Drawing.Color.White;
            this.ucButtonPayment2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButtonPayment2.BackgroundImage")));
            this.ucButtonPayment2.Location = new System.Drawing.Point(25, 321);
            this.ucButtonPayment2.Name = "ucButtonPayment2";
            this.ucButtonPayment2.Size = new System.Drawing.Size(265, 200);
            this.ucButtonPayment2.TabIndex = 12;
            this.ucButtonPayment2.TextButton = "Merchant Drop Off";
            // 
            // ucButtonPayment4
            // 
            this.ucButtonPayment4.BackColor = System.Drawing.Color.White;
            this.ucButtonPayment4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButtonPayment4.BackgroundImage")));
            this.ucButtonPayment4.Location = new System.Drawing.Point(611, 98);
            this.ucButtonPayment4.Name = "ucButtonPayment4";
            this.ucButtonPayment4.Size = new System.Drawing.Size(265, 200);
            this.ucButtonPayment4.TabIndex = 11;
            this.ucButtonPayment4.TextButton = "SCL";
            // 
            // ucButtonPayment3
            // 
            this.ucButtonPayment3.BackColor = System.Drawing.Color.White;
            this.ucButtonPayment3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButtonPayment3.BackgroundImage")));
            this.ucButtonPayment3.Location = new System.Drawing.Point(320, 98);
            this.ucButtonPayment3.Name = "ucButtonPayment3";
            this.ucButtonPayment3.Size = new System.Drawing.Size(265, 200);
            this.ucButtonPayment3.TabIndex = 10;
            this.ucButtonPayment3.TextButton = "เก็บเงินปลายทาง (COD)";
            // 
            // ucButtonPayment1
            // 
            this.ucButtonPayment1.BackColor = System.Drawing.Color.White;
            this.ucButtonPayment1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucButtonPayment1.BackgroundImage")));
            this.ucButtonPayment1.Location = new System.Drawing.Point(28, 98);
            this.ucButtonPayment1.Name = "ucButtonPayment1";
            this.ucButtonPayment1.Size = new System.Drawing.Size(265, 200);
            this.ucButtonPayment1.TabIndex = 8;
            this.ucButtonPayment1.TextButton = "พัสดุปกติ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.panel1.BackgroundImage = global::BJCBCPOS.Properties.Resources.Rectangle_260_3x;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lbProductAndServices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::BJCBCPOS.Properties.Resources.arrow_white_left;
            this.btnBack.Location = new System.Drawing.Point(10, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 56);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lbProductAndServices
            // 
            this.lbProductAndServices.BackColor = System.Drawing.Color.Transparent;
            this.lbProductAndServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductAndServices.ForeColor = System.Drawing.Color.White;
            this.lbProductAndServices.Location = new System.Drawing.Point(3, 5);
            this.lbProductAndServices.Name = "lbProductAndServices";
            this.lbProductAndServices.Size = new System.Drawing.Size(895, 65);
            this.lbProductAndServices.TabIndex = 2;
            this.lbProductAndServices.Text = "เคอรี่ เอ็กซ์เพลส";
            this.lbProductAndServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmParcelSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lb_PageTotal);
            this.Controls.Add(this.lb_PageNo);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.ucFooter1);
            this.Controls.Add(this.ucHeader1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParcelSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmParcelSubMenu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private UCButtonPayment ucButtonPayment2;
        private UCButtonPayment ucButtonPayment4;
        private UCButtonPayment ucButtonPayment3;
        private UCButtonPayment ucButtonPayment1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbProductAndServices;
        private UCHeader ucHeader1;
        private UCFooter ucFooter1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lb_PageTotal;
        private System.Windows.Forms.Label lb_PageNo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
    }
}