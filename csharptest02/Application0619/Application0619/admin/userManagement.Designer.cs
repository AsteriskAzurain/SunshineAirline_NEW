namespace Application0619.admin
{
    partial class userManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltrecords = new System.Windows.Forms.Label();
            this.lbltpages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pblast = new System.Windows.Forms.PictureBox();
            this.pbfirst = new System.Windows.Forms.PictureBox();
            this.cbpage = new System.Windows.Forms.ComboBox();
            this.pbnext = new System.Windows.Forms.PictureBox();
            this.pbprevious = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.cbrole);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(450, 44);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add a new user";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(342, 45);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(170, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(134, 20);
            this.txtname.TabIndex = 3;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "All",
            "Office User",
            "Administrator"});
            this.cbrole.Location = new System.Drawing.Point(35, 47);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(121, 21);
            this.cbrole.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Role:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltrecords);
            this.groupBox2.Controls.Add(this.lbltpages);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pblast);
            this.groupBox2.Controls.Add(this.pbfirst);
            this.groupBox2.Controls.Add(this.cbpage);
            this.groupBox2.Controls.Add(this.pbnext);
            this.groupBox2.Controls.Add(this.pbprevious);
            this.groupBox2.Location = new System.Drawing.Point(12, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lbltrecords
            // 
            this.lbltrecords.AutoSize = true;
            this.lbltrecords.Location = new System.Drawing.Point(587, 20);
            this.lbltrecords.Name = "lbltrecords";
            this.lbltrecords.Size = new System.Drawing.Size(13, 13);
            this.lbltrecords.TabIndex = 15;
            this.lbltrecords.Text = "n";
            // 
            // lbltpages
            // 
            this.lbltpages.AutoSize = true;
            this.lbltpages.Location = new System.Drawing.Point(418, 20);
            this.lbltpages.Name = "lbltpages";
            this.lbltpages.Size = new System.Drawing.Size(13, 13);
            this.lbltpages.TabIndex = 14;
            this.lbltpages.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Records:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Pages:";
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
            // cbpage
            // 
            this.cbpage.FormattingEnabled = true;
            this.cbpage.Location = new System.Drawing.Point(120, 20);
            this.cbpage.Name = "cbpage";
            this.cbpage.Size = new System.Drawing.Size(75, 21);
            this.cbpage.TabIndex = 12;
            this.cbpage.SelectedIndexChanged += new System.EventHandler(this.cbpage_SelectedIndexChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 345);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(699, 523);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 16;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // userManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 579);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "userManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.userManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltrecords;
        private System.Windows.Forms.Label lbltpages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pblast;
        private System.Windows.Forms.PictureBox pbfirst;
        private System.Windows.Forms.ComboBox cbpage;
        private System.Windows.Forms.PictureBox pbnext;
        private System.Windows.Forms.PictureBox pbprevious;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnedit;
    }
}