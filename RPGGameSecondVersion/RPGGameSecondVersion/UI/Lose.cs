using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameSecondVersion.UI
{
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
            this.Lose_Panel.BackgroundImage = Image.FromFile("LoseWallpaper.jpg");
            this.Lose_Panel.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("Your score is successfully updated !");
        }

        private void Lose_Load(object sender, EventArgs e)
        {

        }
    }
}
