namespace FFOSproj
{
    partial class Cashier_Formmmm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalData = new System.Windows.Forms.DataGridView();
            this.nameOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeOFItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Name_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.refresh2_btn = new System.Windows.Forms.Button();
            this.add2_btn = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1954, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalData);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnRemoveFromCart);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Location = new System.Drawing.Point(1264, 118);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 746);
            this.panel3.TabIndex = 2;
            // 
            // totalData
            // 
            this.totalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOfItem,
            this.sizeOFItem,
            this.priceOfItem});
            this.totalData.Location = new System.Drawing.Point(0, 0);
            this.totalData.Name = "totalData";
            this.totalData.RowHeadersWidth = 62;
            this.totalData.RowTemplate.Height = 28;
            this.totalData.Size = new System.Drawing.Size(699, 338);
            this.totalData.TabIndex = 7;
            // 
            // nameOfItem
            // 
            this.nameOfItem.HeaderText = "Name";
            this.nameOfItem.MinimumWidth = 8;
            this.nameOfItem.Name = "nameOfItem";
            this.nameOfItem.ReadOnly = true;
            this.nameOfItem.Width = 150;
            // 
            // sizeOFItem
            // 
            this.sizeOFItem.HeaderText = "Size";
            this.sizeOFItem.MinimumWidth = 8;
            this.sizeOFItem.Name = "sizeOFItem";
            this.sizeOFItem.ReadOnly = true;
            this.sizeOFItem.Width = 150;
            // 
            // priceOfItem
            // 
            this.priceOfItem.HeaderText = "Price";
            this.priceOfItem.MinimumWidth = 8;
            this.priceOfItem.Name = "priceOfItem";
            this.priceOfItem.ReadOnly = true;
            this.priceOfItem.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.AutoSize = true;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(198, 142);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(0, 20);
            this.btnRemoveFromCart.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_1,
            this.Size_1,
            this.Price_1});
            this.dataGridView3.Location = new System.Drawing.Point(3, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1, 1);
            this.dataGridView3.TabIndex = 0;
            // 
            // Name_1
            // 
            this.Name_1.HeaderText = "Name";
            this.Name_1.MinimumWidth = 6;
            this.Name_1.Name = "Name_1";
            this.Name_1.ReadOnly = true;
            this.Name_1.Width = 125;
            // 
            // Size_1
            // 
            this.Size_1.HeaderText = "Size";
            this.Size_1.MinimumWidth = 6;
            this.Size_1.Name = "Size_1";
            this.Size_1.ReadOnly = true;
            this.Size_1.Width = 125;
            // 
            // Price_1
            // 
            this.Price_1.HeaderText = "Price";
            this.Price_1.MinimumWidth = 6;
            this.Price_1.Name = "Price_1";
            this.Price_1.ReadOnly = true;
            this.Price_1.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 118);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 692);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(519, 689);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(429, 814);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(106, 50);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(316, 815);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(106, 50);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(557, 118);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(522, 692);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(519, 689);
            this.dataGridView2.TabIndex = 0;
            // 
            // refresh2_btn
            // 
            this.refresh2_btn.Location = new System.Drawing.Point(861, 814);
            this.refresh2_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh2_btn.Name = "refresh2_btn";
            this.refresh2_btn.Size = new System.Drawing.Size(106, 50);
            this.refresh2_btn.TabIndex = 4;
            this.refresh2_btn.Text = "Refresh";
            this.refresh2_btn.UseVisualStyleBackColor = true;
            this.refresh2_btn.Click += new System.EventHandler(this.refresh2_btn_Click);
            // 
            // add2_btn
            // 
            this.add2_btn.Location = new System.Drawing.Point(973, 814);
            this.add2_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add2_btn.Name = "add2_btn";
            this.add2_btn.Size = new System.Drawing.Size(106, 50);
            this.add2_btn.TabIndex = 5;
            this.add2_btn.Text = "Add";
            this.add2_btn.UseVisualStyleBackColor = true;
            this.add2_btn.Click += new System.EventHandler(this.add2_btn_Click);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(1861, 870);
            this.Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(106, 50);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = true;
            this.Total.Click += new System.EventHandler(this.Total_Click_1);
            // 
            // Cashier_Formmmm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(2086, 964);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.add2_btn);
            this.Controls.Add(this.refresh2_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cashier_Formmmm";
            this.Text = "Cashier Form";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button refresh2_btn;
        private System.Windows.Forms.Button add2_btn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label btnRemoveFromCart;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView totalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeOFItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOfItem;
    }
}