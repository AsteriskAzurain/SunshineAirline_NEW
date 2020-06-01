namespace WindowsFormsApplication1.Usercontrol
{
    partial class ticketlabel
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
            this.lblseat = new System.Windows.Forms.Label();
            this.lblsold = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblrate = new System.Windows.Forms.Label();
            this.lblcabin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblseat
            // 
            this.lblseat.AutoSize = true;
            this.lblseat.Location = new System.Drawing.Point(84, 56);
            this.lblseat.Name = "lblseat";
            this.lblseat.Size = new System.Drawing.Size(13, 13);
            this.lblseat.TabIndex = 30;
            this.lblseat.Text = "0";
            // 
            // lblsold
            // 
            this.lblsold.AutoSize = true;
            this.lblsold.Location = new System.Drawing.Point(84, 45);
            this.lblsold.Name = "lblsold";
            this.lblsold.Size = new System.Drawing.Size(13, 13);
            this.lblsold.TabIndex = 29;
            this.lblsold.Text = "0";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(84, 35);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(13, 13);
            this.lbltotal.TabIndex = 28;
            this.lbltotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sold Tickets:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seats Selected:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total Tickets:";
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblrate.Location = new System.Drawing.Point(42, 23);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(57, 19);
            this.lblrate.TabIndex = 24;
            this.lblrate.Text = "2/8 25%";
            // 
            // lblcabin
            // 
            this.lblcabin.AutoSize = true;
            this.lblcabin.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcabin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcabin.Location = new System.Drawing.Point(31, 8);
            this.lblcabin.Name = "lblcabin";
            this.lblcabin.Size = new System.Drawing.Size(86, 25);
            this.lblcabin.TabIndex = 23;
            this.lblcabin.Text = "First Class";
            // 
            // ticketlabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblseat);
            this.Controls.Add(this.lblsold);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.lblcabin);
            this.Name = "ticketlabel";
            this.Size = new System.Drawing.Size(165, 135);
            this.Load += new System.EventHandler(this.ticketlabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblseat;
        private System.Windows.Forms.Label lblsold;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.Label lblcabin;
    }
}
