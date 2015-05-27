namespace RPGGameSecondVersion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    //using System.Timers;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes;
    using RPGGameSecondVersion.Classes.Abstract;
    public partial class CharecterSelector : Form
    {
        private IHero knight = new HeroKnight(Image.FromFile("Thorin.png"));
        private IHero mage = new HeroMage(Image.FromFile("mage.png"));
        private const int TimerIntervalConst = 100;
        private Timer updateTimer = new Timer();
        public static IHero Player;
        public static Form levelSelector;
        //private IHero player;
        public CharecterSelector()
        {
            
            InitializeComponent();
            this.richTextBox1.Text = "ijsoifhsoifhsoidfhsoih \n wqpoeipqoiepoqiepoqiw \nasfa\nuhihiu\niuyiuhiu\nuihiuh\nouoiuoiu\nghjg\ngjhg\n ";
            updateTimer.Interval = TimerIntervalConst;
            updateTimer.Start();
            updateTimer.Tick += updateTimer_Tick;
            this.Mage_Button.Checked = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
           
        }

        void updateTimer_Tick(object sender, EventArgs e)
        {
            if (this.Mage_Button.Checked)
            {
                this.Hero_PictureBox.Image = mage.HeroImg;
                this.Hero_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Health_Info_Label.Text = mage.HealthPoints.ToString();
                this.Attack_Info_Label.Text = mage.AttackPoints.ToString();
                this.Defence_Info_Label.Text = mage.DefencePoints.ToString();
            }
            else
            {
                this.Hero_PictureBox.Image = knight.HeroImg;
                this.Hero_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Health_Info_Label.Text = knight.HealthPoints.ToString();
                this.Attack_Info_Label.Text = knight.AttackPoints.ToString();
                this.Defence_Info_Label.Text = knight.DefencePoints.ToString();
            }
            updateTimer.Start();
        }

        private void CharecterSelector_Load(object sender, EventArgs e)
        {

        }

        private void Save_Character_Button_Click(object sender, EventArgs e)
        {
            if (this.Mage_Button.Checked)
            {
                Player = new HeroMage(Image.FromFile("mage.png"));
            }
            else
            {
                Player = new HeroKnight(Image.FromFile("Thorin.png"));
            }
            Player.Name = this.Name_Info_Box.Text;
            levelSelector = new LevelSelector();
            levelSelector.Show();
            this.Close();
        }




    }
}
