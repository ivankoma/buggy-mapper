namespace BuggyApp.UserControls
{
    partial class UserControlPathfinding
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
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.buttonGenerateMap = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGenerateSafeAreas = new System.Windows.Forms.Button();
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.checkBoxDiagonal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Location = new System.Drawing.Point(6, 94);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            this.pictureBoxMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseMove);
            // 
            // buttonGenerateMap
            // 
            this.buttonGenerateMap.Location = new System.Drawing.Point(6, 36);
            this.buttonGenerateMap.Name = "buttonGenerateMap";
            this.buttonGenerateMap.Size = new System.Drawing.Size(90, 23);
            this.buttonGenerateMap.TabIndex = 1;
            this.buttonGenerateMap.Text = "Generate map";
            this.buttonGenerateMap.UseVisualStyleBackColor = true;
            this.buttonGenerateMap.Click += new System.EventHandler(this.buttonGenerateMap_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 65);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonGenerateSafeAreas
            // 
            this.buttonGenerateSafeAreas.Location = new System.Drawing.Point(102, 36);
            this.buttonGenerateSafeAreas.Name = "buttonGenerateSafeAreas";
            this.buttonGenerateSafeAreas.Size = new System.Drawing.Size(90, 52);
            this.buttonGenerateSafeAreas.TabIndex = 5;
            this.buttonGenerateSafeAreas.Text = "Generate safe areas";
            this.buttonGenerateSafeAreas.UseVisualStyleBackColor = true;
            this.buttonGenerateSafeAreas.Click += new System.EventHandler(this.buttonGenerateSafeAreas_Click);
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(198, 36);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(90, 52);
            this.buttonFindPath.TabIndex = 6;
            this.buttonFindPath.Text = "Find path";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            this.buttonFindPath.Click += new System.EventHandler(this.buttonFindPath_Click);
            // 
            // checkBoxDiagonal
            // 
            this.checkBoxDiagonal.AutoSize = true;
            this.checkBoxDiagonal.Location = new System.Drawing.Point(102, 12);
            this.checkBoxDiagonal.Name = "checkBoxDiagonal";
            this.checkBoxDiagonal.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDiagonal.TabIndex = 7;
            this.checkBoxDiagonal.Text = "Diagonal";
            this.checkBoxDiagonal.UseVisualStyleBackColor = true;
            this.checkBoxDiagonal.CheckedChanged += new System.EventHandler(this.checkBoxDiagonal_CheckedChanged);
            // 
            // UserControlPathfinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxDiagonal);
            this.Controls.Add(this.buttonFindPath);
            this.Controls.Add(this.buttonGenerateSafeAreas);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerateMap);
            this.Controls.Add(this.pictureBoxMap);
            this.Name = "UserControlPathfinding";
            this.Size = new System.Drawing.Size(810, 554);
            this.Load += new System.EventHandler(this.UserControlPathfinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonGenerateMap;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGenerateSafeAreas;
        private System.Windows.Forms.Button buttonFindPath;
        private System.Windows.Forms.CheckBox checkBoxDiagonal;
    }
}
