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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReadRightSensor = new System.Windows.Forms.Button();
            this.buttonReadLeftSensor = new System.Windows.Forms.Button();
            this.buttonReadTopSensor = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.textBoxMapScaleFactor = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTest);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonReadRightSensor);
            this.panel1.Controls.Add(this.buttonReadLeftSensor);
            this.panel1.Controls.Add(this.buttonReadTopSensor);
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
            this.pictureBoxMap.Location = new System.Drawing.Point(192, 26);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // textBoxMapScaleFactor
            // 
            this.textBoxMapScaleFactor.Location = new System.Drawing.Point(192, 3);
            this.textBoxMapScaleFactor.Name = "textBoxMapScaleFactor";
            this.textBoxMapScaleFactor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMapScaleFactor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMapScaleFactor.TabIndex = 6;
            this.textBoxMapScaleFactor.Text = "4";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(3, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Tag = "Clear";
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(3, 29);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(105, 23);
            this.buttonTest.TabIndex = 9;
            this.buttonTest.Tag = "Test";
            this.buttonTest.Text = "Supersample";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // UserControlInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMapScaleFactor);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMap);
            this.Name = "UserControlInfo";
            this.Size = new System.Drawing.Size(810, 554);
            this.Load += new System.EventHandler(this.UserControlInfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlInfo_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReadRightSensor;
        private System.Windows.Forms.Button buttonReadLeftSensor;
        private System.Windows.Forms.Button buttonReadTopSensor;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxMapScaleFactor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTest;
    }
}
