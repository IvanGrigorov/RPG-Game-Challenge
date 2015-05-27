namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;

    class FifthLevelMonster : Monster, IMonster
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 55;
        private const int ExperienceBonusConst = 70;
        private const int PriceBonusConst = 30;
        private const int LevelConst = 5;
        private const int ScoreBonus = 100;

        public FifthLevelMonster(Image img)
            : base(HealthPointsConst, AttackPointsConst, ExperienceBonusConst, PriceBonusConst, ScoreBonus, LevelConst, img)
        {

        }
    }
}
