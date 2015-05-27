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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
            this.Credits_Panel.BackgroundImage = Image.FromFile("Credits.jpg");
            this.Credits_Panel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Credits_Load(object sender, EventArgs e)
        {

        }
    }
}
