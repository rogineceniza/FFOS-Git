namespace FFOSproj
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cashier_button = new System.Windows.Forms.Button();
            this.admin_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.label1.Size = new System.Drawing.Size(280, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Prima Pizza!";
            // 
            // cashier_button
            // 
            this.cashier_button.BackColor = System.Drawing.Color.SaddleBrown;
            this.cashier_button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier_button.ForeColor = System.Drawing.Color.White;
            this.cashier_button.Location = new System.Drawing.Point(142, 561);
            this.cashier_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashier_button.Name = "cashier_button";
            this.cashier_button.Size = new System.Drawing.Size(184, 72);
            this.cashier_button.TabIndex = 5;
            this.cashier_button.Text = "Cashier";
            this.cashier_button.UseVisualStyleBackColor = false;
            this.cashier_button.Click += new System.EventHandler(this.cashier_button_Click);
            // 
            // admin_button
            // 
            this.admin_button.BackColor = System.Drawing.Color.SaddleBrown;
            this.admin_button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_button.ForeColor = System.Drawing.Color.White;
            this.admin_button.Location = new System.Drawing.Point(142, 468);
            this.admin_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(184, 72);
            this.admin_button.TabIndex = 4;
            this.admin_button.Text = "Admin";
            this.admin_button.UseVisualStyleBackColor = false;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 346);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8);
            this.label2.Size = new System.Drawing.Size(196, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Are you the:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.label3.Size = new System.Drawing.Size(375, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sign in with your username and password.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FFOSproj.Properties.Resources.yukmu_mu_mu_mu_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 828);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 827);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cashier_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cashier_button;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}