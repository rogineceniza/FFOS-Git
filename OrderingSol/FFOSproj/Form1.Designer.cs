namespace FFOSproj
{
    partial class inventoryManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryManagementForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsrrrrr = new System.Windows.Forms.Panel();
            this.DisplayTotalToday = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sales = new System.Windows.Forms.DataGridView();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.inventoryPanel = new System.Windows.Forms.Panel();
            this.size_bvrg = new System.Windows.Forms.ComboBox();
            this.bvrg_clear = new System.Windows.Forms.Button();
            this.bvrg_save = new System.Windows.Forms.Button();
            this.price_bvrg = new System.Windows.Forms.TextBox();
            this.description_bvrg = new System.Windows.Forms.TextBox();
            this.name_bvrg = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pizza_image_picbox = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.viewBinventory = new System.Windows.Forms.Button();
            this.logOutBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DSRbtn = new System.Windows.Forms.Button();
            this.viewInventoryBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addInventoryBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.dsrrrrr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            this.inventoryPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_image_picbox)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dsrrrrr);
            this.panel1.Controls.Add(this.dateTimeLabel);
            this.panel1.Controls.Add(this.inventoryPanel);
            this.panel1.Controls.Add(this.viewBinventory);
            this.panel1.Controls.Add(this.logOutBTN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DSRbtn);
            this.panel1.Controls.Add(this.viewInventoryBTN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.addInventoryBTN);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 841);
            this.panel1.TabIndex = 0;
            // 
            // dsrrrrr
            // 
            this.dsrrrrr.BackColor = System.Drawing.Color.White;
            this.dsrrrrr.Controls.Add(this.panel2);
            this.dsrrrrr.Controls.Add(this.label10);
            this.dsrrrrr.Controls.Add(this.label9);
            this.dsrrrrr.Controls.Add(this.sales);
            this.dsrrrrr.Location = new System.Drawing.Point(230, 49);
            this.dsrrrrr.Name = "dsrrrrr";
            this.dsrrrrr.Size = new System.Drawing.Size(962, 746);
            this.dsrrrrr.TabIndex = 2;
            this.dsrrrrr.Paint += new System.Windows.Forms.PaintEventHandler(this.dsrrrrr_Paint);
            // 
            // DisplayTotalToday
            // 
            this.DisplayTotalToday.AutoSize = true;
            this.DisplayTotalToday.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTotalToday.Location = new System.Drawing.Point(81, 61);
            this.DisplayTotalToday.Name = "DisplayTotalToday";
            this.DisplayTotalToday.Size = new System.Drawing.Size(61, 50);
            this.DisplayTotalToday.TabIndex = 6;
            this.DisplayTotalToday.Text = "...";
            this.DisplayTotalToday.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(392, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Sum of Items Sold Today";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sales";
            // 
            // sales
            // 
            this.sales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales.Location = new System.Drawing.Point(0, 65);
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            this.sales.RowHeadersWidth = 62;
            this.sales.RowTemplate.Height = 28;
            this.sales.Size = new System.Drawing.Size(322, 681);
            this.sales.TabIndex = 1;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.Color.White;
            this.dateTimeLabel.Location = new System.Drawing.Point(971, 18);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(188, 29);
            this.dateTimeLabel.TabIndex = 1;
            this.dateTimeLabel.Text = "Date and Time";
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.Controls.Add(this.size_bvrg);
            this.inventoryPanel.Controls.Add(this.bvrg_clear);
            this.inventoryPanel.Controls.Add(this.bvrg_save);
            this.inventoryPanel.Controls.Add(this.price_bvrg);
            this.inventoryPanel.Controls.Add(this.description_bvrg);
            this.inventoryPanel.Controls.Add(this.name_bvrg);
            this.inventoryPanel.Controls.Add(this.sizeBox);
            this.inventoryPanel.Controls.Add(this.clearBtn);
            this.inventoryPanel.Controls.Add(this.saveBtn);
            this.inventoryPanel.Controls.Add(this.priceBox);
            this.inventoryPanel.Controls.Add(this.description_txt);
            this.inventoryPanel.Controls.Add(this.name_txt);
            this.inventoryPanel.Controls.Add(this.panel4);
            this.inventoryPanel.Controls.Add(this.panel5);
            this.inventoryPanel.Location = new System.Drawing.Point(232, 58);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.Size = new System.Drawing.Size(902, 730);
            this.inventoryPanel.TabIndex = 1;
            // 
            // size_bvrg
            // 
            this.size_bvrg.AllowDrop = true;
            this.size_bvrg.FormattingEnabled = true;
            this.size_bvrg.Location = new System.Drawing.Point(503, 537);
            this.size_bvrg.Name = "size_bvrg";
            this.size_bvrg.Size = new System.Drawing.Size(360, 36);
            this.size_bvrg.TabIndex = 24;
            // 
            // bvrg_clear
            // 
            this.bvrg_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.bvrg_clear.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvrg_clear.ForeColor = System.Drawing.Color.White;
            this.bvrg_clear.Location = new System.Drawing.Point(630, 652);
            this.bvrg_clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bvrg_clear.Name = "bvrg_clear";
            this.bvrg_clear.Size = new System.Drawing.Size(105, 54);
            this.bvrg_clear.TabIndex = 23;
            this.bvrg_clear.Text = "Clear";
            this.bvrg_clear.UseVisualStyleBackColor = false;
            this.bvrg_clear.Click += new System.EventHandler(this.bvrg_clear_Click);
            // 
            // bvrg_save
            // 
            this.bvrg_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.bvrg_save.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvrg_save.ForeColor = System.Drawing.Color.White;
            this.bvrg_save.Location = new System.Drawing.Point(758, 652);
            this.bvrg_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bvrg_save.Name = "bvrg_save";
            this.bvrg_save.Size = new System.Drawing.Size(105, 54);
            this.bvrg_save.TabIndex = 18;
            this.bvrg_save.Text = "Save";
            this.bvrg_save.UseVisualStyleBackColor = false;
            this.bvrg_save.Click += new System.EventHandler(this.bvrg_save_Click);
            // 
            // price_bvrg
            // 
            this.price_bvrg.Location = new System.Drawing.Point(503, 579);
            this.price_bvrg.Name = "price_bvrg";
            this.price_bvrg.Size = new System.Drawing.Size(360, 37);
            this.price_bvrg.TabIndex = 22;
            // 
            // description_bvrg
            // 
            this.description_bvrg.Location = new System.Drawing.Point(503, 441);
            this.description_bvrg.Multiline = true;
            this.description_bvrg.Name = "description_bvrg";
            this.description_bvrg.Size = new System.Drawing.Size(360, 90);
            this.description_bvrg.TabIndex = 21;
            // 
            // name_bvrg
            // 
            this.name_bvrg.Location = new System.Drawing.Point(503, 398);
            this.name_bvrg.Name = "name_bvrg";
            this.name_bvrg.Size = new System.Drawing.Size(360, 37);
            this.name_bvrg.TabIndex = 20;
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(503, 191);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(360, 36);
            this.sizeBox.TabIndex = 13;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.clearBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(630, 306);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 54);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(758, 306);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 54);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(503, 233);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(360, 37);
            this.priceBox.TabIndex = 9;
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(503, 95);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(360, 90);
            this.description_txt.TabIndex = 7;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(503, 52);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(360, 37);
            this.name_txt.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pizza_image_picbox);
            this.panel4.Controls.Add(this.description);
            this.panel4.Controls.Add(this.name);
            this.panel4.Location = new System.Drawing.Point(-2, -9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(911, 383);
            this.panel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(342, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(342, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Size";
            // 
            // pizza_image_picbox
            // 
            this.pizza_image_picbox.BackgroundImage = global::FFOSproj.Properties.Resources.pizza;
            this.pizza_image_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizza_image_picbox.Location = new System.Drawing.Point(37, 114);
            this.pizza_image_picbox.Name = "pizza_image_picbox";
            this.pizza_image_picbox.Size = new System.Drawing.Size(206, 172);
            this.pizza_image_picbox.TabIndex = 0;
            this.pizza_image_picbox.TabStop = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Roboto Mono Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.description.Location = new System.Drawing.Point(342, 105);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(167, 29);
            this.description.TabIndex = 3;
            this.description.Text = "Description";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.name.Location = new System.Drawing.Point(342, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 32);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(-2, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(910, 364);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(342, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(342, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(342, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(342, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::FFOSproj.Properties.Resources.cokkkk;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(37, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 172);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // viewBinventory
            // 
            this.viewBinventory.BackColor = System.Drawing.Color.SaddleBrown;
            this.viewBinventory.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBinventory.ForeColor = System.Drawing.Color.White;
            this.viewBinventory.Location = new System.Drawing.Point(26, 431);
            this.viewBinventory.Margin = new System.Windows.Forms.Padding(0);
            this.viewBinventory.Name = "viewBinventory";
            this.viewBinventory.Size = new System.Drawing.Size(179, 67);
            this.viewBinventory.TabIndex = 6;
            this.viewBinventory.Text = "Beverage Inventory";
            this.viewBinventory.UseVisualStyleBackColor = false;
            this.viewBinventory.Click += new System.EventHandler(this.viewBinventory_Click_1);
            // 
            // logOutBTN
            // 
            this.logOutBTN.BackColor = System.Drawing.Color.SaddleBrown;
            this.logOutBTN.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBTN.ForeColor = System.Drawing.Color.White;
            this.logOutBTN.Location = new System.Drawing.Point(26, 637);
            this.logOutBTN.Margin = new System.Windows.Forms.Padding(0);
            this.logOutBTN.Name = "logOutBTN";
            this.logOutBTN.Size = new System.Drawing.Size(179, 66);
            this.logOutBTN.TabIndex = 4;
            this.logOutBTN.Text = "Logout";
            this.logOutBTN.UseVisualStyleBackColor = false;
            this.logOutBTN.Click += new System.EventHandler(this.logOutBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Daily Sales Report";
            // 
            // DSRbtn
            // 
            this.DSRbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.DSRbtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSRbtn.ForeColor = System.Drawing.Color.White;
            this.DSRbtn.Location = new System.Drawing.Point(26, 533);
            this.DSRbtn.Margin = new System.Windows.Forms.Padding(0);
            this.DSRbtn.Name = "DSRbtn";
            this.DSRbtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.DSRbtn.Size = new System.Drawing.Size(179, 67);
            this.DSRbtn.TabIndex = 3;
            this.DSRbtn.Text = "Daily Sales Report";
            this.DSRbtn.UseVisualStyleBackColor = false;
            this.DSRbtn.Click += new System.EventHandler(this.DSRbtn_Click);
            // 
            // viewInventoryBTN
            // 
            this.viewInventoryBTN.BackColor = System.Drawing.Color.SaddleBrown;
            this.viewInventoryBTN.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInventoryBTN.ForeColor = System.Drawing.Color.White;
            this.viewInventoryBTN.Location = new System.Drawing.Point(26, 324);
            this.viewInventoryBTN.Margin = new System.Windows.Forms.Padding(0);
            this.viewInventoryBTN.Name = "viewInventoryBTN";
            this.viewInventoryBTN.Size = new System.Drawing.Size(179, 67);
            this.viewInventoryBTN.TabIndex = 2;
            this.viewInventoryBTN.Text = "Pizza Inventory";
            this.viewInventoryBTN.UseVisualStyleBackColor = false;
            this.viewInventoryBTN.Click += new System.EventHandler(this.viewInventoryBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FFOSproj.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(45, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 145);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addInventoryBTN
            // 
            this.addInventoryBTN.BackColor = System.Drawing.Color.SaddleBrown;
            this.addInventoryBTN.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInventoryBTN.ForeColor = System.Drawing.Color.White;
            this.addInventoryBTN.Location = new System.Drawing.Point(26, 218);
            this.addInventoryBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addInventoryBTN.Name = "addInventoryBTN";
            this.addInventoryBTN.Size = new System.Drawing.Size(179, 67);
            this.addInventoryBTN.TabIndex = 0;
            this.addInventoryBTN.Text = "ADD Inventory";
            this.addInventoryBTN.UseVisualStyleBackColor = false;
            this.addInventoryBTN.Click += new System.EventHandler(this.addInventoryBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.DisplayTotalToday);
            this.panel2.Location = new System.Drawing.Point(348, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 183);
            this.panel2.TabIndex = 7;
            // 
            // inventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 829);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inventoryManagementForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Ordering System";
            this.Load += new System.EventHandler(this.inventoryManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dsrrrrr.ResumeLayout(false);
            this.dsrrrrr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            this.inventoryPanel.ResumeLayout(false);
            this.inventoryPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizza_image_picbox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutBTN;
        private System.Windows.Forms.Button DSRbtn;
        private System.Windows.Forms.Button viewInventoryBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addInventoryBTN;
        private System.Windows.Forms.Panel inventoryPanel;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.ComboBox size_bvrg;
        private System.Windows.Forms.Button bvrg_clear;
        private System.Windows.Forms.Button bvrg_save;
        private System.Windows.Forms.TextBox price_bvrg;
        private System.Windows.Forms.TextBox description_bvrg;
        private System.Windows.Forms.TextBox name_bvrg;
        private System.Windows.Forms.Button viewBinventory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pizza_image_picbox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel dsrrrrr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView sales;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label DisplayTotalToday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
    }
}

