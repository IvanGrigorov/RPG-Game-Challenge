namespace RPGGameSecondVersion.Interfaces
{
    using System;
    using System.Drawing;
    public interface IMonster
    {
        int HealthPoints { get; set; }

        int PriceBonus { get; set; }

        int AttackPoints { get; }

        int ExperienceBonus { get; }

        int Score { get; set; }

        int Level { get; }

        Image MonsterImg { get; set; }

        Image MonsterAttack { get; }

        bool IsAlive { get; set; }

        bool IsMarked { get; set; }

    }
}
