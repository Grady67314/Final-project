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
            this.keepButton = new System.Windows.Forms.Button();
            this.statLabel = new System.Windows.Forms.Label();
            this.ganonPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ganonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giveButton
            // 
            this.giveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveButton.Location = new System.Drawing.Point(455, 259);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(93, 42);
            this.giveButton.TabIndex = 0;
            this.giveButton.Text = "Give";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.giveButton_Click);
            // 
            // keepButton
            // 
            this.keepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepButton.Location = new System.Drawing.Point(75, 256);
            this.keepButton.Name = "keepButton";
            this.keepButton.Size = new System.Drawing.Size(90, 45);
            this.keepButton.TabIndex = 2;
            this.keepButton.Text = "Keep";
            this.keepButton.UseVisualStyleBackColor = true;
            this.keepButton.Click += new System.EventHandler(this.keepButton_Click);
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.BackColor = System.Drawing.Color.Transparent;
            this.statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statLabel.Location = new System.Drawing.Point(287, 48);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(80, 32);
            this.statLabel.TabIndex = 4;
            this.statLabel.Text = "Gold: 1000\r\nMorality: 0";
            // 
            // ganonPictureBox
            // 
            this.ganonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ganonPictureBox.Image = global::Final_project.Properties.Resources.chracter3_evil_;
            this.ganonPictureBox.Location = new System.Drawing.Point(246, 200);
            this.ganonPictureBox.Name = "ganonPictureBox";
            this.ganonPictureBox.Size = new System.Drawing.Size(150, 140);
            this.ganonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ganonPictureBox.TabIndex = 5;
            this.ganonPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Final_project.Properties.Resources.Zelda;
            this.pictureBox1.Location = new System.Drawing.Point(402, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_project.Properties.Resources.ThroneRoom;
            this.ClientSize = new System.Drawing.Size(638, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ganonPictureBox);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.keepButton);
            this.Controls.Add(this.giveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ganonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveButton;
        private System.Windows.Forms.Button keepButton;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.PictureBox ganonPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

