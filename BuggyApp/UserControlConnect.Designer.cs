namespace BuggyApp
{
    partial class UserControlConnect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(286, 317);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 195);
            this.listBox1.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxPassword.Location = new System.Drawing.Point(286, 257);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(246, 29);
            this.tbxPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Coral;
            this.lbPassword.Location = new System.Drawing.Point(371, 233);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 21);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Coral;
            this.btnConnect.Location = new System.Drawing.Point(286, 126);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(238, 34);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Coral;
            this.btnDisconnect.Location = new System.Drawing.Point(286, 182);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(238, 34);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Coral;
            this.btnSearch.Location = new System.Drawing.Point(286, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(238, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UserControlConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxPassword);
            this.Name = "UserControlConnect";
            this.Size = new System.Drawing.Size(810, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
    }
}
