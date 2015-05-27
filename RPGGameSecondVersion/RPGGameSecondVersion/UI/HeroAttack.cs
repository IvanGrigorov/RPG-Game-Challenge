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
    public partial class HeroAttack : Form
    {
        public HeroAttack(IHero hero)
        {
            InitializeComponent();
            this.heroAnimation_Picturebox.Image = hero.AttackImg;
            this.heroAnimation_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer closeTimer = new Timer();
            closeTimer.Interval = 3500;
            closeTimer.Tick += closeTimer_Tick;
            closeTimer.Start();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        void closeTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeroAttack_Load(object sender, EventArgs e)
        {

        }
    }
}
