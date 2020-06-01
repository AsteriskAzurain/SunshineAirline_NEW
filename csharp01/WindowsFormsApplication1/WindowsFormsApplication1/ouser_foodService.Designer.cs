namespace WindowsFormsApplication1
{
    partial class ouser_foodService
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbIDn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIDtp = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbFLT = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnCfm = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Food Services";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbIDn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbIDtp);
            this.panel1.Location = new System.Drawing.Point(27, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 63);
            this.panel1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(557, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbIDn
            // 
            this.tbIDn.Location = new System.Drawing.Point(256, 29);
            this.tbIDn.Name = "tbIDn";
            this.tbIDn.Size = new System.Drawing.Size(205, 31);
            this.tbIDn.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID Type Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID Type:";
            // 
            // cbIDtp
            // 
            this.cbIDtp.FormattingEnabled = true;
            this.cbIDtp.Items.AddRange(new object[] {
            "ID Card",
            "Passport"});
            this.cbIDtp.Location = new System.Drawing.Point(29, 29);
            this.cbIDtp.Name = "cbIDtp";
            this.cbIDtp.Size = new System.Drawing.Size(187, 31);
            this.cbIDtp.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.cbFLT);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(27, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 63);
            this.panel2.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(557, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 25);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbFLT
            // 
            this.cbFLT.FormattingEnabled = true;
            this.cbFLT.Location = new System.Drawing.Point(105, 16);
            this.cbFLT.Name = "cbFLT";
            this.cbFLT.Size = new System.Drawing.Size(356, 31);
            this.cbFLT.TabIndex = 1;
            this.cbFLT.SelectionChangeCommitted += new System.EventHandler(this.cbFLT_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Flight:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(27, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 244);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected Items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Payment:";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPay.Location = new System.Drawing.Point(174, 529);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(2, 25);
            this.lblPay.TabIndex = 12;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmt.Location = new System.Drawing.Point(174, 502);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(2, 25);
            this.lblAmt.TabIndex = 11;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.Location = new System.Drawing.Point(174, 474);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(2, 25);
            this.lblNum.TabIndex = 10;
            // 
            // btnCfm
            // 
            this.btnCfm.Location = new System.Drawing.Point(500, 497);
            this.btnCfm.Name = "btnCfm";
            this.btnCfm.Size = new System.Drawing.Size(85, 32);
            this.btnCfm.TabIndex = 13;
            this.btnCfm.Text = "Confirm";
            this.btnCfm.UseVisualStyleBackColor = true;
            this.btnCfm.Click += new System.EventHandler(this.btnCfm_Click);
            // 
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(648, 497);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(82, 32);
            this.btnCL.TabIndex = 14;
            this.btnCL.Text = "Cancel";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.btnCL_Click);
            // 
            // ouser_foodService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnCL);
            this.Controls.Add(this.btnCfm);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ouser_foodService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Services";
            this.Load += new System.EventHandler(this.ouser_foodService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbIDn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIDtp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbFLT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnCfm;
        private System.Windows.Forms.Button btnCL;
    }
}