namespace RPGGameSecondVersion.Classes.Abstract
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;

    class Monster : IMonster
    {
        private Image monsterImg;
        private int healthPoints;

        public Monster(int hP, int aP, int expBonus, int priceBonus, int score, int level, Image img)
        {
            this.HealthPoints = hP;
            this.AttackPoints = aP;
            this.ExperienceBonus = expBonus;
            this.PriceBonus = priceBonus;
            this.Score = score;
            this.Level = level;
            this.MonsterImg = img;
            this.IsAlive = true;
            this.IsMarked = false;
            this.MonsterAttack = Image.FromFile("DragonAttack2.gif");
        }

        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                if (value < 0)
                {
                    this.healthPoints = 0;
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }

        public int AttackPoints { get; protected set; }

        public int ExperienceBonus { get; protected set; }

        public int Level { get; protected set; }

        public int Score { get; set; }
        
        public Image MonsterImg
        {
            get { return this.monsterImg; }
            set  { this.monsterImg = value; }
        }
        public Image MonsterAttack { get; set; }

        public int PriceBonus { get; set; }
        
        public bool IsAlive { get; set; }

        public bool IsMarked { get; set; }

    }
}
