namespace RPGGameSecondVersion.Classes.Abstract
{
    using System;
    using System.Drawing;
    using System.Collections.Generic;
    using System.Linq;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Enums;

    public abstract class Hero : IHero
    {
        private Image heroImg;
        //private ICollection<ISpeciality> heroSpecialities;
        private ICollection<IItem> inventory;
        private const int StartUpGold = 0;
        private const int StartUpMana = 100;
        private int healthpoints;
        private int mana;

        public Hero(int hP, int aP, int dP, int level, int score, int exp, Image img, Image attackImg)
        {
            this.HealthPoints = hP;
            this.AttackPoints = aP;
            this.DefencePoints = dP;
            this.Level = level;
            this.Score = score;
            this.Experience = exp;
            this.HeroImg = img;
            this.AttackImg = attackImg;
            this.Gold = StartUpGold;
            this.Mana = StartUpMana;
            //this.heroSpecialities = new List<ISpeciality>();
            this.inventory = new List<IItem>();
        }
        public string Name { get; set; }

        public int HealthPoints 
        { 
            get { return this.healthpoints; }
            set
            {
                if (value > 100)
                {
                    this.healthpoints = 100;
                }
                else if (value < 0)
                {
                    this.healthpoints = 0;
                }
                else
                {
                    this.healthpoints = value;
                } 
            }
        }

        public int AttackPoints { get; set; }

        public int DefencePoints { get; set; }

        public int Level { get; set; }

        public int Score { get; set; }

        public int Gold { get; set; }

        public int Mana
        {
            get { return this.mana; }
            set
            {
                if (value > 100)
                {
                    this.mana = 100;
                }
                else
                {
                    this.mana = value;
                }
            }
        }

        public Gender Gender { get; set; }
       
        public Image HeroImg
        {
            get { return this.heroImg; }
            private set  { this.heroImg = value; }
        }

        public Image AttackImg { get; set; }
       

        public int Experience { get; set; }

        //public ICollection<ISpeciality> HeroSpecialities
        //{
        //    get { return this.heroSpecialities; }
        //}

        //public void AddSpeciality(ISpeciality speciality)
        //{
        //    this.heroSpecialities.Add(speciality);
        //}

        public ICollection<IItem> Inventory
        {
            get { return this.inventory; }
        }
        

        public void AddItemToInventory(IItem item)
        {
            // TODO: Implement the replace functionality
            if (this.Inventory.Any(heroItem => heroItem.Type == item.Type))
            {
                this.Inventory.Remove(this.Inventory.First(heroItem => heroItem.Type == item.Type));
            }
            this.inventory.Add(item);
            this.Gold -= item.Price;
        }
        public void AddDefence(IItem armor)
        {
            this.DefencePoints += armor.ExtraDefence;
        }
        public void AddAttack(IItem weapon)
        {
            this.AttackPoints += weapon.ExtraDamage;
        }
        public void AddHealth(IItem healthPotion)
        {
            this.HealthPoints += healthPotion.ExtraHealth;
        }
    }
}
