
namespace businessApplicationGUI.CustomerForms
{
    partial class makeOrder
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
            this.gridMakeOrder = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btncart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMakeOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMakeOrder
            // 
            this.gridMakeOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridMakeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMakeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMakeOrder.Location = new System.Drawing.Point(0, 0);
            this.gridMakeOrder.Name = "gridMakeOrder";
            this.gridMakeOrder.Size = new System.Drawing.Size(800, 450);
            this.gridMakeOrder.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(39, 297);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btncart
            // 
            this.btncart.AutoSize = true;
            this.btncart.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncart.Location = new System.Drawing.Point(478, 297);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(108, 28);
            this.btncart.TabIndex = 21;
            this.btncart.Text = "Make Order";
            this.btncart.UseVisualStyleBackColor = true;
            this.btncart.Click += new System.EventHandler(this.btncart_Click);
            // 
            // makeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btncart);
            this.Controls.Add(this.gridMakeOrder);
            this.Name = "makeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "makeOrder";
            this.Load += new System.EventHandler(this.makeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMakeOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMakeOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btncart;
    }
}