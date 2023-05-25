namespace FFOSproj
{
    partial class pizzaDatagrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaDatagrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_pizza = new System.Windows.Forms.Button();
            this.showPB = new System.Windows.Forms.DataGridView();
            this.pizzatableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizza_tableDataSet = new FFOSproj.pizza_tableDataSet();
            this.pizza_tableTableAdapter = new FFOSproj.pizza_tableDataSetTableAdapters.pizza_tableTableAdapter();
            this.pizza_tableDataSet1 = new FFOSproj.pizza_tableDataSet1();
            this.pizzatableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pizza_tableTableAdapter1 = new FFOSproj.pizza_tableDataSet1TableAdapters.pizza_tableTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzatableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_tableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_tableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzatableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.del_pizza);
            this.panel1.Controls.Add(this.showPB);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 622);
            this.panel1.TabIndex = 0;
            // 
            // del_pizza
            // 
            this.del_pizza.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_pizza.Location = new System.Drawing.Point(1333, 87);
            this.del_pizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_pizza.Name = "del_pizza";
            this.del_pizza.Size = new System.Drawing.Size(159, 52);
            this.del_pizza.TabIndex = 2;
            this.del_pizza.Text = "Delete Item";
            this.del_pizza.UseVisualStyleBackColor = true;
            this.del_pizza.Click += new System.EventHandler(this.del_pizza_Click);
            // 
            // showPB
            // 
            this.showPB.AllowUserToAddRows = false;
            this.showPB.AutoGenerateColumns = false;
            this.showPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.showPB.DataSource = this.pizzatableBindingSource;
            this.showPB.Location = new System.Drawing.Point(3, 0);
            this.showPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPB.Name = "showPB";
            this.showPB.RowHeadersWidth = 62;
            this.showPB.RowTemplate.Height = 28;
            this.showPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showPB.Size = new System.Drawing.Size(1309, 604);
            this.showPB.TabIndex = 0;
            this.showPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showPB_CellContentClick);
            // 
            // pizzatableBindingSource
            // 
            this.pizzatableBindingSource.DataMember = "pizza_table";
            this.pizzatableBindingSource.DataSource = this.pizza_tableDataSet;
            // 
            // pizza_tableDataSet
            // 
            this.pizza_tableDataSet.DataSetName = "pizza_tableDataSet";
            this.pizza_tableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizza_tableTableAdapter
            // 
            this.pizza_tableTableAdapter.ClearBeforeFill = true;
            // 
            // pizza_tableDataSet1
            // 
            this.pizza_tableDataSet1.DataSetName = "pizza_tableDataSet1";
            this.pizza_tableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzatableBindingSource1
            // 
            this.pizzatableBindingSource1.DataMember = "pizza_table";
            this.pizzatableBindingSource1.DataSource = this.pizza_tableDataSet1;
            // 
            // pizza_tableTableAdapter1
            // 
            this.pizza_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1333, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pizzaDatagrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1532, 643);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pizzaDatagrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIEW Pizza Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pizzaDatagrid_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzatableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_tableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_tableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzatableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView showPB;
        private System.Windows.Forms.Button del_pizza;
        private pizza_tableDataSet pizza_tableDataSet;
        private System.Windows.Forms.BindingSource pizzatableBindingSource;
        private pizza_tableDataSetTableAdapters.pizza_tableTableAdapter pizza_tableTableAdapter;
        private pizza_tableDataSet1 pizza_tableDataSet1;
        private System.Windows.Forms.BindingSource pizzatableBindingSource1;
        private pizza_tableDataSet1TableAdapters.pizza_tableTableAdapter pizza_tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}