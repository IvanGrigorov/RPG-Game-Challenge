namespace RPGGameSecondVersion.Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Items.Armors;
    using RPGGameSecondVersion.Enums;
    
    class Validator
    {
        public static bool CheckForEnaughMoney(IHero hero, IItem item)
        {
            if (hero.Gold < item.Price)
            {
                return false;
            }
            return true;
        }
        public static bool CheckForNeededLevel(IHero hero, ISpeciality speciality)
        {
            if (hero.Level < speciality.RequiredLevel)
            {
                return false;
            }
            return true;
        }
        public static bool CheckForNeededMana(IHero hero, ISpeciality speciality)
        {
            if (hero.Mana < speciality.RequiredMana)
            {
                return false;
            }
            return true;
        }
        public static bool CheckForMarkedTarget(ICollection<IMonster> monsterCollection)
        {
            if (monsterCollection.Any(monster => monster.IsMarked == true))
            {
                return true;
            }
            return false;
        }
        public static bool CheckForAliveEnemy(ICollection<IMonster> monsterCollection)
        {
            if (monsterCollection.Any(monster => monster.IsAlive == true))
            {
                return true;
            }
            return false;
        }
        public static void DetermineAliveProprerty(IMonster monster)
        {
            if (monster.HealthPoints <= 0)
            {
                monster.IsAlive = false;
            }
        }
        public static bool CheckIfEnemyIsStillAlive(IMonster monster)
        {
            if (monster.IsAlive)
            {
                return true;
            }
            return false;
        }
        public static void UpdateLevelIfNeeded(IHero hero) 
        {
            if (hero.Experience >= 100)
            {
                hero.Level++;
                hero.Experience = 0;
            }
        }
    }
}
