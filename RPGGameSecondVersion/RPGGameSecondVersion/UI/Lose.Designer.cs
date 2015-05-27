namespace RPGGameSecondVersion.UI
{
    partial class Lose
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
            this.Lose_Panel = new System.Windows.Forms.Panel();
            this.LoseInfo_Label = new System.Windows.Forms.Label();
            this.Lose_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lose_Panel
            // 
            this.Lose_Panel.Controls.Add(this.LoseInfo_Label);
            this.Lose_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lose_Panel.Location = new System.Drawing.Point(0, 0);
            this.Lose_Panel.Name = "Lose_Panel";
            this.Lose_Panel.Size = new System.Drawing.Size(449, 261);
            this.Lose_Panel.TabIndex = 0;
            // 
            // LoseInfo_Label
            // 
            this.LoseInfo_Label.AutoSize = true;
            this.LoseInfo_Label.BackColor = System.Drawing.Color.Transparent;
            this.LoseInfo_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseInfo_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoseInfo_Label.Location = new System.Drawing.Point(78, 171);
            this.LoseInfo_Label.Name = "LoseInfo_Label";
            this.LoseInfo_Label.Size = new System.Drawing.Size(283, 81);
            this.LoseInfo_Label.TabIndex = 0;
            this.LoseInfo_Label.Text = "                  SORRY !\r\n               YOU LOSE !\r\nTHANK YOU FOR PLAYING !";
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.Lose_Panel);
            this.Name = "Lose";
            this.Text = "Lose";
            this.Load += new System.EventHandler(this.Lose_Load);
            this.Lose_Panel.ResumeLayout(false);
            this.Lose_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Lose_Panel;
        private System.Windows.Forms.Label LoseInfo_Label;
    }
}