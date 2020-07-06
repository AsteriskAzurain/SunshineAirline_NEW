namespace Application0701.admin
{
    partial class edituser
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdorole2 = new System.Windows.Forms.RadioButton();
            this.rdorole1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdosexf = new System.Windows.Forms.RadioButton();
            this.rdosexm = new System.Windows.Forms.RadioButton();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datebirth = new System.Windows.Forms.DateTimePicker();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnphoto = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/Edit User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(51, 91);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(157, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(51, 171);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(157, 20);
            this.txtfname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FirstName";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(51, 245);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(157, 20);
            this.txttel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telephone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdorole2);
            this.groupBox1.Controls.Add(this.rdorole1);
            this.groupBox1.Location = new System.Drawing.Point(260, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role";
            // 
            // rdorole2
            // 
            this.rdorole2.AutoSize = true;
            this.rdorole2.Location = new System.Drawing.Point(126, 26);
            this.rdorole2.Name = "rdorole2";
            this.rdorole2.Size = new System.Drawing.Size(85, 17);
            this.rdorole2.TabIndex = 1;
            this.rdorole2.TabStop = true;
            this.rdorole2.Text = "Administrator";
            this.rdorole2.UseVisualStyleBackColor = true;
            // 
            // rdorole1
            // 
            this.rdorole1.AutoSize = true;
            this.rdorole1.Location = new System.Drawing.Point(28, 26);
            this.rdorole1.Name = "rdorole1";
            this.rdorole1.Size = new System.Drawing.Size(78, 17);
            this.rdorole1.TabIndex = 0;
            this.rdorole1.TabStop = true;
            this.rdorole1.Text = "Office User";
            this.rdorole1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdosexf);
            this.groupBox2.Controls.Add(this.rdosexm);
            this.groupBox2.Location = new System.Drawing.Point(508, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rdosexf
            // 
            this.rdosexf.AutoSize = true;
            this.rdosexf.Location = new System.Drawing.Point(104, 26);
            this.rdosexf.Name = "rdosexf";
            this.rdosexf.Size = new System.Drawing.Size(59, 17);
            this.rdosexf.TabIndex = 1;
            this.rdosexf.TabStop = true;
            this.rdosexf.Text = "Female";
            this.rdosexf.UseVisualStyleBackColor = true;
            this.rdosexf.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdosexm
            // 
            this.rdosexm.AutoSize = true;
            this.rdosexm.Location = new System.Drawing.Point(28, 26);
            this.rdosexm.Name = "rdosexm";
            this.rdosexm.Size = new System.Drawing.Size(48, 17);
            this.rdosexm.TabIndex = 0;
            this.rdosexm.TabStop = true;
            this.rdosexm.Text = "Male";
            this.rdosexm.UseVisualStyleBackColor = true;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(260, 171);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(157, 20);
            this.txtlname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birthday";
            // 
            // datebirth
            // 
            this.datebirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebirth.Location = new System.Drawing.Point(484, 171);
            this.datebirth.Name = "datebirth";
            this.datebirth.Size = new System.Drawing.Size(200, 20);
            this.datebirth.TabIndex = 12;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(260, 245);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(424, 20);
            this.txtaddress.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.AutoSize = true;
            this.textBox5.Location = new System.Drawing.Point(257, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 13);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(744, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 154);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnphoto
            // 
            this.btnphoto.Location = new System.Drawing.Point(765, 242);
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.Size = new System.Drawing.Size(106, 23);
            this.btnphoto.TabIndex = 16;
            this.btnphoto.Text = "Select Photo";
            this.btnphoto.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(260, 314);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 17;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(494, 314);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // edituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 387);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.datebirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "edituser";
            this.Text = "Add/Edit User";
            this.Load += new System.EventHandler(this.edituser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdorole2;
        private System.Windows.Forms.RadioButton rdorole1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdosexf;
        private System.Windows.Forms.RadioButton rdosexm;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datebirth;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnphoto;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}