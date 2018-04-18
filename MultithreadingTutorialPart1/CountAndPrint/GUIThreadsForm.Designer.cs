namespace CountAndPrint
{
    partial class GUIThreadsForm
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
            this.thread1Label = new System.Windows.Forms.Label();
            this.thread2Label = new System.Windows.Forms.Label();
            this.thread3Label = new System.Windows.Forms.Label();
            this.thread1CheckBox = new System.Windows.Forms.CheckBox();
            this.thread2CheckBox = new System.Windows.Forms.CheckBox();
            this.thread3CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // thread1Label
            // 
            this.thread1Label.Location = new System.Drawing.Point(150, 50);
            this.thread1Label.Name = "thread1Label";
            this.thread1Label.Size = new System.Drawing.Size(100, 25);
            this.thread1Label.TabIndex = 0;
            // 
            // thread2Label
            // 
            this.thread2Label.Location = new System.Drawing.Point(150, 100);
            this.thread2Label.Name = "thread2Label";
            this.thread2Label.Size = new System.Drawing.Size(100, 25);
            this.thread2Label.TabIndex = 1;
            // 
            // thread3Label
            // 
            this.thread3Label.Location = new System.Drawing.Point(150, 150);
            this.thread3Label.Name = "thread3Label";
            this.thread3Label.Size = new System.Drawing.Size(100, 25);
            this.thread3Label.TabIndex = 2;
            // 
            // thread1CheckBox
            // 
            this.thread1CheckBox.AutoSize = true;
            this.thread1CheckBox.Location = new System.Drawing.Point(75, 50);
            this.thread1CheckBox.Name = "thread1CheckBox";
            this.thread1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.thread1CheckBox.TabIndex = 3;
            this.thread1CheckBox.UseVisualStyleBackColor = true;
            this.thread1CheckBox.CheckedChanged += new System.EventHandler(this.threadCheckBox_CheckedChanged);
            // 
            // thread2CheckBox
            // 
            this.thread2CheckBox.AutoSize = true;
            this.thread2CheckBox.Location = new System.Drawing.Point(75, 100);
            this.thread2CheckBox.Name = "thread2CheckBox";
            this.thread2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.thread2CheckBox.TabIndex = 4;
            this.thread2CheckBox.UseVisualStyleBackColor = true;
            this.thread2CheckBox.CheckedChanged += new System.EventHandler(this.threadCheckBox_CheckedChanged);
            // 
            // thread3CheckBox
            // 
            this.thread3CheckBox.AutoSize = true;
            this.thread3CheckBox.Location = new System.Drawing.Point(75, 150);
            this.thread3CheckBox.Name = "thread3CheckBox";
            this.thread3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.thread3CheckBox.TabIndex = 5;
            this.thread3CheckBox.UseVisualStyleBackColor = true;
            this.thread3CheckBox.CheckedChanged += new System.EventHandler(this.threadCheckBox_CheckedChanged);
            // 
            // GUIThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.thread3CheckBox);
            this.Controls.Add(this.thread2CheckBox);
            this.Controls.Add(this.thread1CheckBox);
            this.Controls.Add(this.thread3Label);
            this.Controls.Add(this.thread2Label);
            this.Controls.Add(this.thread1Label);
            this.Name = "GUIThreadsForm";
            this.Text = "Count And Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIThreadsForm_FormClosing);
            this.Load += new System.EventHandler(this.GUIThreadsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thread1Label;
        private System.Windows.Forms.Label thread2Label;
        private System.Windows.Forms.Label thread3Label;
        private System.Windows.Forms.CheckBox thread1CheckBox;
        private System.Windows.Forms.CheckBox thread2CheckBox;
        private System.Windows.Forms.CheckBox thread3CheckBox;
    }
}

