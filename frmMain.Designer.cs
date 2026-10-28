namespace Shop_Phone2
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccessoriesProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccessorisPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccessorisSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccessorisLosses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfitAndLossCalculation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurrentUserAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.menuPeople,
            this.menuUsers,
            this.tsmClient,
            this.tsmBrand,
            this.tsmCategory,
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.tsmCurrentUserAccountSettings,
            this.menuLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(934, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccessoriesProduct,
            this.tsmAccessorisPurchases,
            this.tsmAccessorisSales,
            this.tsmAccessorisLosses,
            this.tsmProfitAndLossCalculation});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(61, 24);
            this.tsmMenu.Text = "Menu";
            // 
            // tsmAccessoriesProduct
            // 
            this.tsmAccessoriesProduct.Name = "tsmAccessoriesProduct";
            this.tsmAccessoriesProduct.Size = new System.Drawing.Size(264, 24);
            this.tsmAccessoriesProduct.Text = "Accessories Product";
            this.tsmAccessoriesProduct.Click += new System.EventHandler(this.tsmAccessoriesProduct_Click);
            // 
            // tsmAccessorisPurchases
            // 
            this.tsmAccessorisPurchases.Name = "tsmAccessorisPurchases";
            this.tsmAccessorisPurchases.Size = new System.Drawing.Size(264, 24);
            this.tsmAccessorisPurchases.Text = "Accessoris Purchases";
            this.tsmAccessorisPurchases.Click += new System.EventHandler(this.tsmAccessorisPurchases_Click);
            // 
            // tsmAccessorisSales
            // 
            this.tsmAccessorisSales.Name = "tsmAccessorisSales";
            this.tsmAccessorisSales.Size = new System.Drawing.Size(264, 24);
            this.tsmAccessorisSales.Text = "Accessoris Sales";
            this.tsmAccessorisSales.Click += new System.EventHandler(this.tsmAccessorisSales_Click);
            // 
            // tsmAccessorisLosses
            // 
            this.tsmAccessorisLosses.Name = "tsmAccessorisLosses";
            this.tsmAccessorisLosses.Size = new System.Drawing.Size(264, 24);
            this.tsmAccessorisLosses.Text = "Accessoris Losses";
            this.tsmAccessorisLosses.Click += new System.EventHandler(this.tsmAccessorisLosses_Click);
            // 
            // tsmProfitAndLossCalculation
            // 
            this.tsmProfitAndLossCalculation.Name = "tsmProfitAndLossCalculation";
            this.tsmProfitAndLossCalculation.Size = new System.Drawing.Size(264, 24);
            this.tsmProfitAndLossCalculation.Text = "Profit and Loss Calculation";
            this.tsmProfitAndLossCalculation.Click += new System.EventHandler(this.tsmProfitAndLossCalculation_Click);
            // 
            // menuPeople
            // 
            this.menuPeople.Name = "menuPeople";
            this.menuPeople.Size = new System.Drawing.Size(68, 24);
            this.menuPeople.Text = "People";
            this.menuPeople.Click += new System.EventHandler(this.menuPeople_Click);
            // 
            // menuUsers
            // 
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(60, 24);
            this.menuUsers.Text = "Users";
            this.menuUsers.Click += new System.EventHandler(this.menuUsers_Click);
            // 
            // tsmClient
            // 
            this.tsmClient.Name = "tsmClient";
            this.tsmClient.Size = new System.Drawing.Size(61, 24);
            this.tsmClient.Text = "Client";
            this.tsmClient.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmBrand
            // 
            this.tsmBrand.Name = "tsmBrand";
            this.tsmBrand.Size = new System.Drawing.Size(63, 24);
            this.tsmBrand.Text = "Brand";
            this.tsmBrand.Click += new System.EventHandler(this.tsmBrand_Click);
            // 
            // tsmCategory
            // 
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(85, 24);
            this.tsmCategory.Text = "Category";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem1.Text = "NameAccessoris";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem5.Text = "Supplier";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(71, 24);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // tsmCurrentUserAccountSettings
            // 
            this.tsmCurrentUserAccountSettings.Name = "tsmCurrentUserAccountSettings";
            this.tsmCurrentUserAccountSettings.Size = new System.Drawing.Size(233, 24);
            this.tsmCurrentUserAccountSettings.Text = "Current User Account Settings";
            this.tsmCurrentUserAccountSettings.Click += new System.EventHandler(this.tsmCurrentUserAccountSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 394);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPeople;
        private System.Windows.Forms.ToolStripMenuItem menuUsers;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmClient;
        private System.Windows.Forms.ToolStripMenuItem tsmBrand;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmAccessoriesProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmAccessorisPurchases;
        private System.Windows.Forms.ToolStripMenuItem tsmAccessorisSales;
        private System.Windows.Forms.ToolStripMenuItem tsmAccessorisLosses;
        private System.Windows.Forms.ToolStripMenuItem tsmProfitAndLossCalculation;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrentUserAccountSettings;
    }
}

