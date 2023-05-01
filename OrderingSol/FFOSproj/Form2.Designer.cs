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
            this.update_pizza = new System.Windows.Forms.Button();
            this.del_pizza = new System.Windows.Forms.Button();
            this.viewPizza_btn = new System.Windows.Forms.Button();
            this.showPB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.update_pizza);
            this.panel1.Controls.Add(this.del_pizza);
            this.panel1.Controls.Add(this.viewPizza_btn);
            this.panel1.Controls.Add(this.showPB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 644);
            this.panel1.TabIndex = 0;
            // 
            // update_pizza
            // 
            this.update_pizza.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_pizza.Location = new System.Drawing.Point(850, 174);
            this.update_pizza.Name = "update_pizza";
            this.update_pizza.Size = new System.Drawing.Size(179, 65);
            this.update_pizza.TabIndex = 3;
            this.update_pizza.Text = "Update Pizza";
            this.update_pizza.UseVisualStyleBackColor = true;
            this.update_pizza.Click += new System.EventHandler(this.update_pizza_Click);
            // 
            // del_pizza
            // 
            this.del_pizza.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_pizza.Location = new System.Drawing.Point(850, 281);
            this.del_pizza.Name = "del_pizza";
            this.del_pizza.Size = new System.Drawing.Size(179, 65);
            this.del_pizza.TabIndex = 2;
            this.del_pizza.Text = "Delete Pizza";
            this.del_pizza.UseVisualStyleBackColor = true;
            this.del_pizza.Click += new System.EventHandler(this.del_pizza_Click);
            // 
            // viewPizza_btn
            // 
            this.viewPizza_btn.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPizza_btn.Location = new System.Drawing.Point(850, 52);
            this.viewPizza_btn.Name = "viewPizza_btn";
            this.viewPizza_btn.Size = new System.Drawing.Size(179, 65);
            this.viewPizza_btn.TabIndex = 1;
            this.viewPizza_btn.Text = "View Pizza";
            this.viewPizza_btn.UseVisualStyleBackColor = true;
            this.viewPizza_btn.Click += new System.EventHandler(this.datagrid_btn_Click);
            // 
            // showPB
            // 
            this.showPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showPB.Location = new System.Drawing.Point(3, 3);
            this.showPB.Name = "showPB";
            this.showPB.RowHeadersWidth = 62;
            this.showPB.RowTemplate.Height = 28;
            this.showPB.Size = new System.Drawing.Size(821, 638);
            this.showPB.TabIndex = 0;
            this.showPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showPB_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 803);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "VIEW Inventory";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView showPB;
        private System.Windows.Forms.Button viewPizza_btn;
        private System.Windows.Forms.Button update_pizza;
        private System.Windows.Forms.Button del_pizza;
    }
}