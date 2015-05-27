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
    using System.Data.SqlClient;
    using System.Configuration;

    using RPGGameSecondVersion.UI;
    public partial class MainMenu : Form
    {
        private SoundPlayer player = new SoundPlayer();
        private bool soundOnOrOff;
       
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackgroundImage = Image.FromFile("GameBackground.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            player.SoundLocation = "Hobbit_Soundtrack.wav";
            player.PlayLooping();
            this.SoundIndexer = true;
            this.soundIdentificator_PictureBox.Image = Image.FromFile("sound-On.png");
            this.soundIdentificator_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public bool SoundIndexer
        {
            get { return this.soundOnOrOff; }
            private set { this.soundOnOrOff = value; }
        }

        private void CreateCharacter_Button_Click(object sender, EventArgs e)
        {
            Form characterSelector = new CharecterSelector();
            characterSelector.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Scores_Button_Click(object sender, EventArgs e)
        {
            DataTable topResults = new DataTable();
            SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ToString());
            dbCon.Open();
            StringBuilder results = new StringBuilder();
            results.AppendLine("Name \t Scores");
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 10 PlayerName, Score FROM Scores ORDER BY Score DESC, PlayerName ASC", dbCon);
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["PlayerName"];
                        int score = (int)reader["Score"];
                        results.AppendLine(name + "   " + score);
                    }
                }
            }
            dbCon.Close();
            dbCon.Dispose();
            MessageBox.Show(results.ToString().TrimEnd());
        }

        private void Credits_Button_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
        }

        private void soundIdentificator_PictureBox_Click(object sender, EventArgs e)
        {
            this.SoundIndexer = !SoundIndexer;
            if (this.SoundIndexer) 
            {
                player.PlayLooping();
                this.soundIdentificator_PictureBox.Image = Image.FromFile("sound-On.png");
                this.soundIdentificator_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Refresh();
            }
            else 
            {
                player.Stop();
                this.soundIdentificator_PictureBox.Image = Image.FromFile("Sound - Off.png");
                this.soundIdentificator_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Refresh();
            }
        }
    }
}
