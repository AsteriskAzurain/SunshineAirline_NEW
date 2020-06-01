namespace WindowsFormsApplication1
{
    partial class OfficeUserMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("TeXGyreAdventor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFlightsToolStripMenuItem,
            this.foodServicesToolStripMenuItem,
            this.flightStatusToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchFlightsToolStripMenuItem
            // 
            this.searchFlightsToolStripMenuItem.Font = new System.Drawing.Font("TeXGyreAdventor", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFlightsToolStripMenuItem.Name = "searchFlightsToolStripMenuItem";
            this.searchFlightsToolStripMenuItem.Size = new System.Drawing.Size(151, 33);
            this.searchFlightsToolStripMenuItem.Text = "Search Flights";
            this.searchFlightsToolStripMenuItem.Click += new System.EventHandler(this.searchFlightsToolStripMenuItem_Click);
            // 
            // foodServicesToolStripMenuItem
            // 
            this.foodServicesToolStripMenuItem.Name = "foodServicesToolStripMenuItem";
            this.foodServicesToolStripMenuItem.Size = new System.Drawing.Size(152, 33);
            this.foodServicesToolStripMenuItem.Text = "Food Services";
            this.foodServicesToolStripMenuItem.Click += new System.EventHandler(this.foodServicesToolStripMenuItem_Click);
            // 
            // flightStatusToolStripMenuItem
            // 
            this.flightStatusToolStripMenuItem.Name = "flightStatusToolStripMenuItem";
            this.flightStatusToolStripMenuItem.Size = new System.Drawing.Size(133, 33);
            this.flightStatusToolStripMenuItem.Text = "Flight Status";
            this.flightStatusToolStripMenuItem.Click += new System.EventHandler(this.flightStatusToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(87, 33);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 33);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 1;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // OfficeUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OfficeUserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office User Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}