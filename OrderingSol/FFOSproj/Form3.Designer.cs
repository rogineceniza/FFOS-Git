namespace FFOSproj
{
    partial class beverageDatagrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beverageDatagrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.del_pizza = new System.Windows.Forms.Button();
            this.showPB = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beveragetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beverage_tableDataSet = new FFOSproj.beverage_tableDataSet();
            this.beverage_tableTableAdapter = new FFOSproj.beverage_tableDataSetTableAdapters.beverage_tableTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beveragetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverage_tableDataSet)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1327, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del_pizza
            // 
            this.del_pizza.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_pizza.Location = new System.Drawing.Point(1327, 64);
            this.del_pizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_pizza.Name = "del_pizza";
            this.del_pizza.Size = new System.Drawing.Size(163, 72);
            this.del_pizza.TabIndex = 3;
            this.del_pizza.Text = "Delete Beverage";
            this.del_pizza.UseVisualStyleBackColor = true;
            this.del_pizza.Click += new System.EventHandler(this.del_pizza_Click_1);
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
            this.showPB.DataSource = this.beveragetableBindingSource;
            this.showPB.Location = new System.Drawing.Point(3, 2);
            this.showPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPB.Name = "showPB";
            this.showPB.RowHeadersWidth = 62;
            this.showPB.RowTemplate.Height = 28;
            this.showPB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showPB.Size = new System.Drawing.Size(1305, 590);
            this.showPB.TabIndex = 2;
            this.showPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showPB_CellContentClick);
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
            // beveragetableBindingSource
            // 
            this.beveragetableBindingSource.DataMember = "beverage_table";
            this.beveragetableBindingSource.DataSource = this.beverage_tableDataSet;
            // 
            // beverage_tableDataSet
            // 
            this.beverage_tableDataSet.DataSetName = "beverage_tableDataSet";
            this.beverage_tableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beverage_tableTableAdapter
            // 
            this.beverage_tableTableAdapter.ClearBeforeFill = true;
            // 
            // beverageDatagrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1532, 643);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "beverageDatagrid";
            this.Text = "VIEW Beverage Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.beverageDatagrid_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beveragetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beverage_tableDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView showPB;
        private System.Windows.Forms.Button del_pizza;
        private beverage_tableDataSet beverage_tableDataSet;
        private System.Windows.Forms.BindingSource beveragetableBindingSource;
        private beverage_tableDataSetTableAdapters.beverage_tableTableAdapter beverage_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}