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
    using System.Media;

    using RPGGameSecondVersion.Interfaces;
    public partial class MonsterAttack : Form
    {
        //SoundPlayer fireBreathingDragon;
        public MonsterAttack(IMonster monster)
        {
            InitializeComponent();
            this.monsterAnimation_Picturebox.Image = monster.MonsterAttack;
            this.monsterAnimation_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer closeTimer = new Timer();
            closeTimer.Interval = 3400;
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

        private void MonsterAttack_Load(object sender, EventArgs e)
        {

        }
    }
}
