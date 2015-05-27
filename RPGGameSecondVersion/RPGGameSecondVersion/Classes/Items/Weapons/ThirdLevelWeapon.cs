namespace RPGGameSecondVersion.Classes.Items.Armors
{
    using System;
    using System.Drawing;

    using RPGGameSecondVersion.Interfaces;
    using RPGGameSecondVersion.Classes.Abstract;
    using RPGGameSecondVersion.Enums;
    class ThirdLevelWeapon : Item, IItem
    {
        private const int PriceConst = 150;
        private const int ExtraDamageConst = 75;
        private const int ExtraDefenceConst = 0;
        private const int ExtraHealthConst = 0;
        public ThirdLevelWeapon()
            : base(PriceConst, ExtraDamageConst, ExtraDefenceConst, ExtraHealthConst, ItemType.Weapon, Image.FromFile("ThirdLevelWeapon.png"), "Power Holder")
        {

        }
        public override string PrintInfoForItem()
        {
            return base.PrintInfoForItem() +
                String.Format("adds {0} Attack Points to the hero ", this.ExtraDamage.ToString());
        }
    }
}
