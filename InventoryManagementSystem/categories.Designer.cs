namespace InventoryManagementSystem
{
    partial class categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.catnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catnameerrorlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isactiveDD = new System.Windows.Forms.ComboBox();
            this.isactiveerrorlbl = new System.Windows.Forms.Label();
            this.CatGridView = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1155, 58);
            // 
            // searchtxt
            // 
            this.searchtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.searchtxt.Size = new System.Drawing.Size(183, 26);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.isactiveDD);
            this.leftpanel.Controls.Add(this.label2);
            this.leftpanel.Controls.Add(this.catnametxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.catnameerrorlbl);
            this.leftpanel.Controls.Add(this.isactiveerrorlbl);
            this.leftpanel.Size = new System.Drawing.Size(269, 643);
            this.leftpanel.Controls.SetChildIndex(this.isactiveerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.catnameerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.catnametxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label2, 0);
            this.leftpanel.Controls.SetChildIndex(this.isactiveDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.CatGridView);
            this.rightPanel.Size = new System.Drawing.Size(1155, 643);
            this.rightPanel.Controls.SetChildIndex(this.paneltop, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.CatGridView, 0);
            // 
            // paneltop
            // 
            this.paneltop.Size = new System.Drawing.Size(1155, 62);
            // 
            // catnametxt
            // 
            this.catnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.catnametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.catnametxt.Location = new System.Drawing.Point(12, 369);
            this.catnametxt.MaxLength = 20;
            this.catnametxt.Name = "catnametxt";
            this.catnametxt.Size = new System.Drawing.Size(237, 26);
            this.catnametxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Category Name";
            // 
            // catnameerrorlbl
            // 
            this.catnameerrorlbl.AutoSize = true;
            this.catnameerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnameerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.catnameerrorlbl.Location = new System.Drawing.Point(131, 348);
            this.catnameerrorlbl.Name = "catnameerrorlbl";
            this.catnameerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.catnameerrorlbl.TabIndex = 17;
            this.catnameerrorlbl.Text = "*";
            this.catnameerrorlbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Is,Active";
            // 
            // isactiveDD
            // 
            this.isactiveDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.isactiveDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isactiveDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.isactiveDD.FormattingEnabled = true;
            this.isactiveDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isactiveDD.Location = new System.Drawing.Point(15, 432);
            this.isactiveDD.Name = "isactiveDD";
            this.isactiveDD.Size = new System.Drawing.Size(234, 26);
            this.isactiveDD.TabIndex = 19;
            // 
            // isactiveerrorlbl
            // 
            this.isactiveerrorlbl.AutoSize = true;
            this.isactiveerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isactiveerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.isactiveerrorlbl.Location = new System.Drawing.Point(131, 410);
            this.isactiveerrorlbl.Name = "isactiveerrorlbl";
            this.isactiveerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.isactiveerrorlbl.TabIndex = 20;
            this.isactiveerrorlbl.Text = "*";
            this.isactiveerrorlbl.Visible = false;
            // 
            // CatGridView
            // 
            this.CatGridView.AllowUserToAddRows = false;
            this.CatGridView.AllowUserToDeleteRows = false;
            this.CatGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.catnameGV,
            this.StatusGV});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.CatGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatGridView.Location = new System.Drawing.Point(0, 120);
            this.CatGridView.Name = "CatGridView";
            this.CatGridView.ReadOnly = true;
            this.CatGridView.RowHeadersVisible = false;
            this.CatGridView.RowTemplate.Height = 24;
            this.CatGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatGridView.Size = new System.Drawing.Size(1155, 523);
            this.CatGridView.TabIndex = 4;
            this.CatGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatGridView_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "Cat ID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catnameGV
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.catnameGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.catnameGV.HeaderText = "Category Name";
            this.catnameGV.Name = "catnameGV";
            this.catnameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.StatusGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 643);
            this.Name = "categories";
            this.Text = "sample21";
            this.Load += new System.EventHandler(this.sample21_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox isactiveDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label catnameerrorlbl;
        private System.Windows.Forms.Label isactiveerrorlbl;
        private System.Windows.Forms.DataGridView CatGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}