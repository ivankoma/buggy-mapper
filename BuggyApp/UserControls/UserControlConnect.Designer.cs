namespace BuggyMapper
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
            this.btnConnectToWiFi = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelConnectedToBuggy = new System.Windows.Forms.Label();
            this.panelWiFiBuggyAP = new System.Windows.Forms.Panel();
            this.panelWiFi = new System.Windows.Forms.Panel();
            this.buttonFindBuggy = new System.Windows.Forms.Button();
            this.buttonConnectToBuggy = new System.Windows.Forms.Button();
            this.labelBuggyIP = new System.Windows.Forms.Label();
            this.textBoxBuggyIP = new System.Windows.Forms.TextBox();
            this.panelWiFiBuggyAP.SuspendLayout();
            this.panelWiFi.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(75, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 299);
            this.listBox1.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.Info;
            this.tbxPassword.Location = new System.Drawing.Point(75, 123);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(200, 19);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lbPassword.Location = new System.Drawing.Point(144, 104);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(68, 16);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // btnConnectToWiFi
            // 
            this.btnConnectToWiFi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConnectToWiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectToWiFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectToWiFi.ForeColor = System.Drawing.Color.Coral;
            this.btnConnectToWiFi.Location = new System.Drawing.Point(75, 66);
            this.btnConnectToWiFi.Name = "btnConnectToWiFi";
            this.btnConnectToWiFi.Size = new System.Drawing.Size(200, 35);
            this.btnConnectToWiFi.TabIndex = 7;
            this.btnConnectToWiFi.Text = "Connect";
            this.btnConnectToWiFi.UseVisualStyleBackColor = true;
            this.btnConnectToWiFi.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Coral;
            this.btnDisconnect.Location = new System.Drawing.Point(75, 148);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(200, 35);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Coral;
            this.btnSearch.Location = new System.Drawing.Point(75, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelConnectedToBuggy
            // 
            this.labelConnectedToBuggy.AutoSize = true;
            this.labelConnectedToBuggy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectedToBuggy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConnectedToBuggy.Location = new System.Drawing.Point(291, 523);
            this.labelConnectedToBuggy.Name = "labelConnectedToBuggy";
            this.labelConnectedToBuggy.Size = new System.Drawing.Size(230, 31);
            this.labelConnectedToBuggy.TabIndex = 9;
            this.labelConnectedToBuggy.Text = "Buggy connection";
            // 
            // panelWiFiBuggyAP
            // 
            this.panelWiFiBuggyAP.Controls.Add(this.tbxPassword);
            this.panelWiFiBuggyAP.Controls.Add(this.btnSearch);
            this.panelWiFiBuggyAP.Controls.Add(this.btnDisconnect);
            this.panelWiFiBuggyAP.Controls.Add(this.lbPassword);
            this.panelWiFiBuggyAP.Controls.Add(this.listBox1);
            this.panelWiFiBuggyAP.Controls.Add(this.btnConnectToWiFi);
            this.panelWiFiBuggyAP.Location = new System.Drawing.Point(10, 10);
            this.panelWiFiBuggyAP.Name = "panelWiFiBuggyAP";
            this.panelWiFiBuggyAP.Size = new System.Drawing.Size(350, 530);
            this.panelWiFiBuggyAP.TabIndex = 11;
            // 
            // panelWiFi
            // 
            this.panelWiFi.Controls.Add(this.buttonFindBuggy);
            this.panelWiFi.Controls.Add(this.buttonConnectToBuggy);
            this.panelWiFi.Controls.Add(this.labelBuggyIP);
            this.panelWiFi.Controls.Add(this.textBoxBuggyIP);
            this.panelWiFi.Location = new System.Drawing.Point(445, 10);
            this.panelWiFi.Name = "panelWiFi";
            this.panelWiFi.Size = new System.Drawing.Size(350, 530);
            this.panelWiFi.TabIndex = 12;
            // 
            // buttonFindBuggy
            // 
            this.buttonFindBuggy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFindBuggy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindBuggy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindBuggy.ForeColor = System.Drawing.Color.Coral;
            this.buttonFindBuggy.Location = new System.Drawing.Point(75, 66);
            this.buttonFindBuggy.Name = "buttonFindBuggy";
            this.buttonFindBuggy.Size = new System.Drawing.Size(200, 35);
            this.buttonFindBuggy.TabIndex = 10;
            this.buttonFindBuggy.Text = "Find Buggy\'s IP";
            this.buttonFindBuggy.UseVisualStyleBackColor = true;
            this.buttonFindBuggy.Click += new System.EventHandler(this.buttonFindBuggy_Click);
            // 
            // buttonConnectToBuggy
            // 
            this.buttonConnectToBuggy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonConnectToBuggy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectToBuggy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectToBuggy.ForeColor = System.Drawing.Color.Coral;
            this.buttonConnectToBuggy.Location = new System.Drawing.Point(75, 104);
            this.buttonConnectToBuggy.Name = "buttonConnectToBuggy";
            this.buttonConnectToBuggy.Size = new System.Drawing.Size(200, 35);
            this.buttonConnectToBuggy.TabIndex = 9;
            this.buttonConnectToBuggy.Text = "Connect";
            this.buttonConnectToBuggy.UseVisualStyleBackColor = true;
            this.buttonConnectToBuggy.Click += new System.EventHandler(this.buttonConnectToBuggy_Click);
            // 
            // labelBuggyIP
            // 
            this.labelBuggyIP.AutoSize = true;
            this.labelBuggyIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuggyIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelBuggyIP.Location = new System.Drawing.Point(72, 35);
            this.labelBuggyIP.Name = "labelBuggyIP";
            this.labelBuggyIP.Size = new System.Drawing.Size(20, 16);
            this.labelBuggyIP.TabIndex = 9;
            this.labelBuggyIP.Text = "IP";
            // 
            // textBoxBuggyIP
            // 
            this.textBoxBuggyIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBoxBuggyIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuggyIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuggyIP.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxBuggyIP.Location = new System.Drawing.Point(98, 35);
            this.textBoxBuggyIP.Name = "textBoxBuggyIP";
            this.textBoxBuggyIP.Size = new System.Drawing.Size(177, 19);
            this.textBoxBuggyIP.TabIndex = 9;
            this.textBoxBuggyIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserControlConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelConnectedToBuggy);
            this.Controls.Add(this.panelWiFi);
            this.Controls.Add(this.panelWiFiBuggyAP);
            this.Name = "UserControlConnect";
            this.Size = new System.Drawing.Size(810, 554);
            this.Load += new System.EventHandler(this.UserControlConnect_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlConnect_Paint);
            this.panelWiFiBuggyAP.ResumeLayout(false);
            this.panelWiFiBuggyAP.PerformLayout();
            this.panelWiFi.ResumeLayout(false);
            this.panelWiFi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnConnectToWiFi;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label labelConnectedToBuggy;
        private System.Windows.Forms.Panel panelWiFiBuggyAP;
        private System.Windows.Forms.Panel panelWiFi;
        private System.Windows.Forms.Label labelBuggyIP;
        private System.Windows.Forms.TextBox textBoxBuggyIP;
        private System.Windows.Forms.Button buttonConnectToBuggy;
        private System.Windows.Forms.Button buttonFindBuggy;
    }
}
