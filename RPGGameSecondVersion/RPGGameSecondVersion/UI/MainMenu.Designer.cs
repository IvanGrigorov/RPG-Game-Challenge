namespace RPGGameSecondVersion
{
    partial class MainMenu
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
            this.CreateCharacter_Button = new System.Windows.Forms.Button();
            this.Scores_Button = new System.Windows.Forms.Button();
            this.Credits_Button = new System.Windows.Forms.Button();
            this.soundIdentificator_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soundIdentificator_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCharacter_Button
            // 
            this.CreateCharacter_Button.BackColor = System.Drawing.SystemColors.Control;
            this.CreateCharacter_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCharacter_Button.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacter_Button.Location = new System.Drawing.Point(27, 203);
            this.CreateCharacter_Button.Name = "CreateCharacter_Button";
            this.CreateCharacter_Button.Size = new System.Drawing.Size(103, 23);
            this.CreateCharacter_Button.TabIndex = 0;
            this.CreateCharacter_Button.Text = "Create Character";
            this.CreateCharacter_Button.UseVisualStyleBackColor = false;
            this.CreateCharacter_Button.Click += new System.EventHandler(this.CreateCharacter_Button_Click);
            // 
            // Scores_Button
            // 
            this.Scores_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scores_Button.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores_Button.Location = new System.Drawing.Point(136, 203);
            this.Scores_Button.Name = "Scores_Button";
            this.Scores_Button.Size = new System.Drawing.Size(75, 23);
            this.Scores_Button.TabIndex = 1;
            this.Scores_Button.Text = "Scores";
            this.Scores_Button.UseVisualStyleBackColor = true;
            this.Scores_Button.Click += new System.EventHandler(this.Scores_Button_Click);
            // 
            // Credits_Button
            // 
            this.Credits_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Credits_Button.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits_Button.Location = new System.Drawing.Point(217, 203);
            this.Credits_Button.Name = "Credits_Button";
            this.Credits_Button.Size = new System.Drawing.Size(75, 23);
            this.Credits_Button.TabIndex = 2;
            this.Credits_Button.Text = "Credits";
            this.Credits_Button.UseVisualStyleBackColor = true;
            this.Credits_Button.Click += new System.EventHandler(this.Credits_Button_Click);
            // 
            // soundIdentificator_PictureBox
            // 
            this.soundIdentificator_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.soundIdentificator_PictureBox.Location = new System.Drawing.Point(479, 12);
            this.soundIdentificator_PictureBox.Name = "soundIdentificator_PictureBox";
            this.soundIdentificator_PictureBox.Size = new System.Drawing.Size(46, 44);
            this.soundIdentificator_PictureBox.TabIndex = 3;
            this.soundIdentificator_PictureBox.TabStop = false;
            this.soundIdentificator_PictureBox.Click += new System.EventHandler(this.soundIdentificator_PictureBox_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 270);
            this.Controls.Add(this.soundIdentificator_PictureBox);
            this.Controls.Add(this.Credits_Button);
            this.Controls.Add(this.Scores_Button);
            this.Controls.Add(this.CreateCharacter_Button);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundIdentificator_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCharacter_Button;
        private System.Windows.Forms.Button Scores_Button;
        private System.Windows.Forms.Button Credits_Button;
        private System.Windows.Forms.PictureBox soundIdentificator_PictureBox;
    }
}

