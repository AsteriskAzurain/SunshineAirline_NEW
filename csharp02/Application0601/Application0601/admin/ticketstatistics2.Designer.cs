namespace Application0601.admin
{
    partial class ticketStatistics2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.btnstics = new System.Windows.Forms.Button();
            this.cbview = new System.Windows.Forms.ComboBox();
            this.cbshow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Statistics";
            // 
            // dtpstart
            // 
            this.dtpstart.CustomFormat = "yyyy-MM";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstart.Location = new System.Drawing.Point(37, 59);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(123, 26);
            this.dtpstart.TabIndex = 1;
            // 
            // dtpend
            // 
            this.dtpend.CustomFormat = "yyyy-MM";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpend.Location = new System.Drawing.Point(166, 59);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(123, 26);
            this.dtpend.TabIndex = 2;
            // 
            // btnstics
            // 
            this.btnstics.Location = new System.Drawing.Point(329, 55);
            this.btnstics.Name = "btnstics";
            this.btnstics.Size = new System.Drawing.Size(87, 30);
            this.btnstics.TabIndex = 3;
            this.btnstics.Text = "Statisics";
            this.btnstics.UseVisualStyleBackColor = true;
            this.btnstics.Click += new System.EventHandler(this.btnstics_Click);
            // 
            // cbview
            // 
            this.cbview.FormattingEnabled = true;
            this.cbview.Items.AddRange(new object[] {
            "FlightsAmount",
            "TicketsAmount",
            "TicketsRevenue"});
            this.cbview.Location = new System.Drawing.Point(571, 57);
            this.cbview.Name = "cbview";
            this.cbview.Size = new System.Drawing.Size(155, 28);
            this.cbview.TabIndex = 4;
            this.cbview.SelectedIndexChanged += new System.EventHandler(this.cbview_SelectedIndexChanged);
            // 
            // cbshow
            // 
            this.cbshow.AutoSize = true;
            this.cbshow.Location = new System.Drawing.Point(744, 61);
            this.cbshow.Name = "cbshow";
            this.cbshow.Size = new System.Drawing.Size(128, 24);
            this.cbshow.TabIndex = 5;
            this.cbshow.Text = "Show Amount";
            this.cbshow.UseVisualStyleBackColor = true;
            this.cbshow.CheckedChanged += new System.EventHandler(this.cbshow_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "View By";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 10F;
            legend2.Position.Width = 40F;
            legend2.Position.X = 60F;
            legend2.Position.Y = 3F;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(476, 102);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(396, 347);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 347);
            this.dataGridView1.TabIndex = 8;
            // 
            // ticketStatistics2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbshow);
            this.Controls.Add(this.cbview);
            this.Controls.Add(this.btnstics);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ticketStatistics2";
            this.Text = "Ticket Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Button btnstics;
        private System.Windows.Forms.ComboBox cbview;
        private System.Windows.Forms.CheckBox cbshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}