namespace CarSalesDB.Screens.Products
{
    partial class Employees
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSoldCars = new System.Windows.Forms.Button();
            this.buttonBestworker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QualtyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(437, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = " Welcome To Employes\' Department";
            // 
            // QualtyDataGrid
            // 
            this.QualtyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QualtyDataGrid.Location = new System.Drawing.Point(12, 55);
            this.QualtyDataGrid.Name = "QualtyDataGrid";
            this.QualtyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QualtyDataGrid.Size = new System.Drawing.Size(762, 214);
            this.QualtyDataGrid.TabIndex = 21;
            this.QualtyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QualtyDataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Employees info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSoldCars
            // 
            this.buttonSoldCars.Location = new System.Drawing.Point(607, 378);
            this.buttonSoldCars.Name = "buttonSoldCars";
            this.buttonSoldCars.Size = new System.Drawing.Size(86, 23);
            this.buttonSoldCars.TabIndex = 24;
            this.buttonSoldCars.Text = "Classification";
            this.buttonSoldCars.UseVisualStyleBackColor = true;
            this.buttonSoldCars.Click += new System.EventHandler(this.buttonSoldCars_Click);
            // 
            // buttonBestworker
            // 
            this.buttonBestworker.Location = new System.Drawing.Point(699, 378);
            this.buttonBestworker.Name = "buttonBestworker";
            this.buttonBestworker.Size = new System.Drawing.Size(75, 23);
            this.buttonBestworker.TabIndex = 25;
            this.buttonBestworker.Text = "Best Work";
            this.buttonBestworker.UseVisualStyleBackColor = true;
            this.buttonBestworker.Click += new System.EventHandler(this.buttonBestworker_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBestworker);
            this.Controls.Add(this.buttonSoldCars);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QualtyDataGrid);
            this.Controls.Add(this.label9);
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.QualtyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView QualtyDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSoldCars;
        private System.Windows.Forms.Button buttonBestworker;
    }
}