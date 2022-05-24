namespace CarSalesDB.Screens.Products
{
    partial class ConditionScreen
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
            this.sellrecommendGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCarCondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.textBoxLicense = new System.Windows.Forms.ComboBox();
            this.textBoxHandSales = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sellrecommendGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sellrecommendGridView1
            // 
            this.sellrecommendGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellrecommendGridView1.Location = new System.Drawing.Point(23, 50);
            this.sellrecommendGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellrecommendGridView1.Name = "sellrecommendGridView1";
            this.sellrecommendGridView1.RowHeadersWidth = 51;
            this.sellrecommendGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellrecommendGridView1.Size = new System.Drawing.Size(1028, 305);
            this.sellrecommendGridView1.TabIndex = 0;
            this.sellrecommendGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellrecommendGridView1_CellContentClick);
            this.sellrecommendGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellrecommendGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(16, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(599, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = " Welcome To Car\'s Condition Department";
            // 
            // textBoxCarCondition
            // 
            this.textBoxCarCondition.Location = new System.Drawing.Point(387, 442);
            this.textBoxCarCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarCondition.Name = "textBoxCarCondition";
            this.textBoxCarCondition.Size = new System.Drawing.Size(160, 22);
            this.textBoxCarCondition.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(199, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Car Hand Sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(21, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Car License:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(383, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Car Condition:";
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(951, 511);
            this.buttonAddCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(100, 28);
            this.buttonAddCar.TabIndex = 26;
            this.buttonAddCar.Text = "Add  ";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.FormattingEnabled = true;
            this.textBoxLicense.Location = new System.Drawing.Point(16, 441);
            this.textBoxLicense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.Size = new System.Drawing.Size(160, 24);
            this.textBoxLicense.TabIndex = 29;
            this.textBoxLicense.SelectedIndexChanged += new System.EventHandler(this.textBoxLicense_SelectedIndexChanged);
            // 
            // textBoxHandSales
            // 
            this.textBoxHandSales.Location = new System.Drawing.Point(203, 442);
            this.textBoxHandSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHandSales.Name = "textBoxHandSales";
            this.textBoxHandSales.Size = new System.Drawing.Size(160, 22);
            this.textBoxHandSales.TabIndex = 21;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(820, 511);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(103, 28);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // ConditionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxLicense);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHandSales);
            this.Controls.Add(this.textBoxCarCondition);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellrecommendGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConditionScreen";
            this.Text = "ConditionScreen";
            this.Load += new System.EventHandler(this.ConditionScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellrecommendGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sellrecommendGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCarCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.ComboBox textBoxLicense;
        private System.Windows.Forms.TextBox textBoxHandSales;
        private System.Windows.Forms.Button buttonUpdate;
    }
}