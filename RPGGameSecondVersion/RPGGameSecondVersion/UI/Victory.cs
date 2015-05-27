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
    public partial class Victory : Form
    {
        public Victory()
        {
            InitializeComponent();
            this.Victory_Panel.BackgroundImage = Image.FromFile("Victory.jpg");
            this.Victory_Panel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Victory_Load(object sender, EventArgs e)
        {

        }
    }
}
