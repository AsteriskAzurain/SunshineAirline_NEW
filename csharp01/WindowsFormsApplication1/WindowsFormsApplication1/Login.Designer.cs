namespace WindowsFormsApplication1
{
    partial class frmlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpverify = new System.Windows.Forms.GroupBox();
            this.verifycode = new System.Windows.Forms.PictureBox();
            this.tbverify = new System.Windows.Forms.TextBox();
            this.ckbautologin = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnlogclose = new System.Windows.Forms.Button();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpswd = new System.Windows.Forms.TextBox();
            this.lblalt = new System.Windows.Forms.Label();
            this.btnalt = new System.Windows.Forms.Button();
            this.grpalt = new System.Windows.Forms.GroupBox();
            this.grpverify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifycode)).BeginInit();
            this.grpalt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "The system can be logged in through email and password.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verification Code";
            // 
            // grpverify
            // 
            this.grpverify.Controls.Add(this.verifycode);
            this.grpverify.Controls.Add(this.tbverify);
            this.grpverify.Controls.Add(this.label5);
            this.grpverify.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpverify.Location = new System.Drawing.Point(51, 193);
            this.grpverify.Name = "grpverify";
            this.grpverify.Size = new System.Drawing.Size(504, 57);
            this.grpverify.TabIndex = 5;
            this.grpverify.TabStop = false;
            this.grpverify.Visible = false;
            this.grpverify.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // verifycode
            // 
            this.verifycode.Location = new System.Drawing.Point(388, 13);
            this.verifycode.Name = "verifycode";
            this.verifycode.Size = new System.Drawing.Size(90, 40);
            this.verifycode.TabIndex = 14;
            this.verifycode.TabStop = false;
            this.verifycode.Click += new System.EventHandler(this.verifycode_Click);
            // 
            // tbverify
            // 
            this.tbverify.Location = new System.Drawing.Point(206, 13);
            this.tbverify.Name = "tbverify";
            this.tbverify.Size = new System.Drawing.Size(156, 29);
            this.tbverify.TabIndex = 11;
            // 
            // ckbautologin
            // 
            this.ckbautologin.AutoSize = true;
            this.ckbautologin.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbautologin.Location = new System.Drawing.Point(213, 269);
            this.ckbautologin.Name = "ckbautologin";
            this.ckbautologin.Size = new System.Drawing.Size(169, 26);
            this.ckbautologin.TabIndex = 6;
            this.ckbautologin.Text = "Auto login in 7 days";
            this.ckbautologin.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(164, 324);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 36);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnlogclose
            // 
            this.btnlogclose.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogclose.Location = new System.Drawing.Point(364, 324);
            this.btnlogclose.Name = "btnlogclose";
            this.btnlogclose.Size = new System.Drawing.Size(75, 36);
            this.btnlogclose.TabIndex = 8;
            this.btnlogclose.Text = "Close";
            this.btnlogclose.UseVisualStyleBackColor = true;
            this.btnlogclose.Click += new System.EventHandler(this.btnlogclose_Click);
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(256, 123);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(156, 29);
            this.tbemail.TabIndex = 9;
            // 
            // tbpswd
            // 
            this.tbpswd.Font = new System.Drawing.Font("TeXGyreAdventor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpswd.Location = new System.Drawing.Point(256, 164);
            this.tbpswd.Name = "tbpswd";
            this.tbpswd.Size = new System.Drawing.Size(156, 29);
            this.tbpswd.TabIndex = 10;
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Font = new System.Drawing.Font("TeXGyreAdventor", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalt.Location = new System.Drawing.Point(59, 15);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(172, 25);
            this.lblalt.TabIndex = 11;
            this.lblalt.Text = "AUTO-LOGIN in 3s......";
            // 
            // btnalt
            // 
            this.btnalt.Location = new System.Drawing.Point(237, 16);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(48, 23);
            this.btnalt.TabIndex = 12;
            this.btnalt.Text = "cancel";
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // grpalt
            // 
            this.grpalt.Controls.Add(this.lblalt);
            this.grpalt.Controls.Add(this.btnalt);
            this.grpalt.Location = new System.Drawing.Point(127, 256);
            this.grpalt.Name = "grpalt";
            this.grpalt.Size = new System.Drawing.Size(339, 48);
            this.grpalt.TabIndex = 13;
            this.grpalt.TabStop = false;
            this.grpalt.Visible = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.grpalt);
            this.Controls.Add(this.tbpswd);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.btnlogclose);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.ckbautologin);
            this.Controls.Add(this.grpverify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.grpverify.ResumeLayout(false);
            this.grpverify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verifycode)).EndInit();
            this.grpalt.ResumeLayout(false);
            this.grpalt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpverify;
        private System.Windows.Forms.CheckBox ckbautologin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnlogclose;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbverify;
        private System.Windows.Forms.TextBox tbpswd;
        private System.Windows.Forms.Label lblalt;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.GroupBox grpalt;
        private System.Windows.Forms.PictureBox verifycode;
    }
}

