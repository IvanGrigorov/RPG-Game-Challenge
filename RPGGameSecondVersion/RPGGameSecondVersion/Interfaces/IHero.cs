namespace RPGGameSecondVersion.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using RPGGameSecondVersion.Enums;
    public interface IHero
    {
        string Name { get; set; }
        int HealthPoints { get; set; }

        int AttackPoints { get; set; }

        int DefencePoints { get; set; }

        int Level { get; set; }

        int Score { get; set; }

        int Gold { get; set; }

        int Experience { get; set; }

        int Mana { get; set; }

        Image HeroImg { get; }

        Image AttackImg { get; }

        Gender Gender { get; }

        //ICollection<ISpeciality> HeroSpecialities { get; }

        ICollection<IItem> Inventory { get; }

        //void AddSpeciality (ISpeciality speciality);

        void AddItemToInventory (IItem item);

        void AddDefence(IItem armor);

        void AddAttack(IItem armor);

        void AddHealth(IItem armor);
    }
}
