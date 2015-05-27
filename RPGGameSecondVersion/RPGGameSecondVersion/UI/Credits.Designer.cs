namespace RPGGameSecondVersion.UI
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.Credits_Panel = new System.Windows.Forms.Panel();
            this.CreditsInfo_Label = new System.Windows.Forms.Label();
            this.Credits_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Credits_Panel
            // 
            this.Credits_Panel.Controls.Add(this.CreditsInfo_Label);
            this.Credits_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Credits_Panel.Location = new System.Drawing.Point(0, 0);
            this.Credits_Panel.Name = "Credits_Panel";
            this.Credits_Panel.Size = new System.Drawing.Size(455, 261);
            this.Credits_Panel.TabIndex = 0;
            // 
            // CreditsInfo_Label
            // 
            this.CreditsInfo_Label.AutoSize = true;
            this.CreditsInfo_Label.BackColor = System.Drawing.Color.Transparent;
            this.CreditsInfo_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsInfo_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreditsInfo_Label.Location = new System.Drawing.Point(3, 116);
            this.CreditsInfo_Label.Name = "CreditsInfo_Label";
            this.CreditsInfo_Label.Size = new System.Drawing.Size(388, 136);
            this.CreditsInfo_Label.TabIndex = 0;
            this.CreditsInfo_Label.Text = resources.GetString("CreditsInfo_Label.Text");
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 261);
            this.Controls.Add(this.Credits_Panel);
            this.Name = "Credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.Credits_Panel.ResumeLayout(false);
            this.Credits_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Credits_Panel;
        private System.Windows.Forms.Label CreditsInfo_Label;
    }
}