namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;

    class ThirdLevelMonster : Monster, IMonster
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 35;
        private const int ExperienceBonusConst = 40;
        private const int PriceBonusConst = 20;
        private const int LevelConst = 3;
        private const int ScoreBonus = 50;

        public ThirdLevelMonster(Image img)
            : base(HealthPointsConst, AttackPointsConst, ExperienceBonusConst, PriceBonusConst, ScoreBonus, LevelConst, img)
        {

        }
    }
}
