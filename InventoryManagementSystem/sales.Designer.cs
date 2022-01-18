namespace InventoryManagementSystem
{
    partial class sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodetxt = new System.Windows.Forms.TextBox();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.grosslbl = new System.Windows.Forms.Label();
            this.paybtn = new System.Windows.Forms.Button();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.checkoutbtn = new System.Windows.Forms.Button();
            this.changetogivetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amountgiventxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totaldiscounttxt = new System.Windows.Forms.TextBox();
            this.grosstxt = new System.Windows.Forms.TextBox();
            this.paymentDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUniPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1208, 58);
            // 
            // searchtxt
            // 
            this.searchtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.searchtxt.Size = new System.Drawing.Size(191, 26);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.groupPay);
            this.leftpanel.Controls.Add(this.panel5);
            this.leftpanel.Size = new System.Drawing.Size(269, 711);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel5, 0);
            this.leftpanel.Controls.SetChildIndex(this.groupPay, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Controls.Add(this.DataGV);
            this.rightPanel.Size = new System.Drawing.Size(1208, 711);
            this.rightPanel.Controls.SetChildIndex(this.paneltop, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.DataGV, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // paneltop
            // 
            this.paneltop.Size = new System.Drawing.Size(1208, 62);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(269, 120);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Barcode";
            // 
            // barcodetxt
            // 
            this.barcodetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.barcodetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.barcodetxt.Location = new System.Drawing.Point(12, 60);
            this.barcodetxt.MaxLength = 100;
            this.barcodetxt.Name = "barcodetxt";
            this.barcodetxt.Size = new System.Drawing.Size(246, 26);
            this.barcodetxt.TabIndex = 0;
            this.barcodetxt.TextChanged += new System.EventHandler(this.barcodetxt_TextChanged);
            this.barcodetxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodetxt_Validating);
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.pronameGV,
            this.quantityGV,
            this.perUniPriceGV,
            this.discountGV,
            this.totalamountGV,
            this.deleteGV});
            this.DataGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGV.GridColor = System.Drawing.Color.Bisque;
            this.DataGV.Location = new System.Drawing.Point(0, 120);
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.RowHeadersVisible = false;
            this.DataGV.RowTemplate.Height = 24;
            this.DataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGV.Size = new System.Drawing.Size(1208, 542);
            this.DataGV.TabIndex = 6;
            this.DataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.9073F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.0927F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grosslbl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 662);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1208, 49);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(850, 49);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gross Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grosslbl
            // 
            this.grosslbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grosslbl.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.grosslbl.Location = new System.Drawing.Point(859, 0);
            this.grosslbl.Name = "grosslbl";
            this.grosslbl.Size = new System.Drawing.Size(346, 49);
            this.grosslbl.TabIndex = 24;
            this.grosslbl.Text = "0.00";
            this.grosslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paybtn
            // 
            this.paybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paybtn.FlatAppearance.BorderSize = 2;
            this.paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paybtn.Location = new System.Drawing.Point(12, 417);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(246, 58);
            this.paybtn.TabIndex = 4;
            this.paybtn.Text = "&PAY";
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // groupPay
            // 
            this.groupPay.Controls.Add(this.checkoutbtn);
            this.groupPay.Controls.Add(this.changetogivetxt);
            this.groupPay.Controls.Add(this.label8);
            this.groupPay.Controls.Add(this.amountgiventxt);
            this.groupPay.Controls.Add(this.label6);
            this.groupPay.Controls.Add(this.totaldiscounttxt);
            this.groupPay.Controls.Add(this.grosstxt);
            this.groupPay.Controls.Add(this.paymentDD);
            this.groupPay.Controls.Add(this.label5);
            this.groupPay.Controls.Add(this.label4);
            this.groupPay.Controls.Add(this.label3);
            this.groupPay.Controls.Add(this.paybtn);
            this.groupPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPay.ForeColor = System.Drawing.Color.White;
            this.groupPay.Location = new System.Drawing.Point(0, 217);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(269, 494);
            this.groupPay.TabIndex = 5;
            this.groupPay.TabStop = false;
            this.groupPay.Text = " ";
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbtn.FlatAppearance.BorderSize = 2;
            this.checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutbtn.Location = new System.Drawing.Point(12, 345);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(246, 66);
            this.checkoutbtn.TabIndex = 15;
            this.checkoutbtn.Text = "&CHECKOUT";
            this.checkoutbtn.UseVisualStyleBackColor = true;
            this.checkoutbtn.Click += new System.EventHandler(this.checkoutbtn_Click);
            // 
            // changetogivetxt
            // 
            this.changetogivetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.changetogivetxt.Enabled = false;
            this.changetogivetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.changetogivetxt.Location = new System.Drawing.Point(12, 313);
            this.changetogivetxt.MaxLength = 100;
            this.changetogivetxt.Name = "changetogivetxt";
            this.changetogivetxt.Size = new System.Drawing.Size(246, 26);
            this.changetogivetxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Change To Give";
            // 
            // amountgiventxt
            // 
            this.amountgiventxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.amountgiventxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.amountgiventxt.Location = new System.Drawing.Point(12, 250);
            this.amountgiventxt.MaxLength = 100;
            this.amountgiventxt.Name = "amountgiventxt";
            this.amountgiventxt.Size = new System.Drawing.Size(246, 26);
            this.amountgiventxt.TabIndex = 3;
            this.amountgiventxt.TextChanged += new System.EventHandler(this.amountgiventxt_TextChanged);
            this.amountgiventxt.Validating += new System.ComponentModel.CancelEventHandler(this.amountgiventxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount Given";
            // 
            // totaldiscounttxt
            // 
            this.totaldiscounttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.totaldiscounttxt.Enabled = false;
            this.totaldiscounttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.totaldiscounttxt.Location = new System.Drawing.Point(12, 128);
            this.totaldiscounttxt.MaxLength = 100;
            this.totaldiscounttxt.Name = "totaldiscounttxt";
            this.totaldiscounttxt.Size = new System.Drawing.Size(246, 26);
            this.totaldiscounttxt.TabIndex = 10;
            this.totaldiscounttxt.TextChanged += new System.EventHandler(this.totaldiscounttxt_TextChanged);
            // 
            // grosstxt
            // 
            this.grosstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.grosstxt.Enabled = false;
            this.grosstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.grosstxt.Location = new System.Drawing.Point(12, 70);
            this.grosstxt.MaxLength = 100;
            this.grosstxt.Name = "grosstxt";
            this.grosstxt.Size = new System.Drawing.Size(246, 26);
            this.grosstxt.TabIndex = 9;
            this.grosstxt.TextChanged += new System.EventHandler(this.grosstxt_TextChanged);
            // 
            // paymentDD
            // 
            this.paymentDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.paymentDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.paymentDD.FormattingEnabled = true;
            this.paymentDD.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.paymentDD.Location = new System.Drawing.Point(12, 189);
            this.paymentDD.Name = "paymentDD";
            this.paymentDD.Size = new System.Drawing.Size(246, 26);
            this.paymentDD.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gross Total";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 61);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.barcodetxt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 97);
            this.panel5.TabIndex = 6;
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "Product ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // pronameGV
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.pronameGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.pronameGV.HeaderText = "Product";
            this.pronameGV.Name = "pronameGV";
            this.pronameGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.quantityGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // perUniPriceGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.perUniPriceGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.perUniPriceGV.HeaderText = "Per Unit Price";
            this.perUniPriceGV.Name = "perUniPriceGV";
            this.perUniPriceGV.ReadOnly = true;
            // 
            // discountGV
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.discountGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.discountGV.HeaderText = "Discount";
            this.discountGV.Name = "discountGV";
            this.discountGV.ReadOnly = true;
            // 
            // totalamountGV
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.totalamountGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalamountGV.HeaderText = "Total Amount";
            this.totalamountGV.Name = "totalamountGV";
            this.totalamountGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.deleteGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "EnterBarcode";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 711);
            this.Name = "sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.leftpanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPay.ResumeLayout(false);
            this.groupPay.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox barcodetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label grosslbl;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupPay;
        private System.Windows.Forms.Button checkoutbtn;
        private System.Windows.Forms.TextBox changetogivetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amountgiventxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totaldiscounttxt;
        private System.Windows.Forms.TextBox grosstxt;
        private System.Windows.Forms.ComboBox paymentDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUniPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}