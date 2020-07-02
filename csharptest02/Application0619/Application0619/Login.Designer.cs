namespace Application0619
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp3s = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpvcode = new System.Windows.Forms.GroupBox();
            this.lblvcode = new System.Windows.Forms.Label();
            this.piccode = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvcode = new System.Windows.Forms.TextBox();
            this.btnclz = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.ckautologin = new System.Windows.Forms.CheckBox();
            this.txtpswd = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp3s.SuspendLayout();
            this.grpvcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "The system can be logged in through email and password.";
            // 
            // grp3s
            // 
            this.grp3s.Controls.Add(this.btncancel);
            this.grp3s.Controls.Add(this.label6);
            this.grp3s.Location = new System.Drawing.Point(533, 157);
            this.grp3s.Name = "grp3s";
            this.grp3s.Size = new System.Drawing.Size(200, 114);
            this.grp3s.TabIndex = 23;
            this.grp3s.TabStop = false;
            this.grp3s.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(35, 59);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 37);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Auto login in 3s...";
            // 
            // grpvcode
            // 
            this.grpvcode.Controls.Add(this.lblvcode);
            this.grpvcode.Controls.Add(this.piccode);
            this.grpvcode.Controls.Add(this.label5);
            this.grpvcode.Controls.Add(this.txtvcode);
            this.grpvcode.Location = new System.Drawing.Point(121, 294);
            this.grpvcode.Name = "grpvcode";
            this.grpvcode.Size = new System.Drawing.Size(476, 100);
            this.grpvcode.TabIndex = 22;
            this.grpvcode.TabStop = false;
            this.grpvcode.Visible = false;
            // 
            // lblvcode
            // 
            this.lblvcode.AutoSize = true;
            this.lblvcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvcode.Location = new System.Drawing.Point(276, 19);
            this.lblvcode.Name = "lblvcode";
            this.lblvcode.Size = new System.Drawing.Size(129, 29);
            this.lblvcode.TabIndex = 13;
            this.lblvcode.Text = "verity code";
            this.lblvcode.Click += new System.EventHandler(this.lblvcode_Click);
            // 
            // piccode
            // 
            this.piccode.Location = new System.Drawing.Point(376, 50);
            this.piccode.Name = "piccode";
            this.piccode.Size = new System.Drawing.Size(100, 50);
            this.piccode.TabIndex = 12;
            this.piccode.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Verification Code:";
            // 
            // txtvcode
            // 
            this.txtvcode.Location = new System.Drawing.Point(150, 19);
            this.txtvcode.Name = "txtvcode";
            this.txtvcode.Size = new System.Drawing.Size(100, 20);
            this.txtvcode.TabIndex = 8;
            // 
            // btnclz
            // 
            this.btnclz.Location = new System.Drawing.Point(431, 456);
            this.btnclz.Name = "btnclz";
            this.btnclz.Size = new System.Drawing.Size(75, 30);
            this.btnclz.TabIndex = 21;
            this.btnclz.Text = "Close";
            this.btnclz.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(185, 456);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 30);
            this.btnlogin.TabIndex = 20;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // ckautologin
            // 
            this.ckautologin.AutoSize = true;
            this.ckautologin.Location = new System.Drawing.Point(286, 417);
            this.ckautologin.Name = "ckautologin";
            this.ckautologin.Size = new System.Drawing.Size(118, 17);
            this.ckautologin.TabIndex = 19;
            this.ckautologin.Text = "Auto login in 7 days";
            this.ckautologin.UseVisualStyleBackColor = true;
            // 
            // txtpswd
            // 
            this.txtpswd.Location = new System.Drawing.Point(271, 255);
            this.txtpswd.Name = "txtpswd";
            this.txtpswd.Size = new System.Drawing.Size(196, 20);
            this.txtpswd.TabIndex = 18;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(270, 218);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(196, 20);
            this.txtemail.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 513);
            this.Controls.Add(this.grp3s);
            this.Controls.Add(this.grpvcode);
            this.Controls.Add(this.btnclz);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.ckautologin);
            this.Controls.Add(this.txtpswd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp3s.ResumeLayout(false);
            this.grp3s.PerformLayout();
            this.grpvcode.ResumeLayout(false);
            this.grpvcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp3s;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpvcode;
        private System.Windows.Forms.PictureBox piccode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvcode;
        private System.Windows.Forms.Button btnclz;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox ckautologin;
        private System.Windows.Forms.TextBox txtpswd;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblvcode;
    }
}

