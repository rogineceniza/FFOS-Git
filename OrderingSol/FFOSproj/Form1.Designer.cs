namespace FFOSproj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.viewInventoryBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addInventoryBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pizzaPicLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logOutBTN);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.viewInventoryBTN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.addInventoryBTN);
            this.panel1.Location = new System.Drawing.Point(25, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 116);
            this.panel1.TabIndex = 0;
            // 
            // logOutBTN
            // 
            this.logOutBTN.Location = new System.Drawing.Point(544, 26);
            this.logOutBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logOutBTN.Name = "logOutBTN";
            this.logOutBTN.Size = new System.Drawing.Size(118, 67);
            this.logOutBTN.TabIndex = 4;
            this.logOutBTN.Text = "Logout";
            this.logOutBTN.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Daily Sales Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // viewInventoryBTN
            // 
            this.viewInventoryBTN.Location = new System.Drawing.Point(254, 26);
            this.viewInventoryBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewInventoryBTN.Name = "viewInventoryBTN";
            this.viewInventoryBTN.Size = new System.Drawing.Size(118, 67);
            this.viewInventoryBTN.TabIndex = 2;
            this.viewInventoryBTN.Text = "VIEW Inventory";
            this.viewInventoryBTN.UseVisualStyleBackColor = true;
            this.viewInventoryBTN.Click += new System.EventHandler(this.viewInventoryBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // addInventoryBTN
            // 
            this.addInventoryBTN.Location = new System.Drawing.Point(116, 26);
            this.addInventoryBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addInventoryBTN.Name = "addInventoryBTN";
            this.addInventoryBTN.Size = new System.Drawing.Size(118, 67);
            this.addInventoryBTN.TabIndex = 0;
            this.addInventoryBTN.Text = "ADD Inventory";
            this.addInventoryBTN.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sizeBox);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Controls.Add(this.upload);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.priceBox);
            this.panel2.Controls.Add(this.description_txt);
            this.panel2.Controls.Add(this.name_txt);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.size);
            this.panel2.Controls.Add(this.description);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.pizzaPicLabel);
            this.panel2.Controls.Add(this.imageBox);
            this.panel2.Location = new System.Drawing.Point(27, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 538);
            this.panel2.TabIndex = 1;
            // 
            // sizeBox
            // 
            this.sizeBox.AllowDrop = true;
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(503, 256);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(360, 36);
            this.sizeBox.TabIndex = 13;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(629, 408);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(105, 54);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(758, 408);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 54);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(206, 255);
            this.upload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(105, 47);
            this.upload.TabIndex = 10;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(97, 255);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(105, 47);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(503, 314);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(360, 37);
            this.priceBox.TabIndex = 9;
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(503, 119);
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
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(349, 314);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(62, 28);
            this.price.TabIndex = 5;
            this.price.Text = "Price";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(349, 245);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(54, 28);
            this.size.TabIndex = 4;
            this.size.Text = "Size";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(341, 122);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(131, 28);
            this.description.TabIndex = 3;
            this.description.Text = "Description";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(341, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(85, 28);
            this.name.TabIndex = 2;
            this.name.Text = "Name: ";
            // 
            // pizzaPicLabel
            // 
            this.pizzaPicLabel.AutoSize = true;
            this.pizzaPicLabel.Location = new System.Drawing.Point(25, 14);
            this.pizzaPicLabel.Name = "pizzaPicLabel";
            this.pizzaPicLabel.Size = new System.Drawing.Size(135, 28);
            this.pizzaPicLabel.TabIndex = 1;
            this.pizzaPicLabel.Text = "Pizza Image";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(30, 45);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(281, 204);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(992, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food Ordering System";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOutBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button viewInventoryBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addInventoryBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pizzaPicLabel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ComboBox sizeBox;
    }
}

