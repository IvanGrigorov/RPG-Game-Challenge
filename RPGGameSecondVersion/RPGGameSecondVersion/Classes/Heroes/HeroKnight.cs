namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;

    public class HeroKnight : Hero, IHero
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 45;
        private const int DefencePointsConst = 15;
        private const int StartLevel = 1;
        private const int StartScore = 0;
        private const int StartExp = 0;

        public HeroKnight(Image img)
            : base(HealthPointsConst, AttackPointsConst, DefencePointsConst, StartLevel, StartScore, StartExp, img, Image.FromFile("KnightAttack.gif"))
        {

        }
    }
}
