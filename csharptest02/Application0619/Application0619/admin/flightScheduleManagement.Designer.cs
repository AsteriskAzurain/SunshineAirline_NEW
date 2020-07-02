namespace Application0619.admin
{
    partial class flightScheduleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flightScheduleManagement));
            this.button1 = new System.Windows.Forms.Button();
            this.lblts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datedep2 = new System.Windows.Forms.DateTimePicker();
            this.datedep1 = new System.Windows.Forms.DateTimePicker();
            this.btnex = new System.Windows.Forms.PictureBox();
            this.cbarrct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdepct = new System.Windows.Forms.ComboBox();
            this.rdoct = new System.Windows.Forms.RadioButton();
            this.rdoap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnex)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel / Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblts
            // 
            this.lblts.AutoSize = true;
            this.lblts.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblts.Location = new System.Drawing.Point(542, 161);
            this.lblts.Name = "lblts";
            this.lblts.Size = new System.Drawing.Size(12, 15);
            this.lblts.TabIndex = 16;
            this.lblts.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Schedules:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(48, 187);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(911, 350);
            this.dataGridView1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Flight Schedule Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datedep2);
            this.groupBox1.Controls.Add(this.datedep1);
            this.groupBox1.Controls.Add(this.btnex);
            this.groupBox1.Controls.Add(this.cbarrct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbdepct);
            this.groupBox1.Controls.Add(this.rdoct);
            this.groupBox1.Controls.Add(this.rdoap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(786, 44);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(92, 33);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Departure Date:";
            // 
            // datedep2
            // 
            this.datedep2.CustomFormat = "yyyy-MM-dd";
            this.datedep2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datedep2.Location = new System.Drawing.Point(612, 49);
            this.datedep2.Name = "datedep2";
            this.datedep2.Size = new System.Drawing.Size(125, 20);
            this.datedep2.TabIndex = 11;
            // 
            // datedep1
            // 
            this.datedep1.CustomFormat = "yyyy-MM-dd";
            this.datedep1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datedep1.Location = new System.Drawing.Point(436, 49);
            this.datedep1.Name = "datedep1";
            this.datedep1.Size = new System.Drawing.Size(125, 20);
            this.datedep1.TabIndex = 8;
            // 
            // btnex
            // 
            this.btnex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnex.Image = ((System.Drawing.Image)(resources.GetObject("btnex.Image")));
            this.btnex.Location = new System.Drawing.Point(241, 40);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(50, 40);
            this.btnex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnex.TabIndex = 8;
            this.btnex.TabStop = false;
            // 
            // cbarrct
            // 
            this.cbarrct.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbarrct.FormattingEnabled = true;
            this.cbarrct.Location = new System.Drawing.Point(297, 52);
            this.cbarrct.Name = "cbarrct";
            this.cbarrct.Size = new System.Drawing.Size(90, 27);
            this.cbarrct.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            // 
            // cbdepct
            // 
            this.cbdepct.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepct.FormattingEnabled = true;
            this.cbdepct.Location = new System.Drawing.Point(145, 53);
            this.cbdepct.Name = "cbdepct";
            this.cbdepct.Size = new System.Drawing.Size(90, 27);
            this.cbdepct.TabIndex = 2;
            // 
            // rdoct
            // 
            this.rdoct.AutoSize = true;
            this.rdoct.Location = new System.Drawing.Point(18, 63);
            this.rdoct.Name = "rdoct";
            this.rdoct.Size = new System.Drawing.Size(57, 19);
            this.rdoct.TabIndex = 1;
            this.rdoct.Text = "By City";
            this.rdoct.UseVisualStyleBackColor = true;
            // 
            // rdoap
            // 
            this.rdoap.AutoSize = true;
            this.rdoap.Location = new System.Drawing.Point(18, 30);
            this.rdoap.Name = "rdoap";
            this.rdoap.Size = new System.Drawing.Size(66, 19);
            this.rdoap.TabIndex = 0;
            this.rdoap.Text = "By Airport";
            this.rdoap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeXGyreAdventor", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // flightScheduleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "flightScheduleManagement";
            this.Text = "Flight Schedule Management";
            this.Load += new System.EventHandler(this.flightScheduleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datedep2;
        private System.Windows.Forms.DateTimePicker datedep1;
        private System.Windows.Forms.PictureBox btnex;
        private System.Windows.Forms.ComboBox cbarrct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbdepct;
        private System.Windows.Forms.RadioButton rdoct;
        private System.Windows.Forms.RadioButton rdoap;
        private System.Windows.Forms.Label label1;
    }
}