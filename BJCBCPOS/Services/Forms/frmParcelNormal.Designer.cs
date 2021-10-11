namespace BJCBCPOS.Services.Forms
{
    partial class frmParcelNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParcelNormal));
            this.ucFooter1 = new BJCBCPOS.UCFooter();
            this.ucHeader1 = new BJCBCPOS.UCHeader();
            this.ucKeypad = new BJCBCPOS.UCKeypad();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbProductAndServices = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInputMember = new System.Windows.Forms.Panel();
            this.ucTextBoxWithIcon2 = new BJCBCPOS.UCTextBoxWithIcon();
            this.ucDDLLanguage = new BJCBCPOS.UCDropDownList();
            this.ucTextBoxWithIcon1 = new BJCBCPOS.UCTextBoxWithIcon();
            this.label5 = new System.Windows.Forms.Label();
            this.ucTBFirstname = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbCitizenID = new System.Windows.Forms.Label();
            this.panelInputAddress = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucTextBoxWithIcon3 = new BJCBCPOS.UCTextBoxWithIcon();
            this.ucTextBoxWithIcon5 = new BJCBCPOS.UCTextBoxWithIcon();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucDropDownList1 = new BJCBCPOS.UCDropDownList();
            this.ucTextBoxWithIcon6 = new BJCBCPOS.UCTextBoxWithIcon();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelInputMember.SuspendLayout();
            this.panelInputAddress.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucFooter1
            // 
            this.ucFooter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(53)))));
            this.ucFooter1.Location = new System.Drawing.Point(1, 728);
            this.ucFooter1.Name = "ucFooter1";
            this.ucFooter1.Size = new System.Drawing.Size(1024, 40);
            this.ucFooter1.TabIndex = 125;
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
            this.ucHeader1.currentMenuTitle3 = "เคอรี่ เอ็กเพลส";
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
            this.ucHeader1.TabIndex = 120;
            // 
            // ucKeypad
            // 
            this.ucKeypad.Location = new System.Drawing.Point(688, 426);
            this.ucKeypad.Name = "ucKeypad";
            this.ucKeypad.Size = new System.Drawing.Size(336, 296);
            this.ucKeypad.TabIndex = 121;
            this.ucKeypad.ucTBS = null;
            this.ucKeypad.ucTBWI = null;
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
            this.lbProductAndServices.Size = new System.Drawing.Size(856, 65);
            this.lbProductAndServices.TabIndex = 2;
            this.lbProductAndServices.Text = "พัสดุปกติ";
            this.lbProductAndServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.panel1.BackgroundImage = global::BJCBCPOS.Properties.Resources.Rectangle_260_3x;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lbProductAndServices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 75);
            this.panel1.TabIndex = 126;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BJCBCPOS.Properties.Resources.KerryExpress1;
            this.pictureBox2.Location = new System.Drawing.Point(865, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // panelInputMember
            // 
            this.panelInputMember.AutoScroll = true;
            this.panelInputMember.BackColor = System.Drawing.Color.White;
            this.panelInputMember.Controls.Add(this.ucTextBoxWithIcon2);
            this.panelInputMember.Controls.Add(this.ucDDLLanguage);
            this.panelInputMember.Controls.Add(this.ucTextBoxWithIcon1);
            this.panelInputMember.Controls.Add(this.label5);
            this.panelInputMember.Controls.Add(this.ucTBFirstname);
            this.panelInputMember.Controls.Add(this.lbFirstname);
            this.panelInputMember.Controls.Add(this.lbLanguage);
            this.panelInputMember.Controls.Add(this.lbCitizenID);
            this.panelInputMember.Location = new System.Drawing.Point(1, 172);
            this.panelInputMember.Name = "panelInputMember";
            this.panelInputMember.Size = new System.Drawing.Size(685, 216);
            this.panelInputMember.TabIndex = 127;
            // 
            // ucTextBoxWithIcon2
            // 
            this.ucTextBoxWithIcon2.BackColor = System.Drawing.Color.White;
            this.ucTextBoxWithIcon2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBoxWithIcon2.BackgroundImage")));
            this.ucTextBoxWithIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxWithIcon2.EnabledUC = true;
            this.ucTextBoxWithIcon2.IsAmount = false;
            this.ucTextBoxWithIcon2.IsKeyBoardForScan = false;
            this.ucTextBoxWithIcon2.IsLarge = false;
            this.ucTextBoxWithIcon2.IsNumber = false;
            this.ucTextBoxWithIcon2.IsSetFormat = false;
            this.ucTextBoxWithIcon2.IsValidateNumberZero = false;
            this.ucTextBoxWithIcon2.IsValidateTextEmpty = false;
            this.ucTextBoxWithIcon2.Location = new System.Drawing.Point(299, 108);
            this.ucTextBoxWithIcon2.MaxLength = 32767;
            this.ucTextBoxWithIcon2.Name = "ucTextBoxWithIcon2";
            this.ucTextBoxWithIcon2.PasswordChar = false;
            this.ucTextBoxWithIcon2.placeHolder = "กรอกเบอร์โทรศัพท์สำหรับติดต่อ";
            this.ucTextBoxWithIcon2.Readonly = false;
            this.ucTextBoxWithIcon2.ShortcutsEnabled = true;
            this.ucTextBoxWithIcon2.Size = new System.Drawing.Size(370, 42);
            this.ucTextBoxWithIcon2.TabIndex = 121;
            this.ucTextBoxWithIcon2.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTextBoxWithIcon2.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ucDDLLanguage
            // 
            this.ucDDLLanguage.BackColor = System.Drawing.Color.White;
            this.ucDDLLanguage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDDLLanguage.BackgroundImage")));
            this.ucDDLLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucDDLLanguage.DisplayText = null;
            this.ucDDLLanguage.DropdownExpandRightSide = false;
            this.ucDDLLanguage.ForeColor = System.Drawing.Color.Black;
            this.ucDDLLanguage.IsLarge = false;
            this.ucDDLLanguage.LabelText = "ประเภทบัตร";
            this.ucDDLLanguage.Location = new System.Drawing.Point(299, 12);
            this.ucDDLLanguage.lstDDL = null;
            this.ucDDLLanguage.Name = "ucDDLLanguage";
            this.ucDDLLanguage.Size = new System.Drawing.Size(370, 42);
            this.ucDDLLanguage.TabIndex = 120;
            this.ucDDLLanguage.ValueText = null;
            // 
            // ucTextBoxWithIcon1
            // 
            this.ucTextBoxWithIcon1.BackColor = System.Drawing.Color.White;
            this.ucTextBoxWithIcon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBoxWithIcon1.BackgroundImage")));
            this.ucTextBoxWithIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxWithIcon1.EnabledUC = true;
            this.ucTextBoxWithIcon1.IsAmount = false;
            this.ucTextBoxWithIcon1.IsKeyBoardForScan = false;
            this.ucTextBoxWithIcon1.IsLarge = false;
            this.ucTextBoxWithIcon1.IsNumber = false;
            this.ucTextBoxWithIcon1.IsSetFormat = false;
            this.ucTextBoxWithIcon1.IsValidateNumberZero = false;
            this.ucTextBoxWithIcon1.IsValidateTextEmpty = false;
            this.ucTextBoxWithIcon1.Location = new System.Drawing.Point(299, 60);
            this.ucTextBoxWithIcon1.MaxLength = 32767;
            this.ucTextBoxWithIcon1.Name = "ucTextBoxWithIcon1";
            this.ucTextBoxWithIcon1.PasswordChar = false;
            this.ucTextBoxWithIcon1.placeHolder = "กรอกหมายเลขบัตรประชาชน";
            this.ucTextBoxWithIcon1.Readonly = false;
            this.ucTextBoxWithIcon1.ShortcutsEnabled = true;
            this.ucTextBoxWithIcon1.Size = new System.Drawing.Size(370, 42);
            this.ucTextBoxWithIcon1.TabIndex = 118;
            this.ucTextBoxWithIcon1.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTextBoxWithIcon1.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 42);
            this.label5.TabIndex = 119;
            this.label5.Text = "หมายเลขบัตรประชาชน";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBFirstname
            // 
            this.ucTBFirstname.BackColor = System.Drawing.Color.White;
            this.ucTBFirstname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBFirstname.BackgroundImage")));
            this.ucTBFirstname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBFirstname.EnabledUC = true;
            this.ucTBFirstname.IsAmount = false;
            this.ucTBFirstname.IsKeyBoardForScan = false;
            this.ucTBFirstname.IsLarge = false;
            this.ucTBFirstname.IsNumber = false;
            this.ucTBFirstname.IsSetFormat = false;
            this.ucTBFirstname.IsValidateNumberZero = false;
            this.ucTBFirstname.IsValidateTextEmpty = false;
            this.ucTBFirstname.Location = new System.Drawing.Point(299, 156);
            this.ucTBFirstname.MaxLength = 32767;
            this.ucTBFirstname.Name = "ucTBFirstname";
            this.ucTBFirstname.PasswordChar = false;
            this.ucTBFirstname.placeHolder = "กรอกรหัสไปรษณืย์ของผู้ส่ง";
            this.ucTBFirstname.Readonly = false;
            this.ucTBFirstname.ShortcutsEnabled = true;
            this.ucTBFirstname.Size = new System.Drawing.Size(370, 42);
            this.ucTBFirstname.TabIndex = 104;
            this.ucTBFirstname.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBFirstname.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbFirstname
            // 
            this.lbFirstname.BackColor = System.Drawing.Color.White;
            this.lbFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.ForeColor = System.Drawing.Color.Black;
            this.lbFirstname.Location = new System.Drawing.Point(11, 156);
            this.lbFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(283, 42);
            this.lbFirstname.TabIndex = 105;
            this.lbFirstname.Text = "รหัสไปรษณีย์ของผู้ส่ง";
            this.lbFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLanguage
            // 
            this.lbLanguage.BackColor = System.Drawing.Color.White;
            this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.Color.Black;
            this.lbLanguage.Location = new System.Drawing.Point(11, 108);
            this.lbLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(283, 42);
            this.lbLanguage.TabIndex = 103;
            this.lbLanguage.Text = "เบอร์โทรศัพท์สำหรับติดต่อ";
            this.lbLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCitizenID
            // 
            this.lbCitizenID.BackColor = System.Drawing.Color.White;
            this.lbCitizenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitizenID.ForeColor = System.Drawing.Color.Black;
            this.lbCitizenID.Location = new System.Drawing.Point(11, 12);
            this.lbCitizenID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCitizenID.Name = "lbCitizenID";
            this.lbCitizenID.Size = new System.Drawing.Size(283, 42);
            this.lbCitizenID.TabIndex = 99;
            this.lbCitizenID.Text = "ประเภทบัตร";
            this.lbCitizenID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInputAddress
            // 
            this.panelInputAddress.BackColor = System.Drawing.SystemColors.Control;
            this.panelInputAddress.Controls.Add(this.label4);
            this.panelInputAddress.Controls.Add(this.label3);
            this.panelInputAddress.Controls.Add(this.label2);
            this.panelInputAddress.Controls.Add(this.label1);
            this.panelInputAddress.Controls.Add(this.button1);
            this.panelInputAddress.Controls.Add(this.button2);
            this.panelInputAddress.Controls.Add(this.button3);
            this.panelInputAddress.Location = new System.Drawing.Point(687, 118);
            this.panelInputAddress.Name = "panelInputAddress";
            this.panelInputAddress.Size = new System.Drawing.Size(336, 305);
            this.panelInputAddress.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 34);
            this.label4.TabIndex = 126;
            this.label4.Text = "User ID       300009";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 34);
            this.label3.TabIndex = 125;
            this.label3.Text = "Loc. No.      011";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 34);
            this.label2.TabIndex = 124;
            this.label2.Text = "เลขที่ใบรับฝาก   MDF0000000001";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 34);
            this.label1.TabIndex = 121;
            this.label1.Text = "Bill Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(178, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 54);
            this.button1.TabIndex = 123;
            this.button1.Text = "ยกเลิก";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::BJCBCPOS.Properties.Resources.Sale_btnOtherPayment;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 54);
            this.button2.TabIndex = 122;
            this.button2.Text = "ตกลง";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::BJCBCPOS.Properties.Resources.btn_payment_disable;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(37, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 38);
            this.button3.TabIndex = 121;
            this.button3.Text = "อ่านบัตรประชาชน";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 38);
            this.label7.TabIndex = 167;
            this.label7.Text = "ข้อมูลผู้ส่ง";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 391);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 38);
            this.label6.TabIndex = 169;
            this.label6.Text = "ข้อมูลผู้รับ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ucTextBoxWithIcon3);
            this.panel2.Controls.Add(this.ucTextBoxWithIcon5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(1, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 115);
            this.panel2.TabIndex = 168;
            // 
            // ucTextBoxWithIcon3
            // 
            this.ucTextBoxWithIcon3.BackColor = System.Drawing.Color.White;
            this.ucTextBoxWithIcon3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBoxWithIcon3.BackgroundImage")));
            this.ucTextBoxWithIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxWithIcon3.EnabledUC = true;
            this.ucTextBoxWithIcon3.IsAmount = false;
            this.ucTextBoxWithIcon3.IsKeyBoardForScan = false;
            this.ucTextBoxWithIcon3.IsLarge = false;
            this.ucTextBoxWithIcon3.IsNumber = false;
            this.ucTextBoxWithIcon3.IsSetFormat = false;
            this.ucTextBoxWithIcon3.IsValidateNumberZero = false;
            this.ucTextBoxWithIcon3.IsValidateTextEmpty = false;
            this.ucTextBoxWithIcon3.Location = new System.Drawing.Point(299, 12);
            this.ucTextBoxWithIcon3.MaxLength = 32767;
            this.ucTextBoxWithIcon3.Name = "ucTextBoxWithIcon3";
            this.ucTextBoxWithIcon3.PasswordChar = false;
            this.ucTextBoxWithIcon3.placeHolder = "กรอกเบอร์โทรศัพท์สำหรับติดต่อ";
            this.ucTextBoxWithIcon3.Readonly = false;
            this.ucTextBoxWithIcon3.ShortcutsEnabled = true;
            this.ucTextBoxWithIcon3.Size = new System.Drawing.Size(370, 42);
            this.ucTextBoxWithIcon3.TabIndex = 121;
            this.ucTextBoxWithIcon3.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTextBoxWithIcon3.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ucTextBoxWithIcon5
            // 
            this.ucTextBoxWithIcon5.BackColor = System.Drawing.Color.White;
            this.ucTextBoxWithIcon5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBoxWithIcon5.BackgroundImage")));
            this.ucTextBoxWithIcon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxWithIcon5.EnabledUC = true;
            this.ucTextBoxWithIcon5.IsAmount = false;
            this.ucTextBoxWithIcon5.IsKeyBoardForScan = false;
            this.ucTextBoxWithIcon5.IsLarge = false;
            this.ucTextBoxWithIcon5.IsNumber = false;
            this.ucTextBoxWithIcon5.IsSetFormat = false;
            this.ucTextBoxWithIcon5.IsValidateNumberZero = false;
            this.ucTextBoxWithIcon5.IsValidateTextEmpty = false;
            this.ucTextBoxWithIcon5.Location = new System.Drawing.Point(299, 60);
            this.ucTextBoxWithIcon5.MaxLength = 32767;
            this.ucTextBoxWithIcon5.Name = "ucTextBoxWithIcon5";
            this.ucTextBoxWithIcon5.PasswordChar = false;
            this.ucTextBoxWithIcon5.placeHolder = "กรอกรหัสไปรษณีย์ของสถานที่ส่ง";
            this.ucTextBoxWithIcon5.Readonly = false;
            this.ucTextBoxWithIcon5.ShortcutsEnabled = true;
            this.ucTextBoxWithIcon5.Size = new System.Drawing.Size(370, 42);
            this.ucTextBoxWithIcon5.TabIndex = 104;
            this.ucTextBoxWithIcon5.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTextBoxWithIcon5.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 42);
            this.label9.TabIndex = 105;
            this.label9.Text = "รหัสไปรษณีย์ของสถานที่ส่ง";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 42);
            this.label10.TabIndex = 103;
            this.label10.Text = "เบอร์โทรศัพท์สำหรับติดต่อ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 550);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(406, 38);
            this.label8.TabIndex = 171;
            this.label8.Text = "ข้อมูลพัสดุ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ucDropDownList1);
            this.panel3.Controls.Add(this.ucTextBoxWithIcon6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(1, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 115);
            this.panel3.TabIndex = 170;
            // 
            // ucDropDownList1
            // 
            this.ucDropDownList1.BackColor = System.Drawing.Color.White;
            this.ucDropDownList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDropDownList1.BackgroundImage")));
            this.ucDropDownList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucDropDownList1.DisplayText = null;
            this.ucDropDownList1.DropdownExpandRightSide = false;
            this.ucDropDownList1.ForeColor = System.Drawing.Color.Black;
            this.ucDropDownList1.IsLarge = false;
            this.ucDropDownList1.LabelText = "ขนาดกล่องพัสดุ";
            this.ucDropDownList1.Location = new System.Drawing.Point(299, 12);
            this.ucDropDownList1.lstDDL = null;
            this.ucDropDownList1.Name = "ucDropDownList1";
            this.ucDropDownList1.Size = new System.Drawing.Size(370, 42);
            this.ucDropDownList1.TabIndex = 122;
            this.ucDropDownList1.ValueText = null;
            // 
            // ucTextBoxWithIcon6
            // 
            this.ucTextBoxWithIcon6.BackColor = System.Drawing.Color.White;
            this.ucTextBoxWithIcon6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTextBoxWithIcon6.BackgroundImage")));
            this.ucTextBoxWithIcon6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTextBoxWithIcon6.EnabledUC = true;
            this.ucTextBoxWithIcon6.IsAmount = false;
            this.ucTextBoxWithIcon6.IsKeyBoardForScan = false;
            this.ucTextBoxWithIcon6.IsLarge = false;
            this.ucTextBoxWithIcon6.IsNumber = false;
            this.ucTextBoxWithIcon6.IsSetFormat = false;
            this.ucTextBoxWithIcon6.IsValidateNumberZero = false;
            this.ucTextBoxWithIcon6.IsValidateTextEmpty = false;
            this.ucTextBoxWithIcon6.Location = new System.Drawing.Point(299, 60);
            this.ucTextBoxWithIcon6.MaxLength = 32767;
            this.ucTextBoxWithIcon6.Name = "ucTextBoxWithIcon6";
            this.ucTextBoxWithIcon6.PasswordChar = false;
            this.ucTextBoxWithIcon6.placeHolder = "Tracking No.";
            this.ucTextBoxWithIcon6.Readonly = false;
            this.ucTextBoxWithIcon6.ShortcutsEnabled = true;
            this.ucTextBoxWithIcon6.Size = new System.Drawing.Size(370, 42);
            this.ucTextBoxWithIcon6.TabIndex = 104;
            this.ucTextBoxWithIcon6.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTextBoxWithIcon6.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 42);
            this.label11.TabIndex = 105;
            this.label11.Text = "Tracking No.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 42);
            this.label12.TabIndex = 103;
            this.label12.Text = "ขนาดกล่องพัสดุ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmParcelNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelInputAddress);
            this.Controls.Add(this.panelInputMember);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucFooter1);
            this.Controls.Add(this.ucHeader1);
            this.Controls.Add(this.ucKeypad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParcelNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmParcelNormal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelInputMember.ResumeLayout(false);
            this.panelInputAddress.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UCFooter ucFooter1;
        private UCHeader ucHeader1;
        private UCKeypad ucKeypad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbProductAndServices;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelInputMember;
        public UCTextBoxWithIcon ucTextBoxWithIcon1;
        private System.Windows.Forms.Label label5;
        public UCTextBoxWithIcon ucTBFirstname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbCitizenID;
        private System.Windows.Forms.Panel panelInputAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private UCDropDownList ucDDLLanguage;
        public UCTextBoxWithIcon ucTextBoxWithIcon2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel2;
        public UCTextBoxWithIcon ucTextBoxWithIcon3;
        public UCTextBoxWithIcon ucTextBoxWithIcon5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel3;
        private UCDropDownList ucDropDownList1;
        public UCTextBoxWithIcon ucTextBoxWithIcon6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}