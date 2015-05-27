namespace RPGGameSecondVersion
{
    partial class MonsterAttack
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
            this.monsterAttack_Panel = new System.Windows.Forms.Panel();
            this.monsterAnimation_Picturebox = new System.Windows.Forms.PictureBox();
            this.monsterAttack_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monsterAnimation_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // monsterAttack_Panel
            // 
            this.monsterAttack_Panel.Controls.Add(this.monsterAnimation_Picturebox);
            this.monsterAttack_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monsterAttack_Panel.Location = new System.Drawing.Point(0, 0);
            this.monsterAttack_Panel.Name = "monsterAttack_Panel";
            this.monsterAttack_Panel.Size = new System.Drawing.Size(476, 226);
            this.monsterAttack_Panel.TabIndex = 0;
            // 
            // monsterAnimation_Picturebox
            // 
            this.monsterAnimation_Picturebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monsterAnimation_Picturebox.Location = new System.Drawing.Point(0, 0);
            this.monsterAnimation_Picturebox.Name = "monsterAnimation_Picturebox";
            this.monsterAnimation_Picturebox.Size = new System.Drawing.Size(476, 226);
            this.monsterAnimation_Picturebox.TabIndex = 0;
            this.monsterAnimation_Picturebox.TabStop = false;
            // 
            // MonsterAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 226);
            this.Controls.Add(this.monsterAttack_Panel);
            this.Name = "MonsterAttack";
            this.Text = "MonsterAttack";
            this.Load += new System.EventHandler(this.MonsterAttack_Load);
            this.monsterAttack_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monsterAnimation_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel monsterAttack_Panel;
        private System.Windows.Forms.PictureBox monsterAnimation_Picturebox;
    }
}