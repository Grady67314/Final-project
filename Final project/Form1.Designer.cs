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
            this.zeldaPictureBox = new System.Windows.Forms.PictureBox();
            this.linkPictureBox = new System.Windows.Forms.PictureBox();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.rockPaperScissors = new System.Windows.Forms.PictureBox();
            this.kindkingPictureBox = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ganonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeldaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPaperScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindkingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // giveButton
            // 
            this.giveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveButton.Location = new System.Drawing.Point(455, 257);
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
            this.ganonPictureBox.Visible = false;
            // 
            // zeldaPictureBox
            // 
            this.zeldaPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.zeldaPictureBox.Image = global::Final_project.Properties.Resources.Zelda;
            this.zeldaPictureBox.Location = new System.Drawing.Point(239, 187);
            this.zeldaPictureBox.Name = "zeldaPictureBox";
            this.zeldaPictureBox.Size = new System.Drawing.Size(150, 151);
            this.zeldaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zeldaPictureBox.TabIndex = 6;
            this.zeldaPictureBox.TabStop = false;
            this.zeldaPictureBox.Visible = false;
            // 
            // linkPictureBox
            // 
            this.linkPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.linkPictureBox.Image = global::Final_project.Properties.Resources.Character2;
            this.linkPictureBox.Location = new System.Drawing.Point(246, 189);
            this.linkPictureBox.Name = "linkPictureBox";
            this.linkPictureBox.Size = new System.Drawing.Size(150, 151);
            this.linkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.linkPictureBox.TabIndex = 7;
            this.linkPictureBox.TabStop = false;
            this.linkPictureBox.Visible = false;
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.characterPictureBox.Image = global::Final_project.Properties.Resources.character1;
            this.characterPictureBox.Location = new System.Drawing.Point(246, 192);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(150, 151);
            this.characterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterPictureBox.TabIndex = 8;
            this.characterPictureBox.TabStop = false;
            // 
            // rockPaperScissors
            // 
            this.rockPaperScissors.BackColor = System.Drawing.Color.Transparent;
            this.rockPaperScissors.Image = global::Final_project.Properties.Resources.Rock;
            this.rockPaperScissors.Location = new System.Drawing.Point(242, 177);
            this.rockPaperScissors.Name = "rockPaperScissors";
            this.rockPaperScissors.Size = new System.Drawing.Size(150, 161);
            this.rockPaperScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPaperScissors.TabIndex = 9;
            this.rockPaperScissors.TabStop = false;
            this.rockPaperScissors.Visible = false;
            // 
            // kindkingPictureBox
            // 
            this.kindkingPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.kindkingPictureBox.Image = global::Final_project.Properties.Resources.kindKing;
            this.kindkingPictureBox.Location = new System.Drawing.Point(246, 205);
            this.kindkingPictureBox.Name = "kindkingPictureBox";
            this.kindkingPictureBox.Size = new System.Drawing.Size(150, 138);
            this.kindkingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kindkingPictureBox.TabIndex = 11;
            this.kindkingPictureBox.TabStop = false;
            this.kindkingPictureBox.Visible = false;
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textLabel.Location = new System.Drawing.Point(395, 192);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(150, 54);
            this.textLabel.TabIndex = 12;
            this.textLabel.Text = "label1";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(455, 305);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 35);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "+10";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(75, 307);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(90, 33);
            this.subtractButton.TabIndex = 14;
            this.subtractButton.Text = "-10";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Visible = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(398, 134);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(126, 42);
            this.outputLabel.TabIndex = 15;
            this.outputLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_project.Properties.Resources.ThroneRoom;
            this.ClientSize = new System.Drawing.Size(638, 352);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.keepButton);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.kindkingPictureBox);
            this.Controls.Add(this.rockPaperScissors);
            this.Controls.Add(this.characterPictureBox);
            this.Controls.Add(this.linkPictureBox);
            this.Controls.Add(this.zeldaPictureBox);
            this.Controls.Add(this.ganonPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ganonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeldaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPaperScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindkingPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveButton;
        private System.Windows.Forms.Button keepButton;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.PictureBox ganonPictureBox;
        private System.Windows.Forms.PictureBox zeldaPictureBox;
        private System.Windows.Forms.PictureBox linkPictureBox;
        private System.Windows.Forms.PictureBox characterPictureBox;
        private System.Windows.Forms.PictureBox rockPaperScissors;
        private System.Windows.Forms.PictureBox kindkingPictureBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

