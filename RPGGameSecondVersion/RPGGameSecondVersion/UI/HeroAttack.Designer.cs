namespace RPGGameSecondVersion
{
    partial class HeroAttack
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
            this.HeroAttack_Panel = new System.Windows.Forms.Panel();
            this.heroAnimation_Picturebox = new System.Windows.Forms.PictureBox();
            this.HeroAttack_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroAnimation_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeroAttack_Panel
            // 
            this.HeroAttack_Panel.Controls.Add(this.heroAnimation_Picturebox);
            this.HeroAttack_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroAttack_Panel.Location = new System.Drawing.Point(0, 0);
            this.HeroAttack_Panel.Name = "HeroAttack_Panel";
            this.HeroAttack_Panel.Size = new System.Drawing.Size(425, 197);
            this.HeroAttack_Panel.TabIndex = 0;
            // 
            // heroAnimation_Picturebox
            // 
            this.heroAnimation_Picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroAnimation_Picturebox.Location = new System.Drawing.Point(0, 0);
            this.heroAnimation_Picturebox.Name = "heroAnimation_Picturebox";
            this.heroAnimation_Picturebox.Size = new System.Drawing.Size(425, 197);
            this.heroAnimation_Picturebox.TabIndex = 0;
            this.heroAnimation_Picturebox.TabStop = false;
            // 
            // HeroAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 197);
            this.Controls.Add(this.HeroAttack_Panel);
            this.Name = "HeroAttack";
            this.Text = "HeroAttack";
            this.Load += new System.EventHandler(this.HeroAttack_Load);
            this.HeroAttack_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heroAnimation_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeroAttack_Panel;
        private System.Windows.Forms.PictureBox heroAnimation_Picturebox;
    }
}