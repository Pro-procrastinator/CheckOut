namespace InventoryManagementSystem
{
    partial class settings
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
            this.servertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databasetxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.Label();
            this.usertext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.securitycheck = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.loginbtn);
            this.leftpanel.Controls.Add(this.securitycheck);
            this.leftpanel.Controls.Add(this.usertext);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.databasetxt);
            this.leftpanel.Controls.Add(this.passtxt);
            this.leftpanel.Controls.Add(this.passwordtxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.servertxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Size = new System.Drawing.Size(269, 711);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.servertxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.databasetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.usertext, 0);
            this.leftpanel.Controls.SetChildIndex(this.securitycheck, 0);
            this.leftpanel.Controls.SetChildIndex(this.loginbtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(934, 711);
            // 
            // paneltop
            // 
            this.paneltop.Size = new System.Drawing.Size(934, 62);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // servertxt
            // 
            this.servertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.servertxt.Location = new System.Drawing.Point(12, 267);
            this.servertxt.MaxLength = 40;
            this.servertxt.Name = "servertxt";
            this.servertxt.Size = new System.Drawing.Size(233, 27);
            this.servertxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.passwordtxt.Location = new System.Drawing.Point(12, 458);
            this.passwordtxt.MaxLength = 40;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(233, 27);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // databasetxt
            // 
            this.databasetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.databasetxt.Location = new System.Drawing.Point(12, 331);
            this.databasetxt.MaxLength = 40;
            this.databasetxt.Name = "databasetxt";
            this.databasetxt.Size = new System.Drawing.Size(233, 27);
            this.databasetxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.AutoSize = true;
            this.passtxt.Location = new System.Drawing.Point(12, 434);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(76, 19);
            this.passtxt.TabIndex = 5;
            this.passtxt.Text = "Password";
            // 
            // usertext
            // 
            this.usertext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.usertext.Location = new System.Drawing.Point(12, 395);
            this.usertext.MaxLength = 40;
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(233, 27);
            this.usertext.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Database";
            // 
            // securitycheck
            // 
            this.securitycheck.AutoSize = true;
            this.securitycheck.Location = new System.Drawing.Point(12, 492);
            this.securitycheck.Name = "securitycheck";
            this.securitycheck.Size = new System.Drawing.Size(173, 23);
            this.securitycheck.TabIndex = 5;
            this.securitycheck.Text = "Integerated Security";
            this.securitycheck.UseVisualStyleBackColor = true;
            this.securitycheck.CheckedChanged += new System.EventHandler(this.securitycheck_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.FlatAppearance.BorderSize = 2;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(12, 522);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(233, 37);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Save";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 711);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox databasetxt;
        private System.Windows.Forms.Label passtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servertxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.CheckBox securitycheck;
    }
}