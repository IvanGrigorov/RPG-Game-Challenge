namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    class HeroMage : Hero, IHero
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 55;
        private const int DefencePointsConst = 10;
        private const int StartLevel = 1;
        private const int StartScore = 0;
        private const int StartExp = 0;
        

        public HeroMage(Image img)
            : base(HealthPointsConst, AttackPointsConst, DefencePointsConst, StartLevel, StartScore, StartExp, img, Image.FromFile("MageAttack3.gif"))
        {

        }
    }
}
