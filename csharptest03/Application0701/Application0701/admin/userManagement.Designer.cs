namespace Application0701.admin
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picfirst = new System.Windows.Forms.PictureBox();
            this.piclast = new System.Windows.Forms.PictureBox();
            this.picnext = new System.Windows.Forms.PictureBox();
            this.picpre = new System.Windows.Forms.PictureBox();
            this.cbpage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            this.lbltotalpage = new System.Windows.Forms.Label();
            this.lbltotalrecord = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbrole);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(441, 30);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(128, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add a new user";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(337, 31);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(174, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "All",
            "Office User",
            "Administrator"});
            this.cbrole.Location = new System.Drawing.Point(29, 32);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(110, 21);
            this.cbrole.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Role:";
            // 
            // picfirst
            // 
            this.picfirst.Image = ((System.Drawing.Image)(resources.GetObject("picfirst.Image")));
            this.picfirst.Location = new System.Drawing.Point(53, 457);
            this.picfirst.Name = "picfirst";
            this.picfirst.Size = new System.Drawing.Size(27, 28);
            this.picfirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picfirst.TabIndex = 2;
            this.picfirst.TabStop = false;
            this.picfirst.Click += new System.EventHandler(this.picfirst_Click);
            // 
            // piclast
            // 
            this.piclast.Image = ((System.Drawing.Image)(resources.GetObject("piclast.Image")));
            this.piclast.Location = new System.Drawing.Point(227, 457);
            this.piclast.Name = "piclast";
            this.piclast.Size = new System.Drawing.Size(27, 28);
            this.piclast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclast.TabIndex = 3;
            this.piclast.TabStop = false;
            this.piclast.Click += new System.EventHandler(this.piclast_Click);
            // 
            // picnext
            // 
            this.picnext.Image = ((System.Drawing.Image)(resources.GetObject("picnext.Image")));
            this.picnext.Location = new System.Drawing.Point(194, 457);
            this.picnext.Name = "picnext";
            this.picnext.Size = new System.Drawing.Size(27, 28);
            this.picnext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picnext.TabIndex = 4;
            this.picnext.TabStop = false;
            this.picnext.Click += new System.EventHandler(this.picnext_Click);
            // 
            // picpre
            // 
            this.picpre.Image = ((System.Drawing.Image)(resources.GetObject("picpre.Image")));
            this.picpre.Location = new System.Drawing.Point(86, 457);
            this.picpre.Name = "picpre";
            this.picpre.Size = new System.Drawing.Size(27, 28);
            this.picpre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpre.TabIndex = 5;
            this.picpre.TabStop = false;
            this.picpre.Click += new System.EventHandler(this.picpre_Click);
            // 
            // cbpage
            // 
            this.cbpage.FormattingEnabled = true;
            this.cbpage.Location = new System.Drawing.Point(119, 461);
            this.cbpage.Name = "cbpage";
            this.cbpage.Size = new System.Drawing.Size(69, 21);
            this.cbpage.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Pages:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Records:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 341);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(706, 456);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // lbltotalpage
            // 
            this.lbltotalpage.AutoSize = true;
            this.lbltotalpage.Location = new System.Drawing.Point(370, 461);
            this.lbltotalpage.Name = "lbltotalpage";
            this.lbltotalpage.Size = new System.Drawing.Size(35, 13);
            this.lbltotalpage.TabIndex = 11;
            this.lbltotalpage.Text = "label6";
            // 
            // lbltotalrecord
            // 
            this.lbltotalrecord.AutoSize = true;
            this.lbltotalrecord.Location = new System.Drawing.Point(513, 461);
            this.lbltotalrecord.Name = "lbltotalrecord";
            this.lbltotalrecord.Size = new System.Drawing.Size(35, 13);
            this.lbltotalrecord.TabIndex = 12;
            this.lbltotalrecord.Text = "label6";
            // 
            // userManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 497);
            this.Controls.Add(this.lbltotalrecord);
            this.Controls.Add(this.lbltotalpage);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbpage);
            this.Controls.Add(this.picpre);
            this.Controls.Add(this.picnext);
            this.Controls.Add(this.piclast);
            this.Controls.Add(this.picfirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "userManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.userManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpre)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picfirst;
        private System.Windows.Forms.PictureBox piclast;
        private System.Windows.Forms.PictureBox picnext;
        private System.Windows.Forms.PictureBox picpre;
        private System.Windows.Forms.ComboBox cbpage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label lbltotalpage;
        private System.Windows.Forms.Label lbltotalrecord;
    }
}