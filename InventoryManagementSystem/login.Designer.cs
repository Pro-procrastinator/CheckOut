namespace InventoryManagementSystem
{
    partial class login
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
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.usernamerrorlbl = new System.Windows.Forms.Label();
            this.passerrorlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.loginbtn);
            this.leftpanel.Controls.Add(this.passtxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.usernametxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.usernamerrorlbl);
            this.leftpanel.Controls.Add(this.passerrorlbl);
            this.leftpanel.Size = new System.Drawing.Size(269, 624);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.passerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.usernamerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.usernametxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.passtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.loginbtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(835, 624);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.label2);
            this.paneltop.Size = new System.Drawing.Size(835, 62);
            this.paneltop.Controls.SetChildIndex(this.usernamelbl, 0);
            this.paneltop.Controls.SetChildIndex(this.label2, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.usernametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.usernametxt.Location = new System.Drawing.Point(15, 351);
            this.usernametxt.MaxLength = 30;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(233, 27);
            this.usernametxt.TabIndex = 2;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.passtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.passtxt.Location = new System.Drawing.Point(15, 404);
            this.passtxt.MaxLength = 30;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(233, 27);
            this.passtxt.TabIndex = 4;
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(15, 437);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(233, 43);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // usernamerrorlbl
            // 
            this.usernamerrorlbl.AutoSize = true;
            this.usernamerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.usernamerrorlbl.Location = new System.Drawing.Point(98, 330);
            this.usernamerrorlbl.Name = "usernamerrorlbl";
            this.usernamerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.usernamerrorlbl.TabIndex = 12;
            this.usernamerrorlbl.Text = "*";
            this.usernamerrorlbl.Visible = false;
            // 
            // passerrorlbl
            // 
            this.passerrorlbl.AutoSize = true;
            this.passerrorlbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passerrorlbl.ForeColor = System.Drawing.Color.Red;
            this.passerrorlbl.Location = new System.Drawing.Point(97, 383);
            this.passerrorlbl.Name = "passerrorlbl";
            this.passerrorlbl.Size = new System.Drawing.Size(27, 30);
            this.passerrorlbl.TabIndex = 13;
            this.passerrorlbl.Text = "*";
            this.passerrorlbl.Visible = false;
            this.passerrorlbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(366, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome To CheckOut";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 624);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label passerrorlbl;
        private System.Windows.Forms.Label usernamerrorlbl;
        private System.Windows.Forms.Label label2;
    }
}