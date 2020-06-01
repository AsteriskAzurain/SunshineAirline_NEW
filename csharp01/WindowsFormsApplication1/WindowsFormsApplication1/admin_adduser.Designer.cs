namespace WindowsFormsApplication1
{
    partial class admin_adduser
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
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbaddr = new System.Windows.Forms.TextBox();
            this.datebirth = new System.Windows.Forms.DateTimePicker();
            this.picphoto = new System.Windows.Forms.PictureBox();
            this.btnphoto = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grprole = new System.Windows.Forms.GroupBox();
            this.rdoadmin = new System.Windows.Forms.RadioButton();
            this.rdoouser = new System.Windows.Forms.RadioButton();
            this.grpsex = new System.Windows.Forms.GroupBox();
            this.rdof = new System.Windows.Forms.RadioButton();
            this.rdom = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.grprole.SuspendLayout();
            this.grpsex.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Add/Edit User";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(33, 130);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(160, 26);
            this.tbemail.TabIndex = 7;
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(249, 216);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(160, 26);
            this.tblname.TabIndex = 8;
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(33, 302);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(160, 26);
            this.tbtel.TabIndex = 9;
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(33, 216);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(160, 26);
            this.tbfname.TabIndex = 10;
            // 
            // tbaddr
            // 
            this.tbaddr.Location = new System.Drawing.Point(249, 302);
            this.tbaddr.Name = "tbaddr";
            this.tbaddr.Size = new System.Drawing.Size(376, 26);
            this.tbaddr.TabIndex = 12;
            // 
            // datebirth
            // 
            this.datebirth.CustomFormat = "yyyy-MM-dd";
            this.datebirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebirth.Location = new System.Drawing.Point(465, 216);
            this.datebirth.Name = "datebirth";
            this.datebirth.Size = new System.Drawing.Size(160, 26);
            this.datebirth.TabIndex = 13;
            this.datebirth.ValueChanged += new System.EventHandler(this.datebirth_ValueChanged);
            // 
            // picphoto
            // 
            this.picphoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picphoto.Location = new System.Drawing.Point(676, 130);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(116, 156);
            this.picphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picphoto.TabIndex = 14;
            this.picphoto.TabStop = false;
            // 
            // btnphoto
            // 
            this.btnphoto.Location = new System.Drawing.Point(679, 302);
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.Size = new System.Drawing.Size(103, 23);
            this.btnphoto.TabIndex = 15;
            this.btnphoto.Text = "Select Photo";
            this.btnphoto.UseVisualStyleBackColor = true;
            this.btnphoto.Click += new System.EventHandler(this.btnphoto_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(249, 384);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 36);
            this.btnsubmit.TabIndex = 16;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(488, 384);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 36);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Role";
            // 
            // grprole
            // 
            this.grprole.Controls.Add(this.rdoadmin);
            this.grprole.Controls.Add(this.rdoouser);
            this.grprole.Location = new System.Drawing.Point(235, 110);
            this.grprole.Name = "grprole";
            this.grprole.Size = new System.Drawing.Size(225, 56);
            this.grprole.TabIndex = 20;
            this.grprole.TabStop = false;
            // 
            // rdoadmin
            // 
            this.rdoadmin.AutoSize = true;
            this.rdoadmin.Location = new System.Drawing.Point(109, 21);
            this.rdoadmin.Name = "rdoadmin";
            this.rdoadmin.Size = new System.Drawing.Size(109, 23);
            this.rdoadmin.TabIndex = 1;
            this.rdoadmin.TabStop = true;
            this.rdoadmin.Text = "Administrator";
            this.rdoadmin.UseVisualStyleBackColor = true;
            // 
            // rdoouser
            // 
            this.rdoouser.AutoSize = true;
            this.rdoouser.Location = new System.Drawing.Point(6, 21);
            this.rdoouser.Name = "rdoouser";
            this.rdoouser.Size = new System.Drawing.Size(97, 23);
            this.rdoouser.TabIndex = 0;
            this.rdoouser.TabStop = true;
            this.rdoouser.Text = "Office User";
            this.rdoouser.UseVisualStyleBackColor = true;
            // 
            // grpsex
            // 
            this.grpsex.Controls.Add(this.rdof);
            this.grpsex.Controls.Add(this.rdom);
            this.grpsex.Location = new System.Drawing.Point(466, 110);
            this.grpsex.Name = "grpsex";
            this.grpsex.Size = new System.Drawing.Size(159, 56);
            this.grpsex.TabIndex = 21;
            this.grpsex.TabStop = false;
            // 
            // rdof
            // 
            this.rdof.AutoSize = true;
            this.rdof.Location = new System.Drawing.Point(70, 21);
            this.rdof.Name = "rdof";
            this.rdof.Size = new System.Drawing.Size(71, 23);
            this.rdof.TabIndex = 1;
            this.rdof.TabStop = true;
            this.rdof.Text = "Female";
            this.rdof.UseVisualStyleBackColor = true;
            // 
            // rdom
            // 
            this.rdom.AutoSize = true;
            this.rdom.Location = new System.Drawing.Point(6, 21);
            this.rdom.Name = "rdom";
            this.rdom.Size = new System.Drawing.Size(58, 23);
            this.rdom.TabIndex = 0;
            this.rdom.TabStop = true;
            this.rdom.Text = "Male";
            this.rdom.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Address";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // admin_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 461);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpsex);
            this.Controls.Add(this.grprole);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnphoto);
            this.Controls.Add(this.picphoto);
            this.Controls.Add(this.datebirth);
            this.Controls.Add(this.tbaddr);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin_adduser";
            this.Text = "Add/Edit User";
            this.Load += new System.EventHandler(this.admin_adduser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.grprole.ResumeLayout(false);
            this.grprole.PerformLayout();
            this.grpsex.ResumeLayout(false);
            this.grpsex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.TextBox tbaddr;
        private System.Windows.Forms.DateTimePicker datebirth;
        private System.Windows.Forms.PictureBox picphoto;
        private System.Windows.Forms.Button btnphoto;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grprole;
        private System.Windows.Forms.RadioButton rdoadmin;
        private System.Windows.Forms.RadioButton rdoouser;
        private System.Windows.Forms.GroupBox grpsex;
        private System.Windows.Forms.RadioButton rdof;
        private System.Windows.Forms.RadioButton rdom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}