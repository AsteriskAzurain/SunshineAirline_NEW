namespace Application0604
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpvcode = new System.Windows.Forms.GroupBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpswd = new System.Windows.Forms.TextBox();
            this.tbvcode = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ckbauto = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclz = new System.Windows.Forms.Button();
            this.grpauto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpvcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpauto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "The system can be logged in through email and password.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 248);
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
            // grpvcode
            // 
            this.grpvcode.BackColor = System.Drawing.Color.Transparent;
            this.grpvcode.Controls.Add(this.pictureBox2);
            this.grpvcode.Controls.Add(this.tbvcode);
            this.grpvcode.Controls.Add(this.label5);
            this.grpvcode.Location = new System.Drawing.Point(116, 290);
            this.grpvcode.Name = "grpvcode";
            this.grpvcode.Size = new System.Drawing.Size(518, 78);
            this.grpvcode.TabIndex = 6;
            this.grpvcode.TabStop = false;
            this.grpvcode.Visible = false;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(248, 197);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(363, 20);
            this.tbemail.TabIndex = 7;
            // 
            // tbpswd
            // 
            this.tbpswd.Location = new System.Drawing.Point(248, 245);
            this.tbpswd.Name = "tbpswd";
            this.tbpswd.Size = new System.Drawing.Size(363, 20);
            this.tbpswd.TabIndex = 8;
            // 
            // tbvcode
            // 
            this.tbvcode.Location = new System.Drawing.Point(133, 13);
            this.tbvcode.Name = "tbvcode";
            this.tbvcode.Size = new System.Drawing.Size(239, 20);
            this.tbvcode.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(397, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ckbauto
            // 
            this.ckbauto.AutoSize = true;
            this.ckbauto.Location = new System.Drawing.Point(321, 337);
            this.ckbauto.Name = "ckbauto";
            this.ckbauto.Size = new System.Drawing.Size(118, 17);
            this.ckbauto.TabIndex = 9;
            this.ckbauto.Text = "Auto login in 7 days";
            this.ckbauto.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(212, 399);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclz
            // 
            this.btnclz.Location = new System.Drawing.Point(438, 399);
            this.btnclz.Name = "btnclz";
            this.btnclz.Size = new System.Drawing.Size(75, 23);
            this.btnclz.TabIndex = 11;
            this.btnclz.Text = "Close";
            this.btnclz.UseVisualStyleBackColor = true;
            this.btnclz.Click += new System.EventHandler(this.btnclz_Click);
            // 
            // grpauto
            // 
            this.grpauto.Controls.Add(this.btncancel);
            this.grpauto.Controls.Add(this.label6);
            this.grpauto.Location = new System.Drawing.Point(548, 364);
            this.grpauto.Name = "grpauto";
            this.grpauto.Size = new System.Drawing.Size(163, 91);
            this.grpauto.TabIndex = 12;
            this.grpauto.TabStop = false;
            this.grpauto.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "auto login in 3s...";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(41, 46);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 467);
            this.Controls.Add(this.grpauto);
            this.Controls.Add(this.btnclz);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.ckbauto);
            this.Controls.Add(this.tbpswd);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.grpvcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpvcode.ResumeLayout(false);
            this.grpvcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpauto.ResumeLayout(false);
            this.grpauto.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpvcode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbvcode;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpswd;
        private System.Windows.Forms.CheckBox ckbauto;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclz;
        private System.Windows.Forms.GroupBox grpauto;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label6;
    }
}

