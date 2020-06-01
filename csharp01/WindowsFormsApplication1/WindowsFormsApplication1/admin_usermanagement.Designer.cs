namespace WindowsFormsApplication1
{
    partial class admin_usermanagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_usermanagement));
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbfirst = new System.Windows.Forms.PictureBox();
            this.pblast = new System.Windows.Forms.PictureBox();
            this.pbnext = new System.Windows.Forms.PictureBox();
            this.pbprevious = new System.Windows.Forms.PictureBox();
            this.cbpage = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltrecords = new System.Windows.Forms.Label();
            this.lbltpages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprevious)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("TeXGyreAdventor", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "User Management";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.cbrole);
            this.groupBox1.Location = new System.Drawing.Point(44, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Role:";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(481, 56);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 33);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Add a new user";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(377, 56);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 33);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(173, 58);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(174, 26);
            this.tbname.TabIndex = 14;
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Location = new System.Drawing.Point(26, 58);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(123, 28);
            this.cbrole.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(44, 138);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(893, 350);
            this.dataGridView1.TabIndex = 7;
            // 
            // pbfirst
            // 
            this.pbfirst.Image = ((System.Drawing.Image)(resources.GetObject("pbfirst.Image")));
            this.pbfirst.Location = new System.Drawing.Point(26, 21);
            this.pbfirst.Name = "pbfirst";
            this.pbfirst.Size = new System.Drawing.Size(30, 30);
            this.pbfirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfirst.TabIndex = 8;
            this.pbfirst.TabStop = false;
            this.pbfirst.Click += new System.EventHandler(this.pbfirst_Click);
            // 
            // pblast
            // 
            this.pblast.Image = ((System.Drawing.Image)(resources.GetObject("pblast.Image")));
            this.pblast.Location = new System.Drawing.Point(257, 20);
            this.pblast.Name = "pblast";
            this.pblast.Size = new System.Drawing.Size(30, 30);
            this.pblast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblast.TabIndex = 9;
            this.pblast.TabStop = false;
            this.pblast.Click += new System.EventHandler(this.pblast_Click);
            // 
            // pbnext
            // 
            this.pbnext.Image = ((System.Drawing.Image)(resources.GetObject("pbnext.Image")));
            this.pbnext.Location = new System.Drawing.Point(210, 20);
            this.pbnext.Name = "pbnext";
            this.pbnext.Size = new System.Drawing.Size(30, 30);
            this.pbnext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbnext.TabIndex = 10;
            this.pbnext.TabStop = false;
            this.pbnext.Click += new System.EventHandler(this.pbnext_Click);
            // 
            // pbprevious
            // 
            this.pbprevious.Image = ((System.Drawing.Image)(resources.GetObject("pbprevious.Image")));
            this.pbprevious.Location = new System.Drawing.Point(74, 21);
            this.pbprevious.Name = "pbprevious";
            this.pbprevious.Size = new System.Drawing.Size(30, 30);
            this.pbprevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbprevious.TabIndex = 11;
            this.pbprevious.TabStop = false;
            this.pbprevious.Click += new System.EventHandler(this.pbprevious_Click);
            // 
            // cbpage
            // 
            this.cbpage.FormattingEnabled = true;
            this.cbpage.Location = new System.Drawing.Point(120, 20);
            this.cbpage.Name = "cbpage";
            this.cbpage.Size = new System.Drawing.Size(75, 28);
            this.cbpage.TabIndex = 12;
            this.cbpage.SelectedIndexChanged += new System.EventHandler(this.cbpage_SelectedIndexChanged);
            this.cbpage.SelectionChangeCommitted += new System.EventHandler(this.cbpage_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltrecords);
            this.groupBox2.Controls.Add(this.lbltpages);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pblast);
            this.groupBox2.Controls.Add(this.pbfirst);
            this.groupBox2.Controls.Add(this.cbpage);
            this.groupBox2.Controls.Add(this.pbnext);
            this.groupBox2.Controls.Add(this.pbprevious);
            this.groupBox2.Location = new System.Drawing.Point(44, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 71);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // lbltrecords
            // 
            this.lbltrecords.AutoSize = true;
            this.lbltrecords.Location = new System.Drawing.Point(587, 20);
            this.lbltrecords.Name = "lbltrecords";
            this.lbltrecords.Size = new System.Drawing.Size(18, 20);
            this.lbltrecords.TabIndex = 15;
            this.lbltrecords.Text = "n";
            // 
            // lbltpages
            // 
            this.lbltpages.AutoSize = true;
            this.lbltpages.Location = new System.Drawing.Point(418, 20);
            this.lbltpages.Name = "lbltpages";
            this.lbltpages.Size = new System.Drawing.Size(18, 20);
            this.lbltpages.TabIndex = 14;
            this.lbltpages.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Pages:";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(836, 515);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 30);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_usermanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin_usermanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.admin_usermanagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprevious)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.PictureBox pbfirst;
        private System.Windows.Forms.PictureBox pblast;
        private System.Windows.Forms.PictureBox pbnext;
        private System.Windows.Forms.PictureBox pbprevious;
        private System.Windows.Forms.ComboBox cbpage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltpages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltrecords;
        private System.Windows.Forms.Button btnedit;
    }
}