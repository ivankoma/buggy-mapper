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
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirection)).BeginInit();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.buttonGoLeft);
            this.panelCommands.Controls.Add(this.buttonGoForward);
            this.panelCommands.Controls.Add(this.buttonGoStop);
            this.panelCommands.Controls.Add(this.buttonGoRight);
            this.panelCommands.Location = new System.Drawing.Point(12, 61);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(237, 155);
            this.panelCommands.TabIndex = 4;
            // 
            // buttonGoLeft
            // 
            this.buttonGoLeft.Image = global::BuggyApp.Properties.Resources.left;
            this.buttonGoLeft.Location = new System.Drawing.Point(0, 81);
            this.buttonGoLeft.Name = "buttonGoLeft";
            this.buttonGoLeft.Size = new System.Drawing.Size(75, 75);
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
            this.buttonGoRight.Location = new System.Drawing.Point(162, 81);
            this.buttonGoRight.Name = "buttonGoRight";
            this.buttonGoRight.Size = new System.Drawing.Size(75, 75);
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
            this.buttonReadFront.Location = new System.Drawing.Point(93, 223);
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
            this.buttonReadLeft.Location = new System.Drawing.Point(12, 261);
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
            this.buttonReadRight.Location = new System.Drawing.Point(174, 261);
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
            // UserControlControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDirection)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);

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
    }
}
