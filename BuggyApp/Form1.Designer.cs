namespace BuggyApp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBattery = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.userControlConnect1 = new BuggyApp.UserControlConnect();
            this.userControlHome1 = new BuggyApp.UserControlHome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnControls);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 580);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 144);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 55);
            this.SidePanel.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::BuggyApp.Properties.Resources.info_icon_24;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(12, 333);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(195, 56);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnControls.FlatAppearance.BorderSize = 0;
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControls.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.Color.White;
            this.btnControls.Image = global::BuggyApp.Properties.Resources.track_icon_24;
            this.btnControls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControls.Location = new System.Drawing.Point(12, 278);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(195, 56);
            this.btnControls.TabIndex = 2;
            this.btnControls.Text = "Controls";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.btnControls_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Image = global::BuggyApp.Properties.Resources.wireless_signal_icon_24;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(12, 216);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(195, 56);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::BuggyApp.Properties.Resources._3x3_grid_icon_24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 143);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(195, 56);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnBattery);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 28);
            this.panel2.TabIndex = 1;
            // 
            // btnBattery
            // 
            this.btnBattery.FlatAppearance.BorderSize = 0;
            this.btnBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattery.Image = global::BuggyApp.Properties.Resources.battery_icon_16;
            this.btnBattery.Location = new System.Drawing.Point(705, 3);
            this.btnBattery.Name = "btnBattery";
            this.btnBattery.Size = new System.Drawing.Size(20, 20);
            this.btnBattery.TabIndex = 4;
            this.btnBattery.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::BuggyApp.Properties.Resources.cog_icon_16___Copy;
            this.btnSettings.Location = new System.Drawing.Point(737, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(20, 20);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::BuggyApp.Properties.Resources.on_off_icon_16;
            this.btnExit.Location = new System.Drawing.Point(772, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userControlConnect1
            // 
            this.userControlConnect1.Location = new System.Drawing.Point(213, 58);
            this.userControlConnect1.Name = "userControlConnect1";
            this.userControlConnect1.Size = new System.Drawing.Size(810, 550);
            this.userControlConnect1.TabIndex = 3;
            this.userControlConnect1.Load += new System.EventHandler(this.userControlConnect1_Load);
            // 
            // userControlHome1
            // 
            this.userControlHome1.Location = new System.Drawing.Point(226, 58);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(810, 554);
            this.userControlHome1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.userControlConnect1);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBattery;
        private System.Windows.Forms.Panel SidePanel;
        private UserControlHome userControlHome1;
        private UserControlConnect userControlConnect1;
    }
}

