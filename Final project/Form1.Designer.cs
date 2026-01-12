namespace Final_project
{
    partial class Form1
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
            this.giveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keepButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giveButton
            // 
            this.giveButton.Location = new System.Drawing.Point(489, 300);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(99, 48);
            this.giveButton.TabIndex = 0;
            this.giveButton.Text = "Give";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.giveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final_project.Properties.Resources.ThroneRoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 357);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // keepButton
            // 
            this.keepButton.Location = new System.Drawing.Point(70, 300);
            this.keepButton.Name = "keepButton";
            this.keepButton.Size = new System.Drawing.Size(104, 48);
            this.keepButton.TabIndex = 2;
            this.keepButton.Text = "Keep";
            this.keepButton.UseVisualStyleBackColor = true;
            this.keepButton.Click += new System.EventHandler(this.keepButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(302, 208);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(35, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_project.Properties.Resources.ThroneRoom;
            this.ClientSize = new System.Drawing.Size(640, 355);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.keepButton);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button keepButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

