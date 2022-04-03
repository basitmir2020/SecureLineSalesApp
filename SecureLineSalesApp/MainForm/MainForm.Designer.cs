namespace SecureLineSalesApp.MainForm
{
    partial class MainForm
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
            this.Menu = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnProductVariation = new System.Windows.Forms.Button();
            this.btnVariation = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSubSubCategory = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTittleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Menu.Controls.Add(this.btnStock);
            this.Menu.Controls.Add(this.btnPrice);
            this.Menu.Controls.Add(this.btnProductVariation);
            this.Menu.Controls.Add(this.btnVariation);
            this.Menu.Controls.Add(this.btnProduct);
            this.Menu.Controls.Add(this.btnSubSubCategory);
            this.Menu.Controls.Add(this.btnSubCategory);
            this.Menu.Controls.Add(this.btnCategory);
            this.Menu.Controls.Add(this.btnDashboard);
            this.Menu.Controls.Add(this.panelLogo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 637);
            this.Menu.TabIndex = 0;
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 560);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(220, 60);
            this.btnStock.TabIndex = 9;
            this.btnStock.Text = "  Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrice.FlatAppearance.BorderSize = 0;
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrice.ForeColor = System.Drawing.Color.White;
            this.btnPrice.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrice.Location = new System.Drawing.Point(0, 500);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPrice.Size = new System.Drawing.Size(220, 60);
            this.btnPrice.TabIndex = 8;
            this.btnPrice.Text = "  Price";
            this.btnPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnProductVariation
            // 
            this.btnProductVariation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductVariation.FlatAppearance.BorderSize = 0;
            this.btnProductVariation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductVariation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductVariation.ForeColor = System.Drawing.Color.White;
            this.btnProductVariation.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnProductVariation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductVariation.Location = new System.Drawing.Point(0, 440);
            this.btnProductVariation.Name = "btnProductVariation";
            this.btnProductVariation.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProductVariation.Size = new System.Drawing.Size(220, 60);
            this.btnProductVariation.TabIndex = 7;
            this.btnProductVariation.Text = "  Product Variation";
            this.btnProductVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductVariation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductVariation.UseVisualStyleBackColor = true;
            this.btnProductVariation.Click += new System.EventHandler(this.btnProductVariation_Click);
            // 
            // btnVariation
            // 
            this.btnVariation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVariation.FlatAppearance.BorderSize = 0;
            this.btnVariation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVariation.ForeColor = System.Drawing.Color.White;
            this.btnVariation.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnVariation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariation.Location = new System.Drawing.Point(0, 380);
            this.btnVariation.Name = "btnVariation";
            this.btnVariation.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVariation.Size = new System.Drawing.Size(220, 60);
            this.btnVariation.TabIndex = 6;
            this.btnVariation.Text = "  Variation";
            this.btnVariation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVariation.UseVisualStyleBackColor = true;
            this.btnVariation.Click += new System.EventHandler(this.btnVariation_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 320);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(220, 60);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "  Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSubSubCategory
            // 
            this.btnSubSubCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubSubCategory.FlatAppearance.BorderSize = 0;
            this.btnSubSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubSubCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubSubCategory.ForeColor = System.Drawing.Color.White;
            this.btnSubSubCategory.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnSubSubCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubSubCategory.Location = new System.Drawing.Point(0, 260);
            this.btnSubSubCategory.Name = "btnSubSubCategory";
            this.btnSubSubCategory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSubSubCategory.Size = new System.Drawing.Size(220, 60);
            this.btnSubSubCategory.TabIndex = 4;
            this.btnSubSubCategory.Text = "  Sub SubCategory";
            this.btnSubSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubSubCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubSubCategory.UseVisualStyleBackColor = true;
            this.btnSubSubCategory.Click += new System.EventHandler(this.btnSubSubCategory_Click);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCategory.FlatAppearance.BorderSize = 0;
            this.btnSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubCategory.ForeColor = System.Drawing.Color.White;
            this.btnSubCategory.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnSubCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCategory.Location = new System.Drawing.Point(0, 200);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSubCategory.Size = new System.Drawing.Size(220, 60);
            this.btnSubCategory.TabIndex = 3;
            this.btnSubCategory.Text = "  SubCategory";
            this.btnSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubCategory.UseVisualStyleBackColor = true;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCategory_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 140);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(220, 60);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "  Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::SecureLineSalesApp.Properties.Resources.dashboard1;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.White;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Edwardian Script ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location = new System.Drawing.Point(0, 29);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(207, 29);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Secure Line Sales App";
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTittleBar.Controls.Add(this.lblTitle);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(796, 80);
            this.panelTittleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(331, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(796, 557);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 637);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTittleBar);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnProductVariation;
        private System.Windows.Forms.Button btnVariation;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSubSubCategory;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTittleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}