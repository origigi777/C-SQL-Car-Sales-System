namespace CarSalesDB.Screens.Products
{
    partial class QualityCar
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
            this.QualtyDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonhand = new System.Windows.Forms.Button();
            this.buttonQuality = new System.Windows.Forms.Button();
            this.buttonpricesize = new System.Windows.Forms.Button();
            this.buttonseler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QualtyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(457, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = " Welcome To Car\'s Qualty Department";
            // 
            // QualtyDataGrid
            // 
            this.QualtyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QualtyDataGrid.Location = new System.Drawing.Point(12, 62);
            this.QualtyDataGrid.Name = "QualtyDataGrid";
            this.QualtyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QualtyDataGrid.Size = new System.Drawing.Size(762, 248);
            this.QualtyDataGrid.TabIndex = 20;
            this.QualtyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QualtyDataGrid_CellContentClick);
            // 
            // buttonhand
            // 
            this.buttonhand.Location = new System.Drawing.Point(514, 388);
            this.buttonhand.Name = "buttonhand";
            this.buttonhand.Size = new System.Drawing.Size(77, 23);
            this.buttonhand.TabIndex = 23;
            this.buttonhand.Text = "Hand";
            this.buttonhand.UseVisualStyleBackColor = true;
            this.buttonhand.Click += new System.EventHandler(this.buttonhand_Click);
            // 
            // buttonQuality
            // 
            this.buttonQuality.Location = new System.Drawing.Point(607, 388);
            this.buttonQuality.Name = "buttonQuality";
            this.buttonQuality.Size = new System.Drawing.Size(77, 23);
            this.buttonQuality.TabIndex = 22;
            this.buttonQuality.Text = "Quality";
            this.buttonQuality.UseVisualStyleBackColor = true;
            this.buttonQuality.Click += new System.EventHandler(this.buttonQuality_Click);
            // 
            // buttonpricesize
            // 
            this.buttonpricesize.Location = new System.Drawing.Point(699, 388);
            this.buttonpricesize.Name = "buttonpricesize";
            this.buttonpricesize.Size = new System.Drawing.Size(75, 23);
            this.buttonpricesize.TabIndex = 21;
            this.buttonpricesize.Text = "Price";
            this.buttonpricesize.UseVisualStyleBackColor = true;
            this.buttonpricesize.Click += new System.EventHandler(this.buttonpricesize_Click);
            // 
            // buttonseler
            // 
            this.buttonseler.Location = new System.Drawing.Point(421, 388);
            this.buttonseler.Name = "buttonseler";
            this.buttonseler.Size = new System.Drawing.Size(77, 23);
            this.buttonseler.TabIndex = 24;
            this.buttonseler.Text = "Salers";
            this.buttonseler.UseVisualStyleBackColor = true;
            this.buttonseler.Click += new System.EventHandler(this.buttonseler_Click);
            // 
            // QualityCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonseler);
            this.Controls.Add(this.buttonhand);
            this.Controls.Add(this.buttonQuality);
            this.Controls.Add(this.buttonpricesize);
            this.Controls.Add(this.QualtyDataGrid);
            this.Controls.Add(this.label9);
            this.Name = "QualityCar";
            this.Text = "QualityCar";
            ((System.ComponentModel.ISupportInitialize)(this.QualtyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView QualtyDataGrid;
        private System.Windows.Forms.Button buttonhand;
        private System.Windows.Forms.Button buttonQuality;
        private System.Windows.Forms.Button buttonpricesize;
        private System.Windows.Forms.Button buttonseler;
    }
}