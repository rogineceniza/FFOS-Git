﻿namespace FFOSproj
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
            this.merge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.merge)).BeginInit();
            this.SuspendLayout();
            // 
            // merge
            // 
            this.merge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.merge.Location = new System.Drawing.Point(24, 12);
            this.merge.Name = "merge";
            this.merge.RowHeadersWidth = 62;
            this.merge.RowTemplate.Height = 28;
            this.merge.Size = new System.Drawing.Size(437, 477);
            this.merge.TabIndex = 0;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 651);
            this.Controls.Add(this.merge);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "test";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.merge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView merge;
    }
}