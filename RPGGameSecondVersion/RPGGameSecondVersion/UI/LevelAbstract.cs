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

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Specialities.MageSpecialities;
    using RPGGameSecondVersion.Enums;
    using RPGGameSecondVersion.Classes;
    using RPGGameSecondVersion.Control;
    using RPGGameSecondVersion.UI;
    public partial class LevelAbstract : Form
    {
        private Image enemyAtackImage = Image.FromFile("AttackIcon.png");
        private Image enemyHealthImage = Image.FromFile("HealthIcon.png");
        private Image deadMonster = Image.FromFile("DeadMonster.png");
        private ISpeciality levelTwoSpeciality = new DarkRitual();
        private ISpeciality levelThreeSpeciality = new ThunderAttack();
        private ISpeciality levelFourSpeciality = new BoltStrike();
        private IList<IMonster> collectionOfEnemies;
        private const int GoldDivider = 2;
        private Timer updateInfoTimer;
        private Timer artficialInteligence;
        private Timer manaUpdater;
        //SoundPlayer magic;

        public LevelAbstract()
        {
            InitializeComponent();
        }
        public LevelAbstract(IHero hero, IMonster monsterOne, IMonster monsterTwo, IMonster monsterThree, Image backgroundImage)
            : this()
        {
            this.EnemyOneAttackInfo_Label.Text = monsterOne.AttackPoints.ToString();
            this.EnemyTwoAttackInfo_Label.Text = monsterTwo.AttackPoints.ToString();
            this.ThirdEnemyAttackInfo_Label.Text = monsterThree.AttackPoints.ToString();
            this.EnemyOneHealthInfo_Label.Text = monsterOne.HealthPoints.ToString();
            this.EnemyTwoHealthInfo_Label.Text = monsterTwo.HealthPoints.ToString();
            this.ThirdEnemyHealthInfo_Label.Text = monsterThree.HealthPoints.ToString(); 
            this.EnemyOne_Picture.Image = monsterOne.MonsterImg;
            this.EnemyOne_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyTwo_Picture.Image = monsterTwo.MonsterImg;
            this.EnemyTwo_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyThree_Picture.Image = monsterThree.MonsterImg;
            this.EnemyThree_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Hero_Picture.Image = hero.HeroImg;
            this.Hero_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.HealthInfo_Label.Text = hero.HealthPoints.ToString();
            this.AttackInfo_Label.Text = hero.AttackPoints.ToString();
            this.Level_Info_Label.Text = hero.Level.ToString();
            this.ManaInfo_Label.Text = hero.Mana.ToString();
            this.FirstSpeciality_Picture.Image = levelTwoSpeciality.SpecialityImage;
            this.FirstSpeciality_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FirstSpeciality_Label.Text = levelTwoSpeciality.Name;
            this.SecondSpeciality_Image.Image = levelThreeSpeciality.SpecialityImage;
            this.SecondSpeciality_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            this.SecondSpeciality_Label.Text = levelThreeSpeciality.Name;
            this.ThirdSpeciality_Picture.Image = levelFourSpeciality.SpecialityImage;
            this.ThirdSpeciality_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ThirdSpeciality_Label.Text = levelFourSpeciality.Name;
            this.Armour_Picture.Image = (hero.Inventory.FirstOrDefault(armor => armor.Type == ItemType.Armor) == null) ?
                Image.FromFile("no-data.png") : hero.Inventory.First(armor => armor.Type == ItemType.Armor).ItemImage;
            this.Armour_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Armour_Label.Text = (hero.Inventory.FirstOrDefault(armor => armor.Type == ItemType.Armor) == null) ?
               "No Armor" : hero.Inventory.First(armor => armor.Type == ItemType.Armor).Name;
            this.Weapon_Picture.Image = (hero.Inventory.FirstOrDefault(weapon => weapon.Type == ItemType.Weapon) == null) ?
                Image.FromFile("no-data.png") : hero.Inventory.First(weapon => weapon.Type == ItemType.Weapon).ItemImage;
            this.Weapon_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Weapon_Label.Text = (hero.Inventory.FirstOrDefault(weapon => weapon.Type == ItemType.Weapon) == null) ?
               "No Weapon" : hero.Inventory.First(weapon => weapon.Type == ItemType.Weapon).Name;
            this.Gold_Picture.Image = Image.FromFile("gold.png");
            this.Gold_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Gold_Label.Text = hero.Gold.ToString() + " $";
            this.EnemyOneAttack_Picture.Image = enemyAtackImage;
            this.EnemyOneAttack_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyOneHealth_Picture.Image = enemyHealthImage;
            this.EnemyOneHealth_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyTwoAttack_Picture.Image = enemyAtackImage;
            this.EnemyTwoAttack_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyTwoHealth_Picture.Image = enemyHealthImage;
            this.EnemyTwoHealth_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ThirdEnemyAttack_Picture.Image = enemyAtackImage;
            this.ThirdEnemyAttack_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ThirdEnemyHealth_Picture.Image = enemyHealthImage;
            this.ThirdEnemyHealth_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.collectionOfEnemies = new List<IMonster>() { monsterOne, monsterTwo, monsterThree };
            this.Arena_Panel.BackgroundImage = backgroundImage;
            this.Arena_Panel.BackgroundImageLayout = ImageLayout.Stretch;
            updateInfoTimer = new Timer();
            updateInfoTimer.Interval = 100;
            updateInfoTimer.Tick += updateInfoTimer_Tick;
            updateInfoTimer.Start();
            artficialInteligence = new Timer();
            artficialInteligence.Interval = 4000;
            artficialInteligence.Tick += artficialInteligence_Tick;
            manaUpdater = new Timer();
            manaUpdater.Interval = 2000;
            manaUpdater.Tick += manaUpdater_Tick;
            manaUpdater.Start();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.custtomToolTip.SetToolTip(this.FirstSpeciality_Picture, levelTwoSpeciality.ToString());
            this.custtomToolTip.SetToolTip(this.SecondSpeciality_Image, levelThreeSpeciality.ToString());
            this.custtomToolTip.SetToolTip(this.ThirdSpeciality_Picture, levelFourSpeciality.ToString());
            if (hero.Inventory.Any(armor => armor.Type == ItemType.Armor))
            {
                this.custtomToolTip.SetToolTip(this.Armour_Picture, hero.Inventory.FirstOrDefault(armor => armor.Type == ItemType.Armor).PrintInfoForItem());
            }
            if (hero.Inventory.Any(weapon => weapon.Type == ItemType.Weapon))
            {
                this.custtomToolTip.SetToolTip(this.Weapon_Picture, hero.Inventory.FirstOrDefault(weapon => weapon.Type == ItemType.Weapon).PrintInfoForItem());
            }
        }

        void manaUpdater_Tick(object sender, EventArgs e)
        {
            if (CharecterSelector.Player.Mana >= 100)
            {
                manaUpdater.Stop();
            }
            CharecterSelector.Player.Mana += 1;
        }

        void artficialInteligence_Tick(object sender, EventArgs e)
        {
            CharecterSelector.Player.HealthPoints -= (this.collectionOfEnemies[0].AttackPoints - CharecterSelector.Player.DefencePoints < 0) ?
                0 : (this.collectionOfEnemies[0].AttackPoints - CharecterSelector.Player.DefencePoints);
            MonsterAttack monsterAnimation = new MonsterAttack(new FirstLevelMonster(Image.FromFile("monster.png")));
            monsterAnimation.Show();
            if (CharecterSelector.Player.HealthPoints <= 0)
            {
                UpdateScore(CharecterSelector.Player.Name, CharecterSelector.Player.Score);
                Lose lose = new Lose();
                lose.Show();
                this.Close();
                CharecterSelector.levelSelector.Close();
                
            }
            artficialInteligence.Stop();
        }

        private void updateInfoTimer_Tick(object sender, EventArgs e)
        {
            this.EnemyOneHealthInfo_Label.Text = this.collectionOfEnemies[0].HealthPoints.ToString();
            this.EnemyTwoHealthInfo_Label.Text = this.collectionOfEnemies[1].HealthPoints.ToString();
            this.ThirdEnemyHealthInfo_Label.Text = this.collectionOfEnemies[2].HealthPoints.ToString();
            this.HealthInfo_Label.Text = CharecterSelector.Player.HealthPoints.ToString();
            this.Level_Info_Label.Text = CharecterSelector.Player.Level.ToString();
            this.EnemyOne_Picture.Image = this.collectionOfEnemies[0].MonsterImg;
            this.EnemyOne_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyTwo_Picture.Image = this.collectionOfEnemies[1].MonsterImg;
            this.EnemyTwo_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.EnemyThree_Picture.Image = this.collectionOfEnemies[2].MonsterImg;
            this.EnemyThree_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Hero_Picture.Image = CharecterSelector.Player.HeroImg;
            this.Hero_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ManaInfo_Label.Text = CharecterSelector.Player.Mana.ToString();
            this.Gold_Label.Text = CharecterSelector.Player.Gold.ToString() + " $";
        }

        private void LevelAbstract_Load(object sender, EventArgs e)
        {

        }

        private void FirstSpeciality_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForNeededLevel(CharecterSelector.Player, levelTwoSpeciality) &&
                Validator.CheckForNeededMana(CharecterSelector.Player, levelTwoSpeciality))
            {
                this.InflictDamage(this.collectionOfEnemies, levelTwoSpeciality.InflictedDamage);
                CharecterSelector.Player.Mana -= levelTwoSpeciality.RequiredMana;
                manaUpdater.Start();

            }
            else
            {
                MessageBox.Show("You do not fulfill the requirements !");
            }
        }

        private void SecondSpeciality_Image_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForNeededLevel(CharecterSelector.Player, levelThreeSpeciality) &&
                Validator.CheckForNeededMana(CharecterSelector.Player, levelThreeSpeciality))
            {
                this.InflictDamage(this.collectionOfEnemies, levelThreeSpeciality.InflictedDamage);
                CharecterSelector.Player.Mana -= levelThreeSpeciality.RequiredMana;
                manaUpdater.Start();

            }
            else
            {
                MessageBox.Show("You do not fulfill the requirements !");
            }
        }

        private void ThirdSpeciality_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForNeededLevel(CharecterSelector.Player, levelFourSpeciality) &&
                Validator.CheckForNeededMana(CharecterSelector.Player, levelFourSpeciality))
            {
                this.InflictDamage(this.collectionOfEnemies, levelFourSpeciality.InflictedDamage);
                CharecterSelector.Player.Mana -= levelFourSpeciality.RequiredMana;
                manaUpdater.Start();

            }
            else
            {
                MessageBox.Show("You do not fulfill the requirements !");
            }
        }

        private void Attack_Button_Click(object sender, EventArgs e)
        {
            this.InflictDamage(this.collectionOfEnemies, CharecterSelector.Player.AttackPoints);
        }

        private void Retreat_Button_Click(object sender, EventArgs e)
        {
            CharecterSelector.Player.Gold -= CharecterSelector.Player.Gold / GoldDivider;
            this.Refresh();
            MessageBox.Show("You have retreated and lost \n half of your gold !");
            this.Close();
            CharecterSelector.levelSelector.WindowState = FormWindowState.Normal;
        }

        private void EnemyOne_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForMarkedTarget(this.collectionOfEnemies))
            {
                MessageBox.Show("You have already selected a target !");
            }
            else
            {
                this.collectionOfEnemies[0].IsMarked = true;
            }
        }

        private void EnemyTwo_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForMarkedTarget(this.collectionOfEnemies))
            {
                MessageBox.Show("You have already selected a target !");
            }
            else
            {
                this.collectionOfEnemies[1].IsMarked = true;
            }
        }

        private void EnemyThree_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForMarkedTarget(this.collectionOfEnemies))
            {
                MessageBox.Show("You have already selected a target !");
            }
            else
            {
                this.collectionOfEnemies[2].IsMarked = true;
            }
        }

        private void InflictDamage(ICollection<IMonster> monsterCollection, int damage)
        {
            if (Validator.CheckForMarkedTarget(monsterCollection))
            {
                this.collectionOfEnemies.First(monster => monster.IsMarked == true).HealthPoints -= damage;
                Validator.DetermineAliveProprerty(monsterCollection.First(monster => monster.IsMarked == true));
                if (!Validator.CheckIfEnemyIsStillAlive(monsterCollection.First(monster => monster.IsMarked == true)))
                {
                    CharecterSelector.Player.Experience += monsterCollection.First(monster => monster.IsMarked == true).ExperienceBonus;
                    CharecterSelector.Player.Gold += monsterCollection.First(monster => monster.IsMarked == true).PriceBonus;
                    CharecterSelector.Player.Score += monsterCollection.First(monster => monster.IsMarked == true).Score;
                    Validator.UpdateLevelIfNeeded(CharecterSelector.Player);
                    monsterCollection.First(monster => monster.IsMarked == true).MonsterImg = deadMonster;
                    monsterCollection.First(monster => monster.IsMarked == true).IsMarked = false;
                }
                else
                {
                    monsterCollection.First(monster => monster.IsMarked == true).IsMarked = false;
                }
                if (!Validator.CheckForAliveEnemy(monsterCollection))
                {
                    if (this.collectionOfEnemies.All(monster => monster.Level == 5))
                    {
                        MessageBox.Show("Congratulations ! \n You won the game ! \n Thanks for playing ");
                        UpdateScore(CharecterSelector.Player.Name, CharecterSelector.Player.Score);
                        Victory victory = new Victory();
                        victory.Show();
                        this.Close();
                        CharecterSelector.levelSelector.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("You won the level !");
                        this.Close();
                        CharecterSelector.levelSelector.WindowState = FormWindowState.Normal;
                        
                    }
                }
                HeroAttack heroAnimation = new HeroAttack(CharecterSelector.Player);
                heroAnimation.Show();
                if (Validator.CheckForAliveEnemy(monsterCollection))
                {
                    artficialInteligence.Start();
                }
            }
            else
            {
                MessageBox.Show("You have not selected a target !");
            }
        }
        private void UpdateScore(string name, int score)
        {
            SqlConnection dbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ToString());
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand updateScore = new SqlCommand("INSERT INTO Scores (PlayerName, Score) VALUES (@name, @score)", dbCon);
                updateScore.Parameters.AddWithValue("@name", name);
                updateScore.Parameters.AddWithValue("@score", score);
                updateScore.ExecuteNonQuery();
            }
            dbCon.Close();
            dbCon.Dispose();
        }
    }
}
