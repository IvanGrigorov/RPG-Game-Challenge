namespace RPGGameSecondVersion.UI
{
    partial class Victory
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
            this.Victory_Panel = new System.Windows.Forms.Panel();
            this.VictoryTekst_Label = new System.Windows.Forms.Label();
            this.Victory_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Victory_Panel
            // 
            this.Victory_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Victory_Panel.Controls.Add(this.VictoryTekst_Label);
            this.Victory_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Victory_Panel.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Victory_Panel.Location = new System.Drawing.Point(0, 0);
            this.Victory_Panel.Name = "Victory_Panel";
            this.Victory_Panel.Size = new System.Drawing.Size(496, 261);
            this.Victory_Panel.TabIndex = 0;
            // 
            // VictoryTekst_Label
            // 
            this.VictoryTekst_Label.AutoSize = true;
            this.VictoryTekst_Label.Location = new System.Drawing.Point(12, 59);
            this.VictoryTekst_Label.Name = "VictoryTekst_Label";
            this.VictoryTekst_Label.Size = new System.Drawing.Size(257, 57);
            this.VictoryTekst_Label.TabIndex = 0;
            this.VictoryTekst_Label.Text = "            CONGRATULATIONS !\r\n   YOU      WON       THE    GAME !  \r\nTHANK     Y" +
    "OU     FOR      PLAYING !";
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 261);
            this.Controls.Add(this.Victory_Panel);
            this.Name = "Victory";
            this.Text = "Victory";
            this.Load += new System.EventHandler(this.Victory_Load);
            this.Victory_Panel.ResumeLayout(false);
            this.Victory_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Victory_Panel;
        private System.Windows.Forms.Label VictoryTekst_Label;
    }
}