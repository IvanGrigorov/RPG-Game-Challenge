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

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes;
    public partial class LevelSelector : Form
    {
        Image monsterImage = Image.FromFile("monster.png");
        public LevelSelector()
        {
            InitializeComponent();
            this.Picture_Level1.Image = Image.FromFile("badge_1.png");
            this.Picture_Level1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture_Level2.Image = Image.FromFile("badge_2.png");
            this.Picture_Level2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture_Level3.Image = Image.FromFile("badge_3.png");
            this.Picture_Level3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture_Level4.Image = Image.FromFile("badge_4.png");
            this.Picture_Level4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture_Level5.Image = Image.FromFile("badge_5.png");
            this.Picture_Level5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureShop.Image = Image.FromFile("Blacksmith.png");
            this.PictureShop.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.BackgroundImage = Image.FromFile("LevelSelector.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        
        private void LevelSelector_Load(object sender, EventArgs e)
        {
            
        }

        private void Picture_Level1_Click(object sender, EventArgs e)
        {
            LevelAbstract firstLevel = new LevelAbstract(CharecterSelector.Player, new FirstLevelMonster(monsterImage),
                new FirstLevelMonster(monsterImage), new FirstLevelMonster(monsterImage), Image.FromFile("FirstLevelBackground.jpg"));
            firstLevel.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Picture_Level2_Click(object sender, EventArgs e)
        {
            LevelAbstract secondLevel = new LevelAbstract(CharecterSelector.Player, new SecondLevelMonster(monsterImage),
                new SecondLevelMonster(monsterImage), new SecondLevelMonster(monsterImage), Image.FromFile("SecondLevelBackground.jpg"));
            secondLevel.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Picture_Level3_Click(object sender, EventArgs e)
        {
            LevelAbstract thirdLevel = new LevelAbstract(CharecterSelector.Player, new ThirdLevelMonster(monsterImage),
                new ThirdLevelMonster(monsterImage), new ThirdLevelMonster(monsterImage), Image.FromFile("ThirdLevelBackground.jpg"));
            thirdLevel.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Picture_Level4_Click(object sender, EventArgs e)
        {
            LevelAbstract fourthLevel = new LevelAbstract(CharecterSelector.Player, new FourthLevelMonster(monsterImage),
                new FourthLevelMonster(monsterImage), new FourthLevelMonster(monsterImage), Image.FromFile("FourthLevelBackground.jpg"));
            fourthLevel.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Picture_Level5_Click(object sender, EventArgs e)
        {
            LevelAbstract fifthLevel = new LevelAbstract(CharecterSelector.Player, new FifthLevelMonster(monsterImage),
                new FifthLevelMonster(monsterImage), new FifthLevelMonster(monsterImage), Image.FromFile("FifthLevelBackground.jpg"));
            fifthLevel.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureShop_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
        }

    }
}
