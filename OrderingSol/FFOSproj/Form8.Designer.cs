namespace FFOSproj
{
    partial class test
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
            this.sales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales.Location = new System.Drawing.Point(26, 53);
            this.sales.Name = "sales";
            this.sales.RowHeadersWidth = 62;
            this.sales.RowTemplate.Height = 28;
            this.sales.Size = new System.Drawing.Size(437, 477);
            this.sales.TabIndex = 0;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 651);
            this.Controls.Add(this.sales);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "test";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sales;
    }
}