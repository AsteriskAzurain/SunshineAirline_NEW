namespace WindowsFormsApplication1.Usercontrol
{
    partial class flightOneWay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCabin = new System.Windows.Forms.Label();
            this.lblFLTnum = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pDEP = new System.Windows.Forms.Panel();
            this.lbltimeDEP = new System.Windows.Forms.Label();
            this.lblDEP = new System.Windows.Forms.Label();
            this.pARR = new System.Windows.Forms.Panel();
            this.lbltimeARR = new System.Windows.Forms.Label();
            this.lblARR = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblavl = new System.Windows.Forms.Label();
            this.lbltt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFLTtp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pDEP.SuspendLayout();
            this.pARR.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 60);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Select";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCabin);
            this.panel2.Controls.Add(this.lblFLTnum);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(130, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 114);
            this.panel2.TabIndex = 9;
            // 
            // lblCabin
            // 
            this.lblCabin.AutoSize = true;
            this.lblCabin.Location = new System.Drawing.Point(45, 44);
            this.lblCabin.Name = "lblCabin";
            this.lblCabin.Size = new System.Drawing.Size(69, 19);
            this.lblCabin.TabIndex = 9;
            this.lblCabin.Text = "Economy";
            // 
            // lblFLTnum
            // 
            this.lblFLTnum.AutoSize = true;
            this.lblFLTnum.Location = new System.Drawing.Point(26, 77);
            this.lblFLTnum.Name = "lblFLTnum";
            this.lblFLTnum.Size = new System.Drawing.Size(105, 19);
            this.lblFLTnum.TabIndex = 7;
            this.lblFLTnum.Text = "Flight 101 (95%)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(52, 14);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 19);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "$154.40";
            // 
            // pDEP
            // 
            this.pDEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDEP.Controls.Add(this.lbltimeDEP);
            this.pDEP.Controls.Add(this.lblDEP);
            this.pDEP.Location = new System.Drawing.Point(295, 15);
            this.pDEP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDEP.Name = "pDEP";
            this.pDEP.Size = new System.Drawing.Size(397, 56);
            this.pDEP.TabIndex = 12;
            // 
            // lbltimeDEP
            // 
            this.lbltimeDEP.AutoSize = true;
            this.lbltimeDEP.Location = new System.Drawing.Point(167, 17);
            this.lbltimeDEP.Name = "lbltimeDEP";
            this.lbltimeDEP.Size = new System.Drawing.Size(91, 13);
            this.lbltimeDEP.TabIndex = 1;
            this.lbltimeDEP.Text = "2018-06-25 08:05";
            // 
            // lblDEP
            // 
            this.lblDEP.AutoSize = true;
            this.lblDEP.Location = new System.Drawing.Point(20, 17);
            this.lblDEP.Name = "lblDEP";
            this.lblDEP.Size = new System.Drawing.Size(64, 13);
            this.lblDEP.TabIndex = 0;
            this.lblDEP.Text = "Beijing/PEK";
            // 
            // pARR
            // 
            this.pARR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pARR.Controls.Add(this.lbltimeARR);
            this.pARR.Controls.Add(this.lblARR);
            this.pARR.Location = new System.Drawing.Point(295, 73);
            this.pARR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pARR.Name = "pARR";
            this.pARR.Size = new System.Drawing.Size(397, 56);
            this.pARR.TabIndex = 13;
            // 
            // lbltimeARR
            // 
            this.lbltimeARR.AutoSize = true;
            this.lbltimeARR.Location = new System.Drawing.Point(167, 17);
            this.lbltimeARR.Name = "lbltimeARR";
            this.lbltimeARR.Size = new System.Drawing.Size(91, 13);
            this.lbltimeARR.TabIndex = 3;
            this.lbltimeARR.Text = "2018-06-25 18:05";
            // 
            // lblARR
            // 
            this.lblARR.AutoSize = true;
            this.lblARR.Location = new System.Drawing.Point(20, 17);
            this.lblARR.Name = "lblARR";
            this.lblARR.Size = new System.Drawing.Size(57, 13);
            this.lblARR.TabIndex = 2;
            this.lblARR.Text = "Rome/CIA";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lblavl);
            this.panel9.Controls.Add(this.lbltt);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.lblFLTtp);
            this.panel9.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(700, 15);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(158, 114);
            this.panel9.TabIndex = 14;
            // 
            // lblavl
            // 
            this.lblavl.AutoSize = true;
            this.lblavl.Location = new System.Drawing.Point(18, 76);
            this.lblavl.Name = "lblavl";
            this.lblavl.Size = new System.Drawing.Size(123, 19);
            this.lblavl.TabIndex = 9;
            this.lblavl.Text = "3 available tickets";
            // 
            // lbltt
            // 
            this.lbltt.AutoSize = true;
            this.lbltt.Font = new System.Drawing.Font("TeXGyreAdventor", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltt.Location = new System.Drawing.Point(89, 49);
            this.lbltt.Name = "lbltt";
            this.lbltt.Size = new System.Drawing.Size(46, 16);
            this.lbltt.TabIndex = 8;
            this.lbltt.Text = "10h 0m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("TeXGyreAdventor", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total Time";
            // 
            // lblFLTtp
            // 
            this.lblFLTtp.AutoSize = true;
            this.lblFLTtp.Location = new System.Drawing.Point(52, 15);
            this.lblFLTtp.Name = "lblFLTtp";
            this.lblFLTtp.Size = new System.Drawing.Size(68, 19);
            this.lblFLTtp.TabIndex = 3;
            this.lblFLTtp.Text = "Non-Stop";
            // 
            // flightOneWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pARR);
            this.Controls.Add(this.pDEP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radioButton2);
            this.Name = "flightOneWay";
            this.Size = new System.Drawing.Size(878, 145);
            this.Load += new System.EventHandler(this.flightOneWay_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pDEP.ResumeLayout(false);
            this.pDEP.PerformLayout();
            this.pARR.ResumeLayout(false);
            this.pARR.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCabin;
        private System.Windows.Forms.Label lblFLTnum;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pDEP;
        private System.Windows.Forms.Label lbltimeDEP;
        private System.Windows.Forms.Label lblDEP;
        private System.Windows.Forms.Panel pARR;
        private System.Windows.Forms.Label lbltimeARR;
        private System.Windows.Forms.Label lblARR;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblavl;
        private System.Windows.Forms.Label lbltt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFLTtp;
    }
}
