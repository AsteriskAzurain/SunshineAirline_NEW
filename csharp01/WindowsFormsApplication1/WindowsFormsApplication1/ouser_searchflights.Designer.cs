namespace WindowsFormsApplication1
{
    partial class ouser_searchflights
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFLT = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCabin = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateRTN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateDEP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbARRct = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDEPct = new System.Windows.Forms.ComboBox();
            this.grpways = new System.Windows.Forms.GroupBox();
            this.radioRoundWay = new System.Windows.Forms.RadioButton();
            this.radioOneWay = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pFLTrs = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pRTNrs = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpways.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.grpways);
            this.groupBox1.Font = new System.Drawing.Font("TeXGyreAdventor", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(252, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(950, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(860, 65);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.cbFLT);
            this.groupBox8.Location = new System.Drawing.Point(727, 15);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(112, 85);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Flight Type:";
            // 
            // cbFLT
            // 
            this.cbFLT.FormattingEnabled = true;
            this.cbFLT.Items.AddRange(new object[] {
            "All",
            "Non-stop",
            "stop"});
            this.cbFLT.Location = new System.Drawing.Point(10, 51);
            this.cbFLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFLT.Name = "cbFLT";
            this.cbFLT.Size = new System.Drawing.Size(97, 25);
            this.cbFLT.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.cbCabin);
            this.groupBox7.Location = new System.Drawing.Point(614, 15);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(112, 85);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cabin Type:";
            // 
            // cbCabin
            // 
            this.cbCabin.FormattingEnabled = true;
            this.cbCabin.Location = new System.Drawing.Point(10, 51);
            this.cbCabin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCabin.Name = "cbCabin";
            this.cbCabin.Size = new System.Drawing.Size(97, 25);
            this.cbCabin.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateRTN);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(474, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(136, 85);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Visible = false;
            // 
            // dateRTN
            // 
            this.dateRTN.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRTN.CustomFormat = "yyyy-MM-dd";
            this.dateRTN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRTN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRTN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateRTN.Location = new System.Drawing.Point(10, 53);
            this.dateRTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateRTN.Name = "dateRTN";
            this.dateRTN.Size = new System.Drawing.Size(115, 20);
            this.dateRTN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Return Date:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateDEP);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(347, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(128, 85);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // dateDEP
            // 
            this.dateDEP.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDEP.CustomFormat = "yyyy-MM-dd";
            this.dateDEP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateDEP.Location = new System.Drawing.Point(6, 53);
            this.dateDEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDEP.MinDate = new System.DateTime(2020, 1, 13, 0, 0, 0, 0);
            this.dateDEP.Name = "dateDEP";
            this.dateDEP.Size = new System.Drawing.Size(115, 20);
            this.dateDEP.TabIndex = 1;
            this.dateDEP.ValueChanged += new System.EventHandler(this.dateDEP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Departure Date:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbARRct);
            this.groupBox4.Location = new System.Drawing.Point(236, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(112, 85);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "To City:";
            // 
            // cbARRct
            // 
            this.cbARRct.FormattingEnabled = true;
            this.cbARRct.Location = new System.Drawing.Point(10, 51);
            this.cbARRct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbARRct.Name = "cbARRct";
            this.cbARRct.Size = new System.Drawing.Size(97, 25);
            this.cbARRct.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbDEPct);
            this.groupBox3.Location = new System.Drawing.Point(125, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(112, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "From City:";
            // 
            // cbDEPct
            // 
            this.cbDEPct.FormattingEnabled = true;
            this.cbDEPct.Location = new System.Drawing.Point(10, 51);
            this.cbDEPct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDEPct.Name = "cbDEPct";
            this.cbDEPct.Size = new System.Drawing.Size(97, 25);
            this.cbDEPct.TabIndex = 0;
            // 
            // grpways
            // 
            this.grpways.Controls.Add(this.radioRoundWay);
            this.grpways.Controls.Add(this.radioOneWay);
            this.grpways.Location = new System.Drawing.Point(6, 15);
            this.grpways.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpways.Name = "grpways";
            this.grpways.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpways.Size = new System.Drawing.Size(127, 85);
            this.grpways.TabIndex = 0;
            this.grpways.TabStop = false;
            this.grpways.Enter += new System.EventHandler(this.grpways_Enter);
            // 
            // radioRoundWay
            // 
            this.radioRoundWay.AutoSize = true;
            this.radioRoundWay.Location = new System.Drawing.Point(17, 52);
            this.radioRoundWay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioRoundWay.Name = "radioRoundWay";
            this.radioRoundWay.Size = new System.Drawing.Size(97, 21);
            this.radioRoundWay.TabIndex = 1;
            this.radioRoundWay.Text = "Round Ways";
            this.radioRoundWay.UseVisualStyleBackColor = true;
            this.radioRoundWay.CheckedChanged += new System.EventHandler(this.radioRoundWay_CheckedChanged);
            // 
            // radioOneWay
            // 
            this.radioOneWay.AutoSize = true;
            this.radioOneWay.Location = new System.Drawing.Point(17, 21);
            this.radioOneWay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioOneWay.Name = "radioOneWay";
            this.radioOneWay.Size = new System.Drawing.Size(80, 21);
            this.radioOneWay.TabIndex = 0;
            this.radioOneWay.Text = "One Way";
            this.radioOneWay.UseVisualStyleBackColor = true;
            this.radioOneWay.CheckedChanged += new System.EventHandler(this.radioOneWay_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search Flights";
            // 
            // pFLTrs
            // 
            this.pFLTrs.AutoScroll = true;
            this.pFLTrs.BackColor = System.Drawing.Color.White;
            this.pFLTrs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFLTrs.Location = new System.Drawing.Point(22, 210);
            this.pFLTrs.Name = "pFLTrs";
            this.pFLTrs.Size = new System.Drawing.Size(1380, 361);
            this.pFLTrs.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Departure Flights";
            // 
            // pRTNrs
            // 
            this.pRTNrs.AutoScroll = true;
            this.pRTNrs.BackColor = System.Drawing.Color.White;
            this.pRTNrs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pRTNrs.Location = new System.Drawing.Point(22, 608);
            this.pRTNrs.Name = "pRTNrs";
            this.pRTNrs.Size = new System.Drawing.Size(1380, 246);
            this.pRTNrs.TabIndex = 9;
            this.pRTNrs.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Return Flights";
            this.label9.Visible = false;
            // 
            // ouser_searchflights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1428, 865);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pRTNrs);
            this.Controls.Add(this.pFLTrs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ouser_searchflights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Flights";
            this.Load += new System.EventHandler(this.ouser_searchflights_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpways.ResumeLayout(false);
            this.grpways.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFLT;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCabin;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateRTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateDEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbARRct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDEPct;
        private System.Windows.Forms.GroupBox grpways;
        private System.Windows.Forms.RadioButton radioRoundWay;
        private System.Windows.Forms.RadioButton radioOneWay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pFLTrs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pRTNrs;
        private System.Windows.Forms.Label label9;
    }
}