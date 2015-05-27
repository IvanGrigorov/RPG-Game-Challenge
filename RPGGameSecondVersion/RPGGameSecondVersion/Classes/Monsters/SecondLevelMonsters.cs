namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;

    class SecondLevelMonster : Monster, IMonster
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 20;
        private const int ExperienceBonusConst = 30;
        private const int PriceBonusConst = 15;
        private const int LevelConst = 2;
        private const int ScoreBonus = 35;

        public SecondLevelMonster(Image img)
            : base(HealthPointsConst, AttackPointsConst, ExperienceBonusConst, PriceBonusConst, ScoreBonus, LevelConst, img)
        {

        }
    }
}
