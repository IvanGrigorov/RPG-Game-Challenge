namespace RPGGameSecondVersion
{
    partial class CharecterSelector
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
            this.HeroImg_Panel = new System.Windows.Forms.Panel();
            this.Hero_PictureBox = new System.Windows.Forms.PictureBox();
            this.HeroDescription_Panel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HeroStats_Panel = new System.Windows.Forms.Panel();
            this.Specials_Info_Label = new System.Windows.Forms.Label();
            this.Health_Info_Label = new System.Windows.Forms.Label();
            this.Defence_Info_Label = new System.Windows.Forms.Label();
            this.Attack_Info_Label = new System.Windows.Forms.Label();
            this.Specials_Label = new System.Windows.Forms.Label();
            this.Health_Label = new System.Windows.Forms.Label();
            this.Defence_Label = new System.Windows.Forms.Label();
            this.Attack_Label = new System.Windows.Forms.Label();
            this.MenuOptions_Panel = new System.Windows.Forms.Panel();
            this.Save_Character_Button = new System.Windows.Forms.Button();
            this.Knight_Button = new System.Windows.Forms.RadioButton();
            this.Mage_Button = new System.Windows.Forms.RadioButton();
            this.Name_Info_Box = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.HeroImg_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hero_PictureBox)).BeginInit();
            this.HeroDescription_Panel.SuspendLayout();
            this.HeroStats_Panel.SuspendLayout();
            this.MenuOptions_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeroImg_Panel
            // 
            this.HeroImg_Panel.Controls.Add(this.Hero_PictureBox);
            this.HeroImg_Panel.Location = new System.Drawing.Point(290, 0);
            this.HeroImg_Panel.Name = "HeroImg_Panel";
            this.HeroImg_Panel.Size = new System.Drawing.Size(225, 212);
            this.HeroImg_Panel.TabIndex = 0;
            // 
            // Hero_PictureBox
            // 
            this.Hero_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Hero_PictureBox.Name = "Hero_PictureBox";
            this.Hero_PictureBox.Size = new System.Drawing.Size(225, 212);
            this.Hero_PictureBox.TabIndex = 0;
            this.Hero_PictureBox.TabStop = false;
            // 
            // HeroDescription_Panel
            // 
            this.HeroDescription_Panel.Controls.Add(this.richTextBox1);
            this.HeroDescription_Panel.Location = new System.Drawing.Point(290, 211);
            this.HeroDescription_Panel.Name = "HeroDescription_Panel";
            this.HeroDescription_Panel.Size = new System.Drawing.Size(225, 128);
            this.HeroDescription_Panel.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(18, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(195, 116);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // HeroStats_Panel
            // 
            this.HeroStats_Panel.Controls.Add(this.Specials_Info_Label);
            this.HeroStats_Panel.Controls.Add(this.Health_Info_Label);
            this.HeroStats_Panel.Controls.Add(this.Defence_Info_Label);
            this.HeroStats_Panel.Controls.Add(this.Attack_Info_Label);
            this.HeroStats_Panel.Controls.Add(this.Specials_Label);
            this.HeroStats_Panel.Controls.Add(this.Health_Label);
            this.HeroStats_Panel.Controls.Add(this.Defence_Label);
            this.HeroStats_Panel.Controls.Add(this.Attack_Label);
            this.HeroStats_Panel.Location = new System.Drawing.Point(1, 208);
            this.HeroStats_Panel.Name = "HeroStats_Panel";
            this.HeroStats_Panel.Size = new System.Drawing.Size(290, 131);
            this.HeroStats_Panel.TabIndex = 2;
            // 
            // Specials_Info_Label
            // 
            this.Specials_Info_Label.AutoSize = true;
            this.Specials_Info_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specials_Info_Label.Location = new System.Drawing.Point(111, 100);
            this.Specials_Info_Label.Name = "Specials_Info_Label";
            this.Specials_Info_Label.Size = new System.Drawing.Size(56, 20);
            this.Specials_Info_Label.TabIndex = 7;
            this.Specials_Info_Label.Text = "specials";
            // 
            // Health_Info_Label
            // 
            this.Health_Info_Label.AutoSize = true;
            this.Health_Info_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health_Info_Label.Location = new System.Drawing.Point(98, 57);
            this.Health_Info_Label.Name = "Health_Info_Label";
            this.Health_Info_Label.Size = new System.Drawing.Size(51, 20);
            this.Health_Info_Label.TabIndex = 6;
            this.Health_Info_Label.Text = "health";
            // 
            // Defence_Info_Label
            // 
            this.Defence_Info_Label.AutoSize = true;
            this.Defence_Info_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defence_Info_Label.Location = new System.Drawing.Point(234, 12);
            this.Defence_Info_Label.Name = "Defence_Info_Label";
            this.Defence_Info_Label.Size = new System.Drawing.Size(59, 20);
            this.Defence_Info_Label.TabIndex = 5;
            this.Defence_Info_Label.Text = "defence";
            // 
            // Attack_Info_Label
            // 
            this.Attack_Info_Label.AutoSize = true;
            this.Attack_Info_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack_Info_Label.Location = new System.Drawing.Point(82, 12);
            this.Attack_Info_Label.Name = "Attack_Info_Label";
            this.Attack_Info_Label.Size = new System.Drawing.Size(50, 20);
            this.Attack_Info_Label.TabIndex = 4;
            this.Attack_Info_Label.Text = "attack";
            // 
            // Specials_Label
            // 
            this.Specials_Label.AutoEllipsis = true;
            this.Specials_Label.AutoSize = true;
            this.Specials_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specials_Label.Location = new System.Drawing.Point(3, 93);
            this.Specials_Label.Name = "Specials_Label";
            this.Specials_Label.Size = new System.Drawing.Size(93, 31);
            this.Specials_Label.TabIndex = 3;
            this.Specials_Label.Text = "Specials:";
            // 
            // Health_Label
            // 
            this.Health_Label.AutoEllipsis = true;
            this.Health_Label.AutoSize = true;
            this.Health_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health_Label.Location = new System.Drawing.Point(3, 50);
            this.Health_Label.Name = "Health_Label";
            this.Health_Label.Size = new System.Drawing.Size(86, 31);
            this.Health_Label.TabIndex = 2;
            this.Health_Label.Text = "Health:";
            // 
            // Defence_Label
            // 
            this.Defence_Label.AutoSize = true;
            this.Defence_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Defence_Label.Location = new System.Drawing.Point(130, 7);
            this.Defence_Label.Name = "Defence_Label";
            this.Defence_Label.Size = new System.Drawing.Size(100, 31);
            this.Defence_Label.TabIndex = 1;
            this.Defence_Label.Text = "Defence:";
            // 
            // Attack_Label
            // 
            this.Attack_Label.AutoSize = true;
            this.Attack_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack_Label.Location = new System.Drawing.Point(3, 7);
            this.Attack_Label.Name = "Attack_Label";
            this.Attack_Label.Size = new System.Drawing.Size(86, 31);
            this.Attack_Label.TabIndex = 0;
            this.Attack_Label.Text = "Attack:";
            // 
            // MenuOptions_Panel
            // 
            this.MenuOptions_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuOptions_Panel.Controls.Add(this.Save_Character_Button);
            this.MenuOptions_Panel.Controls.Add(this.Knight_Button);
            this.MenuOptions_Panel.Controls.Add(this.Mage_Button);
            this.MenuOptions_Panel.Controls.Add(this.Name_Info_Box);
            this.MenuOptions_Panel.Controls.Add(this.Name_Label);
            this.MenuOptions_Panel.Location = new System.Drawing.Point(1, 0);
            this.MenuOptions_Panel.Name = "MenuOptions_Panel";
            this.MenuOptions_Panel.Size = new System.Drawing.Size(290, 212);
            this.MenuOptions_Panel.TabIndex = 3;
            // 
            // Save_Character_Button
            // 
            this.Save_Character_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Character_Button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Character_Button.Location = new System.Drawing.Point(86, 165);
            this.Save_Character_Button.Name = "Save_Character_Button";
            this.Save_Character_Button.Size = new System.Drawing.Size(120, 37);
            this.Save_Character_Button.TabIndex = 1;
            this.Save_Character_Button.Text = "Save Charecter ";
            this.Save_Character_Button.UseVisualStyleBackColor = true;
            this.Save_Character_Button.Click += new System.EventHandler(this.Save_Character_Button_Click);
            // 
            // Knight_Button
            // 
            this.Knight_Button.AutoSize = true;
            this.Knight_Button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knight_Button.Location = new System.Drawing.Point(141, 75);
            this.Knight_Button.Name = "Knight_Button";
            this.Knight_Button.Size = new System.Drawing.Size(110, 24);
            this.Knight_Button.TabIndex = 2;
            this.Knight_Button.TabStop = true;
            this.Knight_Button.Text = "Knight Type";
            this.Knight_Button.UseVisualStyleBackColor = true;
            // 
            // Mage_Button
            // 
            this.Mage_Button.AutoSize = true;
            this.Mage_Button.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mage_Button.Location = new System.Drawing.Point(33, 75);
            this.Mage_Button.Name = "Mage_Button";
            this.Mage_Button.Size = new System.Drawing.Size(99, 24);
            this.Mage_Button.TabIndex = 1;
            this.Mage_Button.TabStop = true;
            this.Mage_Button.Text = "Mage Type";
            this.Mage_Button.UseVisualStyleBackColor = true;
            // 
            // Name_Info_Box
            // 
            this.Name_Info_Box.Location = new System.Drawing.Point(96, 18);
            this.Name_Info_Box.Name = "Name_Info_Box";
            this.Name_Info_Box.Size = new System.Drawing.Size(140, 20);
            this.Name_Info_Box.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(7, 9);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(82, 31);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Name:";
            // 
            // CharecterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 339);
            this.Controls.Add(this.MenuOptions_Panel);
            this.Controls.Add(this.HeroStats_Panel);
            this.Controls.Add(this.HeroDescription_Panel);
            this.Controls.Add(this.HeroImg_Panel);
            this.Name = "CharecterSelector";
            this.Text = "CharecterSelector";
            this.Load += new System.EventHandler(this.CharecterSelector_Load);
            this.HeroImg_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hero_PictureBox)).EndInit();
            this.HeroDescription_Panel.ResumeLayout(false);
            this.HeroStats_Panel.ResumeLayout(false);
            this.HeroStats_Panel.PerformLayout();
            this.MenuOptions_Panel.ResumeLayout(false);
            this.MenuOptions_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeroImg_Panel;
        private System.Windows.Forms.Panel HeroDescription_Panel;
        private System.Windows.Forms.Panel HeroStats_Panel;
        private System.Windows.Forms.Panel MenuOptions_Panel;
        private System.Windows.Forms.PictureBox Hero_PictureBox;
        private System.Windows.Forms.Label Attack_Label;
        private System.Windows.Forms.Label Defence_Label;
        private System.Windows.Forms.Label Attack_Info_Label;
        private System.Windows.Forms.Label Specials_Label;
        private System.Windows.Forms.Label Health_Label;
        private System.Windows.Forms.Label Specials_Info_Label;
        private System.Windows.Forms.Label Health_Info_Label;
        private System.Windows.Forms.Label Defence_Info_Label;
        private System.Windows.Forms.Button Save_Character_Button;
        private System.Windows.Forms.RadioButton Knight_Button;
        private System.Windows.Forms.RadioButton Mage_Button;
        private System.Windows.Forms.TextBox Name_Info_Box;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}