namespace CarSalesDB.Screens.Products
{
    partial class CarPrices
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
            this.label9 = new System.Windows.Forms.Label();
            this.PriceDataGrid2121 = new System.Windows.Forms.DataGridView();
            this.buttonPayOff = new System.Windows.Forms.Button();
            this.buttonHigh = new System.Windows.Forms.Button();
            this.buttonLow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid2121)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(16, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(469, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = " Welcome To Prices Department";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PriceDataGrid2121
            // 
            this.PriceDataGrid2121.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGrid2121.Location = new System.Drawing.Point(23, 50);
            this.PriceDataGrid2121.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceDataGrid2121.Name = "PriceDataGrid2121";
            this.PriceDataGrid2121.RowHeadersWidth = 51;
            this.PriceDataGrid2121.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PriceDataGrid2121.Size = new System.Drawing.Size(1016, 263);
            this.PriceDataGrid2121.TabIndex = 22;
            this.PriceDataGrid2121.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PriceDataGrid2121_CellContentClick);
            // 
            // buttonPayOff
            // 
            this.buttonPayOff.Location = new System.Drawing.Point(924, 471);
            this.buttonPayOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPayOff.Name = "buttonPayOff";
            this.buttonPayOff.Size = new System.Drawing.Size(115, 28);
            this.buttonPayOff.TabIndex = 25;
            this.buttonPayOff.Text = "Pay Off";
            this.buttonPayOff.UseVisualStyleBackColor = true;
            this.buttonPayOff.Click += new System.EventHandler(this.buttonPayOff_Click);
            // 
            // buttonHigh
            // 
            this.buttonHigh.Location = new System.Drawing.Point(784, 471);
            this.buttonHigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHigh.Name = "buttonHigh";
            this.buttonHigh.Size = new System.Drawing.Size(115, 28);
            this.buttonHigh.TabIndex = 26;
            this.buttonHigh.Text = "High";
            this.buttonHigh.UseVisualStyleBackColor = true;
            this.buttonHigh.Click += new System.EventHandler(this.buttonHigh_Click);
            // 
            // buttonLow
            // 
            this.buttonLow.Location = new System.Drawing.Point(644, 471);
            this.buttonLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLow.Name = "buttonLow";
            this.buttonLow.Size = new System.Drawing.Size(115, 28);
            this.buttonLow.TabIndex = 27;
            this.buttonLow.Text = "Low Price";
            this.buttonLow.UseVisualStyleBackColor = true;
            this.buttonLow.Click += new System.EventHandler(this.buttonLow_Click);
            // 
            // CarPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonLow);
            this.Controls.Add(this.buttonHigh);
            this.Controls.Add(this.buttonPayOff);
            this.Controls.Add(this.PriceDataGrid2121);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarPrices";
            this.Text = "CarPrices";
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid2121)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView PriceDataGrid2121;
        private System.Windows.Forms.Button buttonPayOff;
        private System.Windows.Forms.Button buttonHigh;
        private System.Windows.Forms.Button buttonLow;
    }
}