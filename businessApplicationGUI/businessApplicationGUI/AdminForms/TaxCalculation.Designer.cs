
namespace businessApplicationGUI.AdminForms
{
    partial class TaxCalculation
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
            this.gridTax = new System.Windows.Forms.DataGridView();
            this.ColumnTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTax)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTax
            // 
            this.gridTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTax});
            this.gridTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTax.Location = new System.Drawing.Point(0, 0);
            this.gridTax.Name = "gridTax";
            this.gridTax.Size = new System.Drawing.Size(800, 450);
            this.gridTax.TabIndex = 0;
            this.gridTax.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnTax
            // 
            this.ColumnTax.HeaderText = "Tax";
            this.ColumnTax.Name = "ColumnTax";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(39, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTax
            // 
            this.btnTax.AutoSize = true;
            this.btnTax.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTax.Location = new System.Drawing.Point(633, 364);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(99, 31);
            this.btnTax.TabIndex = 5;
            this.btnTax.Text = "Show Tax";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // TaxCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridTax);
            this.Name = "TaxCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxCalculation";
            this.Load += new System.EventHandler(this.TaxCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTax;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTax;
    }
}