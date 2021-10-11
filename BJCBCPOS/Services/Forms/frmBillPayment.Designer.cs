
namespace BJCBCPOS.Services.Forms {
    partial class frmBillPayment {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTxtTotal = new System.Windows.Forms.Label();
            this.lbTxtdiscount1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTxtSubtotal = new System.Windows.Forms.Label();
            this.lbdiscount1 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.colVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvBillEditor = new System.Windows.Forms.DataGridView();
            this.colBillLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customButton2 = new BJCBCPOS.Services.Controls.CustomButton();
            this.customButton1 = new BJCBCPOS.Services.Controls.CustomButton();
            this.ucFooterTran1 = new BJCBCPOS.UCFooterTran();
            this.customButton4 = new BJCBCPOS.Services.Controls.CustomButton();
            this.customButton3 = new BJCBCPOS.Services.Controls.CustomButton();
            this.ucKeypad = new BJCBCPOS.UCKeypad();
            this.ucHeader1 = new BJCBCPOS.UCHeader();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillEditor)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBillEditor);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.ucKeypad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(693, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 725);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 38);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.dgvDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(693, 687);
            this.panel3.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Controls.Add(this.label34);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 100);
            this.panel6.TabIndex = 149;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.customButton2);
            this.panel2.Controls.Add(this.lbTxtTotal);
            this.panel2.Controls.Add(this.lbTxtdiscount1);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.lbTxtSubtotal);
            this.panel2.Controls.Add(this.lbdiscount1);
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 300);
            this.panel2.TabIndex = 93;
            // 
            // lbTxtTotal
            // 
            this.lbTxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.lbTxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxtTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTxtTotal.Location = new System.Drawing.Point(426, 116);
            this.lbTxtTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTxtTotal.Name = "lbTxtTotal";
            this.lbTxtTotal.Size = new System.Drawing.Size(239, 45);
            this.lbTxtTotal.TabIndex = 161;
            this.lbTxtTotal.Text = "0.00";
            this.lbTxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTxtdiscount1
            // 
            this.lbTxtdiscount1.BackColor = System.Drawing.Color.White;
            this.lbTxtdiscount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxtdiscount1.ForeColor = System.Drawing.Color.Black;
            this.lbTxtdiscount1.Location = new System.Drawing.Point(407, 85);
            this.lbTxtdiscount1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTxtdiscount1.Name = "lbTxtdiscount1";
            this.lbTxtdiscount1.Size = new System.Drawing.Size(255, 30);
            this.lbTxtdiscount1.TabIndex = 160;
            this.lbTxtdiscount1.Text = "0.00";
            this.lbTxtdiscount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(172)))));
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(26, 116);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(406, 45);
            this.lbTotal.TabIndex = 159;
            this.lbTotal.Text = "ราคาที่ต้องชำระทั้งหมด";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTxtSubtotal
            // 
            this.lbTxtSubtotal.BackColor = System.Drawing.Color.White;
            this.lbTxtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxtSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lbTxtSubtotal.Location = new System.Drawing.Point(407, 55);
            this.lbTxtSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTxtSubtotal.Name = "lbTxtSubtotal";
            this.lbTxtSubtotal.Size = new System.Drawing.Size(255, 30);
            this.lbTxtSubtotal.TabIndex = 158;
            this.lbTxtSubtotal.Text = "0.00";
            this.lbTxtSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbdiscount1
            // 
            this.lbdiscount1.BackColor = System.Drawing.Color.White;
            this.lbdiscount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiscount1.ForeColor = System.Drawing.Color.Black;
            this.lbdiscount1.Location = new System.Drawing.Point(28, 85);
            this.lbdiscount1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdiscount1.Name = "lbdiscount1";
            this.lbdiscount1.Size = new System.Drawing.Size(345, 30);
            this.lbdiscount1.TabIndex = 157;
            this.lbdiscount1.Text = "ส่วนลด";
            this.lbdiscount1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lbSubtotal.Location = new System.Drawing.Point(307, 3);
            this.lbSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(46, 30);
            this.lbSubtotal.TabIndex = 156;
            this.lbSubtotal.Text = "รวม";
            this.lbSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.label37.Location = new System.Drawing.Point(20, 71);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(262, 16);
            this.label37.TabIndex = 150;
            this.label37.Text = "กรุณาตรวจสอบความถูกต้องก่อนเพิ่มบริการ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(20, 55);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(232, 16);
            this.label36.TabIndex = 149;
            this.label36.Text = "เบอร์ติดต่อ: ใส่เบอรโทรศัพท์ที่ติดต่อได้";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(20, 38);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(302, 16);
            this.label34.TabIndex = 148;
            this.label34.Text = "จำรวนเงินที่ต้องชำระ : ใส่จำนวนเงินที่ต้องการชำระ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(20, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(127, 16);
            this.label29.TabIndex = 147;
            this.label29.Text = "ทวนบริการที่รับชำระ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(477, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "เลขที่อ้างอิง :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(570, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 20);
            this.label21.TabIndex = 145;
            this.label21.Text = "S00301181";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDetail.ColumnHeadersHeight = 30;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVendor,
            this.colService,
            this.colReferenceNo,
            this.colAmount,
            this.colFee,
            this.colStatus});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(2, 2);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 60;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvDetail.RowTemplate.Height = 30;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(689, 683);
            this.dgvDetail.TabIndex = 0;
            // 
            // colVendor
            // 
            this.colVendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVendor.HeaderText = "Vendor";
            this.colVendor.Name = "colVendor";
            this.colVendor.ReadOnly = true;
            // 
            // colService
            // 
            this.colService.HeaderText = "Service";
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.HeaderText = "เลขที่อ้างอิง";
            this.colReferenceNo.Name = "colReferenceNo";
            this.colReferenceNo.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colFee
            // 
            this.colFee.HeaderText = "ค่าบริการ";
            this.colFee.Name = "colFee";
            this.colFee.ReadOnly = true;
            this.colFee.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "สถานะ";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.customButton4);
            this.panel7.Controls.Add(this.customButton3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 379);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 61);
            this.panel7.TabIndex = 150;
            // 
            // dgvBillEditor
            // 
            this.dgvBillEditor.AllowUserToAddRows = false;
            this.dgvBillEditor.AllowUserToDeleteRows = false;
            this.dgvBillEditor.AllowUserToResizeColumns = false;
            this.dgvBillEditor.AllowUserToResizeRows = false;
            this.dgvBillEditor.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvBillEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillEditor.ColumnHeadersVisible = false;
            this.dgvBillEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillLabel,
            this.colBillInput,
            this.colBillType,
            this.colRegEx});
            this.dgvBillEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillEditor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(215)))));
            this.dgvBillEditor.Location = new System.Drawing.Point(0, 100);
            this.dgvBillEditor.MultiSelect = false;
            this.dgvBillEditor.Name = "dgvBillEditor";
            this.dgvBillEditor.RowHeadersVisible = false;
            this.dgvBillEditor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBillEditor.RowTemplate.Height = 30;
            this.dgvBillEditor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBillEditor.Size = new System.Drawing.Size(331, 279);
            this.dgvBillEditor.TabIndex = 151;
            // 
            // colBillLabel
            // 
            this.colBillLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.colBillLabel.DefaultCellStyle = dataGridViewCellStyle14;
            this.colBillLabel.HeaderText = "Label";
            this.colBillLabel.Name = "colBillLabel";
            this.colBillLabel.ReadOnly = true;
            this.colBillLabel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colBillInput
            // 
            this.colBillInput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Lime;
            this.colBillInput.DefaultCellStyle = dataGridViewCellStyle15;
            this.colBillInput.HeaderText = "BillTextbox";
            this.colBillInput.Name = "colBillInput";
            this.colBillInput.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colBillType
            // 
            this.colBillType.HeaderText = "colBillType";
            this.colBillType.Name = "colBillType";
            this.colBillType.Visible = false;
            // 
            // colRegEx
            // 
            this.colRegEx.HeaderText = "RegExFormat";
            this.colRegEx.Name = "colRegEx";
            this.colRegEx.Visible = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(81)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(75)))), ((int)(((byte)(81)))));
            this.customButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customButton2.BorderRadius = 6;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.IconColor = System.Drawing.Color.White;
            this.customButton2.IconSize = 50;
            this.customButton2.IconType = BJCBCPOS.Services.Fonts.POSIcons.Plus;
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customButton2.Location = new System.Drawing.Point(32, 194);
            this.customButton2.Name = "customButton2";
            this.customButton2.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.customButton2.ShowIcon = true;
            this.customButton2.Size = new System.Drawing.Size(148, 85);
            this.customButton2.TabIndex = 162;
            this.customButton2.Text = "เพิ่มรายการ";
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customButton1.BorderRadius = 6;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.IconColor = System.Drawing.Color.White;
            this.customButton1.IconSize = 50;
            this.customButton1.IconType = BJCBCPOS.Services.Fonts.POSIcons.CheckboxMarkedCircle;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(480, 194);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(8, 0, 30, 0);
            this.customButton1.ShowIcon = true;
            this.customButton1.Size = new System.Drawing.Size(182, 85);
            this.customButton1.TabIndex = 154;
            this.customButton1.Text = "ชำระ";
            this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // ucFooterTran1
            // 
            this.ucFooterTran1.BackColor = System.Drawing.Color.White;
            this.ucFooterTran1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucFooterTran1.fullContent = null;
            this.ucFooterTran1.functionId = null;
            this.ucFooterTran1.Location = new System.Drawing.Point(0, 728);
            this.ucFooterTran1.mainContent = null;
            this.ucFooterTran1.Name = "ucFooterTran1";
            this.ucFooterTran1.Size = new System.Drawing.Size(693, 40);
            this.ucFooterTran1.TabIndex = 92;
            // 
            // customButton4
            // 
            this.customButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.customButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(95)))));
            this.customButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customButton4.BorderRadius = 8;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.customButton4.ForeColor = System.Drawing.Color.Black;
            this.customButton4.IconColor = System.Drawing.Color.White;
            this.customButton4.IconType = BJCBCPOS.Services.Fonts.POSIcons.Close;
            this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.Location = new System.Drawing.Point(4, 5);
            this.customButton4.Name = "customButton4";
            this.customButton4.Padding = new System.Windows.Forms.Padding(8, 0, 12, 0);
            this.customButton4.ShowIcon = true;
            this.customButton4.Size = new System.Drawing.Size(104, 51);
            this.customButton4.TabIndex = 156;
            this.customButton4.Text = "ยกเลิก";
            this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton4.TextColor = System.Drawing.Color.Black;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.customButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customButton3.BorderRadius = 6;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.IconColor = System.Drawing.Color.White;
            this.customButton3.IconType = BJCBCPOS.Services.Fonts.POSIcons.CheckboxMarkedCircle;
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(224, 5);
            this.customButton3.Name = "customButton3";
            this.customButton3.Padding = new System.Windows.Forms.Padding(8, 0, 12, 0);
            this.customButton3.ShowIcon = true;
            this.customButton3.Size = new System.Drawing.Size(104, 49);
            this.customButton3.TabIndex = 155;
            this.customButton3.Text = "บันทึก";
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // ucKeypad
            // 
            this.ucKeypad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucKeypad.Location = new System.Drawing.Point(0, 440);
            this.ucKeypad.Name = "ucKeypad";
            this.ucKeypad.Size = new System.Drawing.Size(331, 285);
            this.ucKeypad.TabIndex = 3;
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
            this.ucHeader1.currentMenuTitle1 = "Bill Payment";
            this.ucHeader1.currentMenuTitle2 = "Service";
            this.ucHeader1.currentMenuTitle3 = "";
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.lblTotalFee);
            this.panel8.Controls.Add(this.lblTotalAmt);
            this.panel8.Controls.Add(this.lbSubtotal);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(693, 37);
            this.panel8.TabIndex = 163;
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmt.Location = new System.Drawing.Point(411, 3);
            this.lblTotalAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(90, 30);
            this.lblTotalAmt.TabIndex = 157;
            this.lblTotalAmt.Text = "0.00";
            this.lblTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFee.Location = new System.Drawing.Point(505, 3);
            this.lblTotalFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(73, 30);
            this.lblTotalFee.TabIndex = 158;
            this.lblTotalFee.Text = "0.00";
            this.lblTotalFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 30);
            this.label4.TabIndex = 164;
            this.label4.Text = "ราคารวม";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBillPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucFooterTran1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillPayment";
            this.Text = "frmBillPayment";
            this.Load += new System.EventHandler(this.frmBillPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillEditor)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCHeader ucHeader1;
        private System.Windows.Forms.Panel panel1;
        private UCKeypad ucKeypad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private UCFooterTran ucFooterTran1;
        private System.Windows.Forms.Panel panel2;
        private Controls.CustomButton customButton1;
        private System.Windows.Forms.Label lbTxtTotal;
        private System.Windows.Forms.Label lbTxtdiscount1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTxtSubtotal;
        private System.Windows.Forms.Label lbdiscount1;
        private System.Windows.Forms.Label lbSubtotal;
        private Controls.CustomButton customButton2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvBillEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegEx;
        private Controls.CustomButton customButton3;
        private Controls.CustomButton customButton4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.Label label4;
    }
}