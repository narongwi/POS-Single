namespace BJCBCPOS
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbCal = new System.Windows.Forms.Label();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbMessage);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbCal);
            this.panel1.Controls.Add(this.btn00);
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.btndot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(316, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 400);
            this.panel1.TabIndex = 0;
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(5, 5);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(278, 29);
            this.lbMessage.TabIndex = 167;
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BJCBCPOS.Properties.Resources.icon_textbox_delete;
            this.pictureBox2.Location = new System.Drawing.Point(296, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 166;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbCal
            // 
            this.lbCal.BackColor = System.Drawing.Color.White;
            this.lbCal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal.Location = new System.Drawing.Point(0, 43);
            this.lbCal.Name = "lbCal";
            this.lbCal.Size = new System.Drawing.Size(336, 60);
            this.lbCal.TabIndex = 165;
            this.lbCal.Text = "0";
            this.lbCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.White;
            this.btn00.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.ForeColor = System.Drawing.Color.Black;
            this.btn00.Location = new System.Drawing.Point(67, 339);
            this.btn00.Margin = new System.Windows.Forms.Padding(2);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(68, 60);
            this.btn00.TabIndex = 164;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.Num0Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.White;
            this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.Location = new System.Drawing.Point(268, 221);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(68, 60);
            this.btnDivide.TabIndex = 163;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.White;
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(201, 221);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(68, 60);
            this.btnMultiply.TabIndex = 162;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(0, 103);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 60);
            this.btnClear.TabIndex = 161;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.White;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.Location = new System.Drawing.Point(268, 162);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(68, 60);
            this.btnMinus.TabIndex = 160;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(201, 162);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(68, 60);
            this.btnPlus.TabIndex = 159;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(0, 221);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 60);
            this.btn4.TabIndex = 146;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(0, 162);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 60);
            this.btn7.TabIndex = 154;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(134, 221);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 60);
            this.btn6.TabIndex = 152;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(67, 221);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 60);
            this.btn5.TabIndex = 151;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(67, 280);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 60);
            this.btn2.TabIndex = 153;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(0, 280);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 60);
            this.btn1.TabIndex = 150;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(134, 162);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 60);
            this.btn9.TabIndex = 149;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(134, 280);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 60);
            this.btn3.TabIndex = 155;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(67, 162);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 60);
            this.btn8.TabIndex = 148;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumClick);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(201, 280);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(135, 119);
            this.btnEnter.TabIndex = 158;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.White;
            this.btndot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.Color.Black;
            this.btndot.Location = new System.Drawing.Point(134, 339);
            this.btndot.Margin = new System.Windows.Forms.Padding(2);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(68, 60);
            this.btndot.TabIndex = 156;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.NumClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(0, 339);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(68, 60);
            this.btn0.TabIndex = 147;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnDelete.BackgroundImage = global::BJCBCPOS.Properties.Resources.keypad1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(134, 103);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 60);
            this.btnDelete.TabIndex = 157;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(210)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCalculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCal;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbMessage;

    }
}