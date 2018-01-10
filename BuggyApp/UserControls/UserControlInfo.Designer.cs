namespace BuggyMapper
{
    partial class UserControlInfo
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
            this.buttonSetBuggyLocation = new System.Windows.Forms.Button();
            this.textBoxBuggyLocationY = new System.Windows.Forms.TextBox();
            this.textBoxBuggyLocationX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReadRightSensor = new System.Windows.Forms.Button();
            this.buttonReadLeftSensor = new System.Windows.Forms.Button();
            this.buttonReadBottomSensor = new System.Windows.Forms.Button();
            this.buttonReadTopSensor = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetBuggyLocation
            // 
            this.buttonSetBuggyLocation.Location = new System.Drawing.Point(3, 3);
            this.buttonSetBuggyLocation.Name = "buttonSetBuggyLocation";
            this.buttonSetBuggyLocation.Size = new System.Drawing.Size(105, 23);
            this.buttonSetBuggyLocation.TabIndex = 1;
            this.buttonSetBuggyLocation.Text = "Set buggy location";
            this.buttonSetBuggyLocation.UseVisualStyleBackColor = true;
            this.buttonSetBuggyLocation.Click += new System.EventHandler(this.buttonSetBuggyLocation_Click);
            // 
            // textBoxBuggyLocationY
            // 
            this.textBoxBuggyLocationY.Location = new System.Drawing.Point(58, 32);
            this.textBoxBuggyLocationY.Name = "textBoxBuggyLocationY";
            this.textBoxBuggyLocationY.Size = new System.Drawing.Size(50, 20);
            this.textBoxBuggyLocationY.TabIndex = 2;
            // 
            // textBoxBuggyLocationX
            // 
            this.textBoxBuggyLocationX.Location = new System.Drawing.Point(3, 32);
            this.textBoxBuggyLocationX.Name = "textBoxBuggyLocationX";
            this.textBoxBuggyLocationX.Size = new System.Drawing.Size(50, 20);
            this.textBoxBuggyLocationX.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReadRightSensor);
            this.panel1.Controls.Add(this.buttonReadLeftSensor);
            this.panel1.Controls.Add(this.buttonReadBottomSensor);
            this.panel1.Controls.Add(this.buttonReadTopSensor);
            this.panel1.Controls.Add(this.buttonSetBuggyLocation);
            this.panel1.Controls.Add(this.textBoxBuggyLocationX);
            this.panel1.Controls.Add(this.textBoxBuggyLocationY);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 176);
            this.panel1.TabIndex = 4;
            // 
            // buttonReadRightSensor
            // 
            this.buttonReadRightSensor.Location = new System.Drawing.Point(3, 87);
            this.buttonReadRightSensor.Name = "buttonReadRightSensor";
            this.buttonReadRightSensor.Size = new System.Drawing.Size(105, 23);
            this.buttonReadRightSensor.TabIndex = 7;
            this.buttonReadRightSensor.Text = "Read right sensor";
            this.buttonReadRightSensor.UseVisualStyleBackColor = true;
            this.buttonReadRightSensor.Click += new System.EventHandler(this.buttonReadRightSensor_Click);
            // 
            // buttonReadLeftSensor
            // 
            this.buttonReadLeftSensor.Location = new System.Drawing.Point(3, 145);
            this.buttonReadLeftSensor.Name = "buttonReadLeftSensor";
            this.buttonReadLeftSensor.Size = new System.Drawing.Size(105, 23);
            this.buttonReadLeftSensor.TabIndex = 6;
            this.buttonReadLeftSensor.Text = "Read left sensor";
            this.buttonReadLeftSensor.UseVisualStyleBackColor = true;
            this.buttonReadLeftSensor.Click += new System.EventHandler(this.buttonReadLeftSensor_Click);
            // 
            // buttonReadBottomSensor
            // 
            this.buttonReadBottomSensor.Location = new System.Drawing.Point(3, 116);
            this.buttonReadBottomSensor.Name = "buttonReadBottomSensor";
            this.buttonReadBottomSensor.Size = new System.Drawing.Size(105, 23);
            this.buttonReadBottomSensor.TabIndex = 5;
            this.buttonReadBottomSensor.Text = "Read bottom sensor";
            this.buttonReadBottomSensor.UseVisualStyleBackColor = true;
            this.buttonReadBottomSensor.Click += new System.EventHandler(this.buttonReadBottomSensor_Click);
            // 
            // buttonReadTopSensor
            // 
            this.buttonReadTopSensor.Location = new System.Drawing.Point(3, 58);
            this.buttonReadTopSensor.Name = "buttonReadTopSensor";
            this.buttonReadTopSensor.Size = new System.Drawing.Size(105, 23);
            this.buttonReadTopSensor.TabIndex = 4;
            this.buttonReadTopSensor.Text = "Read top sensor";
            this.buttonReadTopSensor.UseVisualStyleBackColor = true;
            this.buttonReadTopSensor.Click += new System.EventHandler(this.buttonReadTopSensor_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(6, 178);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(180, 353);
            this.textBoxLog.TabIndex = 5;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Location = new System.Drawing.Point(192, 0);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // UserControlInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMap);
            this.Name = "UserControlInfo";
            this.Size = new System.Drawing.Size(810, 554);
            this.Load += new System.EventHandler(this.UserControlInfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlInfo_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonSetBuggyLocation;
        private System.Windows.Forms.TextBox textBoxBuggyLocationY;
        private System.Windows.Forms.TextBox textBoxBuggyLocationX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReadRightSensor;
        private System.Windows.Forms.Button buttonReadLeftSensor;
        private System.Windows.Forms.Button buttonReadBottomSensor;
        private System.Windows.Forms.Button buttonReadTopSensor;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}
