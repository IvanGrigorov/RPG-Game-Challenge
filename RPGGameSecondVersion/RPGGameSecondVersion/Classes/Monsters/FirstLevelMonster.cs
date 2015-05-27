namespace RPGGameSecondVersion.Classes
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;

    class FirstLevelMonster : Monster, IMonster
    {
        private const int HealthPointsConst = 100;
        private const int AttackPointsConst = 15;
        private const int ExperienceBonusConst = 20;
        private const int PriceBonusConst = 10;
        private const int LevelConst = 1;
        private const int ScoreBonus = 20;

         public FirstLevelMonster(Image img)
            : base(HealthPointsConst, AttackPointsConst, ExperienceBonusConst, PriceBonusConst, ScoreBonus, LevelConst, img)
        {

        }
    }
}
