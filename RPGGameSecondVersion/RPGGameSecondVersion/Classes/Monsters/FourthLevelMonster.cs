namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;

    class FourthLevelMonster : Monster, IMonster
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 45;
        private const int ExperienceBonusConst = 55;
        private const int PriceBonusConst = 25;
        private const int LevelConst = 4;
        private const int ScoreBonus = 75;

        public FourthLevelMonster(Image img)
            : base(HealthPointsConst, AttackPointsConst, ExperienceBonusConst, PriceBonusConst, ScoreBonus, LevelConst, img)
        {

        }
    }
}
