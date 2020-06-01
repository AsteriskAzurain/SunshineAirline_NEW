namespace WindowsFormsApplication1.Usercontrol
{
    partial class food
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numfood = new System.Windows.Forms.NumericUpDown();
            this.picfood = new System.Windows.Forms.PictureBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.numfood);
            this.panel4.Controls.Add(this.picfood);
            this.panel4.Controls.Add(this.lblFoodName);
            this.panel4.Location = new System.Drawing.Point(20, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 150);
            this.panel4.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("TeXGyreAdventor", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(34, 120);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "price";
            // 
            // numfood
            // 
            this.numfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numfood.Font = new System.Drawing.Font("TeXGyreAdventor", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numfood.Location = new System.Drawing.Point(116, 43);
            this.numfood.Name = "numfood";
            this.numfood.Size = new System.Drawing.Size(39, 24);
            this.numfood.TabIndex = 3;
            this.numfood.ValueChanged += new System.EventHandler(this.numfood_ValueChanged);
            // 
            // picfood
            // 
            this.picfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picfood.Location = new System.Drawing.Point(7, 29);
            this.picfood.Name = "picfood";
            this.picfood.Size = new System.Drawing.Size(100, 88);
            this.picfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfood.TabIndex = 2;
            this.picfood.TabStop = false;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(3, 9);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(56, 14);
            this.lblFoodName.TabIndex = 1;
            this.lblFoodName.Text = "food name";
            // 
            // food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "food";
            this.Size = new System.Drawing.Size(180, 150);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numfood;
        private System.Windows.Forms.PictureBox picfood;
        private System.Windows.Forms.Label lblFoodName;
    }
}
