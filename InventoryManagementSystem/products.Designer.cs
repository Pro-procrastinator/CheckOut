namespace InventoryManagementSystem
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodnameerrorlbl = new System.Windows.Forms.Label();
            this.barcodetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeerrorlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expiryerrorlbl = new System.Windows.Forms.Label();
            this.expirypicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryerrorlbl = new System.Windows.Forms.Label();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.productDataGV = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1084, 58);
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(172, 26);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.categoryDD);
            this.leftpanel.Controls.Add(this.label7);
            this.leftpanel.Controls.Add(this.categoryerrorlbl);
            this.leftpanel.Controls.Add(this.expirypicker);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.expiryerrorlbl);
            this.leftpanel.Controls.Add(this.barcodetxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.barcodeerrorlbl);
            this.leftpanel.Controls.Add(this.productnametxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.prodnameerrorlbl);
            this.leftpanel.Size = new System.Drawing.Size(269, 678);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.prodnameerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.productnametxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.barcodeerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.barcodetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.expiryerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.expirypicker, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label7, 0);
            this.leftpanel.Controls.SetChildIndex(this.categoryDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.productDataGV);
            this.rightPanel.Size = new System.Drawing.Size(1084, 678);
            this.rightPanel.Controls.SetChildIndex(this.paneltop, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.productDataGV, 0);
            // 
            // paneltop
            // 
            this.paneltop.Size = new System.Drawing.Size(1084, 62);
            // 
            // productnametxt
            // 
            this.productnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.productnametxt.Location = new System.Drawing.Point(12, 161);
            this.productnametxt.MaxLength = 20;
            this.productnametxt.Name = "productnametxt";
            this.productnametxt.Size = new System.Drawing.Size(237, 26);
            this.productnametxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Name";
            // 
            // prodnameerrorlbl
            // 
            this.prodnameerrorlbl.AutoSize = true;
            this.prodnameerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnameerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.prodnameerrorlbl.Location = new System.Drawing.Point(215, 139);
            this.prodnameerrorlbl.Name = "prodnameerrorlbl";
            this.prodnameerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.prodnameerrorlbl.TabIndex = 14;
            this.prodnameerrorlbl.Text = "*";
            this.prodnameerrorlbl.Visible = false;
            // 
            // barcodetxt
            // 
            this.barcodetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.barcodetxt.Location = new System.Drawing.Point(12, 217);
            this.barcodetxt.MaxLength = 20;
            this.barcodetxt.Name = "barcodetxt";
            this.barcodetxt.Size = new System.Drawing.Size(237, 26);
            this.barcodetxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Barcode";
            // 
            // barcodeerrorlbl
            // 
            this.barcodeerrorlbl.AutoSize = true;
            this.barcodeerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.barcodeerrorlbl.Location = new System.Drawing.Point(215, 195);
            this.barcodeerrorlbl.Name = "barcodeerrorlbl";
            this.barcodeerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.barcodeerrorlbl.TabIndex = 17;
            this.barcodeerrorlbl.Text = "*";
            this.barcodeerrorlbl.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Expiry Date";
            // 
            // expiryerrorlbl
            // 
            this.expiryerrorlbl.AutoSize = true;
            this.expiryerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.expiryerrorlbl.Location = new System.Drawing.Point(215, 254);
            this.expiryerrorlbl.Name = "expiryerrorlbl";
            this.expiryerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.expiryerrorlbl.TabIndex = 20;
            this.expiryerrorlbl.Text = "*";
            this.expiryerrorlbl.Visible = false;
            // 
            // expirypicker
            // 
            this.expirypicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.expirypicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.expirypicker.CustomFormat = "dd-MMM-yyyy";
            this.expirypicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirypicker.Location = new System.Drawing.Point(12, 276);
            this.expirypicker.Name = "expirypicker";
            this.expirypicker.Size = new System.Drawing.Size(237, 26);
            this.expirypicker.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Category";
            // 
            // categoryerrorlbl
            // 
            this.categoryerrorlbl.AutoSize = true;
            this.categoryerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.categoryerrorlbl.Location = new System.Drawing.Point(215, 308);
            this.categoryerrorlbl.Name = "categoryerrorlbl";
            this.categoryerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.categoryerrorlbl.TabIndex = 27;
            this.categoryerrorlbl.Text = "*";
            this.categoryerrorlbl.Visible = false;
            // 
            // categoryDD
            // 
            this.categoryDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.categoryDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(13, 330);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(236, 26);
            this.categoryDD.TabIndex = 28;
            // 
            // productDataGV
            // 
            this.productDataGV.AllowUserToAddRows = false;
            this.productDataGV.AllowUserToDeleteRows = false;
            this.productDataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.pronameGV,
            this.barcodeGV,
            this.expiryGV,
            this.CategoryGV,
            this.catIDGV});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.productDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGV.Location = new System.Drawing.Point(0, 120);
            this.productDataGV.Name = "productDataGV";
            this.productDataGV.ReadOnly = true;
            this.productDataGV.RowHeadersVisible = false;
            this.productDataGV.RowTemplate.Height = 24;
            this.productDataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGV.Size = new System.Drawing.Size(1084, 558);
            this.productDataGV.TabIndex = 4;
            this.productDataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGV_CellClick);
            // 
            // proIDGV
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.proIDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.proIDGV.HeaderText = "Product ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // pronameGV
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.pronameGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.pronameGV.HeaderText = "Product";
            this.pronameGV.Name = "pronameGV";
            this.pronameGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.barcodeGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.expiryGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // CategoryGV
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.CategoryGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryGV.HeaderText = "Category";
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "Cat ID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 678);
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label categoryerrorlbl;
        private System.Windows.Forms.DateTimePicker expirypicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label expiryerrorlbl;
        private System.Windows.Forms.TextBox barcodetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label barcodeerrorlbl;
        private System.Windows.Forms.TextBox productnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prodnameerrorlbl;
        private System.Windows.Forms.DataGridView productDataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
    }
}