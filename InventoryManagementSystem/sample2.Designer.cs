namespace InventoryManagementSystem
{
    partial class sample2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.savebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftpanel.Size = new System.Drawing.Size(269, 683);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel2);
            this.rightPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightPanel.Size = new System.Drawing.Size(1189, 683);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.Controls.SetChildIndex(this.paneltop, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // paneltop
            // 
            this.paneltop.Size = new System.Drawing.Size(1189, 62);
            // 
            // usernamelbl
            // 
            this.usernamelbl.Size = new System.Drawing.Size(355, 62);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.SetChildIndex(this.backbtn, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1189, 58);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.savebtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addbtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.viewbtn, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dltbtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.editbtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1189, 58);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.savebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.savebtn.FlatAppearance.BorderSize = 2;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.savebtn.Image = global::InventoryManagementSystem.Properties.Resources.save_30px;
            this.savebtn.Location = new System.Drawing.Point(201, 3);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(192, 52);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_1);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.addbtn.Image = global::InventoryManagementSystem.Properties.Resources.add_30px2;
            this.addbtn.Location = new System.Drawing.Point(3, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(192, 52);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_2);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.viewbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.viewbtn.FlatAppearance.BorderSize = 2;
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.viewbtn.Image = global::InventoryManagementSystem.Properties.Resources.view_30px1;
            this.viewbtn.Location = new System.Drawing.Point(795, 3);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(192, 52);
            this.viewbtn.TabIndex = 4;
            this.viewbtn.Text = "View";
            this.viewbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click_1);
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.dltbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dltbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.dltbtn.FlatAppearance.BorderSize = 2;
            this.dltbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dltbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.dltbtn.Image = global::InventoryManagementSystem.Properties.Resources.delete_bin_30px;
            this.dltbtn.Location = new System.Drawing.Point(597, 3);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(192, 52);
            this.dltbtn.TabIndex = 3;
            this.dltbtn.Text = "Delete";
            this.dltbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click_1);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.editbtn.FlatAppearance.BorderSize = 2;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.editbtn.Image = global::InventoryManagementSystem.Properties.Resources.edit_property_30px;
            this.editbtn.Location = new System.Drawing.Point(399, 3);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(192, 52);
            this.editbtn.TabIndex = 1;
            this.editbtn.Text = "Edit";
            this.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchtxt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(993, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 52);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.White;
            this.searchtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchtxt.Location = new System.Drawing.Point(3, 22);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(187, 26);
            this.searchtxt.TabIndex = 0;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged_1);
            // 
            // backbtn
            // 
            this.backbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::InventoryManagementSystem.Properties.Resources.back_to_50px2;
            this.backbtn.Location = new System.Drawing.Point(0, 0);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(79, 62);
            this.backbtn.TabIndex = 1;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 683);
            this.Name = "sample2";
            this.leftpanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backbtn;
      //  private System.Windows.Forms.Panel panel11;
        //public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        //private System.Windows.Forms.Button dbtn;
        //private System.Windows.Forms.Button sbt;
        //private System.Windows.Forms.Button ebtn;
        //private System.Windows.Forms.Button abtn;
       // private System.Windows.Forms.Button vbtn;
        //public System.Windows.Forms.GroupBox groupBox1;
        //protected System.Windows.Forms.TextBox stxt;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.Button addbtn;
        public System.Windows.Forms.Button viewbtn;
        public System.Windows.Forms.Button dltbtn;
        public System.Windows.Forms.Button editbtn;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox searchtxt;
    }
}