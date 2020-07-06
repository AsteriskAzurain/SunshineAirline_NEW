namespace Application0701
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblvcode = new System.Windows.Forms.Label();
            this.txtvcode = new System.Windows.Forms.TextBox();
            this.btnautologin = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpswd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclz = new System.Windows.Forms.Button();
            this.ckbauto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "The system can be logged in through email and password.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Verification Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblvcode);
            this.groupBox1.Controls.Add(this.txtvcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(81, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // lblvcode
            // 
            this.lblvcode.AutoSize = true;
            this.lblvcode.Location = new System.Drawing.Point(268, 16);
            this.lblvcode.Name = "lblvcode";
            this.lblvcode.Size = new System.Drawing.Size(43, 13);
            this.lblvcode.TabIndex = 7;
            this.lblvcode.Text = "验证码";
            this.lblvcode.Click += new System.EventHandler(this.lblvcode_Click);
            // 
            // txtvcode
            // 
            this.txtvcode.Location = new System.Drawing.Point(111, 13);
            this.txtvcode.Name = "txtvcode";
            this.txtvcode.Size = new System.Drawing.Size(115, 20);
            this.txtvcode.TabIndex = 6;
            // 
            // btnautologin
            // 
            this.btnautologin.Location = new System.Drawing.Point(434, 209);
            this.btnautologin.Name = "btnautologin";
            this.btnautologin.Size = new System.Drawing.Size(120, 46);
            this.btnautologin.TabIndex = 9;
            this.btnautologin.Text = "Auto login in 3s... Click to Cancel";
            this.btnautologin.UseVisualStyleBackColor = true;
            this.btnautologin.Visible = false;
            this.btnautologin.Click += new System.EventHandler(this.btnautologin_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(192, 180);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtpswd
            // 
            this.txtpswd.Location = new System.Drawing.Point(192, 223);
            this.txtpswd.Name = "txtpswd";
            this.txtpswd.Size = new System.Drawing.Size(200, 20);
            this.txtpswd.TabIndex = 8;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(142, 351);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclz
            // 
            this.btnclz.Location = new System.Drawing.Point(340, 351);
            this.btnclz.Name = "btnclz";
            this.btnclz.Size = new System.Drawing.Size(75, 23);
            this.btnclz.TabIndex = 11;
            this.btnclz.Text = "Close";
            this.btnclz.UseVisualStyleBackColor = true;
            this.btnclz.Click += new System.EventHandler(this.btnclz_Click);
            // 
            // ckbauto
            // 
            this.ckbauto.AutoSize = true;
            this.ckbauto.Location = new System.Drawing.Point(205, 319);
            this.ckbauto.Name = "ckbauto";
            this.ckbauto.Size = new System.Drawing.Size(122, 17);
            this.ckbauto.TabIndex = 12;
            this.ckbauto.Text = "Auto Login in 7 days";
            this.ckbauto.UseVisualStyleBackColor = true;
            this.ckbauto.CheckedChanged += new System.EventHandler(this.ckbauto_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 424);
            this.Controls.Add(this.ckbauto);
            this.Controls.Add(this.btnclz);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnautologin);
            this.Controls.Add(this.txtpswd);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblvcode;
        private System.Windows.Forms.TextBox txtvcode;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpswd;
        private System.Windows.Forms.Button btnautologin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclz;
        private System.Windows.Forms.CheckBox ckbauto;
    }
}

