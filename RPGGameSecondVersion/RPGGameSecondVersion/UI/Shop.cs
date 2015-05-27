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
    using RPGGameSecondVersion.Classes.Items.Armors;
    using RPGGameSecondVersion.Enums;
    using RPGGameSecondVersion.Control;
    

    public partial class Shop : Form
    {
        private IItem firstLevelArmor = new FirstLevelArmor();
        private IItem secondLevelArmor = new SecondLevelArmor();
        private IItem thirdLevelArmor = new ThirdLevelArmor();
        private IItem firstLevelWeapon = new FirstLevelWeapon();
        private IItem secondLevelWeapon = new SecondLevelWeapon();
        private IItem thirdLevelWeapon = new ThirdLevelWeapon();
        private IItem healthPotion = new HealthPotion();
        private const string NotEnoughGoldMessage = "Not sufficiant funds !";
        SoundPlayer playerBoughtItem = new SoundPlayer();
        public Shop()
        {
            InitializeComponent();
            this.FirstLevelArmor_Picture.Image = firstLevelArmor.ItemImage;
            this.FirstLevelArmor_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FirstArmorCost_Label.Text = firstLevelArmor.Price.ToString() + " $";
            this.FirstArmorBonus_Label.Text = "+" + firstLevelArmor.ExtraDefence.ToString() + " DP";
            this.SecondLevelArmor_Picture.Image = secondLevelArmor.ItemImage;
            this.SecondLevelArmor_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.SecondArmorCost_Label.Text = secondLevelArmor.Price.ToString() + " $";
            this.SecondArmorBonus_Label.Text = "+" + secondLevelArmor.ExtraDefence.ToString() + " DP";
            this.ThirdLevelArmor_Picture.Image = thirdLevelArmor.ItemImage;
            this.ThirdLevelArmor_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ThirdArmorCost_Label.Text = thirdLevelArmor.Price.ToString() + " $";
            this.ThirdArmorBonus_Label.Text = "+" + thirdLevelArmor.ExtraDefence.ToString() + " DP";

            this.FirstLevelWeapon_Picture.Image = firstLevelWeapon.ItemImage;
            this.FirstLevelWeapon_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FirstWeaponCost_Label.Text = firstLevelWeapon.Price.ToString() + " $";
            this.FirstWeaponBonus_Label.Text = "+" + firstLevelWeapon.ExtraDamage.ToString() + " AP";
            this.SecondLevelWeapon_Picture.Image = secondLevelWeapon.ItemImage;
            this.SecondLevelWeapon_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.SecondWeaponCost_Label.Text = secondLevelWeapon.Price.ToString() + " $";
            this.SecondWeaponBonus_Label.Text = "+" + secondLevelWeapon.ExtraDamage.ToString() + " AP";
            this.ThirdLevelWeapon_Picture.Image = thirdLevelWeapon.ItemImage;
            this.ThirdLevelWeapon_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ThirdWeaponCost_Label.Text = thirdLevelWeapon.Price.ToString() + " $";
            this.ThirdWeaponBonus_Label.Text = "+" + thirdLevelWeapon.ExtraDamage.ToString() + " AP";

            this.HealthPotion_Picture.Image = healthPotion.ItemImage;
            this.HealthPotion_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FirstPotionCost_Label.Text = healthPotion.Price.ToString() + " $";
            this.FirstPotionBonus_Label.Text = "+" + healthPotion.ExtraHealth.ToString() + " HP";

            this.YourGoldInfo_Label.Text = CharecterSelector.Player.Gold.ToString() + " $";

            this.CustomToolTip.SetToolTip(this.FirstLevelArmor_Picture, firstLevelArmor.PrintInfoForItem());
            this.CustomToolTip.SetToolTip(this.SecondLevelArmor_Picture, secondLevelArmor.PrintInfoForItem());
            this.CustomToolTip.SetToolTip(this.ThirdLevelArmor_Picture, thirdLevelArmor.PrintInfoForItem());
            this.CustomToolTip.SetToolTip(this.FirstLevelWeapon_Picture, firstLevelWeapon.PrintInfoForItem());
            this.CustomToolTip.SetToolTip(this.SecondLevelWeapon_Picture, secondLevelWeapon.PrintInfoForItem());
            this.CustomToolTip.SetToolTip(this.ThirdLevelWeapon_Picture, thirdLevelWeapon.PrintInfoForItem());
            this.CustomToolTip.SetToolTip(this.HealthPotion_Picture, healthPotion.PrintInfoForItem());

            Timer updateCashInfo = new Timer();
            updateCashInfo.Interval = 100;
            updateCashInfo.Tick += updateCashInfo_Tick;
            updateCashInfo.Start();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.BackgroundImage = Image.FromFile("blacksmith.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        void updateCashInfo_Tick(object sender, EventArgs e)
        {
            this.YourGoldInfo_Label.Text = CharecterSelector.Player.Gold.ToString() + " $";
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void FirstLevelArmor_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, firstLevelArmor))
            {
                CharecterSelector.Player.AddItemToInventory(firstLevelArmor);
                CharecterSelector.Player.AddDefence(firstLevelArmor);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }

        private void SecondLevelArmor_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, secondLevelArmor))
            {
                CharecterSelector.Player.AddItemToInventory(secondLevelArmor);
                CharecterSelector.Player.AddDefence(secondLevelArmor);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }

        private void ThirdLevelArmor_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, thirdLevelArmor))
            {
                CharecterSelector.Player.AddItemToInventory(thirdLevelArmor);
                CharecterSelector.Player.AddDefence(thirdLevelArmor);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }

        private void FirstLevelWeapon_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, firstLevelWeapon))
            {
                CharecterSelector.Player.AddItemToInventory(firstLevelWeapon);
                CharecterSelector.Player.AddAttack(firstLevelWeapon);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }

        private void SecondLevelWeapon_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, secondLevelWeapon))
            {
                CharecterSelector.Player.AddItemToInventory(secondLevelWeapon);
                CharecterSelector.Player.AddAttack(secondLevelWeapon);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }

        private void ThirdLevelWeapon_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, thirdLevelWeapon))
            {
                CharecterSelector.Player.AddItemToInventory(thirdLevelWeapon);
                CharecterSelector.Player.AddAttack(thirdLevelWeapon);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }

        private void HealthPotion_Picture_Click(object sender, EventArgs e)
        {
            if (Validator.CheckForEnaughMoney(CharecterSelector.Player, healthPotion))
            {
                CharecterSelector.Player.AddItemToInventory(healthPotion);
                CharecterSelector.Player.AddHealth(healthPotion);
            }
            else
            {
                MessageBox.Show(NotEnoughGoldMessage);
            }
        }


    }
}
