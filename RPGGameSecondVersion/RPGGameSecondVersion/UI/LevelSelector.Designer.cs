namespace RPGGameSecondVersion
{
    partial class LevelSelector
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
            this.Picture_Level1 = new System.Windows.Forms.PictureBox();
            this.Picture_Level2 = new System.Windows.Forms.PictureBox();
            this.Picture_Level3 = new System.Windows.Forms.PictureBox();
            this.Picture_Level4 = new System.Windows.Forms.PictureBox();
            this.Picture_Level5 = new System.Windows.Forms.PictureBox();
            this.PictureShop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShop)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Level1
            // 
            this.Picture_Level1.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Level1.Location = new System.Drawing.Point(308, 12);
            this.Picture_Level1.Name = "Picture_Level1";
            this.Picture_Level1.Size = new System.Drawing.Size(68, 56);
            this.Picture_Level1.TabIndex = 0;
            this.Picture_Level1.TabStop = false;
            this.Picture_Level1.Click += new System.EventHandler(this.Picture_Level1_Click);
            // 
            // Picture_Level2
            // 
            this.Picture_Level2.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Level2.Location = new System.Drawing.Point(382, 12);
            this.Picture_Level2.Name = "Picture_Level2";
            this.Picture_Level2.Size = new System.Drawing.Size(64, 56);
            this.Picture_Level2.TabIndex = 1;
            this.Picture_Level2.TabStop = false;
            this.Picture_Level2.Click += new System.EventHandler(this.Picture_Level2_Click);
            // 
            // Picture_Level3
            // 
            this.Picture_Level3.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Level3.Location = new System.Drawing.Point(382, 74);
            this.Picture_Level3.Name = "Picture_Level3";
            this.Picture_Level3.Size = new System.Drawing.Size(64, 56);
            this.Picture_Level3.TabIndex = 2;
            this.Picture_Level3.TabStop = false;
            this.Picture_Level3.Click += new System.EventHandler(this.Picture_Level3_Click);
            // 
            // Picture_Level4
            // 
            this.Picture_Level4.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Level4.Location = new System.Drawing.Point(382, 136);
            this.Picture_Level4.Name = "Picture_Level4";
            this.Picture_Level4.Size = new System.Drawing.Size(64, 56);
            this.Picture_Level4.TabIndex = 3;
            this.Picture_Level4.TabStop = false;
            this.Picture_Level4.Click += new System.EventHandler(this.Picture_Level4_Click);
            // 
            // Picture_Level5
            // 
            this.Picture_Level5.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Level5.Location = new System.Drawing.Point(382, 198);
            this.Picture_Level5.Name = "Picture_Level5";
            this.Picture_Level5.Size = new System.Drawing.Size(64, 56);
            this.Picture_Level5.TabIndex = 4;
            this.Picture_Level5.TabStop = false;
            this.Picture_Level5.Click += new System.EventHandler(this.Picture_Level5_Click);
            // 
            // PictureShop
            // 
            this.PictureShop.BackColor = System.Drawing.Color.Transparent;
            this.PictureShop.Location = new System.Drawing.Point(312, 215);
            this.PictureShop.Name = "PictureShop";
            this.PictureShop.Size = new System.Drawing.Size(64, 39);
            this.PictureShop.TabIndex = 5;
            this.PictureShop.TabStop = false;
            this.PictureShop.Click += new System.EventHandler(this.PictureShop_Click);
            // 
            // LevelSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 279);
            this.Controls.Add(this.PictureShop);
            this.Controls.Add(this.Picture_Level5);
            this.Controls.Add(this.Picture_Level4);
            this.Controls.Add(this.Picture_Level3);
            this.Controls.Add(this.Picture_Level2);
            this.Controls.Add(this.Picture_Level1);
            this.Name = "LevelSelector";
            this.Text = "LevelSelector";
            this.Load += new System.EventHandler(this.LevelSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Level5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Level1;
        private System.Windows.Forms.PictureBox Picture_Level2;
        private System.Windows.Forms.PictureBox Picture_Level3;
        private System.Windows.Forms.PictureBox Picture_Level4;
        private System.Windows.Forms.PictureBox Picture_Level5;
        private System.Windows.Forms.PictureBox PictureShop;
    }
}