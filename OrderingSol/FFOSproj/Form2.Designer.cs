namespace FFOSproj
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_pizza = new System.Windows.Forms.Button();
            this.showPB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.del_pizza);
            this.panel1.Controls.Add(this.showPB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 644);
            this.panel1.TabIndex = 0;
            // 
            // del_pizza
            // 
            this.del_pizza.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_pizza.Location = new System.Drawing.Point(989, 49);
            this.del_pizza.Name = "del_pizza";
            this.del_pizza.Size = new System.Drawing.Size(179, 65);
            this.del_pizza.TabIndex = 2;
            this.del_pizza.Text = "Delete Item";
            this.del_pizza.UseVisualStyleBackColor = true;
            this.del_pizza.Click += new System.EventHandler(this.del_pizza_Click);
            // 
            // showPB
            // 
            this.showPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showPB.Location = new System.Drawing.Point(3, 0);
            this.showPB.Name = "showPB";
            this.showPB.RowHeadersWidth = 62;
            this.showPB.RowTemplate.Height = 28;
            this.showPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showPB.Size = new System.Drawing.Size(953, 638);
            this.showPB.TabIndex = 0;
            this.showPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showPB_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 803);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "VIEW Pizza Inventory";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView showPB;
        private System.Windows.Forms.Button del_pizza;
    }
}