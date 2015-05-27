namespace RPGGameSecondVersion.Classes.Items.Armors
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    using RPGGameSecondVersion.Enums;
    class FirstLevelWeapon : Item, IItem
    {
        private const int PriceConst = 50;
        private const int ExtraDamageConst = 20;
        private const int ExtraDefenceConst = 0;
        private const int ExtraHealthConst = 0;
        public FirstLevelWeapon()
            : base(PriceConst, ExtraDamageConst, ExtraDefenceConst, ExtraHealthConst, ItemType.Weapon, Image.FromFile("FirstLevelWeapon.png"), "Fire Crossbow")
        {

        }
        public override string PrintInfoForItem()
        {
            return base.PrintInfoForItem() +
                String.Format("adds {0} Attack Points to the hero ", this.ExtraDamage.ToString());
        }
    }
}
