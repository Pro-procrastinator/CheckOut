namespace InventoryManagementSystem
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saleReturnbtn = new System.Windows.Forms.Button();
            this.productpricingbtn = new System.Windows.Forms.Button();
            this.Suppbtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.salesbtn = new System.Windows.Forms.Button();
            this.purchaseInvoice = new System.Windows.Forms.Button();
            this.stockbtn = new System.Windows.Forms.Button();
            this.productbtn = new System.Windows.Forms.Button();
            this.Usersbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(269, 665);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(1088, 665);
            this.rightPanel.Controls.SetChildIndex(this.paneltop, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // paneltop
            // 
            this.paneltop.Size = new System.Drawing.Size(1088, 71);
            // 
            // usernamelbl
            // 
            this.usernamelbl.Size = new System.Drawing.Size(366, 71);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.saleReturnbtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.productpricingbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Suppbtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesbtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseInvoice, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Usersbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 404);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // saleReturnbtn
            // 
            this.saleReturnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleReturnbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleReturnbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.saleReturnbtn.FlatAppearance.BorderSize = 3;
            this.saleReturnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saleReturnbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReturnbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.saleReturnbtn.Image = global::InventoryManagementSystem.Properties.Resources.assignment_return_80px1;
            this.saleReturnbtn.Location = new System.Drawing.Point(654, 205);
            this.saleReturnbtn.Name = "saleReturnbtn";
            this.saleReturnbtn.Size = new System.Drawing.Size(211, 196);
            this.saleReturnbtn.TabIndex = 8;
            this.saleReturnbtn.Text = "Sales Return";
            this.saleReturnbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saleReturnbtn.UseVisualStyleBackColor = true;
            this.saleReturnbtn.Click += new System.EventHandler(this.saleReturnbtn_Click);
            // 
            // productpricingbtn
            // 
            this.productpricingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productpricingbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productpricingbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.productpricingbtn.FlatAppearance.BorderSize = 3;
            this.productpricingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productpricingbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productpricingbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.productpricingbtn.Image = global::InventoryManagementSystem.Properties.Resources.pricing_80px2;
            this.productpricingbtn.Location = new System.Drawing.Point(437, 205);
            this.productpricingbtn.Name = "productpricingbtn";
            this.productpricingbtn.Size = new System.Drawing.Size(211, 196);
            this.productpricingbtn.TabIndex = 7;
            this.productpricingbtn.Text = "Product Pricing";
            this.productpricingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productpricingbtn.UseVisualStyleBackColor = true;
            this.productpricingbtn.Click += new System.EventHandler(this.productpricingbtn_Click);
            // 
            // Suppbtn
            // 
            this.Suppbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suppbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Suppbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Suppbtn.FlatAppearance.BorderSize = 3;
            this.Suppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suppbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Suppbtn.Image = global::InventoryManagementSystem.Properties.Resources.supplier_80px1;
            this.Suppbtn.Location = new System.Drawing.Point(220, 205);
            this.Suppbtn.Name = "Suppbtn";
            this.Suppbtn.Size = new System.Drawing.Size(211, 196);
            this.Suppbtn.TabIndex = 6;
            this.Suppbtn.Text = "Suppliers";
            this.Suppbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Suppbtn.UseVisualStyleBackColor = true;
            this.Suppbtn.Click += new System.EventHandler(this.Suppbtn_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.button5.Image = global::InventoryManagementSystem.Properties.Resources.categorize_80px1;
            this.button5.Location = new System.Drawing.Point(3, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 196);
            this.button5.TabIndex = 5;
            this.button5.Text = "Categories";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // salesbtn
            // 
            this.salesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.salesbtn.FlatAppearance.BorderSize = 3;
            this.salesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.salesbtn.Image = global::InventoryManagementSystem.Properties.Resources.sales_performance_80px2;
            this.salesbtn.Location = new System.Drawing.Point(871, 3);
            this.salesbtn.Name = "salesbtn";
            this.salesbtn.Size = new System.Drawing.Size(214, 196);
            this.salesbtn.TabIndex = 4;
            this.salesbtn.Text = "Sales";
            this.salesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesbtn.UseVisualStyleBackColor = true;
            this.salesbtn.Click += new System.EventHandler(this.salesbtn_Click);
            // 
            // purchaseInvoice
            // 
            this.purchaseInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.purchaseInvoice.FlatAppearance.BorderSize = 3;
            this.purchaseInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseInvoice.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.purchaseInvoice.Image = global::InventoryManagementSystem.Properties.Resources.invoice_80px1;
            this.purchaseInvoice.Location = new System.Drawing.Point(654, 3);
            this.purchaseInvoice.Name = "purchaseInvoice";
            this.purchaseInvoice.Size = new System.Drawing.Size(211, 196);
            this.purchaseInvoice.TabIndex = 3;
            this.purchaseInvoice.Text = "Purchasing Invoice";
            this.purchaseInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchaseInvoice.UseVisualStyleBackColor = true;
            this.purchaseInvoice.Click += new System.EventHandler(this.purchaseInvoice_Click);
            // 
            // stockbtn
            // 
            this.stockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.stockbtn.FlatAppearance.BorderSize = 3;
            this.stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.stockbtn.Image = global::InventoryManagementSystem.Properties.Resources.stocks_80px1;
            this.stockbtn.Location = new System.Drawing.Point(437, 3);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Size = new System.Drawing.Size(211, 196);
            this.stockbtn.TabIndex = 2;
            this.stockbtn.Text = "Stock";
            this.stockbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockbtn.UseVisualStyleBackColor = true;
            this.stockbtn.Click += new System.EventHandler(this.stockbtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.productbtn.FlatAppearance.BorderSize = 3;
            this.productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.productbtn.Image = global::InventoryManagementSystem.Properties.Resources.product_80px1;
            this.productbtn.Location = new System.Drawing.Point(220, 3);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(211, 196);
            this.productbtn.TabIndex = 1;
            this.productbtn.Text = "Products";
            this.productbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productbtn.UseVisualStyleBackColor = true;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // Usersbtn
            // 
            this.Usersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Usersbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usersbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Usersbtn.FlatAppearance.BorderSize = 3;
            this.Usersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usersbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usersbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.Usersbtn.Image = global::InventoryManagementSystem.Properties.Resources.add_user_group_man_man_80px1;
            this.Usersbtn.Location = new System.Drawing.Point(3, 3);
            this.Usersbtn.Name = "Usersbtn";
            this.Usersbtn.Size = new System.Drawing.Size(211, 196);
            this.Usersbtn.TabIndex = 0;
            this.Usersbtn.Text = "Users";
            this.Usersbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Usersbtn.UseVisualStyleBackColor = true;
            this.Usersbtn.Click += new System.EventHandler(this.Usersbtn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.button1.Image = global::InventoryManagementSystem.Properties.Resources.settings_80px;
            this.button1.Location = new System.Drawing.Point(871, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 196);
            this.button1.TabIndex = 9;
            this.button1.Text = "Settings";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 665);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saleReturnbtn;
        private System.Windows.Forms.Button productpricingbtn;
        private System.Windows.Forms.Button Suppbtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button salesbtn;
        private System.Windows.Forms.Button purchaseInvoice;
        private System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.Button productbtn;
        private System.Windows.Forms.Button Usersbtn;
        private System.Windows.Forms.Button button1;
    }
}