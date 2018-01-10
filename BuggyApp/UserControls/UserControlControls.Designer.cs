namespace BuggyMapper
{
    partial class UserControlControls
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
            this.panelCommands = new System.Windows.Forms.Panel();
            this.buttonGoRightSoft = new System.Windows.Forms.Button();
            this.buttonGoLeftSoft = new System.Windows.Forms.Button();
            this.buttonGoLeft = new System.Windows.Forms.Button();
            this.buttonGoForward = new System.Windows.Forms.Button();
            this.buttonGoStop = new System.Windows.Forms.Button();
            this.buttonGoRight = new System.Windows.Forms.Button();
            this.pictureBoxDirection = new System.Windows.Forms.PictureBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.textBoxReadFromBuggy = new System.Windows.Forms.TextBox();
            this.checkBoxReadFromBuggy = new System.Windows.Forms.CheckBox();
            this.buttonReadFront = new System.Windows.Forms.Button();
            this.buttonReadLeft = new System.Windows.Forms.Button();
            this.buttonReadRight = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.textBoxGoLeftSoft = new System.Windows.Forms.TextBox();
            this.textBoxGoRightSoft = new System.Windows.Forms.TextBox();
            this.textBoxGoLeft = new System.Windows.Forms.TextBox();
            this.textBoxGoRight = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxGoForward = new System.Windows.Forms.TextBox();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirection)).BeginInit();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.textBoxGoRight);
            this.panelCommands.Controls.Add(this.textBoxGoLeft);
            this.panelCommands.Controls.Add(this.textBoxGoRightSoft);
            this.panelCommands.Controls.Add(this.textBoxGoLeftSoft);
            this.panelCommands.Controls.Add(this.buttonGoRightSoft);
            this.panelCommands.Controls.Add(this.buttonGoLeftSoft);
            this.panelCommands.Controls.Add(this.buttonGoLeft);
            this.panelCommands.Controls.Add(this.buttonGoForward);
            this.panelCommands.Controls.Add(this.buttonGoStop);
            this.panelCommands.Controls.Add(this.buttonGoRight);
            this.panelCommands.Location = new System.Drawing.Point(12, 77);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(237, 198);
            this.panelCommands.TabIndex = 4;
            // 
            // buttonGoRightSoft
            // 
            this.buttonGoRightSoft.Location = new System.Drawing.Point(202, 81);
            this.buttonGoRightSoft.Name = "buttonGoRightSoft";
            this.buttonGoRightSoft.Size = new System.Drawing.Size(35, 20);
            this.buttonGoRightSoft.TabIndex = 5;
            this.buttonGoRightSoft.Text = "right";
            this.buttonGoRightSoft.UseVisualStyleBackColor = true;
            this.buttonGoRightSoft.Click += new System.EventHandler(this.buttonGoRightSoft_Click);
            // 
            // buttonGoLeftSoft
            // 
            this.buttonGoLeftSoft.Location = new System.Drawing.Point(0, 80);
            this.buttonGoLeftSoft.Name = "buttonGoLeftSoft";
            this.buttonGoLeftSoft.Size = new System.Drawing.Size(35, 20);
            this.buttonGoLeftSoft.TabIndex = 4;
            this.buttonGoLeftSoft.Text = "left";
            this.buttonGoLeftSoft.UseVisualStyleBackColor = true;
            this.buttonGoLeftSoft.Click += new System.EventHandler(this.buttonGoLeftSoft_Click);
            // 
            // buttonGoLeft
            // 
            this.buttonGoLeft.Image = global::BuggyApp.Properties.Resources.left;
            this.buttonGoLeft.Location = new System.Drawing.Point(0, 106);
            this.buttonGoLeft.Name = "buttonGoLeft";
            this.buttonGoLeft.Size = new System.Drawing.Size(75, 50);
            this.buttonGoLeft.TabIndex = 0;
            this.buttonGoLeft.UseVisualStyleBackColor = true;
            this.buttonGoLeft.Click += new System.EventHandler(this.buttonGoLeft_Click);
            // 
            // buttonGoForward
            // 
            this.buttonGoForward.Image = global::BuggyApp.Properties.Resources.forward;
            this.buttonGoForward.Location = new System.Drawing.Point(81, 0);
            this.buttonGoForward.Name = "buttonGoForward";
            this.buttonGoForward.Size = new System.Drawing.Size(75, 75);
            this.buttonGoForward.TabIndex = 2;
            this.buttonGoForward.UseVisualStyleBackColor = true;
            this.buttonGoForward.Click += new System.EventHandler(this.buttonGoForward_Click);
            // 
            // buttonGoStop
            // 
            this.buttonGoStop.Image = global::BuggyApp.Properties.Resources.stop;
            this.buttonGoStop.Location = new System.Drawing.Point(81, 81);
            this.buttonGoStop.Name = "buttonGoStop";
            this.buttonGoStop.Size = new System.Drawing.Size(75, 75);
            this.buttonGoStop.TabIndex = 3;
            this.buttonGoStop.UseVisualStyleBackColor = true;
            this.buttonGoStop.Click += new System.EventHandler(this.buttonGoStop_Click);
            // 
            // buttonGoRight
            // 
            this.buttonGoRight.Image = global::BuggyApp.Properties.Resources.right;
            this.buttonGoRight.Location = new System.Drawing.Point(162, 106);
            this.buttonGoRight.Name = "buttonGoRight";
            this.buttonGoRight.Size = new System.Drawing.Size(75, 50);
            this.buttonGoRight.TabIndex = 1;
            this.buttonGoRight.UseVisualStyleBackColor = true;
            this.buttonGoRight.Click += new System.EventHandler(this.buttonGoRight_Click);
            // 
            // pictureBoxDirection
            // 
            this.pictureBoxDirection.Image = global::BuggyApp.Properties.Resources.direction;
            this.pictureBoxDirection.Location = new System.Drawing.Point(106, 5);
            this.pictureBoxDirection.Name = "pictureBoxDirection";
            this.pictureBoxDirection.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDirection.TabIndex = 5;
            this.pictureBoxDirection.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.textBoxReadFromBuggy);
            this.panelMap.Controls.Add(this.checkBoxReadFromBuggy);
            this.panelMap.Location = new System.Drawing.Point(390, 409);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(400, 128);
            this.panelMap.TabIndex = 6;
            // 
            // textBoxReadFromBuggy
            // 
            this.textBoxReadFromBuggy.Location = new System.Drawing.Point(3, 26);
            this.textBoxReadFromBuggy.Multiline = true;
            this.textBoxReadFromBuggy.Name = "textBoxReadFromBuggy";
            this.textBoxReadFromBuggy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReadFromBuggy.Size = new System.Drawing.Size(394, 99);
            this.textBoxReadFromBuggy.TabIndex = 1;
            // 
            // checkBoxReadFromBuggy
            // 
            this.checkBoxReadFromBuggy.AutoSize = true;
            this.checkBoxReadFromBuggy.Location = new System.Drawing.Point(3, 3);
            this.checkBoxReadFromBuggy.Name = "checkBoxReadFromBuggy";
            this.checkBoxReadFromBuggy.Size = new System.Drawing.Size(107, 17);
            this.checkBoxReadFromBuggy.TabIndex = 0;
            this.checkBoxReadFromBuggy.Text = "Read from buggy";
            this.checkBoxReadFromBuggy.UseVisualStyleBackColor = true;
            this.checkBoxReadFromBuggy.CheckedChanged += new System.EventHandler(this.checkBoxReadFromBuggy_CheckedChanged);
            this.checkBoxReadFromBuggy.CheckStateChanged += new System.EventHandler(this.checkBoxReadFromBuggy_CheckStateChanged);
            // 
            // buttonReadFront
            // 
            this.buttonReadFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonReadFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadFront.ForeColor = System.Drawing.Color.White;
            this.buttonReadFront.Location = new System.Drawing.Point(93, 277);
            this.buttonReadFront.Name = "buttonReadFront";
            this.buttonReadFront.Size = new System.Drawing.Size(75, 35);
            this.buttonReadFront.TabIndex = 7;
            this.buttonReadFront.Text = "Read frontal sensor";
            this.buttonReadFront.UseVisualStyleBackColor = false;
            this.buttonReadFront.Click += new System.EventHandler(this.buttonReadFront_Click);
            // 
            // buttonReadLeft
            // 
            this.buttonReadLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonReadLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadLeft.ForeColor = System.Drawing.Color.White;
            this.buttonReadLeft.Location = new System.Drawing.Point(12, 315);
            this.buttonReadLeft.Name = "buttonReadLeft";
            this.buttonReadLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonReadLeft.TabIndex = 8;
            this.buttonReadLeft.Text = "Read  left";
            this.buttonReadLeft.UseVisualStyleBackColor = false;
            this.buttonReadLeft.Click += new System.EventHandler(this.buttonReadLeft_Click);
            // 
            // buttonReadRight
            // 
            this.buttonReadRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.buttonReadRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadRight.ForeColor = System.Drawing.Color.White;
            this.buttonReadRight.Location = new System.Drawing.Point(174, 315);
            this.buttonReadRight.Name = "buttonReadRight";
            this.buttonReadRight.Size = new System.Drawing.Size(75, 23);
            this.buttonReadRight.TabIndex = 9;
            this.buttonReadRight.Text = "Read  right";
            this.buttonReadRight.UseVisualStyleBackColor = false;
            this.buttonReadRight.Click += new System.EventHandler(this.buttonReadRight_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxMap.Location = new System.Drawing.Point(390, 3);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxMap.TabIndex = 10;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
            // 
            // textBoxGoLeftSoft
            // 
            this.textBoxGoLeftSoft.Location = new System.Drawing.Point(41, 80);
            this.textBoxGoLeftSoft.Name = "textBoxGoLeftSoft";
            this.textBoxGoLeftSoft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGoLeftSoft.Size = new System.Drawing.Size(34, 20);
            this.textBoxGoLeftSoft.TabIndex = 2;
            this.textBoxGoLeftSoft.Text = "150";
            // 
            // textBoxGoRightSoft
            // 
            this.textBoxGoRightSoft.Location = new System.Drawing.Point(162, 81);
            this.textBoxGoRightSoft.Name = "textBoxGoRightSoft";
            this.textBoxGoRightSoft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGoRightSoft.Size = new System.Drawing.Size(34, 20);
            this.textBoxGoRightSoft.TabIndex = 6;
            this.textBoxGoRightSoft.Text = "150";
            // 
            // textBoxGoLeft
            // 
            this.textBoxGoLeft.Location = new System.Drawing.Point(41, 162);
            this.textBoxGoLeft.Name = "textBoxGoLeft";
            this.textBoxGoLeft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGoLeft.Size = new System.Drawing.Size(34, 20);
            this.textBoxGoLeft.TabIndex = 7;
            this.textBoxGoLeft.Text = "350";
            // 
            // textBoxGoRight
            // 
            this.textBoxGoRight.Location = new System.Drawing.Point(162, 162);
            this.textBoxGoRight.Name = "textBoxGoRight";
            this.textBoxGoRight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGoRight.Size = new System.Drawing.Size(34, 20);
            this.textBoxGoRight.TabIndex = 8;
            this.textBoxGoRight.Text = "350";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(93, 412);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 75);
            this.buttonTest.TabIndex = 9;
            this.buttonTest.Text = "test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxGoForward
            // 
            this.textBoxGoForward.Location = new System.Drawing.Point(115, 58);
            this.textBoxGoForward.Name = "textBoxGoForward";
            this.textBoxGoForward.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGoForward.Size = new System.Drawing.Size(34, 20);
            this.textBoxGoForward.TabIndex = 9;
            this.textBoxGoForward.Text = "1000";
            // 
            // UserControlControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxGoForward);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.buttonReadRight);
            this.Controls.Add(this.buttonReadLeft);
            this.Controls.Add(this.buttonReadFront);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.pictureBoxDirection);
            this.Controls.Add(this.panelCommands);
            this.Name = "UserControlControls";
            this.Size = new System.Drawing.Size(810, 554);
            this.Load += new System.EventHandler(this.UserControlControls_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControlControls_Paint);
            this.panelCommands.ResumeLayout(false);
            this.panelCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirection)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoLeft;
        private System.Windows.Forms.Button buttonGoRight;
        private System.Windows.Forms.Button buttonGoForward;
        private System.Windows.Forms.Button buttonGoStop;
        private System.Windows.Forms.Panel panelCommands;
        private System.Windows.Forms.PictureBox pictureBoxDirection;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.TextBox textBoxReadFromBuggy;
        private System.Windows.Forms.CheckBox checkBoxReadFromBuggy;
        private System.Windows.Forms.Button buttonReadFront;
        private System.Windows.Forms.Button buttonReadLeft;
        private System.Windows.Forms.Button buttonReadRight;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonGoRightSoft;
        private System.Windows.Forms.Button buttonGoLeftSoft;
        private System.Windows.Forms.TextBox textBoxGoLeftSoft;
        private System.Windows.Forms.TextBox textBoxGoRightSoft;
        private System.Windows.Forms.TextBox textBoxGoRight;
        private System.Windows.Forms.TextBox textBoxGoLeft;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxGoForward;
    }
}
