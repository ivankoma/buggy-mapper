﻿namespace BuggyMapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPathfinding = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBattery = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.userControlHome1 = new BuggyMapper.UserControlHome();
            this.userControlConnect1 = new BuggyMapper.UserControlConnect();
            this.userControlControls1 = new BuggyMapper.UserControlControls();
            this.userControlInfo1 = new BuggyMapper.UserControlInfo();
            this.userControlPathfinding1 = new BuggyApp.UserControls.UserControlPathfinding();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnPathfinding);
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
            // btnPathfinding
            // 
            this.btnPathfinding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPathfinding.FlatAppearance.BorderSize = 0;
            this.btnPathfinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPathfinding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathfinding.ForeColor = System.Drawing.Color.White;
            this.btnPathfinding.Image = global::BuggyApp.Properties.Resources.zoom_icon_24;
            this.btnPathfinding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPathfinding.Location = new System.Drawing.Point(12, 395);
            this.btnPathfinding.Name = "btnPathfinding";
            this.btnPathfinding.Size = new System.Drawing.Size(195, 56);
            this.btnPathfinding.TabIndex = 6;
            this.btnPathfinding.Text = "Pathfinding";
            this.btnPathfinding.UseVisualStyleBackColor = false;
            this.btnPathfinding.Click += new System.EventHandler(this.btnPathfinding_Click);
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
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::BuggyApp.Properties.Resources.info_icon_32;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(12, 333);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(195, 56);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Demo";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnControls.FlatAppearance.BorderSize = 0;
            this.btnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.Color.White;
            this.btnControls.Image = ((System.Drawing.Image)(resources.GetObject("btnControls.Image")));
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
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
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
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
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
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBattery
            // 
            this.btnBattery.FlatAppearance.BorderSize = 0;
            this.btnBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnExit.Location = new System.Drawing.Point(772, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // userControlHome1
            // 
            this.userControlHome1.Location = new System.Drawing.Point(210, 26);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(810, 554);
            this.userControlHome1.TabIndex = 11;
            // 
            // userControlConnect1
            // 
            this.userControlConnect1.Location = new System.Drawing.Point(210, 26);
            this.userControlConnect1.Name = "userControlConnect1";
            this.userControlConnect1.Size = new System.Drawing.Size(810, 554);
            this.userControlConnect1.TabIndex = 10;
            // 
            // userControlControls1
            // 
            this.userControlControls1.Location = new System.Drawing.Point(210, 26);
            this.userControlControls1.Name = "userControlControls1";
            this.userControlControls1.Size = new System.Drawing.Size(810, 554);
            this.userControlControls1.TabIndex = 9;
            // 
            // userControlInfo1
            // 
            this.userControlInfo1.Location = new System.Drawing.Point(210, 29);
            this.userControlInfo1.Name = "userControlInfo1";
            this.userControlInfo1.Size = new System.Drawing.Size(810, 554);
            this.userControlInfo1.TabIndex = 8;
            // 
            // userControlPathfinding1
            // 
            this.userControlPathfinding1.Location = new System.Drawing.Point(210, 26);
            this.userControlPathfinding1.Name = "userControlPathfinding1";
            this.userControlPathfinding1.Size = new System.Drawing.Size(810, 554);
            this.userControlPathfinding1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 580);
            this.Controls.Add(this.userControlPathfinding1);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.userControlConnect1);
            this.Controls.Add(this.userControlControls1);
            this.Controls.Add(this.userControlInfo1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buggy Mapper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel SidePanel;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBattery;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnControls;
        private UserControlInfo userControlInfo1;
        private UserControlControls userControlControls1;
        private UserControlConnect userControlConnect1;
        private UserControlHome userControlHome1;
        private System.Windows.Forms.Button btnPathfinding;
        private BuggyApp.UserControls.UserControlPathfinding userControlPathfinding1;
    }
}

