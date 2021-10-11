namespace BJCBCPOS.Services.Forms
{
    partial class frmMemberRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberRegister));
            this.lbCitizenID = new System.Windows.Forms.Label();
            this.panelInputMember = new System.Windows.Forms.Panel();
            this.btnReadCitizen = new System.Windows.Forms.Button();
            this.ucTBWelfair = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbWelfair = new System.Windows.Forms.Label();
            this.ucTBMobileNo = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbMobileNo = new System.Windows.Forms.Label();
            this.ucDDLSelectAddress = new BJCBCPOS.UCDropDownList();
            this.ucTBPostcode = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbPostcode = new System.Windows.Forms.Label();
            this.lbSelectAddress = new System.Windows.Forms.Label();
            this.ucDDLLanguage = new BJCBCPOS.UCDropDownList();
            this.ucTBLastname = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbLastname = new System.Windows.Forms.Label();
            this.ucTBFirstname = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.ucTBMemberID = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.ucTBCitizenID = new BJCBCPOS.UCTextBoxWithIcon();
            this.panelInputAddress = new System.Windows.Forms.Panel();
            this.btnSaveAddress = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ucTBDistrict = new BJCBCPOS.UCTextBoxWithIcon();
            this.label10 = new System.Windows.Forms.Label();
            this.ucTBSubdistrict = new BJCBCPOS.UCTextBoxWithIcon();
            this.label9 = new System.Windows.Forms.Label();
            this.ucDDLProvince = new BJCBCPOS.UCDropDownList();
            this.ucTBVillege = new BJCBCPOS.UCTextBoxWithIcon();
            this.ucTBAddress = new BJCBCPOS.UCTextBoxWithIcon();
            this.lbDiscount2 = new System.Windows.Forms.Label();
            this.lbPrice3 = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.ucTBMoo = new BJCBCPOS.UCTextBoxWithIcon();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.ucFooter1 = new BJCBCPOS.UCFooter();
            this.ucKeypad = new BJCBCPOS.UCKeypad();
            this.ucHeader1 = new BJCBCPOS.UCHeader();
            this.panelInputMember.SuspendLayout();
            this.panelInputAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCitizenID
            // 
            this.lbCitizenID.BackColor = System.Drawing.Color.White;
            this.lbCitizenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCitizenID.ForeColor = System.Drawing.Color.Black;
            this.lbCitizenID.Location = new System.Drawing.Point(11, 17);
            this.lbCitizenID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCitizenID.Name = "lbCitizenID";
            this.lbCitizenID.Size = new System.Drawing.Size(283, 42);
            this.lbCitizenID.TabIndex = 99;
            this.lbCitizenID.Text = "หมายเลขบัตรประชาชน";
            this.lbCitizenID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInputMember
            // 
            this.panelInputMember.AutoScroll = true;
            this.panelInputMember.BackColor = System.Drawing.Color.White;
            this.panelInputMember.Controls.Add(this.btnReadCitizen);
            this.panelInputMember.Controls.Add(this.ucTBWelfair);
            this.panelInputMember.Controls.Add(this.lbWelfair);
            this.panelInputMember.Controls.Add(this.ucTBMobileNo);
            this.panelInputMember.Controls.Add(this.lbMobileNo);
            this.panelInputMember.Controls.Add(this.ucDDLSelectAddress);
            this.panelInputMember.Controls.Add(this.ucTBPostcode);
            this.panelInputMember.Controls.Add(this.lbPostcode);
            this.panelInputMember.Controls.Add(this.lbSelectAddress);
            this.panelInputMember.Controls.Add(this.ucDDLLanguage);
            this.panelInputMember.Controls.Add(this.ucTBLastname);
            this.panelInputMember.Controls.Add(this.lbLastname);
            this.panelInputMember.Controls.Add(this.ucTBFirstname);
            this.panelInputMember.Controls.Add(this.lbFirstname);
            this.panelInputMember.Controls.Add(this.lbLanguage);
            this.panelInputMember.Controls.Add(this.ucTBMemberID);
            this.panelInputMember.Controls.Add(this.lbMemberID);
            this.panelInputMember.Controls.Add(this.ucTBCitizenID);
            this.panelInputMember.Controls.Add(this.lbCitizenID);
            this.panelInputMember.Location = new System.Drawing.Point(1, 55);
            this.panelInputMember.Name = "panelInputMember";
            this.panelInputMember.Size = new System.Drawing.Size(687, 527);
            this.panelInputMember.TabIndex = 100;
            // 
            // btnReadCitizen
            // 
            this.btnReadCitizen.BackColor = System.Drawing.Color.White;
            this.btnReadCitizen.BackgroundImage = global::BJCBCPOS.Properties.Resources.btn_payment_disable;
            this.btnReadCitizen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadCitizen.FlatAppearance.BorderSize = 0;
            this.btnReadCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadCitizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReadCitizen.ForeColor = System.Drawing.Color.Black;
            this.btnReadCitizen.Location = new System.Drawing.Point(299, 449);
            this.btnReadCitizen.Name = "btnReadCitizen";
            this.btnReadCitizen.Size = new System.Drawing.Size(370, 59);
            this.btnReadCitizen.TabIndex = 101;
            this.btnReadCitizen.Text = "อ่านบัตรประชาชน";
            this.btnReadCitizen.UseVisualStyleBackColor = false;
            // 
            // ucTBWelfair
            // 
            this.ucTBWelfair.BackColor = System.Drawing.Color.White;
            this.ucTBWelfair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBWelfair.BackgroundImage")));
            this.ucTBWelfair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBWelfair.EnabledUC = true;
            this.ucTBWelfair.IsAmount = false;
            this.ucTBWelfair.IsKeyBoardForScan = false;
            this.ucTBWelfair.IsLarge = false;
            this.ucTBWelfair.IsNumber = false;
            this.ucTBWelfair.IsSetFormat = false;
            this.ucTBWelfair.IsValidateNumberZero = false;
            this.ucTBWelfair.IsValidateTextEmpty = false;
            this.ucTBWelfair.Location = new System.Drawing.Point(299, 401);
            this.ucTBWelfair.MaxLength = 32767;
            this.ucTBWelfair.Name = "ucTBWelfair";
            this.ucTBWelfair.PasswordChar = false;
            this.ucTBWelfair.placeHolder = "กรอกหมายเลขบัตรสวัสดิการแห่งรัฐ";
            this.ucTBWelfair.Readonly = false;
            this.ucTBWelfair.ShortcutsEnabled = true;
            this.ucTBWelfair.Size = new System.Drawing.Size(370, 42);
            this.ucTBWelfair.TabIndex = 116;
            this.ucTBWelfair.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBWelfair.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbWelfair
            // 
            this.lbWelfair.BackColor = System.Drawing.Color.White;
            this.lbWelfair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelfair.ForeColor = System.Drawing.Color.Black;
            this.lbWelfair.Location = new System.Drawing.Point(11, 401);
            this.lbWelfair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelfair.Name = "lbWelfair";
            this.lbWelfair.Size = new System.Drawing.Size(283, 42);
            this.lbWelfair.TabIndex = 117;
            this.lbWelfair.Text = "หมายเลขบัตรสวัสดิการแห่งรัฐ";
            this.lbWelfair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBMobileNo
            // 
            this.ucTBMobileNo.BackColor = System.Drawing.Color.White;
            this.ucTBMobileNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBMobileNo.BackgroundImage")));
            this.ucTBMobileNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBMobileNo.EnabledUC = true;
            this.ucTBMobileNo.IsAmount = false;
            this.ucTBMobileNo.IsKeyBoardForScan = false;
            this.ucTBMobileNo.IsLarge = false;
            this.ucTBMobileNo.IsNumber = false;
            this.ucTBMobileNo.IsSetFormat = false;
            this.ucTBMobileNo.IsValidateNumberZero = false;
            this.ucTBMobileNo.IsValidateTextEmpty = false;
            this.ucTBMobileNo.Location = new System.Drawing.Point(299, 353);
            this.ucTBMobileNo.MaxLength = 32767;
            this.ucTBMobileNo.Name = "ucTBMobileNo";
            this.ucTBMobileNo.PasswordChar = false;
            this.ucTBMobileNo.placeHolder = "กรอกหมายเลขโทรศัพท์มือถือ";
            this.ucTBMobileNo.Readonly = false;
            this.ucTBMobileNo.ShortcutsEnabled = true;
            this.ucTBMobileNo.Size = new System.Drawing.Size(370, 42);
            this.ucTBMobileNo.TabIndex = 114;
            this.ucTBMobileNo.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBMobileNo.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbMobileNo
            // 
            this.lbMobileNo.BackColor = System.Drawing.Color.White;
            this.lbMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMobileNo.ForeColor = System.Drawing.Color.Black;
            this.lbMobileNo.Location = new System.Drawing.Point(11, 353);
            this.lbMobileNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMobileNo.Name = "lbMobileNo";
            this.lbMobileNo.Size = new System.Drawing.Size(283, 42);
            this.lbMobileNo.TabIndex = 115;
            this.lbMobileNo.Text = "หมายเลขโทรศัพท์มือถือ";
            this.lbMobileNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDDLSelectAddress
            // 
            this.ucDDLSelectAddress.BackColor = System.Drawing.Color.White;
            this.ucDDLSelectAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDDLSelectAddress.BackgroundImage")));
            this.ucDDLSelectAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucDDLSelectAddress.DisplayText = null;
            this.ucDDLSelectAddress.DropdownExpandRightSide = false;
            this.ucDDLSelectAddress.IsLarge = false;
            this.ucDDLSelectAddress.LabelText = "Yes";
            this.ucDDLSelectAddress.Location = new System.Drawing.Point(349, 257);
            this.ucDDLSelectAddress.lstDDL = null;
            this.ucDDLSelectAddress.Name = "ucDDLSelectAddress";
            this.ucDDLSelectAddress.Size = new System.Drawing.Size(320, 42);
            this.ucDDLSelectAddress.TabIndex = 113;
            this.ucDDLSelectAddress.ValueText = null;
            // 
            // ucTBPostcode
            // 
            this.ucTBPostcode.BackColor = System.Drawing.Color.White;
            this.ucTBPostcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBPostcode.BackgroundImage")));
            this.ucTBPostcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBPostcode.EnabledUC = true;
            this.ucTBPostcode.IsAmount = false;
            this.ucTBPostcode.IsKeyBoardForScan = false;
            this.ucTBPostcode.IsLarge = false;
            this.ucTBPostcode.IsNumber = false;
            this.ucTBPostcode.IsSetFormat = false;
            this.ucTBPostcode.IsValidateNumberZero = false;
            this.ucTBPostcode.IsValidateTextEmpty = false;
            this.ucTBPostcode.Location = new System.Drawing.Point(299, 305);
            this.ucTBPostcode.MaxLength = 32767;
            this.ucTBPostcode.Name = "ucTBPostcode";
            this.ucTBPostcode.PasswordChar = false;
            this.ucTBPostcode.placeHolder = "กรอกรหัสไปรษณีย์";
            this.ucTBPostcode.Readonly = false;
            this.ucTBPostcode.ShortcutsEnabled = true;
            this.ucTBPostcode.Size = new System.Drawing.Size(370, 42);
            this.ucTBPostcode.TabIndex = 111;
            this.ucTBPostcode.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBPostcode.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbPostcode
            // 
            this.lbPostcode.BackColor = System.Drawing.Color.White;
            this.lbPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostcode.ForeColor = System.Drawing.Color.Black;
            this.lbPostcode.Location = new System.Drawing.Point(11, 305);
            this.lbPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPostcode.Name = "lbPostcode";
            this.lbPostcode.Size = new System.Drawing.Size(283, 42);
            this.lbPostcode.TabIndex = 112;
            this.lbPostcode.Text = "รหัสไปรษณีย์";
            this.lbPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSelectAddress
            // 
            this.lbSelectAddress.BackColor = System.Drawing.Color.White;
            this.lbSelectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectAddress.ForeColor = System.Drawing.Color.Black;
            this.lbSelectAddress.Location = new System.Drawing.Point(11, 257);
            this.lbSelectAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectAddress.Name = "lbSelectAddress";
            this.lbSelectAddress.Size = new System.Drawing.Size(333, 42);
            this.lbSelectAddress.TabIndex = 110;
            this.lbSelectAddress.Text = "ใช้ที่อยู่ติดต่อที่เดียวกันกับบัตรประชาชน";
            this.lbSelectAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ucDDLLanguage.LabelText = "ภาษาไทย";
            this.ucDDLLanguage.Location = new System.Drawing.Point(299, 113);
            this.ucDDLLanguage.lstDDL = null;
            this.ucDDLLanguage.Name = "ucDDLLanguage";
            this.ucDDLLanguage.Size = new System.Drawing.Size(370, 42);
            this.ucDDLLanguage.TabIndex = 108;
            this.ucDDLLanguage.ValueText = null;
            // 
            // ucTBLastname
            // 
            this.ucTBLastname.BackColor = System.Drawing.Color.White;
            this.ucTBLastname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBLastname.BackgroundImage")));
            this.ucTBLastname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBLastname.EnabledUC = true;
            this.ucTBLastname.IsAmount = false;
            this.ucTBLastname.IsKeyBoardForScan = false;
            this.ucTBLastname.IsLarge = false;
            this.ucTBLastname.IsNumber = false;
            this.ucTBLastname.IsSetFormat = false;
            this.ucTBLastname.IsValidateNumberZero = false;
            this.ucTBLastname.IsValidateTextEmpty = false;
            this.ucTBLastname.Location = new System.Drawing.Point(299, 209);
            this.ucTBLastname.MaxLength = 32767;
            this.ucTBLastname.Name = "ucTBLastname";
            this.ucTBLastname.PasswordChar = false;
            this.ucTBLastname.placeHolder = "กรอกนามสกุล";
            this.ucTBLastname.Readonly = false;
            this.ucTBLastname.ShortcutsEnabled = true;
            this.ucTBLastname.Size = new System.Drawing.Size(370, 42);
            this.ucTBLastname.TabIndex = 106;
            this.ucTBLastname.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBLastname.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbLastname
            // 
            this.lbLastname.BackColor = System.Drawing.Color.White;
            this.lbLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastname.ForeColor = System.Drawing.Color.Black;
            this.lbLastname.Location = new System.Drawing.Point(11, 209);
            this.lbLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(283, 42);
            this.lbLastname.TabIndex = 107;
            this.lbLastname.Text = "นามสกุล";
            this.lbLastname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ucTBFirstname.Location = new System.Drawing.Point(299, 161);
            this.ucTBFirstname.MaxLength = 32767;
            this.ucTBFirstname.Name = "ucTBFirstname";
            this.ucTBFirstname.PasswordChar = false;
            this.ucTBFirstname.placeHolder = "กรอกชื่อ";
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
            this.lbFirstname.Location = new System.Drawing.Point(11, 161);
            this.lbFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(283, 42);
            this.lbFirstname.TabIndex = 105;
            this.lbFirstname.Text = "ชื่อ";
            this.lbFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLanguage
            // 
            this.lbLanguage.BackColor = System.Drawing.Color.White;
            this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.Color.Black;
            this.lbLanguage.Location = new System.Drawing.Point(11, 113);
            this.lbLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(283, 42);
            this.lbLanguage.TabIndex = 103;
            this.lbLanguage.Text = "ภาษาที่ใช้ในการติดต่อสื่อสาร";
            this.lbLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBMemberID
            // 
            this.ucTBMemberID.BackColor = System.Drawing.Color.White;
            this.ucTBMemberID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBMemberID.BackgroundImage")));
            this.ucTBMemberID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBMemberID.EnabledUC = true;
            this.ucTBMemberID.IsAmount = false;
            this.ucTBMemberID.IsKeyBoardForScan = false;
            this.ucTBMemberID.IsLarge = false;
            this.ucTBMemberID.IsNumber = false;
            this.ucTBMemberID.IsSetFormat = false;
            this.ucTBMemberID.IsValidateNumberZero = false;
            this.ucTBMemberID.IsValidateTextEmpty = false;
            this.ucTBMemberID.Location = new System.Drawing.Point(299, 65);
            this.ucTBMemberID.MaxLength = 32767;
            this.ucTBMemberID.Name = "ucTBMemberID";
            this.ucTBMemberID.PasswordChar = false;
            this.ucTBMemberID.placeHolder = "หมายเลขสมาชิก";
            this.ucTBMemberID.Readonly = false;
            this.ucTBMemberID.ShortcutsEnabled = true;
            this.ucTBMemberID.Size = new System.Drawing.Size(370, 42);
            this.ucTBMemberID.TabIndex = 100;
            this.ucTBMemberID.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBMemberID.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbMemberID
            // 
            this.lbMemberID.BackColor = System.Drawing.Color.White;
            this.lbMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemberID.ForeColor = System.Drawing.Color.Black;
            this.lbMemberID.Location = new System.Drawing.Point(11, 65);
            this.lbMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(283, 42);
            this.lbMemberID.TabIndex = 101;
            this.lbMemberID.Text = "หมายเลขสมาชิก";
            this.lbMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBCitizenID
            // 
            this.ucTBCitizenID.BackColor = System.Drawing.Color.White;
            this.ucTBCitizenID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBCitizenID.BackgroundImage")));
            this.ucTBCitizenID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBCitizenID.EnabledUC = true;
            this.ucTBCitizenID.IsAmount = false;
            this.ucTBCitizenID.IsKeyBoardForScan = false;
            this.ucTBCitizenID.IsLarge = false;
            this.ucTBCitizenID.IsNumber = false;
            this.ucTBCitizenID.IsSetFormat = false;
            this.ucTBCitizenID.IsValidateNumberZero = false;
            this.ucTBCitizenID.IsValidateTextEmpty = false;
            this.ucTBCitizenID.Location = new System.Drawing.Point(299, 17);
            this.ucTBCitizenID.MaxLength = 32767;
            this.ucTBCitizenID.Name = "ucTBCitizenID";
            this.ucTBCitizenID.PasswordChar = false;
            this.ucTBCitizenID.placeHolder = "กรอกหมายเลขบัตรประชาชน";
            this.ucTBCitizenID.Readonly = false;
            this.ucTBCitizenID.ShortcutsEnabled = true;
            this.ucTBCitizenID.Size = new System.Drawing.Size(370, 42);
            this.ucTBCitizenID.TabIndex = 98;
            this.ucTBCitizenID.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBCitizenID.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ucTBCitizenID.Load += new System.EventHandler(this.ucTBScanBarcode_Load);
            // 
            // panelInputAddress
            // 
            this.panelInputAddress.BackColor = System.Drawing.Color.White;
            this.panelInputAddress.Controls.Add(this.btnSaveAddress);
            this.panelInputAddress.Controls.Add(this.label11);
            this.panelInputAddress.Controls.Add(this.ucTBDistrict);
            this.panelInputAddress.Controls.Add(this.label10);
            this.panelInputAddress.Controls.Add(this.ucTBSubdistrict);
            this.panelInputAddress.Controls.Add(this.label9);
            this.panelInputAddress.Controls.Add(this.ucDDLProvince);
            this.panelInputAddress.Controls.Add(this.ucTBVillege);
            this.panelInputAddress.Controls.Add(this.ucTBAddress);
            this.panelInputAddress.Controls.Add(this.lbDiscount2);
            this.panelInputAddress.Controls.Add(this.lbPrice3);
            this.panelInputAddress.Controls.Add(this.lbAddress);
            this.panelInputAddress.Controls.Add(this.ucTBMoo);
            this.panelInputAddress.Location = new System.Drawing.Point(689, 55);
            this.panelInputAddress.Name = "panelInputAddress";
            this.panelInputAddress.Size = new System.Drawing.Size(334, 373);
            this.panelInputAddress.TabIndex = 119;
            // 
            // btnSaveAddress
            // 
            this.btnSaveAddress.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAddress.BackgroundImage")));
            this.btnSaveAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAddress.FlatAppearance.BorderSize = 0;
            this.btnSaveAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveAddress.ForeColor = System.Drawing.Color.White;
            this.btnSaveAddress.Location = new System.Drawing.Point(119, 322);
            this.btnSaveAddress.Name = "btnSaveAddress";
            this.btnSaveAddress.Size = new System.Drawing.Size(204, 43);
            this.btnSaveAddress.TabIndex = 120;
            this.btnSaveAddress.Text = "บันทึกที่อยู่";
            this.btnSaveAddress.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 121;
            this.label11.Text = "จังหวัด";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBDistrict
            // 
            this.ucTBDistrict.BackColor = System.Drawing.Color.White;
            this.ucTBDistrict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBDistrict.BackgroundImage")));
            this.ucTBDistrict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBDistrict.EnabledUC = true;
            this.ucTBDistrict.IsAmount = false;
            this.ucTBDistrict.IsKeyBoardForScan = false;
            this.ucTBDistrict.IsLarge = false;
            this.ucTBDistrict.IsNumber = false;
            this.ucTBDistrict.IsSetFormat = true;
            this.ucTBDistrict.IsValidateNumberZero = false;
            this.ucTBDistrict.IsValidateTextEmpty = false;
            this.ucTBDistrict.Location = new System.Drawing.Point(127, 226);
            this.ucTBDistrict.MaxLength = 32767;
            this.ucTBDistrict.Name = "ucTBDistrict";
            this.ucTBDistrict.PasswordChar = false;
            this.ucTBDistrict.placeHolder = "กรอกอำเภอ/เขต";
            this.ucTBDistrict.Readonly = false;
            this.ucTBDistrict.ShortcutsEnabled = true;
            this.ucTBDistrict.Size = new System.Drawing.Size(196, 42);
            this.ucTBDistrict.TabIndex = 97;
            this.ucTBDistrict.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBDistrict.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 96;
            this.label10.Text = "อำเภอ/เขต";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBSubdistrict
            // 
            this.ucTBSubdistrict.BackColor = System.Drawing.Color.White;
            this.ucTBSubdistrict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBSubdistrict.BackgroundImage")));
            this.ucTBSubdistrict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBSubdistrict.EnabledUC = true;
            this.ucTBSubdistrict.IsAmount = false;
            this.ucTBSubdistrict.IsKeyBoardForScan = false;
            this.ucTBSubdistrict.IsLarge = false;
            this.ucTBSubdistrict.IsNumber = false;
            this.ucTBSubdistrict.IsSetFormat = true;
            this.ucTBSubdistrict.IsValidateNumberZero = false;
            this.ucTBSubdistrict.IsValidateTextEmpty = false;
            this.ucTBSubdistrict.Location = new System.Drawing.Point(127, 178);
            this.ucTBSubdistrict.MaxLength = 32767;
            this.ucTBSubdistrict.Name = "ucTBSubdistrict";
            this.ucTBSubdistrict.PasswordChar = false;
            this.ucTBSubdistrict.placeHolder = "กรอกตำบล/แขวง";
            this.ucTBSubdistrict.Readonly = false;
            this.ucTBSubdistrict.ShortcutsEnabled = true;
            this.ucTBSubdistrict.Size = new System.Drawing.Size(196, 42);
            this.ucTBSubdistrict.TabIndex = 95;
            this.ucTBSubdistrict.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBSubdistrict.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 94;
            this.label9.Text = "ตำบล/แขวง";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDDLProvince
            // 
            this.ucDDLProvince.BackColor = System.Drawing.Color.White;
            this.ucDDLProvince.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDDLProvince.BackgroundImage")));
            this.ucDDLProvince.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucDDLProvince.DisplayText = null;
            this.ucDDLProvince.DropdownExpandRightSide = false;
            this.ucDDLProvince.IsLarge = false;
            this.ucDDLProvince.LabelText = "จังหวัด";
            this.ucDDLProvince.Location = new System.Drawing.Point(127, 274);
            this.ucDDLProvince.lstDDL = null;
            this.ucDDLProvince.Name = "ucDDLProvince";
            this.ucDDLProvince.Size = new System.Drawing.Size(196, 42);
            this.ucDDLProvince.TabIndex = 93;
            this.ucDDLProvince.ValueText = null;
            // 
            // ucTBVillege
            // 
            this.ucTBVillege.BackColor = System.Drawing.Color.White;
            this.ucTBVillege.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBVillege.BackgroundImage")));
            this.ucTBVillege.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBVillege.EnabledUC = true;
            this.ucTBVillege.IsAmount = false;
            this.ucTBVillege.IsKeyBoardForScan = false;
            this.ucTBVillege.IsLarge = false;
            this.ucTBVillege.IsNumber = false;
            this.ucTBVillege.IsSetFormat = true;
            this.ucTBVillege.IsValidateNumberZero = false;
            this.ucTBVillege.IsValidateTextEmpty = false;
            this.ucTBVillege.Location = new System.Drawing.Point(127, 130);
            this.ucTBVillege.MaxLength = 32767;
            this.ucTBVillege.Name = "ucTBVillege";
            this.ucTBVillege.PasswordChar = false;
            this.ucTBVillege.placeHolder = "กรอกชื่อหมู่บ้าน";
            this.ucTBVillege.Readonly = false;
            this.ucTBVillege.ShortcutsEnabled = true;
            this.ucTBVillege.Size = new System.Drawing.Size(196, 42);
            this.ucTBVillege.TabIndex = 89;
            this.ucTBVillege.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBVillege.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ucTBAddress
            // 
            this.ucTBAddress.BackColor = System.Drawing.Color.White;
            this.ucTBAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBAddress.BackgroundImage")));
            this.ucTBAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBAddress.Enabled = false;
            this.ucTBAddress.EnabledUC = true;
            this.ucTBAddress.IsAmount = false;
            this.ucTBAddress.IsKeyBoardForScan = false;
            this.ucTBAddress.IsLarge = false;
            this.ucTBAddress.IsNumber = false;
            this.ucTBAddress.IsSetFormat = false;
            this.ucTBAddress.IsValidateNumberZero = false;
            this.ucTBAddress.IsValidateTextEmpty = false;
            this.ucTBAddress.Location = new System.Drawing.Point(127, 34);
            this.ucTBAddress.MaxLength = 32767;
            this.ucTBAddress.Name = "ucTBAddress";
            this.ucTBAddress.PasswordChar = false;
            this.ucTBAddress.placeHolder = "กรอกบ้านเลขที่";
            this.ucTBAddress.Readonly = false;
            this.ucTBAddress.ShortcutsEnabled = true;
            this.ucTBAddress.Size = new System.Drawing.Size(196, 42);
            this.ucTBAddress.TabIndex = 87;
            this.ucTBAddress.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBAddress.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDiscount2
            // 
            this.lbDiscount2.BackColor = System.Drawing.Color.Transparent;
            this.lbDiscount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount2.ForeColor = System.Drawing.Color.Black;
            this.lbDiscount2.Location = new System.Drawing.Point(8, 140);
            this.lbDiscount2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscount2.Name = "lbDiscount2";
            this.lbDiscount2.Size = new System.Drawing.Size(111, 25);
            this.lbDiscount2.TabIndex = 76;
            this.lbDiscount2.Text = "หมู่บ้าน";
            this.lbDiscount2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrice3
            // 
            this.lbPrice3.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice3.ForeColor = System.Drawing.Color.Black;
            this.lbPrice3.Location = new System.Drawing.Point(8, 91);
            this.lbPrice3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice3.Name = "lbPrice3";
            this.lbPrice3.Size = new System.Drawing.Size(111, 25);
            this.lbPrice3.TabIndex = 73;
            this.lbPrice3.Text = "หมู่ที่";
            this.lbPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAddress
            // 
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.Location = new System.Drawing.Point(4, 43);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(115, 25);
            this.lbAddress.TabIndex = 71;
            this.lbAddress.Text = "ที่อยู่เลขที่";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTBMoo
            // 
            this.ucTBMoo.BackColor = System.Drawing.Color.White;
            this.ucTBMoo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucTBMoo.BackgroundImage")));
            this.ucTBMoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucTBMoo.Enabled = false;
            this.ucTBMoo.EnabledUC = true;
            this.ucTBMoo.IsAmount = false;
            this.ucTBMoo.IsKeyBoardForScan = false;
            this.ucTBMoo.IsLarge = false;
            this.ucTBMoo.IsNumber = false;
            this.ucTBMoo.IsSetFormat = true;
            this.ucTBMoo.IsValidateNumberZero = false;
            this.ucTBMoo.IsValidateTextEmpty = false;
            this.ucTBMoo.Location = new System.Drawing.Point(127, 82);
            this.ucTBMoo.MaxLength = 32767;
            this.ucTBMoo.Name = "ucTBMoo";
            this.ucTBMoo.PasswordChar = false;
            this.ucTBMoo.placeHolder = "กรอกหมู่ที่";
            this.ucTBMoo.Readonly = false;
            this.ucTBMoo.ShortcutsEnabled = true;
            this.ucTBMoo.Size = new System.Drawing.Size(196, 42);
            this.ucTBMoo.TabIndex = 88;
            this.ucTBMoo.Tag = BJCBCPOS_Model.UCTextBoxIconType.NoneAndDelete;
            this.ucTBMoo.TextBoxAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewMember
            // 
            this.btnNewMember.BackColor = System.Drawing.Color.White;
            this.btnNewMember.BackgroundImage = global::BJCBCPOS.Properties.Resources.Sale_btnOtherPayment;
            this.btnNewMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewMember.FlatAppearance.BorderSize = 0;
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNewMember.ForeColor = System.Drawing.Color.White;
            this.btnNewMember.Location = new System.Drawing.Point(176, 587);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(265, 135);
            this.btnNewMember.TabIndex = 97;
            this.btnNewMember.Text = "เพิ่มสมาชิกใหม่";
            this.btnNewMember.UseVisualStyleBackColor = false;
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.BackColor = System.Drawing.Color.White;
            this.btnSaveMember.BackgroundImage = global::BJCBCPOS.Properties.Resources.Sale_btnOtherPayment;
            this.btnSaveMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveMember.FlatAppearance.BorderSize = 0;
            this.btnSaveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSaveMember.ForeColor = System.Drawing.Color.White;
            this.btnSaveMember.Location = new System.Drawing.Point(447, 588);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(223, 135);
            this.btnSaveMember.TabIndex = 95;
            this.btnSaveMember.Text = "บันทึกข้อมูล";
            this.btnSaveMember.UseVisualStyleBackColor = false;
            // 
            // ucFooter1
            // 
            this.ucFooter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(53)))));
            this.ucFooter1.Location = new System.Drawing.Point(1, 728);
            this.ucFooter1.Name = "ucFooter1";
            this.ucFooter1.Size = new System.Drawing.Size(1024, 40);
            this.ucFooter1.TabIndex = 118;
            // 
            // ucKeypad
            // 
            this.ucKeypad.Location = new System.Drawing.Point(688, 426);
            this.ucKeypad.Name = "ucKeypad";
            this.ucKeypad.Size = new System.Drawing.Size(336, 296);
            this.ucKeypad.TabIndex = 91;
            this.ucKeypad.ucTBS = null;
            this.ucKeypad.ucTBWI = null;
            // 
            // ucHeader1
            // 
            this.ucHeader1.alertEnabled = true;
            this.ucHeader1.alertFunctionID = null;
            this.ucHeader1.alertStatus = false;
            this.ucHeader1.BackColor = System.Drawing.Color.Transparent;
            this.ucHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHeader1.currentMenuTitle1 = "เมนูหลัก";
            this.ucHeader1.currentMenuTitle2 = "สมาชิก";
            this.ucHeader1.currentMenuTitle3 = "ลงทะเบียนสมาชิก";
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
            this.ucHeader1.TabIndex = 1;
            // 
            // frmMemberRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelInputAddress);
            this.Controls.Add(this.ucFooter1);
            this.Controls.Add(this.panelInputMember);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnSaveMember);
            this.Controls.Add(this.ucKeypad);
            this.Controls.Add(this.ucHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberRegister";
            this.panelInputMember.ResumeLayout(false);
            this.panelInputAddress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCHeader ucHeader1;
        private UCKeypad ucKeypad;
        private System.Windows.Forms.Button btnSaveMember;
        private System.Windows.Forms.Button btnNewMember;
        public UCTextBoxWithIcon ucTBCitizenID;
        private System.Windows.Forms.Label lbCitizenID;
        public System.Windows.Forms.Panel panelInputMember;
        public UCTextBoxWithIcon ucTBLastname;
        private System.Windows.Forms.Label lbLastname;
        public UCTextBoxWithIcon ucTBFirstname;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbLanguage;
        public UCTextBoxWithIcon ucTBMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btnReadCitizen;
        public UCTextBoxWithIcon ucTBWelfair;
        private System.Windows.Forms.Label lbWelfair;
        public UCTextBoxWithIcon ucTBMobileNo;
        private System.Windows.Forms.Label lbMobileNo;
        private UCDropDownList ucDDLSelectAddress;
        public UCTextBoxWithIcon ucTBPostcode;
        private System.Windows.Forms.Label lbPostcode;
        private System.Windows.Forms.Label lbSelectAddress;
        private UCDropDownList ucDDLLanguage;
        private UCFooter ucFooter1;
        private System.Windows.Forms.Panel panelInputAddress;
        private UCTextBoxWithIcon ucTBVillege;
        private UCTextBoxWithIcon ucTBAddress;
        private System.Windows.Forms.Label lbDiscount2;
        private System.Windows.Forms.Label lbPrice3;
        private System.Windows.Forms.Label lbAddress;
        private UCTextBoxWithIcon ucTBMoo;
        private UCDropDownList ucDDLProvince;
        private UCTextBoxWithIcon ucTBDistrict;
        private System.Windows.Forms.Label label10;
        private UCTextBoxWithIcon ucTBSubdistrict;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveAddress;
    }
}