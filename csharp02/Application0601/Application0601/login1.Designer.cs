namespace Application0601
{
    partial class login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grp1_vercode = new System.Windows.Forms.GroupBox();
            this.pic1_ver = new System.Windows.Forms.PictureBox();
            this.tb1_vercode = new System.Windows.Forms.TextBox();
            this.tb1_email = new System.Windows.Forms.TextBox();
            this.tb1_pswd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn1_cancel = new System.Windows.Forms.Button();
            this.grp1_auto = new System.Windows.Forms.GroupBox();
            this.btn1_login = new System.Windows.Forms.Button();
            this.btn1_clz = new System.Windows.Forms.Button();
            this.ckb1_login = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp1_vercode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_ver)).BeginInit();
            this.grp1_auto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "The system canbe logged in through email and password.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Verification Code:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grp1_vercode
            // 
            this.grp1_vercode.Controls.Add(this.pic1_ver);
            this.grp1_vercode.Controls.Add(this.tb1_vercode);
            this.grp1_vercode.Controls.Add(this.label4);
            this.grp1_vercode.Location = new System.Drawing.Point(123, 312);
            this.grp1_vercode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1_vercode.Name = "grp1_vercode";
            this.grp1_vercode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1_vercode.Size = new System.Drawing.Size(598, 65);
            this.grp1_vercode.TabIndex = 6;
            this.grp1_vercode.TabStop = false;
            // 
            // pic1_ver
            // 
            this.pic1_ver.Location = new System.Drawing.Point(475, 15);
            this.pic1_ver.Name = "pic1_ver";
            this.pic1_ver.Size = new System.Drawing.Size(100, 42);
            this.pic1_ver.TabIndex = 10;
            this.pic1_ver.TabStop = false;
            this.pic1_ver.Click += new System.EventHandler(this.pic1_ver_Click);
            // 
            // tb1_vercode
            // 
            this.tb1_vercode.Location = new System.Drawing.Point(185, 19);
            this.tb1_vercode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1_vercode.Name = "tb1_vercode";
            this.tb1_vercode.Size = new System.Drawing.Size(257, 26);
            this.tb1_vercode.TabIndex = 9;
            // 
            // tb1_email
            // 
            this.tb1_email.Location = new System.Drawing.Point(308, 232);
            this.tb1_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1_email.Name = "tb1_email";
            this.tb1_email.Size = new System.Drawing.Size(257, 26);
            this.tb1_email.TabIndex = 7;
            // 
            // tb1_pswd
            // 
            this.tb1_pswd.Location = new System.Drawing.Point(308, 284);
            this.tb1_pswd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb1_pswd.Name = "tb1_pswd";
            this.tb1_pswd.Size = new System.Drawing.Size(257, 26);
            this.tb1_pswd.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Auto login in 3s... ";
            // 
            // btn1_cancel
            // 
            this.btn1_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_cancel.Location = new System.Drawing.Point(185, 12);
            this.btn1_cancel.Name = "btn1_cancel";
            this.btn1_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn1_cancel.TabIndex = 10;
            this.btn1_cancel.Text = "cancel";
            this.btn1_cancel.UseVisualStyleBackColor = true;
            this.btn1_cancel.Click += new System.EventHandler(this.btn1_cancel_Click);
            // 
            // grp1_auto
            // 
            this.grp1_auto.Controls.Add(this.label6);
            this.grp1_auto.Controls.Add(this.btn1_cancel);
            this.grp1_auto.Location = new System.Drawing.Point(260, 385);
            this.grp1_auto.Name = "grp1_auto";
            this.grp1_auto.Size = new System.Drawing.Size(290, 44);
            this.grp1_auto.TabIndex = 11;
            this.grp1_auto.TabStop = false;
            this.grp1_auto.Enter += new System.EventHandler(this.grp1_auto_Enter);
            // 
            // btn1_login
            // 
            this.btn1_login.Location = new System.Drawing.Point(248, 447);
            this.btn1_login.Name = "btn1_login";
            this.btn1_login.Size = new System.Drawing.Size(75, 40);
            this.btn1_login.TabIndex = 12;
            this.btn1_login.Text = "Login";
            this.btn1_login.UseVisualStyleBackColor = true;
            this.btn1_login.Click += new System.EventHandler(this.btn1_login_Click);
            // 
            // btn1_clz
            // 
            this.btn1_clz.Location = new System.Drawing.Point(490, 447);
            this.btn1_clz.Name = "btn1_clz";
            this.btn1_clz.Size = new System.Drawing.Size(75, 40);
            this.btn1_clz.TabIndex = 13;
            this.btn1_clz.Text = "Close";
            this.btn1_clz.UseVisualStyleBackColor = true;
            this.btn1_clz.Click += new System.EventHandler(this.btn1_clz_Click);
            // 
            // ckb1_login
            // 
            this.ckb1_login.AutoSize = true;
            this.ckb1_login.Location = new System.Drawing.Point(308, 400);
            this.ckb1_login.Name = "ckb1_login";
            this.ckb1_login.Size = new System.Drawing.Size(165, 24);
            this.ckb1_login.TabIndex = 14;
            this.ckb1_login.Text = "Auto login in 7 days";
            this.ckb1_login.UseVisualStyleBackColor = true;
            this.ckb1_login.CheckedChanged += new System.EventHandler(this.ckb1_login_CheckedChanged);
            // 
            // login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(811, 530);
            this.Controls.Add(this.ckb1_login);
            this.Controls.Add(this.btn1_clz);
            this.Controls.Add(this.btn1_login);
            this.Controls.Add(this.grp1_auto);
            this.Controls.Add(this.tb1_pswd);
            this.Controls.Add(this.tb1_email);
            this.Controls.Add(this.grp1_vercode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "login1";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp1_vercode.ResumeLayout(false);
            this.grp1_vercode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_ver)).EndInit();
            this.grp1_auto.ResumeLayout(false);
            this.grp1_auto.PerformLayout();
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
        private System.Windows.Forms.GroupBox grp1_vercode;
        private System.Windows.Forms.PictureBox pic1_ver;
        private System.Windows.Forms.TextBox tb1_vercode;
        private System.Windows.Forms.TextBox tb1_email;
        private System.Windows.Forms.TextBox tb1_pswd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn1_cancel;
        private System.Windows.Forms.GroupBox grp1_auto;
        private System.Windows.Forms.Button btn1_login;
        private System.Windows.Forms.Button btn1_clz;
        private System.Windows.Forms.CheckBox ckb1_login;
    }
}